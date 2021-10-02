// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBankAccountViewRepository
    {
        /// <summary>
        /// Performs count on IBankAccountViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBankAccountViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BankAccountView" class from IBankAccountViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BankAccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBankAccountViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBankAccountViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBankAccountViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BankAccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBankAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BankAccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBankAccountViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BankAccountView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBankAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BankAccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBankAccountViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BankAccountView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBankAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BankAccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountView> GetFiltered(long pageNumber, string filterName);


    }
}