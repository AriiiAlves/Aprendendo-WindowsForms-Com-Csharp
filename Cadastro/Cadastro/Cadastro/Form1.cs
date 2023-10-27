using System.Windows.Forms;
using PdfSharp;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mskData.MaxDate = DateTime.Now;
            mskData.MinDate = new DateTime(1800, 01, 01);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Selecione uma Imagem";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoDoArquivo = openFileDialog1.FileName;

                // Carregando a imagem no PictureBox
                pbImagem.Image = new Bitmap(caminhoDoArquivo);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                avisoNome.Visible = true;
            }
            else
            {
                avisoNome.Visible = false;
            }
            if (mskCPF.Text.Length < 11)
            {
                avisoCPF.Visible = true;
            }
            else
            {
                avisoCPF.Visible = false;
            }
            if (mskTelefone.Text.Length < 10)
            {
                avisoTelefone.Visible = true;
            }
            else
            {
                avisoTelefone.Visible = false;
            }
            if(mskCelular.Text.Length < 11) 
            {
                avisoCelular.Visible = true;
            }
            else
            {
                avisoCelular.Visible = false;
            }
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}