﻿using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Infrastructure.Web;
using LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels;
using LucasTecnologiaServices.Modules.Catalog.Models;
using LucasTecnologiaServices.Modules.Catalog.Services;
using LucasTecnologiaServices.Modules.Core.Areas.ViewModels;
using LucasTecnologiaServices.Modules.Core.Models;
using LucasTecnologiaServices.Modules.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.Components
{
    public class ProductWidgetViewComponent : ViewComponent
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMediaService _mediaService;
        private readonly IProductPricingService _productPricingService;
        private readonly IContentLocalizationService _contentLocalizationService;

        public ProductWidgetViewComponent(IRepository<Product> productRepository,
            IMediaService mediaService,
            IProductPricingService productPricingService,
            IContentLocalizationService contentLocalizationService)
        {
            _productRepository = productRepository;
            _mediaService = mediaService;
            _productPricingService = productPricingService;
            _contentLocalizationService = contentLocalizationService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new ProductWidgetComponentVm
            {
                Id = widgetInstance.Id,
                WidgetName = _contentLocalizationService.GetLocalizedProperty(nameof(WidgetInstance), widgetInstance.Id, nameof(widgetInstance.Name), widgetInstance.Name),
                Setting = JsonConvert.DeserializeObject<ProductWidgetSetting>(widgetInstance.Data)
            };

            var query = _productRepository.Query()
              .Where(x => x.IsPublished && x.IsVisibleIndividually);

            if (model.Setting.CategoryId.HasValue && model.Setting.CategoryId.Value > 0)
            {
                query = query.Where(x => x.Categories.Any(c => c.CategoryId == model.Setting.CategoryId.Value));
            }

            if (model.Setting.FeaturedOnly)
            {
                query = query.Where(x => x.IsFeatured);
            }

            model.Products = query
              .Include(x => x.ThumbnailImage)
              .OrderByDescending(x => x.CreatedOn)
              .Take(model.Setting.NumberOfProducts)
              .Select(x => ProductThumbnail.FromProduct(x)).ToList();

            foreach (var product in model.Products)
            {
                product.Name = _contentLocalizationService.GetLocalizedProperty(nameof(Product), product.Id, nameof(product.Name), product.Name);
                product.ThumbnailUrl = _mediaService.GetThumbnailUrl(product.ThumbnailImage);
                product.CalculatedProductPrice = _productPricingService.CalculateProductPrice(product);
            }

            return View(this.GetViewPath(), model);
        }
    }
}
