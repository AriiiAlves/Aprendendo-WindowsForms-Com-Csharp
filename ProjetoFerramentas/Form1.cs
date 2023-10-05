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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Exibindo hora

            lblHora.Text= DateTime.Now.ToLongTimeString();
            lblHora2.Text= DateTime.Now.ToLongTimeString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButton.Text = "Votuporango";
        }

        private void Feminino_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioButton.Text = "Votuporanga";
        }
    }
}