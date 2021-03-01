using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;
using WebApiRest.Models;
using WebApiRest.Services;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IDapper _dapper;
        private readonly IPedidoLancheService _pedidoLancheService;

        public PedidoController(IDapper dapper, IPedidoLancheService pedidoLancheService)
        {
            _dapper = dapper;
            _pedidoLancheService = pedidoLancheService;
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post([FromBody] PedidoViewModel pedidoViewModel)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("id", 0, DbType.Int32);
            dbparams.Add("subtotal", pedidoViewModel.SubTotal, DbType.Decimal);
            dbparams.Add("descontogeral", pedidoViewModel.DescontoGeral, DbType.Decimal);
            dbparams.Add("total", pedidoViewModel.Total, DbType.Decimal);
            dbparams.Add("operacao", 'i', DbType.String);
            dbparams.Add("novoid", 0, DbType.Int32, ParameterDirection.Output);

            var idPedido = await Task.FromResult(_dapper.Insert<int>("[dbo].[sp_pedido]"
                , dbparams,
                commandType: CommandType.StoredProcedure));

            foreach (var pedidoLanche in pedidoViewModel.PedidoLanches)
            {
                pedidoLanche.PedidoId = idPedido;

                //todo: Ajustar o valor unitario que está zerando ao ser recebido
                var idPedidoLanche = _pedidoLancheService.Inserir(pedidoLanche);

                //todo: Fazer a persistencia do ultimo nivel filho (ingredientes)
            }


            return idPedido > 0 ? StatusCode(201) : StatusCode(400);
        }
    }
}
