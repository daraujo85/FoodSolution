using System.Collections.Generic;

namespace ClientWindowsForms.Models
{
    public class LancheViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<IngredienteViewModel> Ingredientes { get; set; }
    }
}
