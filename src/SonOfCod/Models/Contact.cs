using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Contactid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
