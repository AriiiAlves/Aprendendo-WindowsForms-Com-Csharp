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

        private void btnVírgula_Click(object sender, EventArgs e)
        {
            bool ignore = false;

            foreach(char c in strnumber)
            {
                if (c == '.')
                {
                    ignore = true;
                }
            }

            if (ignore == false)
            {
                strnumber += ".";
            }

            lblVisor.Text = strnumber;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            strnumber = "0";
            total = 0;
            lblVisor.Text = strnumber;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
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
                    total /= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }
            lblVisor.Text = strnumber;
            nextoperation = "+";
            strnumber = "0";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
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
                    total /= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }
            lblVisor.Text = strnumber;
            nextoperation = "-";
            strnumber = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
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
                    total /= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }
            lblVisor.Text = strnumber;
            nextoperation = "/";
            strnumber = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
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
                    total /= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }
            lblVisor.Text = strnumber;
            nextoperation = "*";
            strnumber = "0";
        }

        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
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
                    total /= double.Parse(strnumber);
                    nextoperation = "N/A";
                    break;
                default:
                    break;
            }

            lblVisor.Text = $"{total}";
            total = 0;
        }
    }
}