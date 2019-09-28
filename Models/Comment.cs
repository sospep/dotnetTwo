using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetTwo.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }
        public int Article_Id{get; set;}
    }
}