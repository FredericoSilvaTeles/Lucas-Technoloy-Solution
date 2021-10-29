using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Services._1_Interfaces
{
    public interface ICurrencyService
    {
        CultureInfo CurrencyCulture { get; }
        string FormatCurrency(decimal value);
    }
}
