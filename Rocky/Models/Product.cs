using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rocky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название продукта")]
        public string Name { get; set; }
        [Display(Name = "Краткое описание")]
        public string ShortDesc { get; set; }
        [Display(Name = "Описание продукта")]
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        [Display(Name = "Цена")]
        public int Price { get; set; }
        public string Image { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]

        public virtual Category Category { get; set; }
        [Display(Name = "Тип операции")]
        public int ApplicationTypeId { get; set; }

        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }
    }
}
