using System.Collections.Generic;

namespace WebApiRest.Models
{
    public class LancheViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<IngredienteViewModel> Ingredientes { get; set; }
    }
}
