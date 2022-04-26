using GameShop.WebApplication.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GameShop.WebApplication.Models.Porduct
{
    public class PostProductModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        [Display(Name = "ชื่อ")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        [Display(Name = "รายละเอียด")]
        public string Description { get; set; } = string.Empty;

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name = "ชนิด")]
        public string Category { get; set; } = string.Empty;
        
        [Display(Name = "กลุ่ม")]
        public string Group { get; set; } = string.Empty;

        [Display(Name = "ราคา")]
        public double Price { get; set; }
        [Display(Name = "มือสอง")]
        public bool IsUsed { get; set; }
        [Display(Name = "ภาพที่ 1")]
        public byte[]? Image1 { get; set; }
        [Display(Name = "ภาพที่ 2")]
        public byte[]? Image2 { get; set; }
        [Display(Name = "ภาพที่ 3")]
        public byte[]? Image3 { get; set; }
        [Display(Name = "ภาพที่ 4")]
        public byte[]? Image4 { get; set; }
    }
}
