// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICashAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ICashAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICashAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CashAccountSelectorView" class from ICashAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CashAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICashAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICashAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CashAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CashAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CashAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICashAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CashAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CashAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICashAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CashAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}