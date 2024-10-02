using Churrasco.Models;
using Microsoft.AspNetCore.Mvc;
using Churrasco.Repository;

namespace Churrasco.Controllers
{
    [ApiController]
    [Route("API/CriancaController")]
    public class ChurrascoController : Controller
    {
        [HttpPost]
        [Route("ReceberDados")]
        public IActionResult ReceberDados(Participantes participantes)
        {
            _ListaChurrasco.InserirDadosCarta(new Participantes()
            {
               Nome = participantes.Nome,
               DescricaoCarne = participantes.DescricaoCarne,
               Idade = participantes.Idade,
               DescricaoBebida = participantes.DescricaoBebida,
            }
             );
            return Ok($"{participantes.Nome}, Bem vindo ao churrasco!");
        }




        [HttpGet]
        [Route("ObterCartas")]
        public IActionResult ObterCartas()
        {
            return Ok(_ListaChurrasco.GetCarta());
        }
    }
}
