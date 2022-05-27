using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Model
{
    public class Contact
    {
        public enum Cat { Business = 2, Private = 1, Other = 3 }

        [Key]
        public string email { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string surname { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public Cat category { get; set; }

        public string subcategory { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        [Required]
        public DateTime date { get; set; }

        public String printOnlyDate()
        {
            var x = "";
            if (this.date.Day < 10)
                x += "0";
            x += this.date.Day + ".";
            
            if (this.date.Month < 10)
                x += "0";
            x += this.date.Month + "." + this.date.Year;

            return x;
        }

        public String printCategory()
        {
            if (this.category == Cat.Private)
                return "Private";
            else if (this.category == Cat.Business)
                return "Business";
            else return "Other";
        }
    }
}
