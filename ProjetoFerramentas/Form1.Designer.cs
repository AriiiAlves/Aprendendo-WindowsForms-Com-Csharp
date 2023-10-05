namespace ProjetoFerramentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCheckbox = new System.Windows.Forms.Label();
            this.ckVerde = new System.Windows.Forms.CheckBox();
            this.ckAmarelo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRadioButton = new System.Windows.Forms.Label();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCheckbox);
            this.groupBox1.Controls.Add(this.ckVerde);
            this.groupBox1.Controls.Add(this.ckAmarelo);
            this.groupBox1.Location = new System.Drawing.Point(41, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheckBox";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCheckbox
            // 
            this.lblCheckbox.AutoSize = true;
            this.lblCheckbox.Location = new System.Drawing.Point(9, 70);
            this.lblCheckbox.Name = "lblCheckbox";
            this.lblCheckbox.Size = new System.Drawing.Size(75, 15);
            this.lblCheckbox.TabIndex = 2;
            this.lblCheckbox.Text = "Votuporanga";
            // 
            // ckVerde
            // 
            this.ckVerde.AutoSize = true;
            this.ckVerde.Location = new System.Drawing.Point(9, 40);
            this.ckVerde.Margin = new System.Windows.Forms.Padding(2);
            this.ckVerde.Name = "ckVerde";
            this.ckVerde.Size = new System.Drawing.Size(55, 19);
            this.ckVerde.TabIndex = 1;
            this.ckVerde.Text = "Verde";
            this.ckVerde.UseVisualStyleBackColor = true;
            this.ckVerde.CheckedChanged += new System.EventHandler(this.ckVerde_CheckedChanged);
            // 
            // ckAmarelo
            // 
            this.ckAmarelo.AutoSize = true;
            this.ckAmarelo.Location = new System.Drawing.Point(9, 24);
            this.ckAmarelo.Margin = new System.Windows.Forms.Padding(2);
            this.ckAmarelo.Name = "ckAmarelo";
            this.ckAmarelo.Size = new System.Drawing.Size(71, 19);
            this.ckAmarelo.TabIndex = 0;
            this.ckAmarelo.Text = "Amarelo";
            this.ckAmarelo.UseVisualStyleBackColor = true;
            this.ckAmarelo.CheckedChanged += new System.EventHandler(this.ckAmarelo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRadioButton);
            this.groupBox2.Controls.Add(this.Feminino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Location = new System.Drawing.Point(264, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RadioButton";
            // 
            // lblRadioButton
            // 
            this.lblRadioButton.AutoSize = true;
            this.lblRadioButton.Location = new System.Drawing.Point(6, 70);
            this.lblRadioButton.Name = "lblRadioButton";
            this.lblRadioButton.Size = new System.Drawing.Size(75, 15);
            this.lblRadioButton.TabIndex = 3;
            this.lblRadioButton.Text = "Votuporanga";
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(5, 39);
            this.Feminino.Margin = new System.Windows.Forms.Padding(2);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(75, 19);
            this.Feminino.TabIndex = 1;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            this.Feminino.CheckedChanged += new System.EventHandler(this.Feminino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(5, 21);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(41, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ComboBox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 21);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.maskedTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(264, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Máscara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(5, 21);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 23);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblHora2);
            this.groupBox5.Location = new System.Drawing.Point(41, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Timer";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(78, 43);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(35, 15);
            this.lblHora2.TabIndex = 7;
            this.lblHora2.Text = "Nada";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Location = new System.Drawing.Point(264, 237);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calendário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(485, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 206);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Imagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblData,
            this.toolStripStatusLabel3,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Hoje é:";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(12, 17);
            this.lblData.Text = "?";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel3.Text = "||  E são:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(12, 17);
            this.lblHora.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ckVerde;
        private CheckBox ckAmarelo;
        private GroupBox groupBox2;
        private RadioButton Feminino;
        private RadioButton rbMasculino;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private ComboBox comboBox2;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private GroupBox groupBox7;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblHora;
        private DateTimePicker dateTimePicker1;
        private Label lblCheckbox;
        private Label lblRadioButton;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label lblHora2;
        private Label label7;
    }
}