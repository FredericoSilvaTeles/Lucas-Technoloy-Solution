using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.AppService.Core.ViewModels.Accounts
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public bool Confidential { get; set; }

        public bool IsTransactionNode { get; set; }

        public bool SysType { get; set; }

        //public long? ParentAccountId { get; set; }

        //public int? AuditUserId { get; set; }

        //public int? AuditUserId { get; set; }

        public DateTime? AuditTs { get; set; }


    }
}
