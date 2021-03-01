using ClientWindowsForms.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientWindowsForms.Services
{
    public class PedidoService
    {
        public bool FinalizarPedido(PedidoViewModel pedidoViewModel)
        {
            var restClient = new RestClient("http://localhost:5000/api/pedido");
            var request = new RestRequest(Method.POST);

            request.AddJsonBody(pedidoViewModel);

            var response = restClient.Execute(request);

            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }
    }
}
