using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtTipo.SelectedIndex = 0;

            Atualizar();
        }
        private void Salvar(string tarefa, string tipo, string dia, string hora, string status)
        {
            using(StreamWriter writer = new StreamWriter("C:\\Users\\" +
                    "ariel.asilva2\\source\\repos\\Lista de Tarefas\\Lista de Tarefas\\Dados.txt", true))
                {
                writer.WriteLine($"{tarefa},{tipo},{dia},{hora},{status}");
            }
        }
        private static string[,] Ler()
        {
            string caminho = "C:\\Users\\ariel.asilva2\\source\\repos\\Lista de Tarefas\\Lista de Tarefas\\Dados.txt";

            string[,] tarefas = new string[File.ReadAllLines(caminho).Length, 5];

            for (int i = 0; i < File.ReadAllLines(caminho).Length; i++)
            {
                string linha = File.ReadLines(caminho).Skip(i).FirstOrDefault();
                string[] dados = linha.Split(',');

                tarefas[i, 0] = dados[0];
                tarefas[i, 1] = dados[1];
                tarefas[i, 2] = dados[2];
                tarefas[i, 3] = dados[3];
                tarefas[i, 4] = dados[4];
            }

            return tarefas;
        }
        private void Atualizar()
        {
            lstPendentes.Items.Clear();
            lstFeitas.Items.Clear();

            for (int i = 0; i < Ler().GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(Ler()[i, 0]);

                item.SubItems.Add(Ler()[i, 1]);
                item.SubItems.Add(Ler()[i, 2]);
                item.SubItems.Add(Ler()[i, 3]);

                if (Ler()[i, 4] == "Pendente")
                {
                    lstPendentes.Items.Add(item);
                }
                else
                {
                    lstFeitas.Items.Add(item);
                }
            }
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            string tarefa, tipo, dia, hora, status;

            tarefa = txtTarefa.Text;
            tipo = txtTipo.Text;
            dia = txtDia.Text;
            hora = txtHora.Text;
            status = "Pendente";

            if (txtTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Especifique o tipo da tarefa!");
            }
            else if(txtTarefa.Text == "")
            {
                MessageBox.Show("Especifique qual a tarefa!");
            }
            else
            {
                Salvar(tarefa, tipo, dia, hora, status);

                txtTarefa.Text = "";
                txtTipo.SelectedIndex = 0;
                txtDia.Value = DateTime.Today.Date;
                txtHora.Value = DateTime.Now;

                Atualizar();
            }
        }
    }
}