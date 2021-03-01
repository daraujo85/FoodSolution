using ClientWindowsForms.Models;
using RestSharp;
using System.Collections.Generic;

namespace ClientWindowsForms.Services
{
    public class IngredienteService
    {
        public IEnumerable<IngredienteViewModel> GetAll()
        {
            var restClient = new RestClient("http://localhost:5000/api/ingrediente");
            var request = new RestRequest(Method.GET);
            
            var response = restClient.Execute<IEnumerable<IngredienteViewModel>>(request);

            return response.Data;
        }
    }
}
