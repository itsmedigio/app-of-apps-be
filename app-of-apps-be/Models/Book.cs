using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_of_apps_be.Models
{
    [Table("books")]
	public class Book
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
    }
}


