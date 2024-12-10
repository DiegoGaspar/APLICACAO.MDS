using System.ComponentModel.DataAnnotations;

namespace APLICACAO.MDS.App.Models;

public class Funcionario
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome tem que conter 100 caracters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "A posição é obrigatória ")]
    public string Position { get; set; }

    public decimal Salary { get; set; }
}
