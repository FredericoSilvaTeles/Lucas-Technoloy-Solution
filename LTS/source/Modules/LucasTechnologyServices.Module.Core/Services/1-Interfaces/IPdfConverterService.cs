using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Services._1_Interfaces
{
    public interface IPdfConverterService
    {
        byte[] Convert(string htmlContent);
    }
}
