using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        [StringLength(30)]
        public string? Genre { get; set; }   // ✅ ADD THIS
    }
}
