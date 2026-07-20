/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 15/07/2026
 * Time: 08:26
 * * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade01_OrcamentoComputadores
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGabinete;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblPlacaVideo;
        private System.Windows.Forms.Label lblSSD;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label lblPlacaMae;
        private System.Windows.Forms.ComboBox cboProcessador;
        private System.Windows.Forms.ComboBox cboFonte;
        private System.Windows.Forms.ComboBox cboGabinete;
        private System.Windows.Forms.ComboBox cboPlacaVideo;
        private System.Windows.Forms.ComboBox cboSSD;
        private System.Windows.Forms.ComboBox cboRAM;
        private System.Windows.Forms.ComboBox cboPlacaMae;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.CheckBox chkHeadset;
        private System.Windows.Forms.CheckBox chkTecladoMouse;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTaxaMontagem;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTaxaMontagem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTituloAnalise;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label lblValorMontagem;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtRecomendacao;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorMontagem;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnCarregarRecomendacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSituacaoConfiguracao;

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
        /// Do not change the method contents inside the source code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lblTitulo = new System.Windows.Forms.Label();
        	this.lblCliente = new System.Windows.Forms.Label();
        	this.txtCliente = new System.Windows.Forms.TextBox();
        	this.lblPerfil = new System.Windows.Forms.Label();
        	this.cboPerfil = new System.Windows.Forms.ComboBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.cboFonte = new System.Windows.Forms.ComboBox();
        	this.cboGabinete = new System.Windows.Forms.ComboBox();
        	this.cboPlacaVideo = new System.Windows.Forms.ComboBox();
        	this.cboSSD = new System.Windows.Forms.ComboBox();
        	this.cboRAM = new System.Windows.Forms.ComboBox();
        	this.cboPlacaMae = new System.Windows.Forms.ComboBox();
        	this.lblGabinete = new System.Windows.Forms.Label();
        	this.lblFonte = new System.Windows.Forms.Label();
        	this.lblPlacaVideo = new System.Windows.Forms.Label();
        	this.lblSSD = new System.Windows.Forms.Label();
        	this.lblMemoria = new System.Windows.Forms.Label();
        	this.lblPlacaMae = new System.Windows.Forms.Label();
        	this.cboProcessador = new System.Windows.Forms.ComboBox();
        	this.lblProcessador = new System.Windows.Forms.Label();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.chkHeadset = new System.Windows.Forms.CheckBox();
        	this.chkTecladoMouse = new System.Windows.Forms.CheckBox();
        	this.chkMonitor = new System.Windows.Forms.CheckBox();
        	this.groupBox4 = new System.Windows.Forms.GroupBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.lblDesconto = new System.Windows.Forms.Label();
        	this.lblTaxaMontagem = new System.Windows.Forms.Label();
        	this.txtDesconto = new System.Windows.Forms.TextBox();
        	this.txtTaxaMontagem = new System.Windows.Forms.TextBox();
        	this.groupBox5 = new System.Windows.Forms.GroupBox();
        	this.txtSituacaoConfiguracao = new System.Windows.Forms.TextBox();
        	this.txtRecomendacao = new System.Windows.Forms.TextBox();
        	this.txtTotal = new System.Windows.Forms.TextBox();
        	this.txtValorMontagem = new System.Windows.Forms.TextBox();
        	this.txtValorDesconto = new System.Windows.Forms.TextBox();
        	this.txtSubtotal = new System.Windows.Forms.TextBox();
        	this.lblTotal = new System.Windows.Forms.Label();
        	this.lblTituloAnalise = new System.Windows.Forms.Label();
        	this.lblValorDesconto = new System.Windows.Forms.Label();
        	this.lblValorMontagem = new System.Windows.Forms.Label();
        	this.lblSubtotal = new System.Windows.Forms.Label();
        	this.btnCarregarRecomendacao = new System.Windows.Forms.Button();
        	this.btnCalcular = new System.Windows.Forms.Button();
        	this.btnLimpar = new System.Windows.Forms.Button();
        	this.btnSair = new System.Windows.Forms.Button();
        	this.groupBox2.SuspendLayout();
        	this.groupBox3.SuspendLayout();
        	this.groupBox4.SuspendLayout();
        	this.groupBox5.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lblTitulo
        	// 
        	this.lblTitulo.AutoSize = true;
        	this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
        	this.lblTitulo.Location = new System.Drawing.Point(284, 9);
        	this.lblTitulo.Name = "lblTitulo";
        	this.lblTitulo.Size = new System.Drawing.Size(475, 31);
        	this.lblTitulo.TabIndex = 0;
        	this.lblTitulo.Text = "Orçamento e Recomendação de Computadores";
        	// 
        	// lblCliente
        	// 
        	this.lblCliente.AutoSize = true;
        	this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblCliente.Location = new System.Drawing.Point(22, 53);
        	this.lblCliente.Name = "lblCliente";
        	this.lblCliente.Size = new System.Drawing.Size(114, 20);
        	this.lblCliente.TabIndex = 1;
        	this.lblCliente.Text = "Nome do Cliente:";
        	// 
        	// txtCliente
        	// 
        	this.txtCliente.Location = new System.Drawing.Point(143, 53);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(151, 20);
        	this.txtCliente.TabIndex = 2;
        	// 
        	// lblPerfil
        	// 
        	this.lblPerfil.AutoSize = true;
        	this.lblPerfil.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblPerfil.Location = new System.Drawing.Point(350, 53);
        	this.lblPerfil.Name = "lblPerfil";
        	this.lblPerfil.Size = new System.Drawing.Size(124, 20);
        	this.lblPerfil.TabIndex = 3;
        	this.lblPerfil.Text = "Perfil de Utilização:";
        	// 
        	// cboPerfil
        	// 
        	this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboPerfil.FormattingEnabled = true;
        	this.cboPerfil.Items.AddRange(new object[] {
			"Administrativo",
			"Professor de Tecnologia",
			"Desenvolvedor de Software",
			"Desenvolvedor de Jogos"});
        	this.cboPerfil.Location = new System.Drawing.Point(480, 53);
        	this.cboPerfil.Name = "cboPerfil";
        	this.cboPerfil.Size = new System.Drawing.Size(151, 21);
        	this.cboPerfil.TabIndex = 4;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.BackColor = System.Drawing.Color.Transparent;
        	this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        	this.groupBox1.Location = new System.Drawing.Point(12, 14);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(941, 78);
        	this.groupBox1.TabIndex = 5;
        	this.groupBox1.TabStop = false;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.cboFonte);
        	this.groupBox2.Controls.Add(this.cboGabinete);
        	this.groupBox2.Controls.Add(this.cboPlacaVideo);
        	this.groupBox2.Controls.Add(this.cboSSD);
        	this.groupBox2.Controls.Add(this.cboRAM);
        	this.groupBox2.Controls.Add(this.cboPlacaMae);
        	this.groupBox2.Controls.Add(this.lblGabinete);
        	this.groupBox2.Controls.Add(this.lblFonte);
        	this.groupBox2.Controls.Add(this.lblPlacaVideo);
        	this.groupBox2.Controls.Add(this.lblSSD);
        	this.groupBox2.Controls.Add(this.lblMemoria);
        	this.groupBox2.Controls.Add(this.lblPlacaMae);
        	this.groupBox2.Controls.Add(this.cboProcessador);
        	this.groupBox2.Controls.Add(this.lblProcessador);
        	this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.groupBox2.Location = new System.Drawing.Point(12, 98);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(495, 219);
        	this.groupBox2.TabIndex = 6;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Configurações de Hardware";
        	// 
        	// cboFonte
        	// 
        	this.cboFonte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboFonte.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboFonte.FormattingEnabled = true;
        	this.cboFonte.Items.AddRange(new object[] {
			"500 W",
			"650 W",
			"750 W"});
        	this.cboFonte.Location = new System.Drawing.Point(210, 154);
        	this.cboFonte.Name = "cboFonte";
        	this.cboFonte.Size = new System.Drawing.Size(130, 23);
        	this.cboFonte.TabIndex = 13;
        	// 
        	// cboGabinete
        	// 
        	this.cboGabinete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboGabinete.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboGabinete.FormattingEnabled = true;
        	this.cboGabinete.Items.AddRange(new object[] {
			"Básico",
			"Intermediário",
			"Gamer"});
        	this.cboGabinete.Location = new System.Drawing.Point(210, 179);
        	this.cboGabinete.Name = "cboGabinete";
        	this.cboGabinete.Size = new System.Drawing.Size(130, 23);
        	this.cboGabinete.TabIndex = 12;
        	// 
        	// cboPlacaVideo
        	// 
        	this.cboPlacaVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboPlacaVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboPlacaVideo.FormattingEnabled = true;
        	this.cboPlacaVideo.Items.AddRange(new object[] {
			"Vídeo integrado",
			"Dedicada básica",
			"Dedicada intermediária"});
        	this.cboPlacaVideo.Location = new System.Drawing.Point(210, 129);
        	this.cboPlacaVideo.Name = "cboPlacaVideo";
        	this.cboPlacaVideo.Size = new System.Drawing.Size(130, 23);
        	this.cboPlacaVideo.TabIndex = 11;
        	// 
        	// cboSSD
        	// 
        	this.cboSSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboSSD.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboSSD.FormattingEnabled = true;
        	this.cboSSD.Items.AddRange(new object[] {
			"240 GB",
			"500 GB",
			"1 TB"});
        	this.cboSSD.Location = new System.Drawing.Point(210, 104);
        	this.cboSSD.Name = "cboSSD";
        	this.cboSSD.Size = new System.Drawing.Size(130, 23);
        	this.cboSSD.TabIndex = 10;
        	// 
        	// cboRAM
        	// 
        	this.cboRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboRAM.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboRAM.FormattingEnabled = true;
        	this.cboRAM.Items.AddRange(new object[] {
			"8 GB",
			"16 GB",
			"32 GB"});
        	this.cboRAM.Location = new System.Drawing.Point(210, 79);
        	this.cboRAM.Name = "cboRAM";
        	this.cboRAM.Size = new System.Drawing.Size(130, 23);
        	this.cboRAM.TabIndex = 9;
        	// 
        	// cboPlacaMae
        	// 
        	this.cboPlacaMae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboPlacaMae.Font = new System.Drawing.Font("Segoe UI", 9F);
        	this.cboPlacaMae.FormattingEnabled = true;
        	this.cboPlacaMae.Items.AddRange(new object[] {
			"Básica",
			"Intermediária",
			"Avançada"});
        	this.cboPlacaMae.Location = new System.Drawing.Point(210, 54);
        	this.cboPlacaMae.Name = "cboPlacaMae";
        	this.cboPlacaMae.Size = new System.Drawing.Size(130, 23);
        	this.cboPlacaMae.TabIndex = 8;
        	// 
        	// lblGabinete
        	// 
        	this.lblGabinete.AutoSize = true;
        	this.lblGabinete.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblGabinete.Location = new System.Drawing.Point(10, 179);
        	this.lblGabinete.Name = "lblGabinete";
        	this.lblGabinete.Size = new System.Drawing.Size(67, 20);
        	this.lblGabinete.TabIndex = 7;
        	this.lblGabinete.Text = "Gabinete:";
        	// 
        	// lblFonte
        	// 
        	this.lblFonte.AutoSize = true;
        	this.lblFonte.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblFonte.Location = new System.Drawing.Point(10, 154);
        	this.lblFonte.Name = "lblFonte";
        	this.lblFonte.Size = new System.Drawing.Size(47, 20);
        	this.lblFonte.TabIndex = 6;
        	this.lblFonte.Text = "Fonte:";
        	// 
        	// lblPlacaVideo
        	// 
        	this.lblPlacaVideo.AutoSize = true;
        	this.lblPlacaVideo.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblPlacaVideo.Location = new System.Drawing.Point(10, 129);
        	this.lblPlacaVideo.Name = "lblPlacaVideo";
        	this.lblPlacaVideo.Size = new System.Drawing.Size(104, 20);
        	this.lblPlacaVideo.TabIndex = 5;
        	this.lblPlacaVideo.Text = "Placa de vídeo:";
        	// 
        	// lblSSD
        	// 
        	this.lblSSD.AutoSize = true;
        	this.lblSSD.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblSSD.Location = new System.Drawing.Point(10, 104);
        	this.lblSSD.Name = "lblSSD";
        	this.lblSSD.Size = new System.Drawing.Size(40, 20);
        	this.lblSSD.TabIndex = 4;
        	this.lblSSD.Text = "SSD:";
        	// 
        	// lblMemoria
        	// 
        	this.lblMemoria.AutoSize = true;
        	this.lblMemoria.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblMemoria.Location = new System.Drawing.Point(10, 79);
        	this.lblMemoria.Name = "lblMemoria";
        	this.lblMemoria.Size = new System.Drawing.Size(98, 20);
        	this.lblMemoria.TabIndex = 3;
        	this.lblMemoria.Text = "Memória RAM:";
        	// 
        	// lblPlacaMae
        	// 
        	this.lblPlacaMae.AutoSize = true;
        	this.lblPlacaMae.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblPlacaMae.Location = new System.Drawing.Point(10, 54);
        	this.lblPlacaMae.Name = "lblPlacaMae";
        	this.lblPlacaMae.Size = new System.Drawing.Size(76, 20);
        	this.lblPlacaMae.TabIndex = 2;
        	this.lblPlacaMae.Text = "Placa-mãe:";
        	// 
        	// cboProcessador
        	// 
        	this.cboProcessador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboProcessador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cboProcessador.FormattingEnabled = true;
        	this.cboProcessador.Items.AddRange(new object[] {
			"Básico",
			"Intermediário",
			"Avançado",
			"Alto desempenho"});
        	this.cboProcessador.Location = new System.Drawing.Point(210, 29);
        	this.cboProcessador.Name = "cboProcessador";
        	this.cboProcessador.Size = new System.Drawing.Size(130, 23);
        	this.cboProcessador.TabIndex = 1;
        	// 
        	// lblProcessador
        	// 
        	this.lblProcessador.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblProcessador.Location = new System.Drawing.Point(10, 29);
        	this.lblProcessador.Name = "lblProcessador";
        	this.lblProcessador.Size = new System.Drawing.Size(100, 23);
        	this.lblProcessador.TabIndex = 0;
        	this.lblProcessador.Text = "Processador:";
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Controls.Add(this.chkHeadset);
        	this.groupBox3.Controls.Add(this.chkTecladoMouse);
        	this.groupBox3.Controls.Add(this.chkMonitor);
        	this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
        	this.groupBox3.Location = new System.Drawing.Point(531, 98);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(422, 127);
        	this.groupBox3.TabIndex = 7;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "Itens Opcionais";
        	// 
        	// chkHeadset
        	// 
        	this.chkHeadset.AutoSize = true;
        	this.chkHeadset.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.chkHeadset.Location = new System.Drawing.Point(6, 84);
        	this.chkHeadset.Name = "chkHeadset";
        	this.chkHeadset.Size = new System.Drawing.Size(149, 24);
        	this.chkHeadset.TabIndex = 2;
        	this.chkHeadset.Text = "Headset (R$ 180,00)";
        	this.chkHeadset.UseVisualStyleBackColor = true;
        	// 
        	// chkTecladoMouse
        	// 
        	this.chkTecladoMouse.AutoSize = true;
        	this.chkTecladoMouse.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.chkTecladoMouse.Location = new System.Drawing.Point(6, 54);
        	this.chkTecladoMouse.Name = "chkTecladoMouse";
        	this.chkTecladoMouse.Size = new System.Drawing.Size(219, 24);
        	this.chkTecladoMouse.TabIndex = 1;
        	this.chkTecladoMouse.Text = "Kit teclado e mouse (R$ 120,00)";
        	this.chkTecladoMouse.UseVisualStyleBackColor = true;
        	// 
        	// chkMonitor
        	// 
        	this.chkMonitor.AutoSize = true;
        	this.chkMonitor.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.chkMonitor.Location = new System.Drawing.Point(6, 24);
        	this.chkMonitor.Name = "chkMonitor";
        	this.chkMonitor.Size = new System.Drawing.Size(167, 24);
        	this.chkMonitor.TabIndex = 0;
        	this.chkMonitor.Text = "Monitor 24\'\' (R$ 700,00)";
        	this.chkMonitor.UseVisualStyleBackColor = true;
        	// 
        	// groupBox4
        	// 
        	this.groupBox4.Controls.Add(this.label2);
        	this.groupBox4.Controls.Add(this.label1);
        	this.groupBox4.Controls.Add(this.lblDesconto);
        	this.groupBox4.Controls.Add(this.lblTaxaMontagem);
        	this.groupBox4.Controls.Add(this.txtDesconto);
        	this.groupBox4.Controls.Add(this.txtTaxaMontagem);
        	this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
        	this.groupBox4.Location = new System.Drawing.Point(531, 230);
        	this.groupBox4.Name = "groupBox4";
        	this.groupBox4.Size = new System.Drawing.Size(422, 87);
        	this.groupBox4.TabIndex = 8;
        	this.groupBox4.TabStop = false;
        	this.groupBox4.Text = "Taxas e Descontos";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.label2.Location = new System.Drawing.Point(246, 52);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(100, 23);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "%";
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.label1.Location = new System.Drawing.Point(246, 24);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 23);
        	this.label1.TabIndex = 4;
        	this.label1.Text = "%";
        	// 
        	// lblDesconto
        	// 
        	this.lblDesconto.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblDesconto.Location = new System.Drawing.Point(7, 50);
        	this.lblDesconto.Name = "lblDesconto";
        	this.lblDesconto.Size = new System.Drawing.Size(100, 23);
        	this.lblDesconto.TabIndex = 3;
        	this.lblDesconto.Text = "Desconto:";
        	// 
        	// lblTaxaMontagem
        	// 
        	this.lblTaxaMontagem.AutoSize = true;
        	this.lblTaxaMontagem.Font = new System.Drawing.Font("Arial Narrow", 12F);
        	this.lblTaxaMontagem.Location = new System.Drawing.Point(6, 24);
        	this.lblTaxaMontagem.Name = "lblTaxaMontagem";
        	this.lblTaxaMontagem.Size = new System.Drawing.Size(128, 20);
        	this.lblTaxaMontagem.TabIndex = 2;
        	this.lblTaxaMontagem.Text = "Taxa de montagem:";
        	// 
        	// txtDesconto
        	// 
        	this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtDesconto.Location = new System.Drawing.Point(140, 52);
        	this.txtDesconto.Name = "txtDesconto";
        	this.txtDesconto.Size = new System.Drawing.Size(100, 20);
        	this.txtDesconto.TabIndex = 1;
        	// 
        	// txtTaxaMontagem
        	// 
        	this.txtTaxaMontagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtTaxaMontagem.Location = new System.Drawing.Point(140, 24);
        	this.txtTaxaMontagem.Name = "txtTaxaMontagem";
        	this.txtTaxaMontagem.Size = new System.Drawing.Size(100, 20);
        	this.txtTaxaMontagem.TabIndex = 0;
        	// 
        	// groupBox5
        	// 
        	this.groupBox5.Controls.Add(this.txtSituacaoConfiguracao);
        	this.groupBox5.Controls.Add(this.txtRecomendacao);
        	this.groupBox5.Controls.Add(this.txtTotal);
        	this.groupBox5.Controls.Add(this.txtValorMontagem);
        	this.groupBox5.Controls.Add(this.txtValorDesconto);
        	this.groupBox5.Controls.Add(this.txtSubtotal);
        	this.groupBox5.Controls.Add(this.lblTotal);
        	this.groupBox5.Controls.Add(this.lblTituloAnalise);
        	this.groupBox5.Controls.Add(this.lblValorDesconto);
        	this.groupBox5.Controls.Add(this.lblValorMontagem);
        	this.groupBox5.Controls.Add(this.lblSubtotal);
        	this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
        	this.groupBox5.Location = new System.Drawing.Point(12, 326);
        	this.groupBox5.Name = "groupBox5";
        	this.groupBox5.Size = new System.Drawing.Size(941, 238);
        	this.groupBox5.TabIndex = 9;
        	this.groupBox5.TabStop = false;
        	this.groupBox5.Text = "Resultados e Análise";
        	// 
        	// txtSituacaoConfiguracao
        	// 
        	this.txtSituacaoConfiguracao.BackColor = System.Drawing.Color.LightGreen;
        	this.txtSituacaoConfiguracao.Location = new System.Drawing.Point(10, 125);
        	this.txtSituacaoConfiguracao.Name = "txtSituacaoConfiguracao";
        	this.txtSituacaoConfiguracao.ReadOnly = true;
        	this.txtSituacaoConfiguracao.Size = new System.Drawing.Size(855, 25);
        	this.txtSituacaoConfiguracao.TabIndex = 11;
        	// 
        	// txtRecomendacao
        	// 
        	this.txtRecomendacao.BackColor = System.Drawing.SystemColors.Info;
        	this.txtRecomendacao.Location = new System.Drawing.Point(10, 165);
        	this.txtRecomendacao.Multiline = true;
        	this.txtRecomendacao.Name = "txtRecomendacao";
        	this.txtRecomendacao.ReadOnly = true;
        	this.txtRecomendacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.txtRecomendacao.Size = new System.Drawing.Size(855, 58);
        	this.txtRecomendacao.TabIndex = 10;
        	// 
        	// txtTotal
        	// 
        	this.txtTotal.BackColor = System.Drawing.Color.PeachPuff;
        	this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtTotal.ForeColor = System.Drawing.Color.SaddleBrown;
        	this.txtTotal.Location = new System.Drawing.Point(553, 61);
        	this.txtTotal.Name = "txtTotal";
        	this.txtTotal.Size = new System.Drawing.Size(162, 20);
        	this.txtTotal.TabIndex = 8;
        	// 
        	// txtValorMontagem
        	// 
        	this.txtValorMontagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtValorMontagem.Location = new System.Drawing.Point(553, 24);
        	this.txtValorMontagem.Name = "txtValorMontagem";
        	this.txtValorMontagem.Size = new System.Drawing.Size(162, 20);
        	this.txtValorMontagem.TabIndex = 7;
        	// 
        	// txtValorDesconto
        	// 
        	this.txtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtValorDesconto.Location = new System.Drawing.Point(156, 61);
        	this.txtValorDesconto.Name = "txtValorDesconto";
        	this.txtValorDesconto.Size = new System.Drawing.Size(162, 20);
        	this.txtValorDesconto.TabIndex = 6;
        	// 
        	// txtSubtotal
        	// 
        	this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.txtSubtotal.Location = new System.Drawing.Point(156, 24);
        	this.txtSubtotal.Name = "txtSubtotal";
        	this.txtSubtotal.Size = new System.Drawing.Size(162, 20);
        	this.txtSubtotal.TabIndex = 5;
        	// 
        	// lblTotal
        	// 
        	this.lblTotal.AutoSize = true;
        	this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTotal.Location = new System.Drawing.Point(394, 61);
        	this.lblTotal.Name = "lblTotal";
        	this.lblTotal.Size = new System.Drawing.Size(68, 20);
        	this.lblTotal.TabIndex = 4;
        	this.lblTotal.Text = "Total final:";
        	// 
        	// lblTituloAnalise
        	// 
        	this.lblTituloAnalise.AutoSize = true;
        	this.lblTituloAnalise.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTituloAnalise.Location = new System.Drawing.Point(10, 102);
        	this.lblTituloAnalise.Name = "lblTituloAnalise";
        	this.lblTituloAnalise.Size = new System.Drawing.Size(178, 20);
        	this.lblTituloAnalise.TabIndex = 3;
        	this.lblTituloAnalise.Text = "Análise de Compatibilidade:";
        	// 
        	// lblValorDesconto
        	// 
        	this.lblValorDesconto.AutoSize = true;
        	this.lblValorDesconto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblValorDesconto.Location = new System.Drawing.Point(10, 61);
        	this.lblValorDesconto.Name = "lblValorDesconto";
        	this.lblValorDesconto.Size = new System.Drawing.Size(124, 20);
        	this.lblValorDesconto.TabIndex = 2;
        	this.lblValorDesconto.Text = "Valor do desconto:";
        	// 
        	// lblValorMontagem
        	// 
        	this.lblValorMontagem.AutoSize = true;
        	this.lblValorMontagem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblValorMontagem.Location = new System.Drawing.Point(394, 24);
        	this.lblValorMontagem.Name = "lblValorMontagem";
        	this.lblValorMontagem.Size = new System.Drawing.Size(131, 20);
        	this.lblValorMontagem.TabIndex = 1;
        	this.lblValorMontagem.Text = "Valor de montagem:";
        	// 
        	// lblSubtotal
        	// 
        	this.lblSubtotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblSubtotal.Location = new System.Drawing.Point(10, 24);
        	this.lblSubtotal.Name = "lblSubtotal";
        	this.lblSubtotal.Size = new System.Drawing.Size(100, 23);
        	this.lblSubtotal.TabIndex = 0;
        	this.lblSubtotal.Text = "Subtotal:";
        	// 
        	// btnCarregarRecomendacao
        	// 
        	this.btnCarregarRecomendacao.AutoSize = true;
        	this.btnCarregarRecomendacao.BackColor = System.Drawing.Color.ForestGreen;
        	this.btnCarregarRecomendacao.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnCarregarRecomendacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        	this.btnCarregarRecomendacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnCarregarRecomendacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnCarregarRecomendacao.ForeColor = System.Drawing.Color.White;
        	this.btnCarregarRecomendacao.Location = new System.Drawing.Point(168, 586);
        	this.btnCarregarRecomendacao.Name = "btnCarregarRecomendacao";
        	this.btnCarregarRecomendacao.Size = new System.Drawing.Size(120, 35);
        	this.btnCarregarRecomendacao.TabIndex = 10;
        	this.btnCarregarRecomendacao.Text = "Recomendar";
        	this.btnCarregarRecomendacao.UseVisualStyleBackColor = false;
        	this.btnCarregarRecomendacao.Click += new System.EventHandler(this.BtnCarregarRecomendacaoClick);
        	// 
        	// btnCalcular
        	// 
        	this.btnCalcular.AutoSize = true;
        	this.btnCalcular.BackColor = System.Drawing.Color.DeepSkyBlue;
        	this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        	this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnCalcular.ForeColor = System.Drawing.Color.White;
        	this.btnCalcular.Location = new System.Drawing.Point(344, 586);
        	this.btnCalcular.Name = "btnCalcular";
        	this.btnCalcular.Size = new System.Drawing.Size(120, 35);
        	this.btnCalcular.TabIndex = 11;
        	this.btnCalcular.Text = "Calcular";
        	this.btnCalcular.UseVisualStyleBackColor = false;
        	this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
        	// 
        	// btnLimpar
        	// 
        	this.btnLimpar.AutoSize = true;
        	this.btnLimpar.BackColor = System.Drawing.Color.SlateGray;
        	this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLimpar.ForeColor = System.Drawing.Color.White;
        	this.btnLimpar.Location = new System.Drawing.Point(520, 586);
        	this.btnLimpar.Name = "btnLimpar";
        	this.btnLimpar.Size = new System.Drawing.Size(120, 35);
        	this.btnLimpar.TabIndex = 12;
        	this.btnLimpar.Text = "Limpar";
        	this.btnLimpar.UseVisualStyleBackColor = false;
        	this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
        	// 
        	// btnSair
        	// 
        	this.btnSair.AutoSize = true;
        	this.btnSair.BackColor = System.Drawing.Color.Firebrick;
        	this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
        	this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnSair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnSair.ForeColor = System.Drawing.Color.White;
        	this.btnSair.Location = new System.Drawing.Point(696, 586);
        	this.btnSair.Name = "btnSair";
        	this.btnSair.Size = new System.Drawing.Size(120, 35);
        	this.btnSair.TabIndex = 13;
        	this.btnSair.Text = "Sair";
        	this.btnSair.UseVisualStyleBackColor = false;
        	this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.btnCalcular;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.btnSair;
        	this.ClientSize = new System.Drawing.Size(987, 637);
        	this.Controls.Add(this.btnSair);
        	this.Controls.Add(this.btnLimpar);
        	this.Controls.Add(this.btnCalcular);
        	this.Controls.Add(this.btnCarregarRecomendacao);
        	this.Controls.Add(this.groupBox5);
        	this.Controls.Add(this.groupBox4);
        	this.Controls.Add(this.groupBox3);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.cboPerfil);
        	this.Controls.Add(this.lblPerfil);
        	this.Controls.Add(this.txtCliente);
        	this.Controls.Add(this.lblCliente);
        	this.Controls.Add(this.lblTitulo);
        	this.Controls.Add(this.groupBox1);
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Orçamento de Computadores";
        	this.Load += new System.EventHandler(this.MainFormLoad);
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