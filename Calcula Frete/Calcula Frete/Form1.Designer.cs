namespace Calcula_Frete
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
            this.cbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.cbCidadeCliente = new System.Windows.Forms.ComboBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarCadastro = new System.Windows.Forms.Button();
            this.rbInfoNo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rbInfoYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbTransporte = new System.Windows.Forms.PictureBox();
            this.cbCidadeDestino = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstadoDestino = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstadoOrigem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProfissionais = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTransporte = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblValorProfissionais = new System.Windows.Forms.Label();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.lblValorTransporte = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCidadeDestino = new System.Windows.Forms.Label();
            this.lblEstadoDestino = new System.Windows.Forms.Label();
            this.lblCidadeOrigem = new System.Windows.Forms.Label();
            this.lblEstadoOrigem = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransporte)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEstadoCliente
            // 
            this.cbEstadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCliente.FormattingEnabled = true;
            this.cbEstadoCliente.Items.AddRange(new object[] {
            "N/A",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbEstadoCliente.Location = new System.Drawing.Point(26, 97);
            this.cbEstadoCliente.Name = "cbEstadoCliente";
            this.cbEstadoCliente.Size = new System.Drawing.Size(212, 23);
            this.cbEstadoCliente.TabIndex = 0;
            // 
            // cbCidadeCliente
            // 
            this.cbCidadeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeCliente.FormattingEnabled = true;
            this.cbCidadeCliente.Items.AddRange(new object[] {
            "N/A",
            "Cidade 1",
            "Cidade 2",
            "Cidade 3"});
            this.cbCidadeCliente.Location = new System.Drawing.Point(26, 148);
            this.cbCidadeCliente.Name = "cbCidadeCliente";
            this.cbCidadeCliente.Size = new System.Drawing.Size(212, 23);
            this.cbCidadeCliente.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(26, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(212, 23);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviarCadastro);
            this.groupBox1.Controls.Add(this.rbInfoNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rbInfoYes);
            this.groupBox1.Controls.Add(this.cbEstadoCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCidadeCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 281);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnEnviarCadastro
            // 
            this.btnEnviarCadastro.Location = new System.Drawing.Point(98, 245);
            this.btnEnviarCadastro.Name = "btnEnviarCadastro";
            this.btnEnviarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarCadastro.TabIndex = 9;
            this.btnEnviarCadastro.Text = "Enviar";
            this.btnEnviarCadastro.UseVisualStyleBackColor = true;
            this.btnEnviarCadastro.Click += new System.EventHandler(this.btnEnviarCadastro_Click);
            // 
            // rbInfoNo
            // 
            this.rbInfoNo.AutoSize = true;
            this.rbInfoNo.Location = new System.Drawing.Point(77, 204);
            this.rbInfoNo.Name = "rbInfoNo";
            this.rbInfoNo.Size = new System.Drawing.Size(47, 19);
            this.rbInfoNo.TabIndex = 8;
            this.rbInfoNo.TabStop = true;
            this.rbInfoNo.Text = "Não";
            this.rbInfoNo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Usar informações do cadastro no pedido?";
            // 
            // rbInfoYes
            // 
            this.rbInfoYes.AutoSize = true;
            this.rbInfoYes.Location = new System.Drawing.Point(26, 204);
            this.rbInfoYes.Name = "rbInfoYes";
            this.rbInfoYes.Size = new System.Drawing.Size(45, 19);
            this.rbInfoYes.TabIndex = 6;
            this.rbInfoYes.TabStop = true;
            this.rbInfoYes.Text = "Sim";
            this.rbInfoYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbTransporte);
            this.groupBox2.Controls.Add(this.cbCidadeDestino);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbEstadoDestino);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbEstadoOrigem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbCidadeOrigem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbProfissionais);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbTransporte);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 281);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // pbTransporte
            // 
            this.pbTransporte.Image = global::Calcula_Frete.Properties.Resources.tamanho_p;
            this.pbTransporte.Location = new System.Drawing.Point(29, 177);
            this.pbTransporte.Name = "pbTransporte";
            this.pbTransporte.Size = new System.Drawing.Size(195, 91);
            this.pbTransporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTransporte.TabIndex = 13;
            this.pbTransporte.TabStop = false;
            // 
            // cbCidadeDestino
            // 
            this.cbCidadeDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeDestino.FormattingEnabled = true;
            this.cbCidadeDestino.Items.AddRange(new object[] {
            "N/A",
            "Cidade 1",
            "Cidade 2",
            "Cidade 3"});
            this.cbCidadeDestino.Location = new System.Drawing.Point(186, 97);
            this.cbCidadeDestino.Name = "cbCidadeDestino";
            this.cbCidadeDestino.Size = new System.Drawing.Size(212, 23);
            this.cbCidadeDestino.TabIndex = 11;
            this.cbCidadeDestino.SelectedIndexChanged += new System.EventHandler(this.cbCidadeDestino_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cidade de destino";
            // 
            // cbEstadoDestino
            // 
            this.cbEstadoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoDestino.FormattingEnabled = true;
            this.cbEstadoDestino.Items.AddRange(new object[] {
            "N/A",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbEstadoDestino.Location = new System.Drawing.Point(29, 97);
            this.cbEstadoDestino.Name = "cbEstadoDestino";
            this.cbEstadoDestino.Size = new System.Drawing.Size(151, 23);
            this.cbEstadoDestino.TabIndex = 9;
            this.cbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cbEstadoDestino_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estado de destino";
            // 
            // cbEstadoOrigem
            // 
            this.cbEstadoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoOrigem.FormattingEnabled = true;
            this.cbEstadoOrigem.Items.AddRange(new object[] {
            "N/A",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbEstadoOrigem.Location = new System.Drawing.Point(29, 48);
            this.cbEstadoOrigem.Name = "cbEstadoOrigem";
            this.cbEstadoOrigem.Size = new System.Drawing.Size(151, 23);
            this.cbEstadoOrigem.TabIndex = 7;
            this.cbEstadoOrigem.SelectedIndexChanged += new System.EventHandler(this.cbEstadoOrigem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estado de origem";
            // 
            // cbCidadeOrigem
            // 
            this.cbCidadeOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeOrigem.FormattingEnabled = true;
            this.cbCidadeOrigem.Items.AddRange(new object[] {
            "N/A",
            "Cidade 1",
            "Cidade 2",
            "Cidade 3"});
            this.cbCidadeOrigem.Location = new System.Drawing.Point(186, 48);
            this.cbCidadeOrigem.Name = "cbCidadeOrigem";
            this.cbCidadeOrigem.Size = new System.Drawing.Size(212, 23);
            this.cbCidadeOrigem.TabIndex = 6;
            this.cbCidadeOrigem.SelectedIndexChanged += new System.EventHandler(this.cbCidadeOrigem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cidade de origem";
            // 
            // cbProfissionais
            // 
            this.cbProfissionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfissionais.FormattingEnabled = true;
            this.cbProfissionais.Items.AddRange(new object[] {
            "N/A",
            "1",
            "3",
            "5"});
            this.cbProfissionais.Location = new System.Drawing.Point(204, 148);
            this.cbProfissionais.Name = "cbProfissionais";
            this.cbProfissionais.Size = new System.Drawing.Size(169, 23);
            this.cbProfissionais.TabIndex = 3;
            this.cbProfissionais.SelectedIndexChanged += new System.EventHandler(this.cbProfissionais_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantidade de profissionais para empacotar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo de transporte";
            // 
            // cbTransporte
            // 
            this.cbTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransporte.FormattingEnabled = true;
            this.cbTransporte.Items.AddRange(new object[] {
            "N/A",
            "P",
            "M",
            "G"});
            this.cbTransporte.Location = new System.Drawing.Point(29, 148);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Size = new System.Drawing.Size(166, 23);
            this.cbTransporte.TabIndex = 0;
            this.cbTransporte.SelectedIndexChanged += new System.EventHandler(this.cbTransporte_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCidadeCliente);
            this.groupBox3.Controls.Add(this.lblEstadoCliente);
            this.groupBox3.Controls.Add(this.lblNomeCliente);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 178);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info cliente";
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Location = new System.Drawing.Point(27, 94);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCidadeCliente.TabIndex = 2;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Location = new System.Drawing.Point(26, 65);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoCliente.TabIndex = 1;
            this.lblEstadoCliente.Text = "Estado:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(26, 35);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(43, 15);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.btnTotal);
            this.groupBox4.Controls.Add(this.lblValorProfissionais);
            this.groupBox4.Controls.Add(this.lblValorFrete);
            this.groupBox4.Controls.Add(this.lblValorTransporte);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblCidadeDestino);
            this.groupBox4.Controls.Add(this.lblEstadoDestino);
            this.groupBox4.Controls.Add(this.lblCidadeOrigem);
            this.groupBox4.Controls.Add(this.lblEstadoOrigem);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(290, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 237);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orçamento";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(257, 191);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 27);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(46, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL:";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(127, 191);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(124, 27);
            this.btnTotal.TabIndex = 14;
            this.btnTotal.Text = "Calcular total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblValorProfissionais
            // 
            this.lblValorProfissionais.AutoSize = true;
            this.lblValorProfissionais.Location = new System.Drawing.Point(323, 133);
            this.lblValorProfissionais.Name = "lblValorProfissionais";
            this.lblValorProfissionais.Size = new System.Drawing.Size(76, 15);
            this.lblValorProfissionais.TabIndex = 12;
            this.lblValorProfissionais.Text = "Profissionais:";
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.AutoSize = true;
            this.lblValorFrete.Location = new System.Drawing.Point(204, 133);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(36, 15);
            this.lblValorFrete.TabIndex = 11;
            this.lblValorFrete.Text = "Frete:";
            // 
            // lblValorTransporte
            // 
            this.lblValorTransporte.AutoSize = true;
            this.lblValorTransporte.Location = new System.Drawing.Point(45, 133);
            this.lblValorTransporte.Name = "lblValorTransporte";
            this.lblValorTransporte.Size = new System.Drawing.Size(65, 15);
            this.lblValorTransporte.TabIndex = 10;
            this.lblValorTransporte.Text = "Transporte:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "VALOR";
            // 
            // lblCidadeDestino
            // 
            this.lblCidadeDestino.AutoSize = true;
            this.lblCidadeDestino.Location = new System.Drawing.Point(204, 92);
            this.lblCidadeDestino.Name = "lblCidadeDestino";
            this.lblCidadeDestino.Size = new System.Drawing.Size(47, 15);
            this.lblCidadeDestino.TabIndex = 8;
            this.lblCidadeDestino.Text = "Cidade:";
            // 
            // lblEstadoDestino
            // 
            this.lblEstadoDestino.AutoSize = true;
            this.lblEstadoDestino.Location = new System.Drawing.Point(43, 92);
            this.lblEstadoDestino.Name = "lblEstadoDestino";
            this.lblEstadoDestino.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoDestino.TabIndex = 7;
            this.lblEstadoDestino.Text = "Estado:";
            // 
            // lblCidadeOrigem
            // 
            this.lblCidadeOrigem.AutoSize = true;
            this.lblCidadeOrigem.Location = new System.Drawing.Point(204, 48);
            this.lblCidadeOrigem.Name = "lblCidadeOrigem";
            this.lblCidadeOrigem.Size = new System.Drawing.Size(47, 15);
            this.lblCidadeOrigem.TabIndex = 6;
            this.lblCidadeOrigem.Text = "Cidade:";
            // 
            // lblEstadoOrigem
            // 
            this.lblEstadoOrigem.AutoSize = true;
            this.lblEstadoOrigem.Location = new System.Drawing.Point(43, 48);
            this.lblEstadoOrigem.Name = "lblEstadoOrigem";
            this.lblEstadoOrigem.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoOrigem.TabIndex = 5;
            this.lblEstadoOrigem.Text = "Estado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "DESTINO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "ORIGEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calcula Frete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransporte)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbEstadoCliente;
        private ComboBox cbCidadeCliente;
        private TextBox txtNomeCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbCidadeDestino;
        private Label label9;
        private ComboBox cbEstadoDestino;
        private Label label8;
        private ComboBox cbEstadoOrigem;
        private Label label7;
        private ComboBox cbCidadeOrigem;
        private Label label6;
        private ComboBox cbProfissionais;
        private Label label5;
        private Label label4;
        private ComboBox cbTransporte;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label13;
        private RadioButton rbInfoYes;
        private Label lblCidadeCliente;
        private Label lblEstadoCliente;
        private Label lblNomeCliente;
        private RadioButton rbInfoNo;
        private Label lblTotal;
        private Label lblValorProfissionais;
        private Label lblValorFrete;
        private Label lblValorTransporte;
        private Label label20;
        private Label lblCidadeDestino;
        private Label lblEstadoDestino;
        private Label lblCidadeOrigem;
        private Label lblEstadoOrigem;
        private Label label15;
        private Label label14;
        private Button btnEnviarCadastro;
        private PictureBox pbTransporte;
        private Button btnTotal;
        private Button btnLimpar;
    }
}