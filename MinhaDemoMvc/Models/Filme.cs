using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key] // Especifica que o campo será um campo de identificação(Auto incremento, identity )
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")] // Especificando o campo como obrigatório preenchimento e colocando uma msg de erro
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")] // Especificando o tamanho de caracteres do campo máximo e minimo
        public string Titulo { get; set; }


        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")] // Especificando o formato do tipo de dados no caso data
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")] // Especificando o nome a ser exibido na tela da propriedade
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido")] // Especificando os caracteres aceitos
        [Display(Name = "Gênero")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")] // Especificando um padrão entre valor do campo
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Column(TypeName = "decimal(18, 2)")] // Pode especificar o padrão que vai ser definido no banco de dados
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        public int Avaliacao { get; set; }

    }
}
