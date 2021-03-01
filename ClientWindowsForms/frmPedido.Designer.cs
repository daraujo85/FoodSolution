namespace ClientWindowsForms
{
    partial class frmPedido
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLanches = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.IntegrienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegrienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegrienteValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegrienteQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adicionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLanche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtdLanche = new System.Windows.Forms.NumericUpDown();
            this.lblTempo = new System.Windows.Forms.Label();
            this.tmPedido = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubTotalPedido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescontoPedido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalIngredientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.RemoverItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LancheId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdLanche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anton", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lanches";
            // 
            // dgvLanches
            // 
            this.dgvLanches.AllowUserToAddRows = false;
            this.dgvLanches.AllowUserToDeleteRows = false;
            this.dgvLanches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLanches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome});
            this.dgvLanches.Location = new System.Drawing.Point(24, 81);
            this.dgvLanches.MultiSelect = false;
            this.dgvLanches.Name = "dgvLanches";
            this.dgvLanches.ReadOnly = true;
            this.dgvLanches.RowHeadersVisible = false;
            this.dgvLanches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLanches.Size = new System.Drawing.Size(170, 281);
            this.dgvLanches.TabIndex = 1;
            this.dgvLanches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLanches_CellContentClick);
            this.dgvLanches.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLanches_CellEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Anton", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 22;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "descricao";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Anton", 30F);
            this.lblIngredientes.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIngredientes.Location = new System.Drawing.Point(190, 9);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(234, 69);
            this.lblIngredientes.TabIndex = 2;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToDeleteRows = false;
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIngredientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntegrienteId,
            this.IntegrienteNome,
            this.IntegrienteValorUnit,
            this.IntegrienteQtd,
            this.remover,
            this.adicionar});
            this.dgvIngredientes.Location = new System.Drawing.Point(200, 81);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(439, 281);
            this.dgvIngredientes.TabIndex = 3;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellContentClick);
            this.dgvIngredientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellEnter);
            this.dgvIngredientes.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellValidated);
            // 
            // IntegrienteId
            // 
            this.IntegrienteId.DataPropertyName = "Id";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Anton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.IntegrienteId.DefaultCellStyle = dataGridViewCellStyle3;
            this.IntegrienteId.HeaderText = "Id";
            this.IntegrienteId.Name = "IntegrienteId";
            this.IntegrienteId.Visible = false;
            this.IntegrienteId.Width = 22;
            // 
            // IntegrienteNome
            // 
            this.IntegrienteNome.DataPropertyName = "descricao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.IntegrienteNome.DefaultCellStyle = dataGridViewCellStyle4;
            this.IntegrienteNome.HeaderText = "Nome";
            this.IntegrienteNome.Name = "IntegrienteNome";
            this.IntegrienteNome.ReadOnly = true;
            this.IntegrienteNome.Width = 60;
            // 
            // IntegrienteValorUnit
            // 
            this.IntegrienteValorUnit.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.IntegrienteValorUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.IntegrienteValorUnit.HeaderText = "Valor Unit.";
            this.IntegrienteValorUnit.Name = "IntegrienteValorUnit";
            this.IntegrienteValorUnit.ReadOnly = true;
            this.IntegrienteValorUnit.Width = 81;
            // 
            // IntegrienteQtd
            // 
            this.IntegrienteQtd.DataPropertyName = "Quantidade";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            this.IntegrienteQtd.DefaultCellStyle = dataGridViewCellStyle6;
            this.IntegrienteQtd.HeaderText = "Qtd.";
            this.IntegrienteQtd.Name = "IntegrienteQtd";
            this.IntegrienteQtd.Width = 52;
            // 
            // remover
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remover.DefaultCellStyle = dataGridViewCellStyle7;
            this.remover.HeaderText = "";
            this.remover.Name = "remover";
            this.remover.ReadOnly = true;
            this.remover.Text = "-";
            this.remover.ToolTipText = "Remover";
            this.remover.UseColumnTextForButtonValue = true;
            this.remover.Width = 5;
            // 
            // adicionar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.DefaultCellStyle = dataGridViewCellStyle8;
            this.adicionar.HeaderText = "";
            this.adicionar.Name = "adicionar";
            this.adicionar.ReadOnly = true;
            this.adicionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adicionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adicionar.Text = "+";
            this.adicionar.ToolTipText = "Adicionar";
            this.adicionar.UseColumnTextForButtonValue = true;
            this.adicionar.Width = 19;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoverItem,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.Desconto,
            this.Subtotal,
            this.LancheId,
            this.TotalLanche,
            this.PedidoId});
            this.dgvPedidos.Location = new System.Drawing.Point(24, 437);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1015, 281);
            this.dgvPedidos.TabIndex = 5;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anton", 30F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(16, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalhes do pedido";
            // 
            // btnAddLanche
            // 
            this.btnAddLanche.Font = new System.Drawing.Font("Anton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLanche.ForeColor = System.Drawing.Color.Black;
            this.btnAddLanche.Location = new System.Drawing.Point(889, 176);
            this.btnAddLanche.Name = "btnAddLanche";
            this.btnAddLanche.Size = new System.Drawing.Size(150, 186);
            this.btnAddLanche.TabIndex = 6;
            this.btnAddLanche.Text = "&Adicionar (F8)";
            this.btnAddLanche.UseVisualStyleBackColor = true;
            this.btnAddLanche.Click += new System.EventHandler(this.btnAddLanche_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Anton", 30F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(877, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 69);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qtd.";
            // 
            // nudQtdLanche
            // 
            this.nudQtdLanche.Font = new System.Drawing.Font("Anton", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdLanche.ForeColor = System.Drawing.Color.Black;
            this.nudQtdLanche.Location = new System.Drawing.Point(889, 81);
            this.nudQtdLanche.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdLanche.Name = "nudQtdLanche";
            this.nudQtdLanche.Size = new System.Drawing.Size(150, 87);
            this.nudQtdLanche.TabIndex = 8;
            this.nudQtdLanche.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Anton", 30F);
            this.lblTempo.ForeColor = System.Drawing.Color.Gray;
            this.lblTempo.Location = new System.Drawing.Point(930, 365);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(120, 69);
            this.lblTempo.TabIndex = 9;
            this.lblTempo.Text = "00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmPedido
            // 
            this.tmPedido.Tick += new System.EventHandler(this.tmPedido_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Anton", 20F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(20, 739);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 47);
            this.label5.TabIndex = 11;
            this.label5.Text = "SubTotal";
            // 
            // lblSubTotalPedido
            // 
            this.lblSubTotalPedido.AutoSize = true;
            this.lblSubTotalPedido.Font = new System.Drawing.Font("Anton", 30F);
            this.lblSubTotalPedido.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotalPedido.Location = new System.Drawing.Point(118, 721);
            this.lblSubTotalPedido.Name = "lblSubTotalPedido";
            this.lblSubTotalPedido.Size = new System.Drawing.Size(0, 69);
            this.lblSubTotalPedido.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Anton", 20F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(348, 740);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descontos";
            // 
            // lblDescontoPedido
            // 
            this.lblDescontoPedido.AutoSize = true;
            this.lblDescontoPedido.Font = new System.Drawing.Font("Anton", 30F);
            this.lblDescontoPedido.ForeColor = System.Drawing.Color.Black;
            this.lblDescontoPedido.Location = new System.Drawing.Point(468, 722);
            this.lblDescontoPedido.Name = "lblDescontoPedido";
            this.lblDescontoPedido.Size = new System.Drawing.Size(0, 69);
            this.lblDescontoPedido.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Anton", 20F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(673, 739);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 47);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPedido.Font = new System.Drawing.Font("Anton", 30F);
            this.lblTotalPedido.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPedido.Location = new System.Drawing.Point(735, 722);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(0, 69);
            this.lblTotalPedido.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Anton", 20F);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(418, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 47);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total";
            // 
            // lblTotalIngredientes
            // 
            this.lblTotalIngredientes.AutoSize = true;
            this.lblTotalIngredientes.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIngredientes.Font = new System.Drawing.Font("Anton", 30F);
            this.lblTotalIngredientes.ForeColor = System.Drawing.Color.Black;
            this.lblTotalIngredientes.Location = new System.Drawing.Point(480, 9);
            this.lblTotalIngredientes.Name = "lblTotalIngredientes";
            this.lblTotalIngredientes.Size = new System.Drawing.Size(0, 69);
            this.lblTotalIngredientes.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(654, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Anton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(889, 732);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 54);
            this.btnFinalizar.TabIndex = 19;
            this.btnFinalizar.Text = "&Finalizar Pedido (F9)";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // RemoverItem
            // 
            this.RemoverItem.HeaderText = "";
            this.RemoverItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoverItem.Image")));
            this.RemoverItem.Name = "RemoverItem";
            this.RemoverItem.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Anton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantidade";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn7.HeaderText = "Qtd.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "Quantidade";
            this.dataGridViewTextBoxColumn7.Width = 52;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor Unit.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 81;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "Desconto";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Anton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle13;
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 78;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Anton", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle14;
            this.Subtotal.HeaderText = "SubTotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 75;
            // 
            // LancheId
            // 
            this.LancheId.DataPropertyName = "LancheId";
            this.LancheId.HeaderText = "LancheId";
            this.LancheId.Name = "LancheId";
            this.LancheId.Visible = false;
            this.LancheId.Width = 77;
            // 
            // TotalLanche
            // 
            this.TotalLanche.DataPropertyName = "Total";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Anton", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.TotalLanche.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalLanche.HeaderText = "Total";
            this.TotalLanche.Name = "TotalLanche";
            this.TotalLanche.ReadOnly = true;
            this.TotalLanche.Width = 56;
            // 
            // PedidoId
            // 
            this.PedidoId.DataPropertyName = "PedidoId";
            this.PedidoId.HeaderText = "PedidoId";
            this.PedidoId.Name = "PedidoId";
            this.PedidoId.Visible = false;
            this.PedidoId.Width = 74;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 789);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalIngredientes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescontoPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSubTotalPedido);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.nudQtdLanche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddLanche);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.dgvLanches);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdLanche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLanches;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtdLanche;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer tmPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubTotalPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescontoPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalIngredientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegrienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegrienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegrienteValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegrienteQtd;
        private System.Windows.Forms.DataGridViewButtonColumn remover;
        private System.Windows.Forms.DataGridViewButtonColumn adicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewImageColumn RemoverItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LancheId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoId;
    }
}

