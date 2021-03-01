using ClientWindowsForms.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientWindowsForms.Services
{
    public class LancheService
    {
        public IEnumerable<LancheViewModel> GetAll()
        {
            var restClient = new RestClient("http://localhost:5000/api/lanche");
            var request = new RestRequest(Method.GET);
            
            var response = restClient.Execute<IEnumerable<LancheViewModel>>(request);

            return response.Data;
        }
    }
}
