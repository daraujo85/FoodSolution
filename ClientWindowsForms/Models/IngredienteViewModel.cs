using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWindowsForms.Models
{
    public class IngredienteViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
