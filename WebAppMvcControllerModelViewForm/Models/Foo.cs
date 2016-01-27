using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAppMvcControllerModelViewForm.Models
{
    public class Foo
    {
        [Required] //The Id field is required.
        //[Required(ErrorMessage="Error in model")]
        //[Required(ErrorMessageResourceType = typeof(ResxModel), ErrorMessageResourceName = "ModelUserIdError")]
        [Display(Name = "Id label")]
        //[Display(Name = "ModelUserIdDisplay", ResourceType = typeof(ResxModel))]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}")]
        public DateTime DataCreate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Birthday { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Repassword { get; set; }
    }
}