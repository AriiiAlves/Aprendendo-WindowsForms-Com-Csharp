namespace Registro_de_Ponto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            cbCargo.SelectedIndex = 0;
            cbSelecionarFuncion�rio.SelectedIndex = 0;

            // L� nomes dos funcion�rios e atribui � combobox
            for (int i=0; i < LerNomes().Length; i++)
            {
                cbSelecionarFuncion�rio.Items.Add(LerNomes()[i]);
            }
        }
        // Salva um cadastro novo no txt
        private void Cadastrar(string nome, string cargo, string salario, string cpf, string telefone, string datanasc)
        {
            // Caminho do txt
            string caminho = "C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Registro de Ponto\\Registro de Ponto\\Arquivos do Projeto\\Cadastros\\Cadastros.txt";

            // Se o arquivo txt n�o existe, cria um
            if (File.Exists(caminho) == false)
            {
                File.Create(caminho);
            }

            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                writer.WriteLine($"{nome},{cargo},{salario},{cpf},{telefone},{datanasc}");
            }
        }
        // Salva um registro de ponto no txt
        private void BaterPonto(string nome, string tipo)
        {
            // Caminho do txt
            string caminho = $"C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Registro de Ponto\\Registro de Ponto\\Arquivos do Projeto\\Pontos Registrados\\{nome}.txt";

            // Se o arquivo txt n�o existe, cria um
            if (File.Exists(caminho) == false)
            {
                File.Create(caminho);
            }

            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                writer.WriteLine($"{tipo},{DateTime.Now.ToString("dd/MM/yy")},{DateTime.Now.ToString("HH:mm")}");
            }
        }
        // L� o txt, separa os dados em um array unidimensional com os nomes e retorna esse array
        private static string[] LerNomes()
        {
            // Caminho do txt
            string caminho = "C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Registro de Ponto\\Registro de Ponto\\Arquivos do Projeto\\Cadastros\\Cadastros.txt";

            // Se o arquivo txt n�o existe, cria um
            if (File.Exists(caminho) == false)
            {
                File.Create(caminho);
            }
            
            string[] nomes = new string[File.ReadAllLines(caminho).Length];

            for (int i = 0; i < File.ReadAllLines(caminho).Length; i++)
            {
                string linha = File.ReadLines(caminho).Skip(i).FirstOrDefault();
                string[] dados = linha.Split(',');

                nomes[i] = dados[0];
            }

            return nomes;
        }
        // Timer corrente
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSalario.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            cbCargo.SelectedIndex = 0;
            txtDataNasc.Value = DateTime.Now;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbCargo.SelectedIndex == 0 || txtNome.Text == "" || txtSalario.Text == "" || txtTelefone.Text.Length < 10 || txtCpf.Text.Length < 11) 
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            else
            {
                // Cadastra, limpa os campos e atualiza a combobox de funcion�rios
                Cadastrar(txtNome.Text, cbCargo.Text, txtSalario.Text, txtCpf.Text, txtTelefone.Text, txtDataNasc.Text);

                cbSelecionarFuncion�rio.Items.Clear();
                cbSelecionarFuncion�rio.Items.Add("Selecione um funcion�rio");
                cbSelecionarFuncion�rio.SelectedIndex = 0;

                for (int i = 0; i < LerNomes().Length; i++)
                {
                    cbSelecionarFuncion�rio.Items.Add(LerNomes()[i]);
                }
                
                MessageBox.Show("Sucesso!");

                txtNome.Clear();
                txtSalario.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                cbCargo.SelectedIndex = 0;
                txtDataNasc.Value = DateTime.Now;
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (cbSelecionarFuncion�rio.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um funcion�rio!");
            }
            else
            {
                BaterPonto(cbSelecionarFuncion�rio.Text, "Entrada");
                MessageBox.Show($"ENTRADA {DateTime.Now.ToString("dd/MM/yy HH:mm")} - {cbSelecionarFuncion�rio.Text}\n\nSucesso!");
            }
        }

        private void btnSa�da_Click(object sender, EventArgs e)
        {
            if (cbSelecionarFuncion�rio.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um funcion�rio!");
            }
            else
            {
                BaterPonto(cbSelecionarFuncion�rio.Text, "Sa�da");
                MessageBox.Show($"SA�DA {DateTime.Now.ToString("dd/MM/yy HH:mm")} - {cbSelecionarFuncion�rio.Text}\n\nSucesso!");
            }
        }
    }
}