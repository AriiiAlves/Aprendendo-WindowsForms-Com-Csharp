using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Atualizar();

            txtTipo.SelectedIndex = 0;
            cbDeletar.SelectedIndex = 0;
            cbConcluir.SelectedIndex = 0;
        }
        // Caminho do txt (funciona como banco de dados do programa)
        static string caminho = "C:\\Users\\ariel.asilva2\\Documents\\GitHub\\Windows-Forms-Learning-with-CSharp\\Lista de Tarefas\\Lista de Tarefas\\Dados.txt";
        // Salva uma tarefa nova no txt
        private void Salvar(string tarefa, string tipo, string dia, string hora, string status)
        {
            using(StreamWriter writer = new StreamWriter(caminho, true))
                {
                writer.WriteLine($"{tarefa},{tipo},{dia},{hora},{status}");
            }
        }
        // Lê o txt, separa os dados em um array bidimensional (como se fosse um dicionário) e retorna esse array
        private static string[,] Ler()
        {
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
        // Atualiza todos os valores visíveis do programa
        private void Atualizar()
        {
            // Limpa as ComboBoxes e Listas
            lstPendentes.Items.Clear();
            lstFeitas.Items.Clear();
            cbDeletar.Items.Clear();
            cbConcluir.Items.Clear();

            // Adiciona valor padrão no índice 0 das ComboBoxes
            cbDeletar.Items.Add("Selecione uma tarefa");
            cbConcluir.Items.Add("Selecione uma tarefa");

            // Atualizando cada item com os dados do array
            for (int i = 0; i < Ler().GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(Ler()[i, 0]);

                item.SubItems.Add(Ler()[i, 1]);
                item.SubItems.Add(Ler()[i, 2]);
                item.SubItems.Add(Ler()[i, 3]);

                if (Ler()[i, 4] == "Pendente")
                {
                    // Adiciona item na lista
                    lstPendentes.Items.Add(item);
                    // Adiciona nome do item a ser concluído na ComboBox
                    cbConcluir.Items.Add(Ler()[i, 0]);
                }
                else
                {
                    // Adiciona item na lista
                    lstFeitas.Items.Add(item);
                }

                // Adiciona todos os itens disponíveis na ComboBox
                cbDeletar.Items.Add(Ler()[i, 0]);
            }
        }
        // Cria uma nova tarefa, com o status "Pendente"
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
        // Deleta uma tarefa. Salva o array bidimensional, apaga todos os dados do txt, e reescreve o array no txt, exceto a linha da tarefa que foi excluída.
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(cbDeletar.SelectedIndex != 0)
            {
                string[,] tarefas = Ler();

                File.WriteAllText(caminho, string.Empty);

                for (int i = 0; i < tarefas.GetLength(0); i++)
                {
                    if(tarefas[i, 0] != cbDeletar.Text)
                    {
                    using (StreamWriter writer = new StreamWriter(caminho, true))
                        {
                            writer.WriteLine($"{tarefas[i, 0]},{tarefas[i, 1]},{tarefas[i, 2]},{tarefas[i, 3]},{tarefas[i, 4]}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Especifique o tipo da tarefa!");
            }

            Atualizar();
            cbDeletar.SelectedIndex = 0;
        }
        // Coloca uma tarefa como concluída. Salva o array bidimensional, apaga todos os dados do txt, e reescreve o array no txt, modificando o dado da coluna 5 da tarefa escolhida como "Concluído".
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (cbConcluir.SelectedIndex != 0)
            {
                string[,] tarefas = Ler();

                File.WriteAllText(caminho, string.Empty);

                for (int i = 0; i < tarefas.GetLength(0); i++)
                {
                    if (tarefas[i, 0] == cbConcluir.Text)
                    {
                        using (StreamWriter writer = new StreamWriter(caminho, true))
                        {
                            writer.WriteLine($"{tarefas[i, 0]},{tarefas[i, 1]},{tarefas[i, 2]},{tarefas[i, 3]},Concluído");
                        }
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(caminho, true))
                        {
                            writer.WriteLine($"{tarefas[i, 0]},{tarefas[i, 1]},{tarefas[i, 2]},{tarefas[i, 3]},{tarefas[i, 4]}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Especifique o tipo da tarefa!");
            }

            Atualizar();
            cbConcluir.SelectedIndex = 0;
        }
    }
}