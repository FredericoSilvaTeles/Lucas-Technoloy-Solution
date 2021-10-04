using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Media : EntityBase
    {
        [StringLength(100)]
        public string Caption { get; private set; }

        public int FileSize { get; private set; }

        [StringLength(100)]
        public string FileName { get; private set; }

        public MediaType MediaType { get; private set; }

    }
}