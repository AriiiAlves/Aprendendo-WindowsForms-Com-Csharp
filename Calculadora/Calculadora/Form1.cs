namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strnumber = "", nextoperation = "N/A";
        double total = 0, temp = 0;
        bool firstop = true;
        private void btn0_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "0";
            }
            else
            {
                strnumber += "0";
            }
            lblVisor.Text = strnumber;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "1";
            }
            else
            {
                strnumber += "1";
            }
            lblVisor.Text = strnumber;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "2";
            }
            else
            {
                strnumber += "2";
            }
            lblVisor.Text = strnumber;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "3";
            }
            else
            {
                strnumber += "3";
            }
            lblVisor.Text = strnumber;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "4";
            }
            else
            {
                strnumber += "4";
            }
            lblVisor.Text = strnumber;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "5";
            }
            else
            {
                strnumber += "5";
            }
            lblVisor.Text = strnumber;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "6";
            }
            else
            {
                strnumber += "6";
            }
            lblVisor.Text = strnumber;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "7";
            }
            else
            {
                strnumber += "7";
            }
            lblVisor.Text = strnumber;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "8";
            }
            else
            {
                strnumber += "8";
            }
            lblVisor.Text = strnumber;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (strnumber == "0")
            {
                strnumber = "9";
            }
            else
            {
                strnumber += "9";
            }
            lblVisor.Text = strnumber;
        }

        private void btnV�rgula_Click(object sender, EventArgs e)
        {
            bool ignore = false;

            // Verifica se o n�mero digitado j� possui n�meros ap�s a v�rgula
            foreach (char c in strnumber)
            {
                if (c == ',')
                {
                    ignore = true;
                }
            }

            // Adiciona a v�rgula
            if (ignore == false)
            {
                strnumber += ",";
            }

            // Mostra n�mero no visor
            lblVisor.Text = strnumber;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa todos os dados e mostra no visor
            strnumber = "0";
            total = 0;
            firstop = true;
            lblVisor.Text = strnumber;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Se essa � a primeira opera��o a ser realizada, o primeiro n�mero da opera��o � adicionado ao total
            if (firstop)
            {
                nextoperation = "+";
                firstop = false;
            }

            // Verifica se h� uma opera��o pendente e a executa
            switch (nextoperation)
            {
                case "+":
                    total += double.Parse(strnumber);
                    break;
                case "-":
                    total -= double.Parse(strnumber);
                    break;
                case "*":
                    total *= double.Parse(strnumber);
                    break;
                case "/":
                    // Tratamento da divis�o por zero
                    if (double.Parse(strnumber) == 0)
                    {
                        strnumber = "Divis�o por zero!";
                    }
                    else
                    {
                        total /= double.Parse(strnumber);
                    }
                    break;
                default:
                    break;
            }

            // Se o total � nulo, o valor mostrado � o n�mero digitado anteriormente. Se n�o, � mostrado o total
            if (total == 0)
            {
                lblVisor.Text = $"{strnumber}";
            }
            else
            {
                lblVisor.Text = $"{total}";
            }

            // Definindo pr�xima opera��o e resetando o n�mero do visor
            nextoperation = "+";
            strnumber = "0";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            // Se essa � a primeira opera��o a ser realizada, o primeiro n�mero da opera��o � adicionado ao total
            if (firstop)
            {
                nextoperation = "+";
                firstop = false;
            }

            // Verifica se h� uma opera��o pendente e a executa
            switch (nextoperation)
            {
                case "+":
                    total += double.Parse(strnumber);
                    break;
                case "-":
                    total -= double.Parse(strnumber);
                    break;
                case "*":
                    total *= double.Parse(strnumber);
                    break;
                case "/":
                    // Tratamento da divis�o por zero
                    if (double.Parse(strnumber) == 0)
                    {
                        strnumber = "Divis�o por zero!";
                    }
                    else
                    {
                        total /= double.Parse(strnumber);
                    }
                    break;
                default:
                    break;
            }

            // Se o total � nulo, o valor mostrado � o n�mero digitado anteriormente. Se n�o, � mostrado o total
            // Mostra mensagem de erro se ela for emitida e depois redefine a strnumber para 0
            if (strnumber == "Divis�o por zero!" || total == 0)
            {
                lblVisor.Text = $"{strnumber}";
            }
            else
            {
                lblVisor.Text = $"{total}";
            }

            // Definindo pr�xima opera��o e resetando o n�mero do visor
            nextoperation = "-";
            strnumber = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Se essa � a primeira opera��o a ser realizada, o primeiro n�mero da opera��o � adicionado ao total
            if (firstop)
            {
                nextoperation = "+";
                firstop = false;
            }

            // Verifica se h� uma opera��o pendente e a executa
            switch (nextoperation)
            {
                case "+":
                    total += double.Parse(strnumber);
                    break;
                case "-":
                    total -= double.Parse(strnumber);
                    break;
                case "*":
                    total *= double.Parse(strnumber);
                    break;
                case "/":
                    // Tratamento da divis�o por zero
                    if (double.Parse(strnumber) == 0)
                    {
                        strnumber = "Divis�o por zero!";
                    }
                    else
                    {
                        total /= double.Parse(strnumber);
                    }
                    break;
                default:
                    break;
            }

            // Se o total � nulo, o valor mostrado � o n�mero digitado anteriormente. Se n�o, � mostrado o total
            // Mostra mensagem de erro se ela for emitida e depois redefine a strnumber para 0
            if (strnumber == "Divis�o por zero!" || total == 0)
            {
                lblVisor.Text = $"{strnumber}";
            }
            else
            {
                lblVisor.Text = $"{total}";
            }

            // Definindo pr�xima opera��o e resetando o n�mero do visor
            nextoperation = "/";
            strnumber = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Se essa � a primeira opera��o a ser realizada, o primeiro n�mero da opera��o � adicionado ao total
            if (firstop)
            {
                nextoperation = "+";
                firstop = false;
            }

            // Verifica se h� uma opera��o pendente e a executa
            switch (nextoperation)
            {
                case "+":
                    total += double.Parse(strnumber);
                    break;
                case "-":
                    total -= double.Parse(strnumber);
                    break;
                case "*":
                    total *= double.Parse(strnumber);
                    break;
                case "/":
                    // Tratamento da divis�o por zero
                    if (double.Parse(strnumber) == 0)
                    {
                        strnumber = "Divis�o por zero!";
                    }
                    else
                    {
                        total /= double.Parse(strnumber);
                    }
                    break;
                default:
                    break;
            }

            // Se o total � nulo, o valor mostrado � o n�mero digitado anteriormente. Se n�o, � mostrado o total
            // Mostra mensagem de erro se ela for emitida e depois redefine a strnumber para 0
            if (strnumber == "Divis�o por zero!" || total == 0)
            {
                lblVisor.Text = $"{strnumber}";
            }
            else
            {
                lblVisor.Text = $"{total}";
            }

            // Definindo pr�xima opera��o e resetando o n�mero do visor
            nextoperation = "*";
            strnumber = "0";
        }

        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
            // Verifica se h� uma opera��o pendente e a executa
            switch (nextoperation)
            {
                case "+":
                    total += double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                case "-":
                    total -= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                case "*":
                    total *= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                case "/":
                    // Tratamento da divis�o por zero
                    if (double.Parse(strnumber) == 0)
                    {
                        strnumber = "Divis�o por zero!";
                    }
                    else
                    {
                        total /= double.Parse(strnumber);
                    }
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }

            // Se o total � nulo, o valor mostrado � o n�mero digitado anteriormente. Se n�o, � mostrado o total
            // Se a mensagem de erro for emitida, a opera��o � ignorada e o usu�rio tem a oportunidade de realizar uma nova opera��o a partir do total j� existente
            if (strnumber == "Divis�o por zero!")
            {
                lblVisor.Text = $"{strnumber}";
            }
            else
            {
                lblVisor.Text = $"{total}";
            }

            // Mostrando total no visor
            strnumber = $"{total}";
        }
    }
}