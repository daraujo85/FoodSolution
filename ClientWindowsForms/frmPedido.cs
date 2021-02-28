using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientWindowsForms
{
    public partial class frmPedido : Form
    {
        private List<Lanche> _lanches;
        private List<Ingrediente> _ingredientes;
        private List<PedidoLanche> _pedidos;
        private BindingSource _bsLanches;
        private BindingSource _bsIngredientes;
        private BindingSource _bsPedidos;

        private Stopwatch temporizador;

        public frmPedido()
        {
            InitializeComponent();
            FormatarGridLanches();
            LimparListas();
            DefinirGridBindings();
            CarregarLanches();
            //SimularPedido();
            //CarregarIngredientes();

            temporizador = new Stopwatch();
            temporizador.Start();
            tmPedido.Start();

        }

        private void DefinirGridBindings()
        {
            _bsLanches = new BindingSource(_lanches, null);
            _bsIngredientes = new BindingSource(_ingredientes, null);
            _bsPedidos = new BindingSource(_pedidos, null);

            dgvLanches.DataSource = _bsLanches;
            dgvIngredientes.DataSource = _bsIngredientes;
            dgvPedidos.DataSource = _bsPedidos;
        }

        private void AtualizarGridView()
        {
            dgvLanches.Update();
            dgvLanches.Refresh();
            dgvIngredientes.Update();
            dgvIngredientes.Refresh();
            dgvPedidos.Update();
            dgvPedidos.Refresh();
        }

        private void LimparListas()
        {
            _lanches = new List<Lanche>();
            _ingredientes = new List<Ingrediente>();
            _pedidos = new List<PedidoLanche>();
        }

        private void SimularPedido()
        {
            var pedidos = new List<PedidoLanche> {
                new PedidoLanche{
                Id= 1,
                Nome = "X-Bacon",
                Quantidade = 2,
                ValorUnitario = 6.5,
                SubTotal = 13
                },
                new PedidoLanche{
                Id= 2,
                Nome = "X-Bacon c/ adicionais",
                Quantidade = 2,
                ValorUnitario = 12,
                SubTotal = 24,
                Desconto = -0.80

                }
            };


            dgvPedidos.DataSource = pedidos;

        }
        private void CarregarLanches()
        {
            _lanches = new List<Lanche>
           {
            new Lanche { Id = 1, Nome = "X-Bacon", Ingredientes = new List<Ingrediente> {
                new Ingrediente { Id = 2, Nome = "Bacon", ValorUnitario = 2, Quantidade = 1 },
                new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
                new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 }
             }
            },
            new Lanche { Id = 2, Nome = "X-Burger", Ingredientes = new List<Ingrediente> {
                new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
                new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 }
             }  },
            new Lanche { Id = 3, Nome = "X-Egg", Ingredientes = new List<Ingrediente> {
                new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
                new Ingrediente { Id = 4, Nome = "Ovo", ValorUnitario = 0.8, Quantidade = 1 },
                new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 },
             }  },
            new Lanche { Id = 4, Nome = "X-Egg Bacon", Ingredientes = new List<Ingrediente> {
                new Ingrediente { Id = 2, Nome = "Bacon", ValorUnitario = 2, Quantidade = 1 },
                new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
                new Ingrediente { Id = 4, Nome = "Ovo", ValorUnitario = 0.8, Quantidade = 1 },
                new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 },
             }  },
            new Lanche { Id = 5, Nome = "Monte do seu jeito" },
           };

            dgvLanches.DataSource = _lanches;

        }
        private List<Ingrediente> CarregarTodosIngredientes()
        {
            return new List<Ingrediente>
        {
            new Ingrediente { Id = 1, Nome = "Alface", ValorUnitario = 0.4, Quantidade = 0 },
            new Ingrediente { Id = 2, Nome = "Bacon", ValorUnitario = 2, Quantidade = 0 },
            new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 0},
            new Ingrediente { Id = 4, Nome = "Ovo", ValorUnitario = 0.8, Quantidade = 0 },
            new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5 , Quantidade = 0},
        };

        }

        private void FormatarGridLanches()
        {
            dgvLanches.ColumnHeadersDefaultCellStyle.Font = new Font("Aton", 14F, FontStyle.Regular);
            dgvIngredientes.ColumnHeadersDefaultCellStyle.Font = new Font("Aton", 14F, FontStyle.Regular);
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Aton", 14F, FontStyle.Regular);

        }

        private void dgvLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirIngredientes(e.RowIndex);

        }
        private void dgvLanches_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ExibirIngredientes(e.RowIndex);

        }

        private void ExibirIngredientes(int RowIndex)
        {
            if (RowIndex < 0)
            {
                return;
            }
            int.TryParse(dgvLanches.Rows[RowIndex].Cells[0].Value.ToString(), out int idLanche);

            var ingredientesLanche = IdentificaIngredientes(idLanche);

            _ingredientes = ingredientesLanche == null ? CarregarTodosIngredientes() : ingredientesLanche;

            _bsIngredientes.DataSource = _ingredientes;

            var totalIngredientes = CalcularValorTotalIngredientes();

            lblTotalIngredientes.Text = totalIngredientes.ToString("C2");
        }

        private List<Ingrediente> IdentificaIngredientes(int id)
        {
            return _lanches.Where(x => x.Ingredientes != null && x.Id == id).Select(x => x.Ingredientes.ToList()).FirstOrDefault();
        }

        private double CalcularValorTotalIngredientes()
        {
            var sum = 0.0;

            for (int i = 0; i < dgvIngredientes.Rows.Count; ++i)
            {
                double.TryParse(dgvIngredientes.Rows[i].Cells[5].Value.ToString(), out double qtd);
                double.TryParse(dgvIngredientes.Rows[i].Cells[4].Value.ToString(), out double valor);
                double totalItem = qtd * valor;

                sum += totalItem;
            }

            return sum;
        }


        private void dgvIngredientes_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var totalIngredientes = CalcularValorTotalIngredientes();

            lblTotalIngredientes.Text = totalIngredientes.ToString("C2");
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int.TryParse(senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString(), out int qtdIngrediente);

                qtdIngrediente = e.ColumnIndex == 0 ? qtdIngrediente -= 1 : qtdIngrediente += 1;

                senderGrid.Rows[e.RowIndex].Cells[5].Value = qtdIngrediente < 0 ? 0 : qtdIngrediente;

                var totalIngredientes = CalcularValorTotalIngredientes();

                lblTotalIngredientes.Text = totalIngredientes.ToString("C2");
            }

            this.dgvIngredientes.CellEnter += new DataGridViewCellEventHandler(dgvIngredientes_CellEnter);
        }

        private void dgvIngredientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.dgvIngredientes.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) ||
                (this.dgvIngredientes.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn))
            {
                this.dgvIngredientes.BeginEdit(false);
            }
        }

        private void tmPedido_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = temporizador.Elapsed.Duration().ToString(@"mm\:ss");
        }

        private void btnAddLanche_Click(object sender, EventArgs e)
        {
            var lancheSelecionado = dgvLanches.CurrentRow;
            var totalIngredientes = CalcularValorTotalIngredientes();

            var pedidoLanche = new PedidoLanche
            {
                LancheId = Convert.ToInt32(lancheSelecionado.Cells[0].Value),
                Nome = Convert.ToString(lancheSelecionado.Cells[1].Value),
                Quantidade = Convert.ToInt32(nudQtdLanche.Value),
                ValorUnitario = totalIngredientes
            };


            foreach (DataGridViewRow row in dgvIngredientes.Rows)
            {
                var qtdIngredente = Convert.ToInt32(row.Cells[5].Value);

                if (qtdIngredente > 0)
                {
                    var pedidoLancheItem = new PedidoLancheItem
                    {
                        IngredienteId = Convert.ToInt32(row.Cells[2].Value),
                        Nome = Convert.ToString(row.Cells[3].Value),
                        Quantidade = qtdIngredente,
                        ValorUnitario = Convert.ToDouble(row.Cells[4].Value)
                    };

                    pedidoLanche.SubTotal = pedidoLanche.Quantidade * pedidoLanche.ValorUnitario;

                    pedidoLanche.Total = pedidoLanche.SubTotal - pedidoLanche.Desconto;

                    pedidoLanche.Itens.Add(pedidoLancheItem);
                }

            }

            var minimoQtdItens = pedidoLanche.Itens.Sum(x => x.Quantidade);

            if (minimoQtdItens == 0)
            {
                MessageBox.Show("É necessário selecionar pelo menos um ingrediente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var lancheExiste = VerificardLancheExiste(pedidoLanche);

            if (lancheExiste)
            {
                //todo: atualizar a quantidade no lanche existente
                AtualizarQtdLanche(pedidoLanche);
                
            }
            else
            {
                ConcederDescontoCarne(pedidoLanche);
                ConcederDescontoQueijo(pedidoLanche);
                ConcederDescontoVeggie(pedidoLanche);

                _pedidos.Add(pedidoLanche);
            }

            var subTotal = AtualizarSubTotalLanche();

            var desconto = AtualizarDescontoLanche();

            var total = AtualizarTotalLanche();

            ExibirResultados(subTotal, desconto, total);

            DefinirGridBindings();

            AtualizarGridView();
        }

        private void ExibirResultados(double subTotal, double desconto, double total)
        {
            lblSubTotalPedido.Text = subTotal.ToString("C2");
            lblDescontoPedido.Text = desconto.ToString("C2");
            lblTotalPedido.Text = total.ToString("C2");
        }

        /// <summary>
        /// Verifica se o lanche que está sendo adicionado já costa na relação com mesmo LancheId e ingredientes
        /// </summary>
        /// <param name="pedidoLanche"></param>
        /// <returns></returns>
        private bool VerificardLancheExiste(PedidoLanche pedidoLanche)
        {
            if (_pedidos.Count() == 0)
            {
                return false;
            }

            foreach (var _ in from pedido in _pedidos.Where(x => x.LancheId == pedidoLanche.LancheId).ToList()
                              let itensA = pedido.Itens
                              let itensB = pedidoLanche.Itens
                              let diff = itensA.Except(itensB, new IdComparer()).ToList()
                              where diff.Count == 0
                              select new { })
            {
                return true;
            }

            return false;
        }
        private void AtualizarQtdLanche(PedidoLanche pedidoLanche)
        {
            if (_pedidos.Count() == 0)
            {
                return;
            }

            foreach (var pedido in _pedidos.Where(x => x.LancheId == pedidoLanche.LancheId).ToList())
            {
                var itensA = pedido.Itens;
                var itensB = pedidoLanche.Itens;
                var diff = itensA.Except(itensB, new IdComparer()).ToList();
                
                if (diff.Count == 0)
                {
                    pedido.Quantidade += pedidoLanche.Quantidade;

                    ConcederDescontoCarne(pedidoLanche);
                    ConcederDescontoQueijo(pedidoLanche);
                    ConcederDescontoVeggie(pedidoLanche);

                    pedido.Desconto += pedidoLanche.Desconto;
                    return;
                }
            }
         
        }
        private double AtualizarTotalLanche()
        {
            if (_pedidos.Count() == 0)
            {
                return 0;
            }

            return _pedidos.Sum(x => x.Total = x.SubTotal - x.Desconto);
                                                  
        }
        private double AtualizarSubTotalLanche()
        {
            if (_pedidos.Count() == 0)
            {
                return 0;
            }

            return _pedidos.Sum(x => x.SubTotal = x.Quantidade * x.ValorUnitario);

        }

        private double AtualizarDescontoLanche()
        {
            if (_pedidos.Count() == 0)
            {
                return 0;
            }

            return _pedidos.Sum(x => x.Desconto);

        }
        #region Promocoes

        public void ConcederDescontoCarne(PedidoLanche pedidoLanche)
        {
            var descontoLanche = pedidoLanche.Itens.Where(x => x.Nome == "Hambúrguer de carne" && x.Quantidade >= 3).Select(y=>((y.Quantidade)/3) * y.ValorUnitario).FirstOrDefault();
            pedidoLanche.Desconto += (descontoLanche * pedidoLanche.Quantidade);

        }
        public void ConcederDescontoQueijo(PedidoLanche pedidoLanche)
        {
            var descontoLanche = pedidoLanche.Itens.Where(x => x.Nome == "Queijo" && x.Quantidade >= 3).Select(y => ((y.Quantidade) / 3) * y.ValorUnitario).FirstOrDefault();
            pedidoLanche.Desconto += (descontoLanche * pedidoLanche.Quantidade);

        }
        public void ConcederDescontoVeggie(PedidoLanche pedidoLanche)
        {
            var alfaceExiste = pedidoLanche.Itens.Exists(x => x.Nome == "Alface");
            var baconExiste = pedidoLanche.Itens.Exists(x => x.Nome == "Bacon");
            
            if (alfaceExiste== true && baconExiste == false)
            {
                pedidoLanche.Desconto += pedidoLanche.SubTotal * 0.1;
                return;
            }

        }
        #endregion
        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnAddLanche_Click(sender, e);
            }
        }
    }
    public class IdComparer : IEqualityComparer<PedidoLancheItem>
    {
        public int GetHashCode(PedidoLancheItem co)
        {
            if (co == null)
            {
                return 0;
            }
            return co.Id.GetHashCode();
        }

        public bool Equals(PedidoLancheItem x1, PedidoLancheItem x2)
        {
            if (object.ReferenceEquals(x1, x2))
            {
                return true;
            }
            if (object.ReferenceEquals(x1, null) ||
                object.ReferenceEquals(x2, null))
            {
                return false;
            }
            return x1.IngredienteId == x2.IngredienteId && x1.Quantidade == x2.Quantidade;
        }
    }
    public class PedidoLancheItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IngredienteId { get; internal set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public int PedidoLancheId { get; set; }
    }

    public class PedidoLanche
    {
        public int Id { get; internal set; }
        public int LancheId { get; set; }
        public string Nome { get; internal set; }
        public int Quantidade { get; internal set; }
        public double ValorUnitario { get; internal set; }
        public double SubTotal { get; internal set; }
        public double Desconto { get; internal set; }
        public double Total { get; internal set; }
        public List<PedidoLancheItem> Itens { get; set; }

        public PedidoLanche()
        {
            Itens = new List<PedidoLancheItem>();
        }
    }

    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
    }

    public class Lanche
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}