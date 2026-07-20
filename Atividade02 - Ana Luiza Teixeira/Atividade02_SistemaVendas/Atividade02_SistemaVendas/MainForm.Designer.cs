/*
 * Created by SharpDevelop.
 * User: User
 * Date: 16/07/2026
 * Time: 16:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade02_SistemaVendas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.TextBox txtValorUnit;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.Label lblValorUnit;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkGarantia;
		private System.Windows.Forms.CheckBox chkEntrega;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdbCredito;
		private System.Windows.Forms.RadioButton rdbDebito;
		private System.Windows.Forms.RadioButton rdbPix;
		private System.Windows.Forms.RadioButton rdbDinheiro;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblAcrescimos;
		private System.Windows.Forms.Label lblDesconto;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.TextBox txtDesconto;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtAcrescimos;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtResumo;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnNovaVenda;
		private System.Windows.Forms.Button btnSair;
		
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
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.txtValorUnit = new System.Windows.Forms.TextBox();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblValorUnit = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkGarantia = new System.Windows.Forms.CheckBox();
			this.chkEntrega = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdbCredito = new System.Windows.Forms.RadioButton();
			this.rdbDebito = new System.Windows.Forms.RadioButton();
			this.rdbPix = new System.Windows.Forms.RadioButton();
			this.rdbDinheiro = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtDesconto = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtAcrescimos = new System.Windows.Forms.TextBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblAcrescimos = new System.Windows.Forms.Label();
			this.lblDesconto = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtResumo = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnNovaVenda = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.nudQuantidade);
			this.groupBox1.Controls.Add(this.txtValorUnit);
			this.groupBox1.Controls.Add(this.txtProduto);
			this.groupBox1.Controls.Add(this.txtCliente);
			this.groupBox1.Controls.Add(this.lblQuantidade);
			this.groupBox1.Controls.Add(this.lblValorUnit);
			this.groupBox1.Controls.Add(this.lblProduto);
			this.groupBox1.Controls.Add(this.lblCliente);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 151);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informações da Venda";
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudQuantidade.Location = new System.Drawing.Point(142, 100);
			this.nudQuantidade.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(98, 20);
			this.nudQuantidade.TabIndex = 7;
			this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudQuantidade.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// txtValorUnit
			// 
			this.txtValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtValorUnit.Location = new System.Drawing.Point(142, 75);
			this.txtValorUnit.Name = "txtValorUnit";
			this.txtValorUnit.Size = new System.Drawing.Size(201, 20);
			this.txtValorUnit.TabIndex = 6;
			// 
			// txtProduto
			// 
			this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtProduto.Location = new System.Drawing.Point(142, 50);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(201, 20);
			this.txtProduto.TabIndex = 5;
			// 
			// txtCliente
			// 
			this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtCliente.Location = new System.Drawing.Point(142, 25);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(201, 20);
			this.txtCliente.TabIndex = 4;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblQuantidade.Location = new System.Drawing.Point(7, 100);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(81, 20);
			this.lblQuantidade.TabIndex = 3;
			this.lblQuantidade.Text = "Quantidade:";
			// 
			// lblValorUnit
			// 
			this.lblValorUnit.AutoSize = true;
			this.lblValorUnit.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblValorUnit.Location = new System.Drawing.Point(7, 75);
			this.lblValorUnit.Name = "lblValorUnit";
			this.lblValorUnit.Size = new System.Drawing.Size(92, 20);
			this.lblValorUnit.TabIndex = 2;
			this.lblValorUnit.Text = "Valor Unitário:";
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblProduto.Location = new System.Drawing.Point(7, 50);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(60, 20);
			this.lblProduto.TabIndex = 1;
			this.lblProduto.Text = "Produto:";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblCliente.Location = new System.Drawing.Point(7, 25);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(112, 20);
			this.lblCliente.TabIndex = 0;
			this.lblCliente.Text = "Nome do cliente:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20F);
			this.lblTitulo.Location = new System.Drawing.Point(199, 21);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(330, 31);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Sistema de Vendas e Descontos";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.chkGarantia);
			this.groupBox2.Controls.Add(this.chkEntrega);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(419, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(258, 127);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Serviços Opcionais";
			// 
			// chkGarantia
			// 
			this.chkGarantia.AutoSize = true;
			this.chkGarantia.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.chkGarantia.Location = new System.Drawing.Point(7, 50);
			this.chkGarantia.Name = "chkGarantia";
			this.chkGarantia.Size = new System.Drawing.Size(220, 24);
			this.chkGarantia.TabIndex = 1;
			this.chkGarantia.Text = "Garantia estendida - 5% subtotal";
			this.chkGarantia.UseVisualStyleBackColor = true;
			// 
			// chkEntrega
			// 
			this.chkEntrega.AutoSize = true;
			this.chkEntrega.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.chkEntrega.Location = new System.Drawing.Point(7, 25);
			this.chkEntrega.Name = "chkEntrega";
			this.chkEntrega.Size = new System.Drawing.Size(138, 24);
			this.chkEntrega.TabIndex = 0;
			this.chkEntrega.Text = "Entrega - R$ 25,00";
			this.chkEntrega.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.rdbCredito);
			this.groupBox3.Controls.Add(this.rdbDebito);
			this.groupBox3.Controls.Add(this.rdbPix);
			this.groupBox3.Controls.Add(this.rdbDinheiro);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(12, 227);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(371, 138);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Forma de Pagamento";
			// 
			// rdbCredito
			// 
			this.rdbCredito.AutoSize = true;
			this.rdbCredito.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.rdbCredito.Location = new System.Drawing.Point(7, 102);
			this.rdbCredito.Name = "rdbCredito";
			this.rdbCredito.Size = new System.Drawing.Size(130, 24);
			this.rdbCredito.TabIndex = 3;
			this.rdbCredito.Text = "Cartão de crédito";
			this.rdbCredito.UseVisualStyleBackColor = true;
			// 
			// rdbDebito
			// 
			this.rdbDebito.AutoSize = true;
			this.rdbDebito.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.rdbDebito.Location = new System.Drawing.Point(7, 77);
			this.rdbDebito.Name = "rdbDebito";
			this.rdbDebito.Size = new System.Drawing.Size(188, 24);
			this.rdbDebito.TabIndex = 2;
			this.rdbDebito.Text = "Cartão de débito - 3% OFF";
			this.rdbDebito.UseVisualStyleBackColor = true;
			// 
			// rdbPix
			// 
			this.rdbPix.AutoSize = true;
			this.rdbPix.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.rdbPix.Location = new System.Drawing.Point(7, 52);
			this.rdbPix.Name = "rdbPix";
			this.rdbPix.Size = new System.Drawing.Size(108, 24);
			this.rdbPix.TabIndex = 1;
			this.rdbPix.Text = "PIX - 8% OFF";
			this.rdbPix.UseVisualStyleBackColor = true;
			// 
			// rdbDinheiro
			// 
			this.rdbDinheiro.AutoSize = true;
			this.rdbDinheiro.Checked = true;
			this.rdbDinheiro.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.rdbDinheiro.Location = new System.Drawing.Point(7, 27);
			this.rdbDinheiro.Name = "rdbDinheiro";
			this.rdbDinheiro.Size = new System.Drawing.Size(144, 24);
			this.rdbDinheiro.TabIndex = 0;
			this.rdbDinheiro.TabStop = true;
			this.rdbDinheiro.Text = "Dinheiro - 10% OFF";
			this.rdbDinheiro.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.txtDesconto);
			this.groupBox4.Controls.Add(this.txtTotal);
			this.groupBox4.Controls.Add(this.txtAcrescimos);
			this.groupBox4.Controls.Add(this.txtSubtotal);
			this.groupBox4.Controls.Add(this.lblTotal);
			this.groupBox4.Controls.Add(this.lblAcrescimos);
			this.groupBox4.Controls.Add(this.lblDesconto);
			this.groupBox4.Controls.Add(this.lblSubtotal);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(419, 203);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(258, 162);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Resumo Financeiro";
			// 
			// txtDesconto
			// 
			this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtDesconto.Location = new System.Drawing.Point(106, 50);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.ReadOnly = true;
			this.txtDesconto.Size = new System.Drawing.Size(134, 20);
			this.txtDesconto.TabIndex = 7;
			// 
			// txtTotal
			// 
			this.txtTotal.BackColor = System.Drawing.Color.DarkSalmon;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtTotal.ForeColor = System.Drawing.Color.SaddleBrown;
			this.txtTotal.Location = new System.Drawing.Point(106, 100);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(134, 20);
			this.txtTotal.TabIndex = 6;
			// 
			// txtAcrescimos
			// 
			this.txtAcrescimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtAcrescimos.Location = new System.Drawing.Point(106, 75);
			this.txtAcrescimos.Name = "txtAcrescimos";
			this.txtAcrescimos.ReadOnly = true;
			this.txtAcrescimos.Size = new System.Drawing.Size(134, 20);
			this.txtAcrescimos.TabIndex = 5;
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtSubtotal.Location = new System.Drawing.Point(106, 25);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(134, 20);
			this.txtSubtotal.TabIndex = 4;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblTotal.Location = new System.Drawing.Point(7, 100);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(68, 20);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "Total final:";
			// 
			// lblAcrescimos
			// 
			this.lblAcrescimos.AutoSize = true;
			this.lblAcrescimos.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblAcrescimos.Location = new System.Drawing.Point(7, 75);
			this.lblAcrescimos.Name = "lblAcrescimos";
			this.lblAcrescimos.Size = new System.Drawing.Size(84, 20);
			this.lblAcrescimos.TabIndex = 2;
			this.lblAcrescimos.Text = "Acréscimos:";
			// 
			// lblDesconto
			// 
			this.lblDesconto.AutoSize = true;
			this.lblDesconto.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblDesconto.Location = new System.Drawing.Point(7, 50);
			this.lblDesconto.Name = "lblDesconto";
			this.lblDesconto.Size = new System.Drawing.Size(70, 20);
			this.lblDesconto.TabIndex = 1;
			this.lblDesconto.Text = "Desconto:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblSubtotal.Location = new System.Drawing.Point(7, 25);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(61, 20);
			this.lblSubtotal.TabIndex = 0;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtResumo);
			this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox5.Location = new System.Drawing.Point(12, 372);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(665, 100);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Resumo completo da venda";
			// 
			// txtResumo
			// 
			this.txtResumo.BackColor = System.Drawing.SystemColors.Info;
			this.txtResumo.Location = new System.Drawing.Point(7, 25);
			this.txtResumo.Multiline = true;
			this.txtResumo.Name = "txtResumo";
			this.txtResumo.ReadOnly = true;
			this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResumo.Size = new System.Drawing.Size(652, 69);
			this.txtResumo.TabIndex = 0;
			// 
			// btnCalcular
			// 
			this.btnCalcular.AutoSize = true;
			this.btnCalcular.BackColor = System.Drawing.Color.ForestGreen;
			this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(131, 502);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(76, 32);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnNovaVenda
			// 
			this.btnNovaVenda.AutoSize = true;
			this.btnNovaVenda.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNovaVenda.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
			this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovaVenda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnNovaVenda.ForeColor = System.Drawing.Color.White;
			this.btnNovaVenda.Location = new System.Drawing.Point(313, 502);
			this.btnNovaVenda.Name = "btnNovaVenda";
			this.btnNovaVenda.Size = new System.Drawing.Size(105, 32);
			this.btnNovaVenda.TabIndex = 7;
			this.btnNovaVenda.Text = "Nova Venda";
			this.btnNovaVenda.UseVisualStyleBackColor = false;
			this.btnNovaVenda.Click += new System.EventHandler(this.BtnNovaVendaClick);
			// 
			// btnSair
			// 
			this.btnSair.AutoSize = true;
			this.btnSair.BackColor = System.Drawing.Color.Firebrick;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(524, 502);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 32);
			this.btnSair.TabIndex = 8;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnCalcular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(746, 594);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnNovaVenda);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Vendas e Descontos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
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
