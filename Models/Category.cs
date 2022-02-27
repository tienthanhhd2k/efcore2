using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore2.Models
{   
    [Table("Category")]
    public class Category
    {  
        public int CategoryId {get; set;}
        public string CategoryName {get; set;}
    }
}