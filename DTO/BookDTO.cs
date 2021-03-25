using System.ComponentModel.DataAnnotations;

namespace Book_Hw.DTO
{
    public class BookDTO 
    {
        [Key]
        public int Id { get; set; }
        public int Book_id { get; set; }
        public decimal Book_price { get; set; }
        public string ISBN { get; set; }
        public string Book_name { get; set; }
        public string Book_description { get; set; }
    }
}