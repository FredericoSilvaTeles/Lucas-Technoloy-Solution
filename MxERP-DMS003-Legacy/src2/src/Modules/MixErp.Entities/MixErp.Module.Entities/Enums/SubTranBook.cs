using System.Text;
using System.Threading.Tasks;

namespace MixErp.Module.Entities.Enums
{
    public enum SubTranBook
    {
        Direct,
        Quotation,
        Order, /*Readonly*/
        Delivery, /*Readonly*/
        Receipt, /*Readonly*/
        Invoice,
        Payment,
        Return,
        Transfer,
        Suspense
        
    }
}