using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NimapCodeFirst.Models
{
    [Table("Nimap_Products")]
    public class Product
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }
    }

    public class Db:DbContext
    {
        public Db():base("constr")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}