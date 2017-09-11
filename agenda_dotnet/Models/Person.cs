using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace agenda_dotnet.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Adress { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [DisplayName( "Phone Type" )]
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType{
        Home,
        Work, 
        Other
    }
}
