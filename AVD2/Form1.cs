using AVD2.src.Jogos;
using AVD2.src;

namespace AVD2
{
    public partial class Form1 : Form
    {

        private Jogador jogador;
        private Cassino cassino;

        public Form1()
        {
            InitializeComponent();
            jogador = new Jogador("Jogador1", 1000m);
            cassino = new Cassino(jogador);
            cassino.AdicionarJogo(new CacaNiquel());
            cassino.AdicionarJogo(new Roleta());

            AtualizarSaldo();
        }

        private void AtualizarSaldo()
        {
            txtSaldo.Text = jogador.Saldo.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCacaNiquel_Click(object sender, EventArgs e)
        {
            decimal valorAposta;
            if (decimal.TryParse(txtValorAposta.Text, out valorAposta))
            {
                if (valorAposta > 0 && valorAposta <= jogador.Saldo)
                {
                    var jogo = new CacaNiquel();
                    jogador.AtualizarSaldo(-valorAposta);
                    jogo.Apostar(valorAposta);

                    // Simulação de resultado
                    Random rnd = new Random();
                    bool venceu = rnd.Next(0, 2) == 1; // Ganha ou perde aleatoriamente

                    if (venceu)
                    {
                        decimal premio = valorAposta * 2;
                        jogador.AtualizarSaldo(premio);
                        lstResultados.Items.Add($"Você ganhou {premio:C} no Caça-Níquel!");
                    }
                    else
                    {
                        lstResultados.Items.Add("Você perdeu no Caça-Níquel!");
                    }
                    AtualizarSaldo();
                }
                else
                {
                    MessageBox.Show("Aposta inválida! Verifique o saldo ou o valor da aposta.");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido.");
            }
        }

        private void btnRoleta_Click(object sender, EventArgs e)
        {
            panelRoletaPopup.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoAposta.SelectedItem.ToString() == "Numero")
            {
                txtNumeroEscolhido.Visible = true;
                label3.Visible = true;
                cmbEscolhaCor.Visible = false;
                label4.Visible = false;
            }
            else if (cmbTipoAposta.SelectedItem.ToString() == "Cor")
            {
                txtNumeroEscolhido.Visible = false;
                label3.Visible = false;
                cmbEscolhaCor.Visible = true;
                label4.Visible = true;
            }
        }

        private void btnApostarRoleta_Click(object sender, EventArgs e)
        {
            decimal valorAposta;
            string tipoAposta = cmbTipoAposta.SelectedItem.ToString();
            string escolhaCor = cmbEscolhaCor.SelectedItem?.ToString(); // ComboBox para cor
            int numeroEscolhido = -1;

            if (tipoAposta == "Numero" && !int.TryParse(txtNumeroEscolhido.Text, out numeroEscolhido))
            {
                MessageBox.Show("Por favor, insira um número válido para a aposta.");
                return;
            }

            if (decimal.TryParse(txtValorAposta.Text, out valorAposta))
            {
                if (valorAposta > 0 && valorAposta <= jogador.Saldo)
                {
                    // Cria uma nova instância de Roleta e define a aposta
                    var jogo = new Roleta();
                    jogo.DefinirAposta(tipoAposta, escolhaCor, numeroEscolhido);

                    // Deduz o valor da aposta do saldo do jogador
                    jogador.AtualizarSaldo(-valorAposta);

                    // Realiza a aposta e captura o resultado
                    bool ganhou = jogo.FazerAposta(valorAposta);
                    string resultado;

                    if (ganhou)
                    {
                        decimal premio = valorAposta * 1.5m; // Exemplo de multiplicador de prêmio
                        jogador.AtualizarSaldo(premio); // Atualiza o saldo do jogador com o prêmio
                        resultado = $"Ganhou {premio:C}";
                    }
                    else
                    {
                        resultado = "Perdeu";
                    }

                    // Adiciona o resultado da aposta à lstResultados
                    string entrada = $"Aposta: {tipoAposta}, Valor: {valorAposta:C}, \n Resultado: {resultado}, Saldo: {jogador.Saldo:C}";
                    lstResultados.Items.Add(entrada);

                    // Atualiza o saldo exibido na interface
                    AtualizarSaldo();
                }
                else
                {
                    MessageBox.Show("Aposta inválida! Verifique o saldo ou o valor da aposta.");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido.");
            }
        }

        private void btnFecharPopup_Click(object sender, EventArgs e)
        {
            panelRoletaPopup.Visible = false;
        }
    }
}
