namespace Cadastro
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
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.avisoNome = new System.Windows.Forms.Label();
            this.avisoCPF = new System.Windows.Forms.Label();
            this.avisoData = new System.Windows.Forms.Label();
            this.avisoTelefone = new System.Windows.Forms.Label();
            this.avisoCelular = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(75, 99);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(86, 23);
            this.mskCPF.TabIndex = 0;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(86, 160);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 23);
            this.mskTelefone.TabIndex = 7;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(86, 189);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(100, 23);
            this.mskCelular.TabIndex = 9;
            this.mskCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(149, 257);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(230, 257);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(274, 66);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(156, 118);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 12;
            this.pbImagem.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(316, 193);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // avisoNome
            // 
            this.avisoNome.AutoSize = true;
            this.avisoNome.ForeColor = System.Drawing.Color.Red;
            this.avisoNome.Location = new System.Drawing.Point(248, 69);
            this.avisoNome.Name = "avisoNome";
            this.avisoNome.Size = new System.Drawing.Size(10, 15);
            this.avisoNome.TabIndex = 14;
            this.avisoNome.Text = "!";
            this.avisoNome.Visible = false;
            // 
            // avisoCPF
            // 
            this.avisoCPF.AutoSize = true;
            this.avisoCPF.ForeColor = System.Drawing.Color.Red;
            this.avisoCPF.Location = new System.Drawing.Point(167, 107);
            this.avisoCPF.Name = "avisoCPF";
            this.avisoCPF.Size = new System.Drawing.Size(10, 15);
            this.avisoCPF.TabIndex = 15;
            this.avisoCPF.Text = "!";
            this.avisoCPF.Visible = false;
            // 
            // avisoData
            // 
            this.avisoData.AutoSize = true;
            this.avisoData.ForeColor = System.Drawing.Color.Red;
            this.avisoData.Location = new System.Drawing.Point(248, 140);
            this.avisoData.Name = "avisoData";
            this.avisoData.Size = new System.Drawing.Size(10, 15);
            this.avisoData.TabIndex = 16;
            this.avisoData.Text = "!";
            this.avisoData.Visible = false;
            // 
            // avisoTelefone
            // 
            this.avisoTelefone.AutoSize = true;
            this.avisoTelefone.ForeColor = System.Drawing.Color.Red;
            this.avisoTelefone.Location = new System.Drawing.Point(192, 168);
            this.avisoTelefone.Name = "avisoTelefone";
            this.avisoTelefone.Size = new System.Drawing.Size(10, 15);
            this.avisoTelefone.TabIndex = 17;
            this.avisoTelefone.Text = "!";
            this.avisoTelefone.Visible = false;
            // 
            // avisoCelular
            // 
            this.avisoCelular.AutoSize = true;
            this.avisoCelular.ForeColor = System.Drawing.Color.Red;
            this.avisoCelular.Location = new System.Drawing.Point(192, 197);
            this.avisoCelular.Name = "avisoCelular";
            this.avisoCelular.Size = new System.Drawing.Size(10, 15);
            this.avisoCelular.TabIndex = 18;
            this.avisoCelular.Text = "!";
            this.avisoCelular.Visible = false;
            // 
            // mskData
            // 
            this.mskData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskData.Location = new System.Drawing.Point(149, 132);
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(93, 23);
            this.mskData.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 304);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.avisoCelular);
            this.Controls.Add(this.avisoTelefone);
            this.Controls.Add(this.avisoData);
            this.Controls.Add(this.avisoCPF);
            this.Controls.Add(this.avisoNome);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mskCPF;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCelular;
        private Label label5;
        private Button btnSalvar;
        private Button btnLimpar;
        private PictureBox pbImagem;
        private Button btnUpload;
        private Label avisoNome;
        private Label avisoCPF;
        private Label avisoData;
        private Label avisoTelefone;
        private Label avisoCelular;
        private DateTimePicker mskData;
    }
}