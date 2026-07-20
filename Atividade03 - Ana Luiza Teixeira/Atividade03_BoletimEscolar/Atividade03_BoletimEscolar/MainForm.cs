using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade03_BoletimEscolar
{
    public partial class MainForm : Form
    {
        // Variável para verificar se o cálculo já foi realizado
        bool calculado = false;

        public MainForm()
        {
            InitializeComponent();
        }

        void BtnCalcularClick(object sender, EventArgs e)
        {
            // Declaração das variáveis
            double nota1, nota2, nota3, nota4;
            double media;
            int frequencia;
            string situacao;

            // Verifica se o nome foi informado
            if (txtAluno.Text == "")
            {
                MessageBox.Show("Informe o nome do aluno.");
                txtAluno.Focus();
                return;
            }

            // Verifica se a turma foi informada
            if (txtTurma.Text == "")
            {
                MessageBox.Show("Informe a turma.");
                txtTurma.Focus();
                return;
            }

            // Lê a nota 1
            if (!double.TryParse(txtNota1.Text, out nota1))
            {
                MessageBox.Show("Digite uma nota válida.");
                txtNota1.Focus();
                return;
            }

            if (nota1 < 0 || nota1 > 10)
            {
                MessageBox.Show("A nota deve estar entre 0 e 10.");
                txtNota1.Focus();
                return;
            }

            // Lê a nota 2
            if (!double.TryParse(txtNota2.Text, out nota2))
            {
                MessageBox.Show("Digite uma nota válida.");
                txtNota2.Focus();
                return;
            }

            if (nota2 < 0 || nota2 > 10)
            {
                MessageBox.Show("A nota deve estar entre 0 e 10.");
                txtNota2.Focus();
                return;
            }

            // Lê a nota 3
            if (!double.TryParse(txtNota3.Text, out nota3))
            {
                MessageBox.Show("Digite uma nota válida.");
                txtNota3.Focus();
                return;
            }

            if (nota3 < 0 || nota3 > 10)
            {
                MessageBox.Show("A nota deve estar entre 0 e 10.");
                txtNota3.Focus();
                return;
            }

            // Lê a nota 4
            if (!double.TryParse(txtNota4.Text, out nota4))
            {
                MessageBox.Show("Digite uma nota válida.");
                txtNota4.Focus();
                return;
            }

            if (nota4 < 0 || nota4 > 10)
            {
                MessageBox.Show("A nota deve estar entre 0 e 10.");
                txtNota4.Focus();
                return;
            }

            // Recebe a frequência
            frequencia = (int)nudFrequencia.Value;

            // Calcula a média
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            // A frequência tem prioridade
            if (frequencia < 75)
            {
                situacao = "Reprovado por frequência";
            }
            else if (media >= 7)
            {
                situacao = "Aprovado";
            }
            else if (media >= 5)
            {
                situacao = "Recuperação";
            }
            else
            {
                situacao = "Reprovado por nota";
            }

            // Exibe o resultado
            txtMedia.Text = media.ToString("0.00");
            txtSituacao.Text = situacao;

            // Libera a adição ao ListBox
            calculado = true;
        }

        void BtnAdicionarResultadoClick(object sender, EventArgs e)
        {
            // Verifica se o cálculo foi realizado
            if (calculado == false)
            {
                MessageBox.Show("Calcule a média antes de adicionar o resultado.");
                return;
            }

            // Monta o texto que será exibido no ListBox
            string resultado;

            resultado = "Aluno: " + txtAluno.Text +
                        " | Turma: " + txtTurma.Text +
                        " | Média: " + txtMedia.Text +
                        " | Frequência: " + nudFrequencia.Value + "%" +
                        " | Situação: " + txtSituacao.Text;

            // Adiciona o resultado na lista
            lstResultados.Items.Add(resultado);

            // Impede adicionar novamente sem recalcular
            calculado = false;
        }

        void BtnRemoverSelecionadoClick(object sender, EventArgs e)
        {
            // Verifica se algum item foi selecionado
            if (lstResultados.SelectedIndex != -1)
            {
                // Remove o item selecionado
                lstResultados.Items.RemoveAt(lstResultados.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um estudante para remover.");
            }
        }

        void BtnLimparListaClick(object sender, EventArgs e)
        {
            // Verifica se existe algum item na lista
            if (lstResultados.Items.Count > 0)
            {
                lstResultados.Items.Clear();
            }
            else
            {
                MessageBox.Show("A lista já está vazia.");
            }
        }

        void BtnLimparCamposClick(object sender, EventArgs e)
        {
            // Limpa os campos de entrada
            txtAluno.Clear();
            txtTurma.Clear();

            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();

            // Volta a frequência para zero
            nudFrequencia.Value = 0;

            // Limpa os resultados calculados
            txtMedia.Clear();
            txtSituacao.Clear();

            // Libera para um novo cálculo
            calculado = false;

            // Coloca o foco no nome do aluno
            txtAluno.Focus();
        }

        void BtnGerarResumoClick(object sender, EventArgs e)
        {
            // Variáveis de contagem
            int total = lstResultados.Items.Count;
            int aprovados = 0;
            int recuperacao = 0;
            int reprovadosNota = 0;
            int reprovadosFrequencia = 0;

            // Percorre todos os itens da lista
            for (int i = 0; i < lstResultados.Items.Count; i++)
            {
                // Guarda o texto do estudante atual
                string resultado = lstResultados.Items[i].ToString();

                // Verifica a situação do aluno
                if (resultado.Contains("Situação: Aprovado"))
                {
                    aprovados++;
                }
                else if (resultado.Contains("Situação: Recuperação"))
                {
                    recuperacao++;
                }
                else if (resultado.Contains("Situação: Reprovado por nota"))
                {
                    reprovadosNota++;
                }
                else if (resultado.Contains("Situação: Reprovado por frequência"))
                {
                    reprovadosFrequencia++;
                }
            }

            // Exibe o resumo
            txtResumoTurma.Text = "Total de estudantes: " + total +
                                  "\r\nAprovados: " + aprovados +
                                  "\r\nRecuperação: " + recuperacao +
                                  "\r\nReprovados por nota: " + reprovadosNota +
                                  "\r\nReprovados por frequência: " + reprovadosFrequencia;
        }
    }
}