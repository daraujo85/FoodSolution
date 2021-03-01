using ClientWindowsForms.Models;
using ClientWindowsForms.Services;
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
        private List<LancheViewModel> _lanches;
        private List<IngredienteViewModel> _ingredientes;
        private List<PedidoLancheViewModel> _pedidos;
        private BindingSource _bsLanches;
        private BindingSource _bsIngredientes;
        private BindingSource _bsPedidos;
        private LancheService _lancheService;
        private IngredienteService _ingredienteService;
        private PedidoService _pedidoService;
        private Stopwatch temporizador;

        public frmPedido()
        {
            InitializeComponent();
            InicializarServices();
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

        private void InicializarServices()
        {
            _lancheService = new LancheService();
            _ingredienteService = new IngredienteService();
            _pedidoService = new PedidoService();
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
            _lanches = new List<LancheViewModel>();
            _ingredientes = new List<IngredienteViewModel>();
            _pedidos = new List<PedidoLancheViewModel>();
        }

        private void SimularPedido()
        {
            var pedidos = new List<PedidoLancheViewModel> {
                new PedidoLancheViewModel{
                Id= 1,
                Descricao = "X-Bacon",
                Quantidade = 2,
                ValorUnitario = 6.5,
                SubTotal = 13
                },
                new PedidoLancheViewModel{
                Id= 2,
                Descricao = "X-Bacon c/ adicionais",
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
            //_lanches = new List<LancheViewModel>
            //{
            // new LancheViewModel { Id = 1, Descricao = "X-Bacon", Ingredientes = new List<Ingrediente> {
            //     new Ingrediente { Id = 2, Nome = "Bacon", ValorUnitario = 2, Quantidade = 1 },
            //     new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
            //     new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 }
            //  }
            // },
            // new LancheViewModel { Id = 2, Descricao = "X-Burger", Ingredientes = new List<Ingrediente> {
            //     new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
            //     new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 }
            //  }  },
            // new LancheViewModel { Id = 3, Descricao = "X-Egg", Ingredientes = new List<Ingrediente> {
            //     new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
            //     new Ingrediente { Id = 4, Nome = "Ovo", ValorUnitario = 0.8, Quantidade = 1 },
            //     new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 },
            //  }  },
            // new LancheViewModel { Id = 4, Descricao = "X-Egg Bacon", Ingredientes = new List<Ingrediente> {
            //     new Ingrediente { Id = 2, Nome = "Bacon", ValorUnitario = 2, Quantidade = 1 },
            //     new Ingrediente { Id = 3, Nome = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 1},
            //     new Ingrediente { Id = 4, Nome = "Ovo", ValorUnitario = 0.8, Quantidade = 1 },
            //     new Ingrediente { Id = 5, Nome = "Queijo", ValorUnitario = 1.5, Quantidade = 1 },
            //  }  },
            // new LancheViewModel { Id = 5, Descricao = "Monte do seu jeito" },
            //};

            var resultLanches = _lancheService.GetAll();

            _lanches = resultLanches.ToList();

            dgvLanches.DataSource = _lanches;

        }

        private List<IngredienteViewModel> CarregarTodosIngredientes()
        {
        //    return new List<IngredienteViewModel>
        //{
        //    new IngredienteViewModel { Id = 1, Descricao = "Alface", ValorUnitario = 0.4, Quantidade = 0 },
        //    new IngredienteViewModel { Id = 2, Descricao = "Bacon", ValorUnitario = 2, Quantidade = 0 },
        //    new IngredienteViewModel { Id = 3, Descricao = "Hambúrguer de carne", ValorUnitario = 3, Quantidade = 0},
        //    new IngredienteViewModel { Id = 4, Descricao = "Ovo", ValorUnitario = 0.8, Quantidade = 0 },
        //    new IngredienteViewModel { Id = 5, Descricao = "Queijo", ValorUnitario = 1.5 , Quantidade = 0},
        //};

            return _ingredienteService.GetAll().ToList();

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

            _ingredientes = ingredientesLanche == null || ingredientesLanche.Count() == 0 ? CarregarTodosIngredientes() : ingredientesLanche;

            _bsIngredientes.DataSource = _ingredientes;

            var totalIngredientes = CalcularValorTotalIngredientes();

            lblTotalIngredientes.Text = totalIngredientes.ToString("C2");
        }

        private List<IngredienteViewModel> IdentificaIngredientes(int id)
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

        private void IlustrarIngrediente(string nomeIngrediente)
        {
            switch (nomeIngrediente)
            {
                case "Bacon":

                    pictureBox1.Image = Properties.Resources.bacon;

                    break;

                case "Hambúrguer de carne":

                    pictureBox1.Image = Properties.Resources.carne_hambuger;

                    break;
                case "Queijo":

                    pictureBox1.Image = Properties.Resources.queijo;

                    break;
                case "Ovo":

                    pictureBox1.Image = Properties.Resources.ovo;

                    break;
                case "Alface":

                    pictureBox1.Image = Properties.Resources.alface;

                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void dgvIngredientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            var nomeIngrediente = senderGrid.CurrentRow.Cells[3].Value.ToString();

            IlustrarIngrediente(nomeIngrediente);

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

            var pedidoLanche = new PedidoLancheViewModel
            {
                LancheId = Convert.ToInt32(lancheSelecionado.Cells[0].Value),
                Descricao = Convert.ToString(lancheSelecionado.Cells[1].Value),
                Quantidade = Convert.ToInt32(nudQtdLanche.Value),
                ValorUnitario = totalIngredientes
            };


            foreach (DataGridViewRow row in dgvIngredientes.Rows)
            {
                var qtdIngredente = Convert.ToInt32(row.Cells[5].Value);

                if (qtdIngredente > 0)
                {
                    var pedidoLancheItem = new PedidoLancheItemViewModel
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
        private bool VerificardLancheExiste(PedidoLancheViewModel pedidoLanche)
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
        private void AtualizarQtdLanche(PedidoLancheViewModel pedidoLanche)
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

        public void ConcederDescontoCarne(PedidoLancheViewModel pedidoLanche)
        {
            var descontoLanche = pedidoLanche.Itens.Where(x => x.Nome == "Hambúrguer de carne" && x.Quantidade >= 3).Select(y=>((y.Quantidade)/3) * y.ValorUnitario).FirstOrDefault();
            pedidoLanche.Desconto += (descontoLanche * pedidoLanche.Quantidade);

        }
        public void ConcederDescontoQueijo(PedidoLancheViewModel pedidoLanche)
        {
            var descontoLanche = pedidoLanche.Itens.Where(x => x.Nome == "Queijo" && x.Quantidade >= 3).Select(y => ((y.Quantidade) / 3) * y.ValorUnitario).FirstOrDefault();
            pedidoLanche.Desconto += (descontoLanche * pedidoLanche.Quantidade);

        }
        public void ConcederDescontoVeggie(PedidoLancheViewModel pedidoLanche)
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
            if (e.KeyCode == Keys.F8)
            {
                btnAddLanche_Click(sender, e);
            }
            if (e.KeyCode == Keys.F9)
            {
                btnFinalizar_Click(sender, e);
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                //todo: Remover lanche da lista de pedidos
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gostaria de finalizar o pedido?", "Confirmação de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var pedidoViewModel = new PedidoViewModel
                {
                    PedidoLanches = _pedidos,
                    SubTotal = AtualizarSubTotalLanche(),
                    DescontoGeral = AtualizarDescontoLanche(),
                    Total = AtualizarTotalLanche()
                };

                var resultPedido = _pedidoService.FinalizarPedido(pedidoViewModel);

                if (resultPedido)
                {
                    MessageBox.Show("Pedido realizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o pedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
    public class IdComparer : IEqualityComparer<PedidoLancheItemViewModel>
    {
        public int GetHashCode(PedidoLancheItemViewModel co)
        {
            if (co == null)
            {
                return 0;
            }
            return co.Id.GetHashCode();
        }

        public bool Equals(PedidoLancheItemViewModel x1, PedidoLancheItemViewModel x2)
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


}