namespace Registro_de_Ponto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            cbCargo.SelectedIndex = 0;
            cbSelecionarFuncionário.SelectedIndex = 0;

            // Lê nomes dos funcionários e atribui à combobox
            for (int i=0; i < LerNomes().Length; i++)
            {
                cbSelecionarFuncionário.Items.Add(LerNomes()[i]);
            }
        }
        // Salva um cadastro novo no txt
        private void Cadastrar(string nome, string cargo, string salario, string cpf, string telefone, string datanasc)
        {
            // Caminho do txt
            string caminho = "C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Registro de Ponto\\Registro de Ponto\\Arquivos do Projeto\\Cadastros\\Cadastros.txt";

            // Se o arquivo txt não existe, cria um
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

            // Se o arquivo txt não existe, cria um
            if (File.Exists(caminho) == false)
            {
                File.Create(caminho);
            }

            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                writer.WriteLine($"{tipo},{DateTime.Now.ToString("dd/MM/yy")},{DateTime.Now.ToString("HH:mm")}");
            }
        }
        // Lê o txt, separa os dados em um array unidimensional com os nomes e retorna esse array
        private static string[] LerNomes()
        {
            // Caminho do txt
            string caminho = "C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Registro de Ponto\\Registro de Ponto\\Arquivos do Projeto\\Cadastros\\Cadastros.txt";

            // Se o arquivo txt não existe, cria um
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
                // Cadastra, limpa os campos e atualiza a combobox de funcionários
                Cadastrar(txtNome.Text, cbCargo.Text, txtSalario.Text, txtCpf.Text, txtTelefone.Text, txtDataNasc.Text);

                cbSelecionarFuncionário.Items.Clear();
                cbSelecionarFuncionário.Items.Add("Selecione um funcionário");
                cbSelecionarFuncionário.SelectedIndex = 0;

                for (int i = 0; i < LerNomes().Length; i++)
                {
                    cbSelecionarFuncionário.Items.Add(LerNomes()[i]);
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
            if (cbSelecionarFuncionário.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um funcionário!");
            }
            else
            {
                BaterPonto(cbSelecionarFuncionário.Text, "Entrada");
                MessageBox.Show($"ENTRADA {DateTime.Now.ToString("dd/MM/yy HH:mm")} - {cbSelecionarFuncionário.Text}\n\nSucesso!");
            }
        }

        private void btnSaída_Click(object sender, EventArgs e)
        {
            if (cbSelecionarFuncionário.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um funcionário!");
            }
            else
            {
                BaterPonto(cbSelecionarFuncionário.Text, "Saída");
                MessageBox.Show($"SAÍDA {DateTime.Now.ToString("dd/MM/yy HH:mm")} - {cbSelecionarFuncionário.Text}\n\nSucesso!");
            }
        }
    }
}