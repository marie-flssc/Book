using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Hw.Models
{
    public class Book
    {
        public int id { get; set; }
        public decimal price { get; set; }
        public string isbn { get; set; }
    }
}
