using System.ComponentModel.DataAnnotations;

namespace DogShelterWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Dog_Breed { get; set; }
        public int Age { get; set; }
        public DateTime DateTimeArrived { get; set; }
    }
}
