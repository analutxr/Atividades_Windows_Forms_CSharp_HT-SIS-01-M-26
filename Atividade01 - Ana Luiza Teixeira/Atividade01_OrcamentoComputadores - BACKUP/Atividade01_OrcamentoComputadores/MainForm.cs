using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade01_OrcamentoComputadores
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnCarregarRecomendacaoClick(object sender, EventArgs e)
		{
			// Verifica se algum perfil foi escolhido
			if (cboPerfil.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione um perfil antes de carregar a recomendação.");
				return;
			}

			// Recomendação para Administrativo
			if (cboPerfil.Text == "Administrativo")
			{
				cboProcessador.Text = "Processador básico";
				cboPlacaMae.Text = "Placa-mãe básica";
				cboRAM.Text = "8 GB";
				cboSSD.Text = "240 GB";
				cboPlacaVideo.Text = "Vídeo integrado";
				cboFonte.Text = "Fonte 500 W";
				cboGabinete.Text = "Gabinete básico";
			}

			// Recomendação para Professor de Tecnologia
			else if (cboPerfil.Text == "Professor de Tecnologia")
			{
				cboProcessador.Text = "Processador intermediário";
				cboPlacaMae.Text = "Placa-mãe intermediária";
				cboRAM.Text = "16 GB";
				cboSSD.Text = "500 GB";
				cboPlacaVideo.Text = "Vídeo integrado";
				cboFonte.Text = "Fonte 500 W";
				cboGabinete.Text = "Gabinete intermediário";
			}

			// Recomendação para Desenvolvedor de Software
			else if (cboPerfil.Text == "Desenvolvedor de Software")
			{
				cboProcessador.Text = "Processador avançado";
				cboPlacaMae.Text = "Placa-mãe intermediária";
				cboRAM.Text = "16 GB";
				cboSSD.Text = "500 GB";
				cboPlacaVideo.Text = "Dedicada básica";
				cboFonte.Text = "Fonte 650 W";
				cboGabinete.Text = "Gabinete intermediário";
			}

			// Recomendação para Desenvolvedor de Jogos
			else if (cboPerfil.Text == "Desenvolvedor de Jogos")
			{
				cboProcessador.Text = "Processador de alto desempenho";
				cboPlacaMae.Text = "Placa-mãe avançada";
				cboRAM.Text = "32 GB";
				cboSSD.Text = "1 TB";
				cboPlacaVideo.Text = "Dedicada intermediária";
				cboFonte.Text = "Fonte 750 W";
				cboGabinete.Text = "Gabinete gamer";
			}

			MessageBox.Show("Configuração recomendada carregada.");
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			// Verifica se o nome do cliente foi informado
			if (txtCliente.Text.Trim() == "")
			{
				MessageBox.Show("Informe o nome do cliente.");
				return;
			}

			// Verifica se o perfil foi selecionado
			if (cboPerfil.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione um perfil.");
				return;
			}


			// Verifica se todos os componentes foram escolhidos
			if (cboProcessador.SelectedIndex == -1 ||
			    cboPlacaMae.SelectedIndex == -1 ||
			    cboRAM.SelectedIndex == -1 ||
			    cboSSD.SelectedIndex == -1 ||
			    cboPlacaVideo.SelectedIndex == -1 ||
			    cboFonte.SelectedIndex == -1 ||
			    cboGabinete.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione todos os componentes.");
				return;
			}


			double subtotal = 0;


			// Soma os componentes escolhidos
			subtotal += PrecoProcessador();
			subtotal += PrecoPlacaMae();
			subtotal += PrecoRAM();
			subtotal += PrecoSSD();
			subtotal += PrecoPlacaVideo();
			subtotal += PrecoFonte();
			subtotal += PrecoGabinete();


			// Soma os itens opcionais
			if (chkMonitor.Checked)
			{
				subtotal += 700;
			}

			if (chkTecladoMouse.Checked)
			{
				subtotal += 120;
			}

			if (chkHeadset.Checked)
			{
				subtotal += 180;
			}


			// Taxa de montagem de 10%
			double taxaMontagem;

			if (!double.TryParse(txtTaxaMontagem.Text, out taxaMontagem))
			{
				MessageBox.Show("Informe uma taxa de montagem válida.");
				return;
			}

			if (taxaMontagem < 0)
			{
				MessageBox.Show("A taxa de montagem não pode ser negativa.");
				return;
			}

			double valorMontagem = subtotal * taxaMontagem / 100;


			// Pega o desconto digitado
			double desconto;

			if (!double.TryParse(txtDesconto.Text, out desconto))
			{
				desconto = 0;
			}


			// Impede desconto negativo
			if (desconto < 0)
			{
				MessageBox.Show("O desconto não pode ser negativo.");
				return;
			}


			// Impede desconto acima de 30%
			if (desconto > 30)
			{
				MessageBox.Show("O desconto máximo permitido é 30%.");
				return;
			}


			double valorDesconto = subtotal * desconto / 100;


			double totalFinal = subtotal + valorMontagem - valorDesconto;


			// Mostra os valores formatados como moeda
			txtSubtotal.Text = subtotal.ToString("C2");
			txtValorMontagem.Text = valorMontagem.ToString("C2");
			txtValorDesconto.Text = valorDesconto.ToString("C2");
			txtTotal.Text = totalFinal.ToString("C2");
			
			// Análise de compatibilidade da configuração escolhida
			string problemas = "";
			bool ressalva = false;


			// Verifica requisitos conforme o perfil escolhido
			if (cboPerfil.Text == "Administrativo")
			{
				if (cboRAM.Text == "8 GB")
				{
					// atende o mínimo
				}
				else
				{
					problemas += "• Memória RAM abaixo do recomendado.\n";
				}

				if (cboSSD.Text == "240 GB" || cboSSD.Text == "500 GB" || cboSSD.Text == "1 TB")
				{
					// atende o mínimo
				}
				else
				{
					problemas += "• SSD abaixo do mínimo.\n";
				}
			}


			else if (cboPerfil.Text == "Professor de Tecnologia")
			{
				if (cboRAM.Text == "8 GB")
				{
					problemas += "• RAM mínima de 16 GB não atendida.\n";
				}

				if (cboSSD.Text == "240 GB")
				{
					problemas += "• SSD mínimo de 480 GB não atendido.\n";
				}
			}


			else if (cboPerfil.Text == "Desenvolvedor de Software")
			{
				if (cboRAM.Text == "8 GB")
				{
					problemas += "• RAM mínima de 16 GB não atendida.\n";
				}

				if (cboSSD.Text == "240 GB")
				{
					problemas += "• SSD mínimo de 480 GB não atendido.\n";
				}

				if (cboPlacaVideo.Text == "Vídeo integrado")
				{
					ressalva = true;
					problemas += "• Placa de vídeo dedicada é recomendada para desenvolvimento.\n";
				}
			}


			else if (cboPerfil.Text == "Desenvolvedor de Jogos")
			{
				if (cboRAM.Text != "32 GB")
				{
					problemas += "• Jogos exigem 32 GB de RAM.\n";
				}

				if (cboSSD.Text != "1 TB")
				{
					problemas += "• Jogos exigem SSD de 1 TB.\n";
				}

				if (cboPlacaVideo.Text == "Vídeo integrado")
				{
					problemas += "• Placa de vídeo dedicada é obrigatória.\n";
				}
			}


			// Exibe o resultado da análise
			if (problemas == "")
			{
				txtSituacaoConfiguracao.Text = "Configuração adequada";
				txtSituacaoConfiguracao.BackColor = Color.LightGreen;
				txtRecomendacao.Text = "Todos os requisitos mínimos foram atendidos.";
			}
			else if (ressalva)
			{
				txtSituacaoConfiguracao.Text = "Configuração adequada com ressalva";
				txtSituacaoConfiguracao.BackColor = Color.LightYellow;
				txtRecomendacao.Text = problemas;
			}
			else
			{
				txtSituacaoConfiguracao.Text = "Configuração incompatível";
				txtSituacaoConfiguracao.BackColor = Color.LightCoral;
				txtRecomendacao.Text = problemas;
			}
		}
		
		double PrecoProcessador()
		{
			if (cboProcessador.Text == "Básico")
				return 650;

			if (cboProcessador.Text == "Intermediário")
				return 1000;

			if (cboProcessador.Text == "Avançado")
				return 1450;

			if (cboProcessador.Text == "Alto desempenho")
				return 2300;

			return 0;
		}


		double PrecoPlacaMae()
		{
			if (cboPlacaMae.Text == "Básica")
				return 550;

			if (cboPlacaMae.Text == "Intermediária")
				return 750;

			if (cboPlacaMae.Text == "Avançada")
				return 1100;

			return 0;
		}


		double PrecoRAM()
		{
			if (cboRAM.Text == "8 GB")
				return 180;

			if (cboRAM.Text == "16 GB")
				return 320;

			if (cboRAM.Text == "32 GB")
				return 620;

			return 0;
		}


		double PrecoSSD()
		{
			if (cboSSD.Text == "240 GB")
				return 180;

			if (cboSSD.Text == "500 GB")
				return 280;

			if (cboSSD.Text == "1 TB")
				return 480;

			return 0;
		}


		double PrecoPlacaVideo()
		{
			if (cboPlacaVideo.Text == "Vídeo integrado")
				return 0;

			if (cboPlacaVideo.Text == "Dedicada básica")
				return 1500;

			if (cboPlacaVideo.Text == "Dedicada intermediária")
				return 2300;

			return 0;
		}


		double PrecoFonte()
		{
			if (cboFonte.Text == "500 W")
				return 280;

			if (cboFonte.Text == "650 W")
				return 420;

			if (cboFonte.Text == "7750 W")
				return 580;

			return 0;
		}


		double PrecoGabinete()
		{
			if (cboGabinete.Text == "Básico")
				return 250;

			if (cboGabinete.Text == "Intermediário")
				return 350;

			if (cboGabinete.Text == "Gamer")
				return 500;

			return 0;
		}
		
		void BtnLimparClick(object sender, EventArgs e)
		{
			// Limpa os campos de texto
			txtCliente.Clear();
			txtSubtotal.Clear();
			txtValorMontagem.Clear();
			txtValorDesconto.Clear();
			txtTotal.Clear();
			txtSituacaoConfiguracao.Clear();
			txtRecomendacao.Clear();

			// Volta os ComboBox para sem seleção
			cboPerfil.SelectedIndex = -1;
			cboProcessador.SelectedIndex = -1;
			cboPlacaMae.SelectedIndex = -1;
			cboRAM.SelectedIndex = -1;
			cboSSD.SelectedIndex = -1;
			cboPlacaVideo.SelectedIndex = -1;
			cboFonte.SelectedIndex = -1;
			cboGabinete.SelectedIndex = -1;

			// Desmarca os opcionais
			chkMonitor.Checked = false;
			chkTecladoMouse.Checked = false;
			chkHeadset.Checked = false;

			// Volta a taxa padrão
			txtTaxaMontagem.Text = "10";

			// Limpa a cor da situação
			txtSituacaoConfiguracao.BackColor = Color.White;

			txtCliente.Focus();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
			                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Close();
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			// Deixa os campos sem seleção ao iniciar
			cboPerfil.SelectedIndex = -1;
			cboProcessador.SelectedIndex = -1;
			cboPlacaMae.SelectedIndex = -1;
			cboRAM.SelectedIndex = -1;
			cboSSD.SelectedIndex = -1;
			cboPlacaVideo.SelectedIndex = -1;
			cboFonte.SelectedIndex = -1;
			cboGabinete.SelectedIndex = -1;

			// Taxa inicial de montagem
			txtTaxaMontagem.Text = "10";
		}
	}
}
