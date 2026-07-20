/*
 * Created by SharpDevelop.
 * User: User
 * Date: 18/07/2026
 * Time: 00:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade05_CadastroClientes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblDataCadastro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.Button btnTodos;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAtivarDesativar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblDataCadastro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnTodos = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAtivarDesativar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.lblEmail);
			this.groupBox1.Controls.Add(this.chkAtivo);
			this.groupBox1.Controls.Add(this.txtCidade);
			this.groupBox1.Controls.Add(this.txtTelefone);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.lblDataCadastro);
			this.groupBox1.Controls.Add(this.lblCidade);
			this.groupBox1.Controls.Add(this.lblTelefone);
			this.groupBox1.Controls.Add(this.lblCPF);
			this.groupBox1.Controls.Add(this.lblNome);
			this.groupBox1.Controls.Add(this.lblID);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(475, 197);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Cliente";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox2.Location = new System.Drawing.Point(289, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 20);
			this.textBox2.TabIndex = 14;
			// 
			// lblEmail
			// 
			this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(237, 50);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 23);
			this.lblEmail.TabIndex = 13;
			this.lblEmail.Text = "e-mail:";
			// 
			// chkAtivo
			// 
			this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.chkAtivo.Location = new System.Drawing.Point(289, 77);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(104, 24);
			this.chkAtivo.TabIndex = 12;
			this.chkAtivo.Text = "Cliente ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtCidade.Location = new System.Drawing.Point(80, 100);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(151, 20);
			this.txtCidade.TabIndex = 11;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtTelefone.Location = new System.Drawing.Point(80, 77);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(151, 20);
			this.txtTelefone.TabIndex = 10;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePicker1.Location = new System.Drawing.Point(128, 144);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtCPF.Location = new System.Drawing.Point(80, 50);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(151, 20);
			this.txtCPF.TabIndex = 8;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNome.Location = new System.Drawing.Point(289, 25);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(151, 20);
			this.txtNome.TabIndex = 7;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtID.Location = new System.Drawing.Point(80, 25);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(151, 20);
			this.txtID.TabIndex = 6;
			// 
			// lblDataCadastro
			// 
			this.lblDataCadastro.AutoSize = true;
			this.lblDataCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataCadastro.Location = new System.Drawing.Point(8, 144);
			this.lblDataCadastro.Name = "lblDataCadastro";
			this.lblDataCadastro.Size = new System.Drawing.Size(114, 20);
			this.lblDataCadastro.TabIndex = 5;
			this.lblDataCadastro.Text = "Data de cadastro:";
			// 
			// lblCidade
			// 
			this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(6, 100);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(100, 20);
			this.lblCidade.TabIndex = 4;
			this.lblCidade.Text = "Cidade:";
			// 
			// lblTelefone
			// 
			this.lblTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefone.Location = new System.Drawing.Point(7, 75);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(100, 20);
			this.lblTelefone.TabIndex = 3;
			this.lblTelefone.Text = "Telefone:";
			// 
			// lblCPF
			// 
			this.lblCPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPF.Location = new System.Drawing.Point(7, 50);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(100, 20);
			this.lblCPF.TabIndex = 2;
			this.lblCPF.Text = "CPF:";
			// 
			// lblNome
			// 
			this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(237, 25);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 23);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome:";
			// 
			// lblID
			// 
			this.lblID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(7, 25);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(100, 20);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnTodos);
			this.groupBox2.Controls.Add(this.btnBuscar);
			this.groupBox2.Controls.Add(this.txtBuscar);
			this.groupBox2.Controls.Add(this.lblBuscar);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(515, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 197);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pesquisa";
			// 
			// btnTodos
			// 
			this.btnTodos.FlatAppearance.BorderSize = 2;
			this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnTodos.Location = new System.Drawing.Point(130, 91);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(107, 23);
			this.btnTodos.TabIndex = 9;
			this.btnTodos.Text = "Mostrar todos";
			this.btnTodos.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 2;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnBuscar.Location = new System.Drawing.Point(32, 91);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 8;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtBuscar.Location = new System.Drawing.Point(7, 50);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(230, 20);
			this.txtBuscar.TabIndex = 7;
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Location = new System.Drawing.Point(7, 25);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(100, 25);
			this.lblBuscar.TabIndex = 0;
			this.lblBuscar.Text = "Buscar cliente:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(12, 256);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(869, 191);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Clientes Cadastrados";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colID,
			this.colNome,
			this.colCPF,
			this.colEmail,
			this.colTelefone,
			this.colCidade,
			this.colAtivo,
			this.colDataCadastro});
			this.dataGridView1.Location = new System.Drawing.Point(7, 25);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(849, 151);
			this.dataGridView1.TabIndex = 0;
			// 
			// colID
			// 
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			// 
			// colNome
			// 
			this.colNome.HeaderText = "Nome";
			this.colNome.Name = "colNome";
			this.colNome.ReadOnly = true;
			// 
			// colCPF
			// 
			this.colCPF.HeaderText = "CPF";
			this.colCPF.Name = "colCPF";
			this.colCPF.ReadOnly = true;
			// 
			// colEmail
			// 
			this.colEmail.HeaderText = "e-mail";
			this.colEmail.Name = "colEmail";
			this.colEmail.ReadOnly = true;
			// 
			// colTelefone
			// 
			this.colTelefone.HeaderText = "Telefone";
			this.colTelefone.Name = "colTelefone";
			this.colTelefone.ReadOnly = true;
			// 
			// colCidade
			// 
			this.colCidade.HeaderText = "Cidade";
			this.colCidade.Name = "colCidade";
			this.colCidade.ReadOnly = true;
			// 
			// colAtivo
			// 
			this.colAtivo.HeaderText = "Cliente Ativo";
			this.colAtivo.Name = "colAtivo";
			this.colAtivo.ReadOnly = true;
			// 
			// colDataCadastro
			// 
			this.colDataCadastro.HeaderText = "Data de Cadastro";
			this.colDataCadastro.Name = "colDataCadastro";
			this.colDataCadastro.ReadOnly = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnEditar);
			this.groupBox4.Controls.Add(this.btnAtivarDesativar);
			this.groupBox4.Controls.Add(this.btnCancelar);
			this.groupBox4.Controls.Add(this.btnExcluir);
			this.groupBox4.Controls.Add(this.btnNovo);
			this.groupBox4.Controls.Add(this.btnSalvar);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(12, 453);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(869, 76);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ações";
			// 
			// btnEditar
			// 
			this.btnEditar.FlatAppearance.BorderSize = 2;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnEditar.Location = new System.Drawing.Point(315, 32);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(112, 24);
			this.btnEditar.TabIndex = 15;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnAtivarDesativar
			// 
			this.btnAtivarDesativar.FlatAppearance.BorderSize = 2;
			this.btnAtivarDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAtivarDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnAtivarDesativar.Location = new System.Drawing.Point(575, 32);
			this.btnAtivarDesativar.Name = "btnAtivarDesativar";
			this.btnAtivarDesativar.Size = new System.Drawing.Size(112, 24);
			this.btnAtivarDesativar.TabIndex = 14;
			this.btnAtivarDesativar.Text = "Ativar/Desativar";
			this.btnAtivarDesativar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 2;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnCancelar.Location = new System.Drawing.Point(705, 32);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 24);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.FlatAppearance.BorderSize = 2;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnExcluir.Location = new System.Drawing.Point(445, 32);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(112, 24);
			this.btnExcluir.TabIndex = 11;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnNovo
			// 
			this.btnNovo.FlatAppearance.BorderSize = 2;
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnNovo.Location = new System.Drawing.Point(55, 32);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(112, 24);
			this.btnNovo.TabIndex = 10;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatAppearance.BorderSize = 2;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSalvar.Location = new System.Drawing.Point(185, 32);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(112, 24);
			this.btnSalvar.TabIndex = 9;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(292, 19);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(217, 31);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Cadastro de Clientes";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 600);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Cadastro de Clientes";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
