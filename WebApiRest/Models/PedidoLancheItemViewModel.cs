namespace WebApiRest.Models
{
    public class PedidoLancheItemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IngredienteId { get; internal set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public int PedidoLancheId { get; set; }
    }
}
