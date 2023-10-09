namespace Calcula_Frete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbEstadoOrigem.SelectedIndex = 0;
            cbCidadeOrigem.SelectedIndex = 0;
            cbEstadoDestino.SelectedIndex = 0;
            cbCidadeDestino.SelectedIndex = 0;
            cbTransporte.SelectedIndex = 0;
            cbProfissionais.SelectedIndex = 0;
        }

        decimal valFrete, valTransp, valProf, valTotal;

        private void cbEstadoOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEstadoOrigem.Text = $"Estado: {cbEstadoOrigem.Text}";
        }

        private void cbCidadeOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCidadeOrigem.Text = $"Cidade: {cbCidadeOrigem.Text}";
        }

        private void cbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstadoDestino.Text == "SP" || cbEstadoDestino.Text == "MG" || cbEstadoDestino.Text == "SC")
            {
                valFrete = 500;
            }
            else if (cbEstadoDestino.Text == "RJ" || cbEstadoDestino.Text == "PR")
            {
                valFrete = 830;
            }
            else if (cbEstadoDestino.Text == "AM")
            {
                valFrete = 7450;
            }
            else if (cbEstadoDestino.Text != "N/A")
            {
                valFrete = 2340;
            }
            lblEstadoDestino.Text = $"Estado: {cbEstadoDestino.Text}";
            lblValorFrete.Text = "Frete: " + valFrete.ToString("C");
        }

        private void cbCidadeDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCidadeDestino.Text = $"Cidade: {cbCidadeDestino.Text}";
        }

        private void cbProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProfissionais.Text)
            {
                case "1":
                    valProf = 2500;
                    break;
                case "3":
                    valProf = 4500;
                    break;
                case "5":
                    valProf = 6800;
                    break;
            }
            lblValorProfissionais.Text = "Profissionais: " + valProf.ToString("C");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            valTotal = valTransp + valFrete + valProf;
            if (valTotal > 15000)
            {
                valTotal = valTotal - ((valTotal / 100) * 15);
                lblTotal.Text = "TOTAL: " + valTotal.ToString("C") + " (Desconto de 15%)";
            }
            else
            {
                lblTotal.Text = "TOTAL: " + valTotal.ToString("C");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbEstadoOrigem.SelectedIndex = 0;
            cbCidadeOrigem.SelectedIndex = 0;
            cbEstadoDestino.SelectedIndex = 0;
            cbCidadeDestino.SelectedIndex = 0;
            cbTransporte.SelectedIndex = 0;
            cbProfissionais.SelectedIndex = 0;
            valTransp = 0;
            valFrete = 0;
            valProf = 0;
            valTotal = 0;
            lblTotal.Text = "TOTAL: " + valTotal.ToString("C");
        }

        private void cbTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransporte.SelectedIndex == 0)
            {
                valTransp = 0;
            }
            else if (cbTransporte.SelectedIndex == 1)
            {
                pbTransporte.Load("C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Calcula Frete\\Calcula Frete\\Resources\\tamanho p.jpg");
                valTransp = 3000;
            }
            else if (cbTransporte.SelectedIndex == 2)
            {
                pbTransporte.Load("C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Calcula Frete\\Calcula Frete\\Resources\\tamanho m.jpg");
                valTransp = 4500;
            }
            else if (cbTransporte.SelectedIndex == 3)
            {
                pbTransporte.Load("C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Calcula Frete\\Calcula Frete\\Resources\\tamanho g.jpg");
                valTransp = 6500;
            }
            lblValorTransporte.Text = "Transporte: " + valTransp.ToString("C");
        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            lblNomeCliente.Text = $"Nome: {txtNomeCliente.Text}";
            lblEstadoCliente.Text = $"Estado: {cbEstadoCliente.Text}";
            lblCidadeCliente.Text = $"Cidade: {cbCidadeCliente.Text}";

            if (rbInfoYes.Checked == true)
            {
                cbEstadoOrigem.SelectedIndex = cbEstadoCliente.SelectedIndex;
                cbCidadeOrigem.SelectedIndex = cbCidadeCliente.SelectedIndex;
            }
        }

        private void rbInfoYes_CheckedChanged(object sender, EventArgs e)
        {
        }


    }
}