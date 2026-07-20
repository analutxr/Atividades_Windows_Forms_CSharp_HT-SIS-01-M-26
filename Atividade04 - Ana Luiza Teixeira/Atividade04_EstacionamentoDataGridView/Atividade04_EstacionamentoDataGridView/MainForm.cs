using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade04_EstacionamentoDataGridView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Define os horários iniciais de entrada e saída assim que a tela abre
        void MainFormLoad(object sender, EventArgs e)
        {
            dtpEntrada.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;
        }

        // Limpa os campos de texto e reseta o combobox após inserir um veículo
        private void LimparCampos()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            cboTipo.SelectedIndex = -1; 
            dtpEntrada.Value = DateTime.Now;
            txtPlaca.Focus(); // Devolve o foco para o primeiro campo
        }

        // Varre a tabela para atualizar as contagens e o valor total arrecadado
        private void AtualizarIndicadores()
        {
            int estacionados = 0;
            int finalizados = 0;
            decimal totalRecebido = 0;

            foreach (DataGridViewRow linha in dgvVeiculos.Rows)
            {
                string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
                
                if (situacao == "Estacionado")
                {
                    estacionados++;
                }
                else if (situacao == "Finalizado")
                {
                    finalizados++;
                    totalRecebido += Convert.ToDecimal(linha.Cells["colValor"].Value);
                }
            }

            // Atualiza os componentes de texto com os totais calculados
            lblEstacionados.Text = estacionados.ToString();
            lblFinalizados.Text = finalizados.ToString();
            lblTotalRecebido.Text = totalRecebido.ToString("C2"); // Formatação em R$
        }

        // Valida se todos os campos obrigatórios foram preenchidos antes de dar entrada
        private bool ValidarEntrada()
        {
            if (txtPlaca.Text.Trim() == "")
            {
                MessageBox.Show("Informe a placa do veículo.");
                txtPlaca.Focus();
                return false;
            }
            if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Informe o modelo do veículo.");
                txtModelo.Focus();
                return false;
            }
            if (cboTipo.SelectedIndex == -1) 
            {
                MessageBox.Show("Selecione o tipo do veículo.");
                return false;
            }
            return true;
        }

        // Verifica se a placa informada já possui uma entrada aberta (Situação = "Estacionado")
        private bool PlacaJaEstacionada(string placa)
        {
            foreach (DataGridViewRow linha in dgvVeiculos.Rows)
            {
                string placaTabela = Convert.ToString(linha.Cells["colPlaca"].Value);
                string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
                if (placaTabela.Equals(placa, StringComparison.OrdinalIgnoreCase)
                    && situacao == "Estacionado")
                {
                    return true;
                }
            }
            return false;
        }

        // Recupera a linha que está selecionada na tabela para aplicar as ações de Saída ou Remoção
        private DataGridViewRow ObterLinhaSelecionada()
        {
            if (dgvVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha na tabela.");
                return null;
            }
            return dgvVeiculos.SelectedRows[0];
        }

        // Retorna o valor cobrado por hora com base no tipo do veículo selecionado
        private decimal ObterValorHora(string tipo)
        {
            if (tipo == "Moto") return 4m;
            else if (tipo == "Carro") return 7m;
            else return 10m;
        }

        // Calcula o tempo de permanência arredondando as horas para cima
        private int CalcularHoras(DateTime entrada, DateTime saida)
        {
            TimeSpan permanencia = saida - entrada;
            return (int)Math.Ceiling(permanencia.TotalHours);
        }

        // Evento de clique para adicionar um veículo no DataGridView
        void BtnRegistrarEntradaClick(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
                return;

            string placa = txtPlaca.Text.Trim().ToUpper();
            if (PlacaJaEstacionada(placa))
            {
                MessageBox.Show("Esta placa já possui uma entrada em aberto.");
                return;
            }

            // Adiciona a nova linha com os dados iniciais do veículo
            dgvVeiculos.Rows.Add(
                placa,
                txtModelo.Text.Trim(),
                cboTipo.Text, 
                dtpEntrada.Value,
                null,
                0,
                0m,
                "Estacionado"
            );

            AtualizarIndicadores();
            LimparCampos();
        }

        // Evento de clique para processar a saída e calcular o valor cobrado
        void BtnRegistrarSaidaClick(object sender, EventArgs e)
        {
            DataGridViewRow linha = ObterLinhaSelecionada();
            if (linha == null)
                return;

            string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
            if (situacao == "Finalizado")
            {
                MessageBox.Show("A saída deste veículo já foi registrada.");
                return;
            }

            DateTime entrada = Convert.ToDateTime(linha.Cells["colEntrada"].Value);
            DateTime saida = dtpSaida.Value;
            if (saida < entrada)
            {
                MessageBox.Show("A saída não pode ser anterior à entrada.");
                return;
            }

            string tipo = Convert.ToString(linha.Cells["colTipo"].Value);
            int horas = CalcularHoras(entrada, saida);
            decimal valor = horas * ObterValorHora(tipo);

            // Atualiza as células da linha correspondente com os dados de fechamento
            linha.Cells["colSaida"].Value = saida;
            linha.Cells["colHoras"].Value = horas;
            linha.Cells["colValor"].Value = valor;
            linha.Cells["colSituacao"].Value = "Finalizado";

            AtualizarIndicadores();
        }

        // Filtra a exibição da tabela ocultando as linhas que não dão match com o termo buscado
        void BtnPesquisarClick(object sender, EventArgs e)
        {
            string pesquisa = txtPlacaPesquisa.Text.Trim().ToUpper(); 
            dgvVeiculos.ClearSelection();
            foreach (DataGridViewRow linha in dgvVeiculos.Rows)
            {
                string placa = Convert.ToString(linha.Cells["colPlaca"].Value);
                linha.Visible = pesquisa == "" || placa.Contains(pesquisa);
            }
        }

        // Exibe uma caixa de diálogo para confirmar a remoção da linha selecionada
        void BtnRemoverRegistroClick(object sender, EventArgs e)
        {
            DataGridViewRow linha = ObterLinhaSelecionada();
            if (linha == null)
                return;

            DialogResult resposta = MessageBox.Show(
                "Deseja remover o registro selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                dgvVeiculos.Rows.Remove(linha);
                AtualizarIndicadores();
            }
        }

        // Reseta os campos de entrada e a busca rápida simultaneamente
        void BtnLimparTudoClick(object sender, EventArgs e)
        {
            txtPlacaPesquisa.Clear(); 
            LimparCampos();
            dtpSaida.Value = DateTime.Now;
        }

        // Altera a cor de fundo da célula de situação dinamicamente (amarelo para aberto, verde para finalizado)
        private void DgvVeiculosCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVeiculos.Columns[e.ColumnIndex].Name == "colSituacao" && e.Value != null)
            {
                if (e.Value.ToString() == "Estacionado")
                    e.CellStyle.BackColor = Color.LightYellow;
                else
                    e.CellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}