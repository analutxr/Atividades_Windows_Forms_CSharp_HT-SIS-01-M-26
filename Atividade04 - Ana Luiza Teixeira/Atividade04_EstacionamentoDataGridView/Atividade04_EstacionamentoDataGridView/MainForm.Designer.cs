/*
 * Created by SharpDevelop.
 * User: User
 * Date: 17/07/2026
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade04_EstacionamentoDataGridView
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnRegistrarEntrada;
		private System.Windows.Forms.ComboBox cboTipo;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblRegistroEntrada;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.DataGridView dgvVeiculos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSaida;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHoras;
		private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtTotalRecebido;
		private System.Windows.Forms.TextBox txtFinalizados;
		private System.Windows.Forms.TextBox txtEstacionados;
		private System.Windows.Forms.Label lblTotalRecebido;
		private System.Windows.Forms.Label lblFinalizados;
		private System.Windows.Forms.Label lblEstacionados;
		private System.Windows.Forms.Button btnRegistrarSaida;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtPlacaPesquisa;
		private System.Windows.Forms.Label lblPlacaPesquisa;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DateTimePicker dtpSaida;
		private System.Windows.Forms.Label lblRegistroSaida;
		private System.Windows.Forms.Button btnRemoverRegistro;
		private System.Windows.Forms.Button btnLimparTudo;
		private System.Windows.Forms.Button btnMostrarTudo;
		private System.Windows.Forms.Button btnRemoverSelecionado;
		private System.Windows.Forms.Button brnEncerrar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblRegistroEntrada = new System.Windows.Forms.Label();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnRegistrarEntrada = new System.Windows.Forms.Button();
			this.cboTipo = new System.Windows.Forms.ComboBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvVeiculos = new System.Windows.Forms.DataGridView();
			this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtTotalRecebido = new System.Windows.Forms.TextBox();
			this.txtFinalizados = new System.Windows.Forms.TextBox();
			this.txtEstacionados = new System.Windows.Forms.TextBox();
			this.lblTotalRecebido = new System.Windows.Forms.Label();
			this.lblFinalizados = new System.Windows.Forms.Label();
			this.lblEstacionados = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtPlacaPesquisa = new System.Windows.Forms.TextBox();
			this.lblPlacaPesquisa = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnRemoverRegistro = new System.Windows.Forms.Button();
			this.btnRegistrarSaida = new System.Windows.Forms.Button();
			this.dtpSaida = new System.Windows.Forms.DateTimePicker();
			this.lblRegistroSaida = new System.Windows.Forms.Label();
			this.btnLimparTudo = new System.Windows.Forms.Button();
			this.btnMostrarTudo = new System.Windows.Forms.Button();
			this.btnRemoverSelecionado = new System.Windows.Forms.Button();
			this.brnEncerrar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblRegistroEntrada);
			this.groupBox1.Controls.Add(this.dtpEntrada);
			this.groupBox1.Controls.Add(this.btnLimpar);
			this.groupBox1.Controls.Add(this.btnRegistrarEntrada);
			this.groupBox1.Controls.Add(this.cboTipo);
			this.groupBox1.Controls.Add(this.txtModelo);
			this.groupBox1.Controls.Add(this.txtPlaca);
			this.groupBox1.Controls.Add(this.lblTipo);
			this.groupBox1.Controls.Add(this.lblModelo);
			this.groupBox1.Controls.Add(this.lblPlaca);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(323, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registro de Entrada";
			// 
			// lblRegistroEntrada
			// 
			this.lblRegistroEntrada.AutoSize = true;
			this.lblRegistroEntrada.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblRegistroEntrada.Location = new System.Drawing.Point(8, 100);
			this.lblRegistroEntrada.Name = "lblRegistroEntrada";
			this.lblRegistroEntrada.Size = new System.Drawing.Size(58, 20);
			this.lblRegistroEntrada.TabIndex = 7;
			this.lblRegistroEntrada.Text = "Entrada:";
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntrada.Location = new System.Drawing.Point(94, 100);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.ShowUpDown = true;
			this.dtpEntrada.Size = new System.Drawing.Size(201, 20);
			this.dtpEntrada.TabIndex = 6;
			// 
			// btnLimpar
			// 
			this.btnLimpar.AutoSize = true;
			this.btnLimpar.FlatAppearance.BorderSize = 2;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnLimpar.Location = new System.Drawing.Point(207, 136);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(62, 25);
			this.btnLimpar.TabIndex = 4;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnRegistrarEntrada
			// 
			this.btnRegistrarEntrada.AutoSize = true;
			this.btnRegistrarEntrada.BackColor = System.Drawing.Color.ForestGreen;
			this.btnRegistrarEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnRegistrarEntrada.FlatAppearance.BorderSize = 2;
			this.btnRegistrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnRegistrarEntrada.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarEntrada.Location = new System.Drawing.Point(61, 136);
			this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
			this.btnRegistrarEntrada.Size = new System.Drawing.Size(101, 25);
			this.btnRegistrarEntrada.TabIndex = 3;
			this.btnRegistrarEntrada.Text = "Registrar entrada";
			this.btnRegistrarEntrada.UseVisualStyleBackColor = false;
			this.btnRegistrarEntrada.Click += new System.EventHandler(this.BtnRegistrarEntradaClick);
			// 
			// cboTipo
			// 
			this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cboTipo.FormattingEnabled = true;
			this.cboTipo.Items.AddRange(new object[] {
			"Carro",
			"Moto",
			"Utilitário"});
			this.cboTipo.Location = new System.Drawing.Point(94, 75);
			this.cboTipo.Name = "cboTipo";
			this.cboTipo.Size = new System.Drawing.Size(201, 21);
			this.cboTipo.TabIndex = 5;
			// 
			// txtModelo
			// 
			this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtModelo.Location = new System.Drawing.Point(94, 50);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(201, 20);
			this.txtModelo.TabIndex = 4;
			// 
			// txtPlaca
			// 
			this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtPlaca.Location = new System.Drawing.Point(94, 25);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(201, 20);
			this.txtPlaca.TabIndex = 3;
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblTipo.Location = new System.Drawing.Point(7, 75);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(39, 20);
			this.lblTipo.TabIndex = 2;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblModelo.Location = new System.Drawing.Point(7, 50);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(59, 20);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblPlaca.Location = new System.Drawing.Point(7, 25);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(46, 20);
			this.lblPlaca.TabIndex = 0;
			this.lblPlaca.Text = "Placa:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvVeiculos);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(12, 239);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(617, 139);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listagem de Veículos";
			// 
			// dgvVeiculos
			// 
			this.dgvVeiculos.AllowUserToAddRows = false;
			this.dgvVeiculos.AllowUserToDeleteRows = false;
			this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colPlaca,
			this.colModelo,
			this.colTipo,
			this.colEntrada,
			this.colSaida,
			this.colHoras,
			this.colValor,
			this.colSituacao});
			this.dgvVeiculos.Location = new System.Drawing.Point(6, 24);
			this.dgvVeiculos.MultiSelect = false;
			this.dgvVeiculos.Name = "dgvVeiculos";
			this.dgvVeiculos.ReadOnly = true;
			this.dgvVeiculos.RowHeadersVisible = false;
			this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVeiculos.Size = new System.Drawing.Size(587, 89);
			this.dgvVeiculos.TabIndex = 0;
			// 
			// colPlaca
			// 
			this.colPlaca.HeaderText = "Placa";
			this.colPlaca.Name = "colPlaca";
			this.colPlaca.ReadOnly = true;
			// 
			// colModelo
			// 
			this.colModelo.HeaderText = "Modelo";
			this.colModelo.Name = "colModelo";
			this.colModelo.ReadOnly = true;
			// 
			// colTipo
			// 
			this.colTipo.HeaderText = "Tipo";
			this.colTipo.Name = "colTipo";
			this.colTipo.ReadOnly = true;
			// 
			// colEntrada
			// 
			this.colEntrada.HeaderText = "Entrada";
			this.colEntrada.Name = "colEntrada";
			this.colEntrada.ReadOnly = true;
			// 
			// colSaida
			// 
			this.colSaida.HeaderText = "Saida";
			this.colSaida.Name = "colSaida";
			this.colSaida.ReadOnly = true;
			// 
			// colHoras
			// 
			this.colHoras.HeaderText = "Horas";
			this.colHoras.Name = "colHoras";
			this.colHoras.ReadOnly = true;
			// 
			// colValor
			// 
			this.colValor.HeaderText = "Valor";
			this.colValor.Name = "colValor";
			this.colValor.ReadOnly = true;
			// 
			// colSituacao
			// 
			this.colSituacao.HeaderText = "Situação";
			this.colSituacao.Name = "colSituacao";
			this.colSituacao.ReadOnly = true;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(204, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(288, 31);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Controle de Estacionamento";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtTotalRecebido);
			this.groupBox3.Controls.Add(this.txtFinalizados);
			this.groupBox3.Controls.Add(this.txtEstacionados);
			this.groupBox3.Controls.Add(this.lblTotalRecebido);
			this.groupBox3.Controls.Add(this.lblFinalizados);
			this.groupBox3.Controls.Add(this.lblEstacionados);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(18, 384);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(275, 112);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Indicadores";
			// 
			// txtTotalRecebido
			// 
			this.txtTotalRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtTotalRecebido.Location = new System.Drawing.Point(163, 75);
			this.txtTotalRecebido.Name = "txtTotalRecebido";
			this.txtTotalRecebido.Size = new System.Drawing.Size(100, 20);
			this.txtTotalRecebido.TabIndex = 5;
			// 
			// txtFinalizados
			// 
			this.txtFinalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtFinalizados.Location = new System.Drawing.Point(163, 50);
			this.txtFinalizados.Name = "txtFinalizados";
			this.txtFinalizados.Size = new System.Drawing.Size(100, 20);
			this.txtFinalizados.TabIndex = 4;
			// 
			// txtEstacionados
			// 
			this.txtEstacionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtEstacionados.Location = new System.Drawing.Point(163, 25);
			this.txtEstacionados.Name = "txtEstacionados";
			this.txtEstacionados.Size = new System.Drawing.Size(100, 20);
			this.txtEstacionados.TabIndex = 3;
			// 
			// lblTotalRecebido
			// 
			this.lblTotalRecebido.AutoSize = true;
			this.lblTotalRecebido.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblTotalRecebido.Location = new System.Drawing.Point(7, 75);
			this.lblTotalRecebido.Name = "lblTotalRecebido";
			this.lblTotalRecebido.Size = new System.Drawing.Size(104, 20);
			this.lblTotalRecebido.TabIndex = 2;
			this.lblTotalRecebido.Text = "Total Recebido:";
			// 
			// lblFinalizados
			// 
			this.lblFinalizados.AutoSize = true;
			this.lblFinalizados.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblFinalizados.Location = new System.Drawing.Point(7, 50);
			this.lblFinalizados.Name = "lblFinalizados";
			this.lblFinalizados.Size = new System.Drawing.Size(132, 20);
			this.lblFinalizados.TabIndex = 1;
			this.lblFinalizados.Text = "Veículos finalizados:";
			// 
			// lblEstacionados
			// 
			this.lblEstacionados.AutoSize = true;
			this.lblEstacionados.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblEstacionados.Location = new System.Drawing.Point(7, 25);
			this.lblEstacionados.Name = "lblEstacionados";
			this.lblEstacionados.Size = new System.Drawing.Size(149, 20);
			this.lblEstacionados.TabIndex = 0;
			this.lblEstacionados.Text = "Veículos estacionados:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnMostrarTodos);
			this.groupBox5.Controls.Add(this.btnPesquisar);
			this.groupBox5.Controls.Add(this.txtPlacaPesquisa);
			this.groupBox5.Controls.Add(this.lblPlacaPesquisa);
			this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox5.Location = new System.Drawing.Point(344, 57);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(285, 176);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Pesquisa";
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.AutoSize = true;
			this.btnMostrarTodos.FlatAppearance.BorderSize = 2;
			this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnMostrarTodos.Location = new System.Drawing.Point(142, 61);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(97, 25);
			this.btnMostrarTodos.TabIndex = 3;
			this.btnMostrarTodos.Text = "Mostrar todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.FlatAppearance.BorderSize = 2;
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnPesquisar.Location = new System.Drawing.Point(31, 61);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(72, 24);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// txtPlacaPesquisa
			// 
			this.txtPlacaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtPlacaPesquisa.Location = new System.Drawing.Point(59, 24);
			this.txtPlacaPesquisa.Name = "txtPlacaPesquisa";
			this.txtPlacaPesquisa.Size = new System.Drawing.Size(184, 20);
			this.txtPlacaPesquisa.TabIndex = 1;
			// 
			// lblPlacaPesquisa
			// 
			this.lblPlacaPesquisa.AutoSize = true;
			this.lblPlacaPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlacaPesquisa.Location = new System.Drawing.Point(6, 25);
			this.lblPlacaPesquisa.Name = "lblPlacaPesquisa";
			this.lblPlacaPesquisa.Size = new System.Drawing.Size(46, 20);
			this.lblPlacaPesquisa.TabIndex = 0;
			this.lblPlacaPesquisa.Text = "Placa:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnRemoverRegistro);
			this.groupBox6.Controls.Add(this.btnRegistrarSaida);
			this.groupBox6.Controls.Add(this.dtpSaida);
			this.groupBox6.Controls.Add(this.lblRegistroSaida);
			this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox6.Location = new System.Drawing.Point(316, 384);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(313, 119);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Registro de Saída";
			// 
			// btnRemoverRegistro
			// 
			this.btnRemoverRegistro.AutoSize = true;
			this.btnRemoverRegistro.BackColor = System.Drawing.Color.Firebrick;
			this.btnRemoverRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.btnRemoverRegistro.FlatAppearance.BorderSize = 2;
			this.btnRemoverRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnRemoverRegistro.ForeColor = System.Drawing.Color.White;
			this.btnRemoverRegistro.Location = new System.Drawing.Point(170, 61);
			this.btnRemoverRegistro.Name = "btnRemoverRegistro";
			this.btnRemoverRegistro.Size = new System.Drawing.Size(104, 27);
			this.btnRemoverRegistro.TabIndex = 5;
			this.btnRemoverRegistro.Text = "Remover registro";
			this.btnRemoverRegistro.UseVisualStyleBackColor = false;
			this.btnRemoverRegistro.Click += new System.EventHandler(this.BtnRemoverRegistroClick);
			// 
			// btnRegistrarSaida
			// 
			this.btnRegistrarSaida.AutoSize = true;
			this.btnRegistrarSaida.BackColor = System.Drawing.Color.ForestGreen;
			this.btnRegistrarSaida.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnRegistrarSaida.FlatAppearance.BorderSize = 2;
			this.btnRegistrarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnRegistrarSaida.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarSaida.Location = new System.Drawing.Point(34, 61);
			this.btnRegistrarSaida.Name = "btnRegistrarSaida";
			this.btnRegistrarSaida.Size = new System.Drawing.Size(101, 27);
			this.btnRegistrarSaida.TabIndex = 4;
			this.btnRegistrarSaida.Text = "Registrar saída";
			this.btnRegistrarSaida.UseVisualStyleBackColor = false;
			this.btnRegistrarSaida.Click += new System.EventHandler(this.BtnRegistrarSaidaClick);
			// 
			// dtpSaida
			// 
			this.dtpSaida.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSaida.Location = new System.Drawing.Point(59, 25);
			this.dtpSaida.Name = "dtpSaida";
			this.dtpSaida.ShowUpDown = true;
			this.dtpSaida.Size = new System.Drawing.Size(212, 20);
			this.dtpSaida.TabIndex = 1;
			// 
			// lblRegistroSaida
			// 
			this.lblRegistroSaida.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblRegistroSaida.Location = new System.Drawing.Point(7, 25);
			this.lblRegistroSaida.Name = "lblRegistroSaida";
			this.lblRegistroSaida.Size = new System.Drawing.Size(100, 23);
			this.lblRegistroSaida.TabIndex = 0;
			this.lblRegistroSaida.Text = "Saída:";
			// 
			// btnLimparTudo
			// 
			this.btnLimparTudo.AutoSize = true;
			this.btnLimparTudo.FlatAppearance.BorderSize = 2;
			this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnLimparTudo.Location = new System.Drawing.Point(54, 525);
			this.btnLimparTudo.Name = "btnLimparTudo";
			this.btnLimparTudo.Size = new System.Drawing.Size(74, 25);
			this.btnLimparTudo.TabIndex = 7;
			this.btnLimparTudo.Text = "Limpar tudo";
			this.btnLimparTudo.UseVisualStyleBackColor = true;
			this.btnLimparTudo.Click += new System.EventHandler(this.BtnLimparTudoClick);
			// 
			// btnMostrarTudo
			// 
			this.btnMostrarTudo.AutoSize = true;
			this.btnMostrarTudo.FlatAppearance.BorderSize = 2;
			this.btnMostrarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMostrarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnMostrarTudo.Location = new System.Drawing.Point(177, 525);
			this.btnMostrarTudo.Name = "btnMostrarTudo";
			this.btnMostrarTudo.Size = new System.Drawing.Size(97, 25);
			this.btnMostrarTudo.TabIndex = 8;
			this.btnMostrarTudo.Text = "Mostrar todos";
			this.btnMostrarTudo.UseVisualStyleBackColor = true;
			// 
			// btnRemoverSelecionado
			// 
			this.btnRemoverSelecionado.AutoSize = true;
			this.btnRemoverSelecionado.FlatAppearance.BorderSize = 2;
			this.btnRemoverSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRemoverSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnRemoverSelecionado.Location = new System.Drawing.Point(323, 525);
			this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
			this.btnRemoverSelecionado.Size = new System.Drawing.Size(124, 25);
			this.btnRemoverSelecionado.TabIndex = 9;
			this.btnRemoverSelecionado.Text = "Remover selecionado";
			this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
			// 
			// brnEncerrar
			// 
			this.brnEncerrar.AutoSize = true;
			this.brnEncerrar.BackColor = System.Drawing.Color.Firebrick;
			this.brnEncerrar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.brnEncerrar.FlatAppearance.BorderSize = 2;
			this.brnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.brnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.brnEncerrar.ForeColor = System.Drawing.Color.White;
			this.brnEncerrar.Location = new System.Drawing.Point(496, 525);
			this.brnEncerrar.Name = "brnEncerrar";
			this.brnEncerrar.Size = new System.Drawing.Size(104, 25);
			this.brnEncerrar.TabIndex = 10;
			this.brnEncerrar.Text = "Encerrar sistema";
			this.brnEncerrar.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 593);
			this.Controls.Add(this.brnEncerrar);
			this.Controls.Add(this.btnRemoverSelecionado);
			this.Controls.Add(this.btnMostrarTudo);
			this.Controls.Add(this.btnLimparTudo);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle de Estacionamento";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
