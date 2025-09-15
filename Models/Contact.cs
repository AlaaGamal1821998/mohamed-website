using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
namespace PersonalMohmed2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("الاسم")]
        public string Name { get; set; }
        [Required]
        [DisplayName("الايميل")]
        public string Email { get; set; }
        [DisplayName("رقم التليفون")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("رسالتك")]
        public string Message { get; set; }


    }
}