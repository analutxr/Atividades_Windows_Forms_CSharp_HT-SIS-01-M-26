using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade02_SistemaVendas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void BtnCalcularClick(object sender, EventArgs e)
        {
            decimal valorUnitario;
            decimal subtotal;
            decimal desconto = 0;
            decimal acrescimos = 0;
            decimal total;
            decimal percentualPagamento = 0;

            //=========================
            // VALIDAÇÕES
            //=========================

            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do cliente.");
                txtCliente.Focus();
                return;
            }

            if (txtProduto.Text.Trim() == "")
            {
                MessageBox.Show("Informe o produto.");
                txtProduto.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorUnit.Text, out valorUnitario))
            {
                MessageBox.Show("Informe um valor unitário válido.");
                txtValorUnit.Focus();
                return;
            }

            if (valorUnitario < 0)
            {
                MessageBox.Show("O valor unitário não pode ser negativo.");
                txtValorUnit.Focus();
                return;
            }

            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.");
                nudQuantidade.Focus();
                return;
            }

            if (!rdbDinheiro.Checked &&
                !rdbPix.Checked &&
                !rdbDebito.Checked &&
                !rdbCredito.Checked)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            //=========================
            // SUBTOTAL
            //=========================

            subtotal = valorUnitario * nudQuantidade.Value;

            //=========================
            // DESCONTO PAGAMENTO
            //=========================

            if (rdbDinheiro.Checked)
                percentualPagamento = 10;
            else if (rdbPix.Checked)
                percentualPagamento = 8;
            else if (rdbDebito.Checked)
                percentualPagamento = 3;
            else
                percentualPagamento = 0;

            desconto = subtotal * percentualPagamento / 100;

            //=========================
            // DESCONTO EXTRA
            //=========================

            // Aplica o desconto adicional para compras acima de R$ 1.000,00
            if (subtotal > 1000)
            {
                desconto += subtotal * 2 / 100;
            }

            //=========================
            // LIMITE DE 15%
            //=========================

            // Garante que o desconto total não ultrapasse 15% do subtotal
            if (desconto > subtotal * 0.15m)
            {
                desconto = subtotal * 0.15m;
            }

            //=========================
            // ACRÉSCIMOS
            //=========================

            if (chkEntrega.Checked)
            {
                acrescimos += 25;
            }

            if (chkGarantia.Checked)
            {
                acrescimos += subtotal * 0.05m;
            }

            //=========================
            // TOTAL
            //=========================

            total = subtotal - desconto + acrescimos;

            //=========================
            // EXIBIR RESULTADOS
            //=========================

            txtSubtotal.Text = subtotal.ToString("C2");
            txtDesconto.Text = desconto.ToString("C2");
            txtAcrescimos.Text = acrescimos.ToString("C2");
            txtTotal.Text = total.ToString("C2");

            //=========================
            // RESUMO
            //=========================

            // Define o percentual de desconto conforme a forma de pagamento
            string pagamento = "";

            if (rdbDinheiro.Checked)
                pagamento = "Dinheiro";
            else if (rdbPix.Checked)
                pagamento = "PIX";
            else if (rdbDebito.Checked)
                pagamento = "Débito";
            else
                pagamento = "Crédito";

            txtResumo.Text =
                "Cliente: " + txtCliente.Text +
                " | Produto: " + txtProduto.Text +
                " | Qtde: " + nudQuantidade.Value +
                " | Pagamento: " + pagamento +
                " | Entrega: " + (chkEntrega.Checked ? "Sim" : "Não") +
                " | Garantia: " + (chkGarantia.Checked ? "Sim" : "Não") +
                " | Total: " + total.ToString("C2");
        }

        void BtnNovaVendaClick(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProduto.Clear();
            txtValorUnit.Clear();

            nudQuantidade.Value = 1;

            chkEntrega.Checked = false;
            chkGarantia.Checked = false;

            rdbDinheiro.Checked = false;
            rdbPix.Checked = false;
            rdbDebito.Checked = false;
            rdbCredito.Checked = false;

            txtSubtotal.Clear();
            txtDesconto.Clear();
            txtAcrescimos.Clear();
            txtTotal.Clear();
            txtResumo.Clear();

            txtCliente.Focus();
        }

        void BtnSairClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}