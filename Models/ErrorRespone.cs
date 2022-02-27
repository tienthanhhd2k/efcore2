using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore2.Models
{
    public class ErrorRespone
    {
        public int ErrorCode{get; set;}
        public  string ErrorMessage{get; set;}
    }
}