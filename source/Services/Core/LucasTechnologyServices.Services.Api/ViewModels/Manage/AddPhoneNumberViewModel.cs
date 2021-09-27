using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Services.Api.ViewModels.Manage
{
    public class AddPhoneNumberViewModel
    {
        
        [Required(ErrorMessage = "The {0} field is required")]
        [Phone]
        [Display(Name = "phone number")]
        public string PhoneNumber { get; set; }
    }
}
