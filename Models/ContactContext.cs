using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace PersonalMohmed2.Models
{
    public class ContactContext : DbContext
    {

        public DbSet<Contact> Contacts { get; set; }
    }
}