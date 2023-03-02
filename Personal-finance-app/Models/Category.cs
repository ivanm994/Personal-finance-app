using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Personal_finance_app.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Remote("IsUnique", "Home")]
        public string Name { get; set; }
    }
}
