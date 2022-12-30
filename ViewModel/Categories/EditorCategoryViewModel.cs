using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Categories;

public class EditorCategoryViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "Erro deve conter entre 3 e 40 caracters")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Slug { get; set; }
}