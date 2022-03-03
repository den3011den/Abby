using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public string Name { get; set; }

        [Display(Name="Порядок отображения")]
        [Range(1,100000,ErrorMessage = "Поле вне допустимых границах")]        
        public int DisplayOrder { get; set; }

    }
}
