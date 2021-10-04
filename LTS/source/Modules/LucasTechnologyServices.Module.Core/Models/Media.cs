using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Media : EntityBase
    {
        [StringLength(100)]
        public string Caption { get; set; }

        public int FileSize { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public MediaType MediaType { get; set; }

    }
}