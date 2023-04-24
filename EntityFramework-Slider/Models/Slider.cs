﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Slider.Models
{
    public class Slider:BaseEntity
    {     
        public string Image { get; set; }
        [Required(ErrorMessage = "Don't be empty")]
        [NotMapped]                                       // Propertini bazaya salmir 
        public IFormFile Photo { get; set; }             // IFormFile - fayllarla islemek ucun ///
    }
}
