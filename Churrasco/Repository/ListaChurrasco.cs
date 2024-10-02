using Churrasco.Models;
using Churrasco.Repository;
namespace Churrasco.Repository
{
    public class ListaChurrasco : ImplementaçãoLista
    {
        public static List<Participantes> listaParticipantes = new List<Participantes>();

        public void InserirDadosCarta(Participantes participantes)
        {
            listaParticipantes.Add(participantes);
        }

        public List<Participantes> GetCarta()
        {
            return listaParticipantes;
        }
    }
}
