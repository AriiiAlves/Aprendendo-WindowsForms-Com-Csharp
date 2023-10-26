namespace Lista_de_Tarefas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.DateTimePicker();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.DateTimePicker();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPendentes = new System.Windows.Forms.ListView();
            this.lstPendenteTarefa = new System.Windows.Forms.ColumnHeader();
            this.lstPendenteTipo = new System.Windows.Forms.ColumnHeader();
            this.lstPendenteDia = new System.Windows.Forms.ColumnHeader();
            this.lstPendenteHora = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstFeitas = new System.Windows.Forms.ListView();
            this.lstFeitaTarefa = new System.Windows.Forms.ColumnHeader();
            this.lstFeitaTipo = new System.Windows.Forms.ColumnHeader();
            this.lstFeitaDia = new System.Windows.Forms.ColumnHeader();
            this.lstFeitaHora = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Tarefas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarefa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.txtTarefa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(47, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Nova";
            // 
            // txtHora
            // 
            this.txtHora.CustomFormat = "00:00";
            this.txtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora.Location = new System.Drawing.Point(64, 136);
            this.txtHora.Name = "txtHora";
            this.txtHora.ShowUpDown = true;
            this.txtHora.Size = new System.Drawing.Size(121, 23);
            this.txtHora.TabIndex = 14;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(129, 194);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 13;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dia ";
            // 
            // txtDia
            // 
            this.txtDia.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDia.Location = new System.Drawing.Point(64, 105);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(121, 23);
            this.txtDia.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Selecione um tipo",
            "Evento",
            "Trabalho",
            "Estudos",
            "Curso"});
            this.txtTipo.Location = new System.Drawing.Point(64, 71);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 23);
            this.txtTipo.TabIndex = 9;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(64, 36);
            this.txtTarefa.Multiline = true;
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(235, 23);
            this.txtTarefa.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstPendentes);
            this.groupBox2.Location = new System.Drawing.Point(375, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 344);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A Fazer";
            // 
            // lstPendentes
            // 
            this.lstPendentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstPendenteTarefa,
            this.lstPendenteTipo,
            this.lstPendenteDia,
            this.lstPendenteHora});
            this.lstPendentes.Location = new System.Drawing.Point(6, 22);
            this.lstPendentes.Name = "lstPendentes";
            this.lstPendentes.Size = new System.Drawing.Size(188, 316);
            this.lstPendentes.TabIndex = 0;
            this.lstPendentes.UseCompatibleStateImageBehavior = false;
            this.lstPendentes.View = System.Windows.Forms.View.Details;
            // 
            // lstPendenteTarefa
            // 
            this.lstPendenteTarefa.Text = "Tarefa";
            // 
            // lstPendenteTipo
            // 
            this.lstPendenteTipo.Text = "Tipo";
            // 
            // lstPendenteDia
            // 
            this.lstPendenteDia.Text = "Dia";
            // 
            // lstPendenteHora
            // 
            this.lstPendenteHora.Text = "Hora";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstFeitas);
            this.groupBox3.Location = new System.Drawing.Point(588, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 344);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Completas";
            // 
            // lstFeitas
            // 
            this.lstFeitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstFeitaTarefa,
            this.lstFeitaTipo,
            this.lstFeitaDia,
            this.lstFeitaHora});
            this.lstFeitas.Location = new System.Drawing.Point(6, 22);
            this.lstFeitas.Name = "lstFeitas";
            this.lstFeitas.Size = new System.Drawing.Size(188, 316);
            this.lstFeitas.TabIndex = 1;
            this.lstFeitas.UseCompatibleStateImageBehavior = false;
            this.lstFeitas.View = System.Windows.Forms.View.Details;
            // 
            // lstFeitaTarefa
            // 
            this.lstFeitaTarefa.Text = "Tarefa";
            // 
            // lstFeitaTipo
            // 
            this.lstFeitaTipo.Text = "Tipo";
            // 
            // lstFeitaDia
            // 
            this.lstFeitaDia.Text = "Dia";
            // 
            // lstFeitaHora
            // 
            this.lstFeitaHora.Text = "Hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtTarefa;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView lstPendentes;
        private ColumnHeader lstPendenteTarefa;
        private Label label2;
        private DateTimePicker txtDia;
        private ComboBox txtTipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private ColumnHeader lstPendenteTipo;
        private ColumnHeader lstPendenteDia;
        private ColumnHeader lstPendenteHora;
        private ListView lstFeitas;
        private ColumnHeader lstFeitaTarefa;
        private ColumnHeader lstFeitaTipo;
        private ColumnHeader lstFeitaDia;
        private ColumnHeader lstFeitaHora;
        private Button btnCriar;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker txtHora;
    }
}