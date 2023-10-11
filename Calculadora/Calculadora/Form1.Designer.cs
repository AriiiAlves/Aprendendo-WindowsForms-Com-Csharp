namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVisor = new Label();
            btn7 = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn1 = new Button();
            btn9 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnLimpar = new Button();
            btnDividir = new Button();
            btnAdicionar = new Button();
            btnVírgula = new Button();
            btnMultiplicar = new Button();
            btnSubtrair = new Button();
            btnCalcularResultado = new Button();
            SuspendLayout();
            // 
            // lblVisor
            // 
            lblVisor.BackColor = SystemColors.ButtonShadow;
            lblVisor.BorderStyle = BorderStyle.Fixed3D;
            lblVisor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblVisor.ForeColor = SystemColors.ControlLightLight;
            lblVisor.Location = new Point(45, 45);
            lblVisor.Name = "lblVisor";
            lblVisor.Size = new Size(256, 42);
            lblVisor.TabIndex = 1;
            lblVisor.Text = "0";
            lblVisor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.Control;
            btn7.Cursor = Cursors.Hand;
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(45, 119);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 48);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Location = new Point(45, 173);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 48);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.Control;
            btn8.Cursor = Cursors.Hand;
            btn8.Location = new Point(112, 119);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 48);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Location = new Point(179, 173);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 48);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Location = new Point(112, 173);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 48);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Location = new Point(45, 227);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 48);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Location = new Point(179, 119);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 48);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Location = new Point(112, 227);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 48);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Location = new Point(179, 227);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 48);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Location = new Point(112, 283);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 48);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(45, 283);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(61, 48);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Cursor = Cursors.Hand;
            btnDividir.Location = new Point(243, 119);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(58, 48);
            btnDividir.TabIndex = 12;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(243, 283);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(58, 48);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnVírgula
            // 
            btnVírgula.Cursor = Cursors.Hand;
            btnVírgula.Location = new Point(179, 283);
            btnVírgula.Name = "btnVírgula";
            btnVírgula.Size = new Size(58, 48);
            btnVírgula.TabIndex = 14;
            btnVírgula.Text = ",";
            btnVírgula.UseVisualStyleBackColor = true;
            btnVírgula.Click += btnVírgula_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Cursor = Cursors.Hand;
            btnMultiplicar.Location = new Point(243, 173);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(58, 48);
            btnMultiplicar.TabIndex = 15;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Cursor = Cursors.Hand;
            btnSubtrair.Location = new Point(243, 227);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(58, 48);
            btnSubtrair.TabIndex = 16;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnCalcularResultado
            // 
            btnCalcularResultado.Cursor = Cursors.Hand;
            btnCalcularResultado.Location = new Point(243, 337);
            btnCalcularResultado.Name = "btnCalcularResultado";
            btnCalcularResultado.Size = new Size(58, 48);
            btnCalcularResultado.TabIndex = 17;
            btnCalcularResultado.Text = "=";
            btnCalcularResultado.UseVisualStyleBackColor = true;
            btnCalcularResultado.Click += btnCalcularResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(339, 416);
            Controls.Add(btnCalcularResultado);
            Controls.Add(btnSubtrair);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnVírgula);
            Controls.Add(btnAdicionar);
            Controls.Add(btnDividir);
            Controls.Add(btnLimpar);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn9);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(lblVisor);
            Controls.Add(btn7);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
        }

        #endregion

        private Label lblVisor;
        private Button btn7;
        private Button btn4;
        private Button btn8;
        private Button btn6;
        private Button btn5;
        private Button btn1;
        private Button btn9;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnLimpar;
        private Button btnDividir;
        private Button btnAdicionar;
        private Button btnVírgula;
        private Button btnMultiplicar;
        private Button btnSubtrair;
        private Button btnCalcularResultado;
    }
}