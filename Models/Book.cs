using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Hw
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
