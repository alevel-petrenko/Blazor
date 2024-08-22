using System.ComponentModel.DataAnnotations;

namespace AppDatabase.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public bool Allergy { get; set; }
        public DateTime Birthday { get; set; }
    }
}
