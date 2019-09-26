using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetTwo.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        
        public string Content { get; set; }
        public decimal Price { get; set; }
    }
}