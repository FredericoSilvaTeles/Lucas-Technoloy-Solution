// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IDefaultWidgetSetupViewRepository
    {
        /// <summary>
        /// Performs count on IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <returns>Returns the number of IDefaultWidgetSetupViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DefaultWidgetSetupView" class from IDefaultWidgetSetupViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DefaultWidgetSetupView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DefaultWidgetSetupView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IDefaultWidgetSetupViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DefaultWidgetSetupView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DefaultWidgetSetupView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DefaultWidgetSetupView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DefaultWidgetSetupView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DefaultWidgetSetupView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DefaultWidgetSetupView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DefaultWidgetSetupView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DefaultWidgetSetupView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDefaultWidgetSetupViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DefaultWidgetSetupView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DefaultWidgetSetupView> GetFiltered(long pageNumber, string filterName);


    }
}