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
            if (decimal.TryParse(txtValorAposta.Text, out decimal valorAposta))
            {
                string resultado = cassino.ApostarNoCacaNiquel(valorAposta);
                lstResultados.Items.Add(resultado);
                AtualizarSaldo();
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
            if (decimal.TryParse(txtValorAposta.Text, out decimal valorAposta))
            {
                string tipoAposta = cmbTipoAposta.SelectedItem?.ToString();
                string escolhaCor = cmbEscolhaCor.SelectedItem?.ToString();
                int numeroEscolhido = int.TryParse(txtNumeroEscolhido.Text, out int n) ? n : -1;

                string resultado = cassino.ApostarNaRoleta(valorAposta, tipoAposta, escolhaCor, numeroEscolhido);
                lstResultados.Items.Add(resultado);
                AtualizarSaldo();
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
