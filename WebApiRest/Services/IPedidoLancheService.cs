using System.Threading.Tasks;
using WebApiRest.Models;

namespace WebApiRest.Services
{
    public interface IPedidoLancheService
    {
        Task<int> Inserir(PedidoLancheViewModel pedidoLancheViewModel);
    }
}
