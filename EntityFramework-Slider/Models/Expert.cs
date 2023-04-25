using System.ComponentModel.DataAnnotations;

namespace EntityFramework_Slider.Models
{
    public class Expert: BaseEntity
    {
        [Required]
        public string Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
    }
}
