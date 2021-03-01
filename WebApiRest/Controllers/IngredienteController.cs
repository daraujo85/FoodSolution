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
    public class IngredienteController : Controller
    {
        private readonly IDapper _dapper;

        public IngredienteController(IDapper dapper)
        {
            _dapper = dapper;
        }
        [HttpGet]
        public async Task<IEnumerable<IngredienteViewModel>> GetAll()
        {
            var result = await Task.FromResult(_dapper.GetAll<IngredienteViewModel>($"Select *, valor as [valorunitario] from [ingrediente] order by id", null, commandType: CommandType.Text));

            return result;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IngredienteViewModel> GetById(int Id)
        {
            var result = await Task.FromResult(_dapper.Get<IngredienteViewModel>($"Select * from [ingrediente] where id = {Id}", null, commandType: CommandType.Text));

            return result;
        }
    }
}
