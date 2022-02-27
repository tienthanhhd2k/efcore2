using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore2.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Manufacture { get; set; }
        public int CategoryID { get; set; }
    }
}