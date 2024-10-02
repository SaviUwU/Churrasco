using Churrasco.Models;
namespace Churrasco.Repository
{
    public interface ImplementaçãoLista
    {
        public void InserirDadosParticipantes(Participantes participantes);

        public List<Participantes> GetCarta();
    }
}
