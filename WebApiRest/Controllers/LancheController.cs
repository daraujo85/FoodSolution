using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using WebApiRest.Models;
using WebApiRest.Services;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancheController : Controller
    {
        private readonly IDapper _dapper;

        public LancheController(IDapper dapper)
        {
            _dapper = dapper;
        }
        [HttpGet]
        public async Task<IEnumerable<LancheViewModel>> GetAll()
        {
            var result = await Task.FromResult(_dapper.GetAll<LancheViewModel>($"Select * from [lanche] order by id", null, commandType: CommandType.Text));

            foreach (var item in result)
            {
                var resultIngredientes = await Task.FromResult(_dapper.GetAll<IngredienteViewModel>($"Select *, valor as [valorunitario], 1 as [quantidade] from [ingrediente] i inner join [lanche_ingrediente] li on i.id = li.ingrediente_id where li.lanche_id = {item.Id} order by i.id", null, commandType: CommandType.Text));

                item.Ingredientes = resultIngredientes;
            }

            return result;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<LancheViewModel> GetById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<LancheViewModel>($"Select * from [lanche] where id = {Id}", null, commandType: CommandType.Text));

            return result;
        }
    }
}
