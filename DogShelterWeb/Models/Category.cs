using System.ComponentModel;
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
        [Range(0,20,ErrorMessage ="Dog's age can't be more than 20 years!")]
        public int Age { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString= @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Date arrived")]
        public string DateArrived { get; set; }
    }
}
