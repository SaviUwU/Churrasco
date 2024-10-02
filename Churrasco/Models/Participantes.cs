using System.ComponentModel.DataAnnotations;

namespace Churrasco.Models
{
    public class Participantes
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoNome(ErrorMessage = "O nome não possui o comprimento adequado")]
        public string Nome { get; set; }

        public string DescricaoCarne { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoIdade(ErrorMessage = "é menor de idade")]
        public string Idade {  get; set; }
        
        public string DescricaoBebida {  get; set; }


    }
}
