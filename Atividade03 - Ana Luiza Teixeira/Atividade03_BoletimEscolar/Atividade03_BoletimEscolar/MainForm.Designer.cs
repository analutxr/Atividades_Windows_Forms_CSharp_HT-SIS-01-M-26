/*
 * Created by SharpDevelop.
 * User: User
 * Date: 17/07/2026
 * Time: 01:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade03_BoletimEscolar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nudFrequencia;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.TextBox txtAluno;
		private System.Windows.Forms.Label lblAluno;
		private System.Windows.Forms.Label lblFrequencia;
		private System.Windows.Forms.Label lblTurma;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSituacao;
		private System.Windows.Forms.TextBox txtMedia;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.Label lblMedia;
		private System.Windows.Forms.TextBox txtNota4;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.Label lblNota4;
		private System.Windows.Forms.Label lblNota3;
		private System.Windows.Forms.Label lblNota2;
		private System.Windows.Forms.Label lblNota1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox lstResultados;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnAdicionarResultado;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtResumoTurma;
		private System.Windows.Forms.Button btnGerarResumo;
		private System.Windows.Forms.Button btnLimparCampos;
		private System.Windows.Forms.Button btnLimparLista;
		private System.Windows.Forms.Button btnRemoverSelecionado;
		
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudFrequencia = new System.Windows.Forms.NumericUpDown();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.txtAluno = new System.Windows.Forms.TextBox();
			this.lblAluno = new System.Windows.Forms.Label();
			this.lblFrequencia = new System.Windows.Forms.Label();
			this.lblTurma = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSituacao = new System.Windows.Forms.TextBox();
			this.txtMedia = new System.Windows.Forms.TextBox();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.lblMedia = new System.Windows.Forms.Label();
			this.txtNota4 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.lblNota4 = new System.Windows.Forms.Label();
			this.lblNota3 = new System.Windows.Forms.Label();
			this.lblNota2 = new System.Windows.Forms.Label();
			this.lblNota1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lstResultados = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAdicionarResultado = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtResumoTurma = new System.Windows.Forms.TextBox();
			this.btnGerarResumo = new System.Windows.Forms.Button();
			this.btnLimparCampos = new System.Windows.Forms.Button();
			this.btnLimparLista = new System.Windows.Forms.Button();
			this.btnRemoverSelecionado = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20F);
			this.lblTitulo.Location = new System.Drawing.Point(225, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(233, 31);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Boletim Escolar Digital";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudFrequencia);
			this.groupBox1.Controls.Add(this.txtTurma);
			this.groupBox1.Controls.Add(this.txtAluno);
			this.groupBox1.Controls.Add(this.lblAluno);
			this.groupBox1.Controls.Add(this.lblFrequencia);
			this.groupBox1.Controls.Add(this.lblTurma);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 138);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Aluno e Turma";
			// 
			// nudFrequencia
			// 
			this.nudFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudFrequencia.Location = new System.Drawing.Point(138, 75);
			this.nudFrequencia.Name = "nudFrequencia";
			this.nudFrequencia.Size = new System.Drawing.Size(120, 20);
			this.nudFrequencia.TabIndex = 5;
			// 
			// txtTurma
			// 
			this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtTurma.Location = new System.Drawing.Point(138, 50);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(180, 20);
			this.txtTurma.TabIndex = 4;
			// 
			// txtAluno
			// 
			this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtAluno.Location = new System.Drawing.Point(138, 25);
			this.txtAluno.Name = "txtAluno";
			this.txtAluno.Size = new System.Drawing.Size(180, 20);
			this.txtAluno.TabIndex = 3;
			// 
			// lblAluno
			// 
			this.lblAluno.AutoSize = true;
			this.lblAluno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAluno.Location = new System.Drawing.Point(7, 25);
			this.lblAluno.Name = "lblAluno";
			this.lblAluno.Size = new System.Drawing.Size(105, 20);
			this.lblAluno.TabIndex = 2;
			this.lblAluno.Text = "Nome do aluno:";
			// 
			// lblFrequencia
			// 
			this.lblFrequencia.AutoSize = true;
			this.lblFrequencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFrequencia.Location = new System.Drawing.Point(7, 75);
			this.lblFrequencia.Name = "lblFrequencia";
			this.lblFrequencia.Size = new System.Drawing.Size(104, 20);
			this.lblFrequencia.TabIndex = 1;
			this.lblFrequencia.Text = "Frequência (%):";
			// 
			// lblTurma
			// 
			this.lblTurma.AutoSize = true;
			this.lblTurma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurma.Location = new System.Drawing.Point(7, 50);
			this.lblTurma.Name = "lblTurma";
			this.lblTurma.Size = new System.Drawing.Size(49, 20);
			this.lblTurma.TabIndex = 0;
			this.lblTurma.Text = "Turma:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSituacao);
			this.groupBox2.Controls.Add(this.txtMedia);
			this.groupBox2.Controls.Add(this.lblSituacao);
			this.groupBox2.Controls.Add(this.lblMedia);
			this.groupBox2.Controls.Add(this.txtNota4);
			this.groupBox2.Controls.Add(this.txtNota3);
			this.groupBox2.Controls.Add(this.txtNota2);
			this.groupBox2.Controls.Add(this.txtNota1);
			this.groupBox2.Controls.Add(this.lblNota4);
			this.groupBox2.Controls.Add(this.lblNota3);
			this.groupBox2.Controls.Add(this.lblNota2);
			this.groupBox2.Controls.Add(this.lblNota1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(351, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 137);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Notas e Resultados";
			// 
			// txtSituacao
			// 
			this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtSituacao.Location = new System.Drawing.Point(78, 103);
			this.txtSituacao.Name = "txtSituacao";
			this.txtSituacao.ReadOnly = true;
			this.txtSituacao.Size = new System.Drawing.Size(130, 20);
			this.txtSituacao.TabIndex = 11;
			// 
			// txtMedia
			// 
			this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtMedia.Location = new System.Drawing.Point(78, 77);
			this.txtMedia.Name = "txtMedia";
			this.txtMedia.ReadOnly = true;
			this.txtMedia.Size = new System.Drawing.Size(130, 20);
			this.txtMedia.TabIndex = 10;
			// 
			// lblSituacao
			// 
			this.lblSituacao.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblSituacao.Location = new System.Drawing.Point(7, 103);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(100, 23);
			this.lblSituacao.TabIndex = 9;
			this.lblSituacao.Text = "Situação:";
			// 
			// lblMedia
			// 
			this.lblMedia.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblMedia.Location = new System.Drawing.Point(8, 80);
			this.lblMedia.Name = "lblMedia";
			this.lblMedia.Size = new System.Drawing.Size(100, 23);
			this.lblMedia.TabIndex = 8;
			this.lblMedia.Text = "Média:";
			// 
			// txtNota4
			// 
			this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNota4.Location = new System.Drawing.Point(167, 44);
			this.txtNota4.Name = "txtNota4";
			this.txtNota4.Size = new System.Drawing.Size(40, 20);
			this.txtNota4.TabIndex = 7;
			// 
			// txtNota3
			// 
			this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNota3.Location = new System.Drawing.Point(114, 44);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(40, 20);
			this.txtNota3.TabIndex = 6;
			// 
			// txtNota2
			// 
			this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNota2.Location = new System.Drawing.Point(61, 44);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(40, 20);
			this.txtNota2.TabIndex = 5;
			// 
			// txtNota1
			// 
			this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNota1.Location = new System.Drawing.Point(8, 44);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(40, 20);
			this.txtNota1.TabIndex = 4;
			// 
			// lblNota4
			// 
			this.lblNota4.AutoSize = true;
			this.lblNota4.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblNota4.Location = new System.Drawing.Point(167, 21);
			this.lblNota4.Name = "lblNota4";
			this.lblNota4.Size = new System.Drawing.Size(25, 20);
			this.lblNota4.TabIndex = 3;
			this.lblNota4.Text = "N4";
			this.lblNota4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNota3
			// 
			this.lblNota3.AutoSize = true;
			this.lblNota3.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblNota3.Location = new System.Drawing.Point(114, 21);
			this.lblNota3.Name = "lblNota3";
			this.lblNota3.Size = new System.Drawing.Size(25, 20);
			this.lblNota3.TabIndex = 2;
			this.lblNota3.Text = "N3";
			// 
			// lblNota2
			// 
			this.lblNota2.AutoSize = true;
			this.lblNota2.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblNota2.Location = new System.Drawing.Point(61, 22);
			this.lblNota2.Name = "lblNota2";
			this.lblNota2.Size = new System.Drawing.Size(25, 20);
			this.lblNota2.TabIndex = 1;
			this.lblNota2.Text = "N2";
			// 
			// lblNota1
			// 
			this.lblNota1.AutoSize = true;
			this.lblNota1.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblNota1.Location = new System.Drawing.Point(8, 21);
			this.lblNota1.Name = "lblNota1";
			this.lblNota1.Size = new System.Drawing.Size(25, 20);
			this.lblNota1.TabIndex = 0;
			this.lblNota1.Text = "N1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblQuantidade);
			this.groupBox3.Controls.Add(this.lstResultados);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(13, 200);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(332, 256);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Listagem de Resultados";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblQuantidade.Location = new System.Drawing.Point(6, 21);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(124, 20);
			this.lblQuantidade.TabIndex = 0;
			this.lblQuantidade.Text = "Estudantes na lista:";
			// 
			// lstResultados
			// 
			this.lstResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.lstResultados.FormattingEnabled = true;
			this.lstResultados.Location = new System.Drawing.Point(6, 52);
			this.lstResultados.Name = "lstResultados";
			this.lstResultados.Size = new System.Drawing.Size(320, 199);
			this.lstResultados.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAdicionarResultado);
			this.groupBox4.Controls.Add(this.btnCalcular);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(351, 200);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(304, 100);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ações Rápidas";
			// 
			// btnAdicionarResultado
			// 
			this.btnAdicionarResultado.AutoSize = true;
			this.btnAdicionarResultado.BackColor = System.Drawing.Color.MediumBlue;
			this.btnAdicionarResultado.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAdicionarResultado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnAdicionarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionarResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnAdicionarResultado.ForeColor = System.Drawing.Color.White;
			this.btnAdicionarResultado.Location = new System.Drawing.Point(123, 39);
			this.btnAdicionarResultado.Name = "btnAdicionarResultado";
			this.btnAdicionarResultado.Size = new System.Drawing.Size(158, 32);
			this.btnAdicionarResultado.TabIndex = 1;
			this.btnAdicionarResultado.Text = "Adicionar resultado";
			this.btnAdicionarResultado.UseVisualStyleBackColor = false;
			this.btnAdicionarResultado.Click += new System.EventHandler(this.BtnAdicionarResultadoClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.AutoSize = true;
			this.btnCalcular.BackColor = System.Drawing.Color.ForestGreen;
			this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(18, 39);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(76, 32);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtResumoTurma);
			this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox5.Location = new System.Drawing.Point(351, 307);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(304, 149);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Resumo da Turma";
			// 
			// txtResumoTurma
			// 
			this.txtResumoTurma.BackColor = System.Drawing.SystemColors.Info;
			this.txtResumoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtResumoTurma.Location = new System.Drawing.Point(7, 25);
			this.txtResumoTurma.Multiline = true;
			this.txtResumoTurma.Name = "txtResumoTurma";
			this.txtResumoTurma.ReadOnly = true;
			this.txtResumoTurma.Size = new System.Drawing.Size(291, 118);
			this.txtResumoTurma.TabIndex = 0;
			// 
			// btnGerarResumo
			// 
			this.btnGerarResumo.AutoSize = true;
			this.btnGerarResumo.BackColor = System.Drawing.Color.Chocolate;
			this.btnGerarResumo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnGerarResumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnGerarResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGerarResumo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnGerarResumo.ForeColor = System.Drawing.Color.White;
			this.btnGerarResumo.Location = new System.Drawing.Point(60, 495);
			this.btnGerarResumo.Name = "btnGerarResumo";
			this.btnGerarResumo.Size = new System.Drawing.Size(121, 32);
			this.btnGerarResumo.TabIndex = 6;
			this.btnGerarResumo.Text = "Gerar resumo";
			this.btnGerarResumo.UseVisualStyleBackColor = false;
			this.btnGerarResumo.Click += new System.EventHandler(this.BtnGerarResumoClick);
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.AutoSize = true;
			this.btnLimparCampos.BackColor = System.Drawing.Color.Gray;
			this.btnLimparCampos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparCampos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnLimparCampos.ForeColor = System.Drawing.Color.White;
			this.btnLimparCampos.Location = new System.Drawing.Point(379, 495);
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Size = new System.Drawing.Size(130, 32);
			this.btnLimparCampos.TabIndex = 7;
			this.btnLimparCampos.Text = "Limpar campos";
			this.btnLimparCampos.UseVisualStyleBackColor = false;
			this.btnLimparCampos.Click += new System.EventHandler(this.BtnLimparCamposClick);
			// 
			// btnLimparLista
			// 
			this.btnLimparLista.AutoSize = true;
			this.btnLimparLista.BackColor = System.Drawing.Color.Firebrick;
			this.btnLimparLista.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLimparLista.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.btnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparLista.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnLimparLista.ForeColor = System.Drawing.Color.White;
			this.btnLimparLista.Location = new System.Drawing.Point(523, 495);
			this.btnLimparLista.Name = "btnLimparLista";
			this.btnLimparLista.Size = new System.Drawing.Size(107, 32);
			this.btnLimparLista.TabIndex = 8;
			this.btnLimparLista.Text = "Limpar lista";
			this.btnLimparLista.UseVisualStyleBackColor = false;
			this.btnLimparLista.Click += new System.EventHandler(this.BtnLimparListaClick);
			// 
			// btnRemoverSelecionado
			// 
			this.btnRemoverSelecionado.AutoSize = true;
			this.btnRemoverSelecionado.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnRemoverSelecionado.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRemoverSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverSelecionado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnRemoverSelecionado.ForeColor = System.Drawing.Color.White;
			this.btnRemoverSelecionado.Location = new System.Drawing.Point(195, 495);
			this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
			this.btnRemoverSelecionado.Size = new System.Drawing.Size(170, 32);
			this.btnRemoverSelecionado.TabIndex = 9;
			this.btnRemoverSelecionado.Text = "Remover selecionado";
			this.btnRemoverSelecionado.UseVisualStyleBackColor = false;
			this.btnRemoverSelecionado.Click += new System.EventHandler(this.BtnRemoverSelecionadoClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnCalcular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 563);
			this.Controls.Add(this.btnRemoverSelecionado);
			this.Controls.Add(this.btnLimparLista);
			this.Controls.Add(this.btnLimparCampos);
			this.Controls.Add(this.btnGerarResumo);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitulo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Boletim Escolar";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
