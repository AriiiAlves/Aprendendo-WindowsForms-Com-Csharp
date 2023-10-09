namespace ProjetoFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ao carregar os componentes, vai atualizar a barra de status
            // Trabalhando com a classe Datetime

            lblData.Text = DateTime.Now.ToLongDateString();

            // Adiionar itens no cbitens

            cbItens.Items.Add("Selecione um objeto:");
            cbItens.Items.Add("Teclado");
            cbItens.Items.Add("Monitor");
            cbItens.Items.Add("Placa de vídeo");

            // Deixar comboboxes com itens selecionados

            cbNomes.SelectedIndex = 0;
            cbItens.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Exibindo hora

            lblHora.Text= DateTime.Now.ToLongTimeString();
            lblHora2.Text= DateTime.Now.ToLongTimeString();
        }

        private void ckAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAmarelo.Checked)
            {
                lblCheckbox.ForeColor = Color.Yellow;
                lblCheckbox.BackColor = Color.Black;
                ckVerde.Checked = false;
            }
        }

        private void ckVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (ckVerde.Checked)
            {
                lblCheckbox.ForeColor = Color.Green;
                lblCheckbox.BackColor = Color.Black;
                ckAmarelo.Checked = false;
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButton.Text = "Votuporango";
        }

        private void Feminino_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButton.Text = "Votuporanga";
        }

        private void btnMascara_Click(object sender, EventArgs e)
        {
            lblMascara.Text = txtMascara.Text;
        }

        private void cbNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomes.Text = cbNomes.Text;
            lblIndex.Text = cbNomes.SelectedIndex.ToString();
        }

        private void cbItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItens.Text = cbItens.Text;
            lblIndex2.Text= cbItens.SelectedIndex.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblCalendario.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}