using System;
using System.Collections.Generic;

namespace WebApiRest.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public double SubTotal { get; set; }
        public double DescontoGeral { get; set; }
        public double Total { get; set; }
        public List<PedidoLancheViewModel> PedidoLanches { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
