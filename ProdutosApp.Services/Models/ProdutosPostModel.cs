using System.ComponentModel.DataAnnotations;

namespace ProdutosApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para cadastro de produto na API
    /// </summary>
    public class ProdutosPostModel
    {
        [MinLength(9, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no maximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço do produto.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public int? Quantidade { get; set; }
    }
}



