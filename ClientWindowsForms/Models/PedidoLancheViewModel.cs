using System.Collections.Generic;

namespace ClientWindowsForms.Models
{
    public class PedidoLancheViewModel
    {
        public int Id { get; internal set; }
        public int LancheId { get; set; }
        public string Descricao { get; internal set; }
        public int Quantidade { get; internal set; }
        public double ValorUnitario { get; internal set; }
        public double SubTotal { get; internal set; }
        public double Desconto { get; internal set; }
        public double Total { get; internal set; }
        public List<PedidoLancheItemViewModel> Itens { get; set; }
        public int PedidoId { get; set; }

        public PedidoLancheViewModel()
        {
            Itens = new List<PedidoLancheItemViewModel>();
        }
    }
}
