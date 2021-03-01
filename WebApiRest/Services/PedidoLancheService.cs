using Dapper;
using System.Data;
using System.Threading.Tasks;
using WebApiRest.Models;

namespace WebApiRest.Services
{
    public class PedidoLancheService: IPedidoLancheService
    {
        private readonly IDapper _dapper;

        public PedidoLancheService(IDapper dapper)
        {
            _dapper = dapper;
        }
        public async Task<int> Inserir(PedidoLancheViewModel pedidoLancheViewModel)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("id", 0, DbType.Int32);
            dbparams.Add("quantidade", pedidoLancheViewModel.Quantidade, DbType.Int32);
            dbparams.Add("valorunitario", pedidoLancheViewModel.ValorUnitario, DbType.Decimal);
            dbparams.Add("desconto", pedidoLancheViewModel.Desconto, DbType.Decimal);
            dbparams.Add("lancheid", pedidoLancheViewModel.LancheId, DbType.Int32);
            dbparams.Add("pedidoid", pedidoLancheViewModel.PedidoId, DbType.Int32);
            dbparams.Add("operacao", 'i', DbType.String);
            dbparams.Add("novoid", 0, DbType.Int32, ParameterDirection.Output);

            var resultPedido = await Task.FromResult(_dapper.Insert<int>("[dbo].[sp_pedido_lanche]"
                , dbparams,
                commandType: CommandType.StoredProcedure));

            return resultPedido;
        }
    }
}
