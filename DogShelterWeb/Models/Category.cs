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
        public int Age { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Date arrived")]
        public string DateArrived { get; set; }
    }
}
