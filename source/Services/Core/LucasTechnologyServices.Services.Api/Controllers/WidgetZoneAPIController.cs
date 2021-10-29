using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WidgetZoneAPIController : ControllerBase
    {
        
        [Services("Core")]
        [Authorize(Roles = "admin")]
        [Route("api/widget-zone")]
        public WidgetAPIController(IRepository<WidgetZone> WidgetZoneRepository)
        {
            _widgetZoneRepository = WidgetZoneRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

        }
           

    }
}
