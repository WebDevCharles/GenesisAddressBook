using System.ComponentModel.DataAnnotations;

namespace GenesisAddressBook.Models.ViewModels
{
    public class EmailData
    {
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; } = "";
        [Required]
        public string Subject { get; set; } = "";
        [Required]
        public string Body { get; set; } = "";
        public int? Id { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public string? GroupName { get; set; }
    }
}
