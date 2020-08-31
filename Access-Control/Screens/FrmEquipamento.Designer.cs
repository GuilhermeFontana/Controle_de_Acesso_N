namespace Neomot_Access_Control.Screens {
    partial class FrmEquipamento {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEquipamentos_TesteConexao = new System.Windows.Forms.Label();
            this.lblTitulo_TesteConexao = new System.Windows.Forms.Label();
            this.cbBoxEquipamentos_TesteConexao = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLeitoras = new System.Windows.Forms.Label();
            this.cbBoxLeitoras = new System.Windows.Forms.ComboBox();
            this.lblTitulo_AcoesLeitoras = new System.Windows.Forms.Label();
            this.btnAbrirPorta2 = new System.Windows.Forms.Button();
            this.btnAbrirPorta1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSentidoGiroCatracas = new System.Windows.Forms.Label();
            this.lblCatracas = new System.Windows.Forms.Label();
            this.cbBoxCatracas = new System.Windows.Forms.ComboBox();
            this.cbBoxSentidoGiroCatracas = new System.Windows.Forms.ComboBox();
            this.lblTitulo_AcoesCatracas = new System.Windows.Forms.Label();
            this.btnAbrirUrnaCartoes = new System.Windows.Forms.Button();
            this.btnLiberarCatraca = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblEquipamentos_OutrasAcoes = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAjustarHoraDataEqpto = new System.Windows.Forms.Button();
            this.lblTitulo_OutrasAcoes = new System.Windows.Forms.Label();
            this.btnReiniciarEqpto = new System.Windows.Forms.Button();
            this.cbBoxEquipamentos_OutrasAcoes = new System.Windows.Forms.ComboBox();
            this.btnAgora = new System.Windows.Forms.Button();
            this.btnLerInfoEqpto = new System.Windows.Forms.Button();
            this.btnLerAcessoasEqpto = new System.Windows.Forms.Button();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.lblSaidaInfo = new System.Windows.Forms.Label();
            this.txtSaidaInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEquipamentos_TesteConexao);
            this.panel1.Controls.Add(this.lblTitulo_TesteConexao);
            this.panel1.Controls.Add(this.cbBoxEquipamentos_TesteConexao);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Location = new System.Drawing.Point(34, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 155);
            this.panel1.TabIndex = 0;
            // 
            // lblEquipamentos_TesteConexao
            // 
            this.lblEquipamentos_TesteConexao.AutoSize = true;
            this.lblEquipamentos_TesteConexao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblEquipamentos_TesteConexao.Location = new System.Drawing.Point(192, 54);
            this.lblEquipamentos_TesteConexao.Name = "lblEquipamentos_TesteConexao";
            this.lblEquipamentos_TesteConexao.Size = new System.Drawing.Size(74, 13);
            this.lblEquipamentos_TesteConexao.TabIndex = 25;
            this.lblEquipamentos_TesteConexao.Text = "Equipamentos";
            // 
            // lblTitulo_TesteConexao
            // 
            this.lblTitulo_TesteConexao.AutoSize = true;
            this.lblTitulo_TesteConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_TesteConexao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTitulo_TesteConexao.Location = new System.Drawing.Point(339, 12);
            this.lblTitulo_TesteConexao.Name = "lblTitulo_TesteConexao";
            this.lblTitulo_TesteConexao.Size = new System.Drawing.Size(135, 20);
            this.lblTitulo_TesteConexao.TabIndex = 5;
            this.lblTitulo_TesteConexao.Text = "Testar Conexão";
            // 
            // cbBoxEquipamentos_TesteConexao
            // 
            this.cbBoxEquipamentos_TesteConexao.FormattingEnabled = true;
            this.cbBoxEquipamentos_TesteConexao.Items.AddRange(new object[] {
            "iD Access 27",
            "iD Access 28",
            "iD Access 29",
            "iD Access 30",
            "iD Access 31",
            "iD Block 25",
            "iD Block 26"});
            this.cbBoxEquipamentos_TesteConexao.Location = new System.Drawing.Point(284, 46);
            this.cbBoxEquipamentos_TesteConexao.Name = "cbBoxEquipamentos_TesteConexao";
            this.cbBoxEquipamentos_TesteConexao.Size = new System.Drawing.Size(321, 21);
            this.cbBoxEquipamentos_TesteConexao.TabIndex = 1;
            this.cbBoxEquipamentos_TesteConexao.Text = "Selecione";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(195, 87);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(410, 53);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLeitoras);
            this.panel2.Controls.Add(this.cbBoxLeitoras);
            this.panel2.Controls.Add(this.lblTitulo_AcoesLeitoras);
            this.panel2.Controls.Add(this.btnAbrirPorta2);
            this.panel2.Controls.Add(this.btnAbrirPorta1);
            this.panel2.Location = new System.Drawing.Point(34, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 170);
            this.panel2.TabIndex = 1;
            // 
            // lblLeitoras
            // 
            this.lblLeitoras.AutoSize = true;
            this.lblLeitoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblLeitoras.Location = new System.Drawing.Point(9, 42);
            this.lblLeitoras.Name = "lblLeitoras";
            this.lblLeitoras.Size = new System.Drawing.Size(44, 13);
            this.lblLeitoras.TabIndex = 29;
            this.lblLeitoras.Text = "Leitoras";
            // 
            // cbBoxLeitoras
            // 
            this.cbBoxLeitoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cbBoxLeitoras.FormattingEnabled = true;
            this.cbBoxLeitoras.Items.AddRange(new object[] {
            "iD Access 27",
            "iD Access 28",
            "iD Access 29",
            "iD Access 30",
            "iD Access 31"});
            this.cbBoxLeitoras.Location = new System.Drawing.Point(12, 58);
            this.cbBoxLeitoras.Name = "cbBoxLeitoras";
            this.cbBoxLeitoras.Size = new System.Drawing.Size(307, 21);
            this.cbBoxLeitoras.TabIndex = 3;
            this.cbBoxLeitoras.Text = "Selecione";
            // 
            // lblTitulo_AcoesLeitoras
            // 
            this.lblTitulo_AcoesLeitoras.AutoSize = true;
            this.lblTitulo_AcoesLeitoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_AcoesLeitoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTitulo_AcoesLeitoras.Location = new System.Drawing.Point(91, 11);
            this.lblTitulo_AcoesLeitoras.Name = "lblTitulo_AcoesLeitoras";
            this.lblTitulo_AcoesLeitoras.Size = new System.Drawing.Size(163, 20);
            this.lblTitulo_AcoesLeitoras.TabIndex = 6;
            this.lblTitulo_AcoesLeitoras.Text = "Ações nas Leitoras";
            // 
            // btnAbrirPorta2
            // 
            this.btnAbrirPorta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnAbrirPorta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPorta2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirPorta2.ForeColor = System.Drawing.Color.White;
            this.btnAbrirPorta2.Location = new System.Drawing.Point(218, 109);
            this.btnAbrirPorta2.Name = "btnAbrirPorta2";
            this.btnAbrirPorta2.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirPorta2.TabIndex = 5;
            this.btnAbrirPorta2.Text = "Abrir Porta 2";
            this.btnAbrirPorta2.UseVisualStyleBackColor = false;
            this.btnAbrirPorta2.Click += new System.EventHandler(this.btnAbrirPorta2_Click);
            // 
            // btnAbrirPorta1
            // 
            this.btnAbrirPorta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnAbrirPorta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirPorta1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirPorta1.ForeColor = System.Drawing.Color.White;
            this.btnAbrirPorta1.Location = new System.Drawing.Point(12, 109);
            this.btnAbrirPorta1.Name = "btnAbrirPorta1";
            this.btnAbrirPorta1.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirPorta1.TabIndex = 4;
            this.btnAbrirPorta1.Text = "Abrir Porta 1";
            this.btnAbrirPorta1.UseVisualStyleBackColor = false;
            this.btnAbrirPorta1.Click += new System.EventHandler(this.btnAbrirPorta1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSentidoGiroCatracas);
            this.panel3.Controls.Add(this.lblCatracas);
            this.panel3.Controls.Add(this.cbBoxCatracas);
            this.panel3.Controls.Add(this.cbBoxSentidoGiroCatracas);
            this.panel3.Controls.Add(this.lblTitulo_AcoesCatracas);
            this.panel3.Controls.Add(this.btnAbrirUrnaCartoes);
            this.panel3.Controls.Add(this.btnLiberarCatraca);
            this.panel3.Location = new System.Drawing.Point(378, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 170);
            this.panel3.TabIndex = 2;
            // 
            // lblSentidoGiroCatracas
            // 
            this.lblSentidoGiroCatracas.AutoSize = true;
            this.lblSentidoGiroCatracas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblSentidoGiroCatracas.Location = new System.Drawing.Point(14, 119);
            this.lblSentidoGiroCatracas.Name = "lblSentidoGiroCatracas";
            this.lblSentidoGiroCatracas.Size = new System.Drawing.Size(80, 13);
            this.lblSentidoGiroCatracas.TabIndex = 31;
            this.lblSentidoGiroCatracas.Text = "Sentido de Giro";
            // 
            // lblCatracas
            // 
            this.lblCatracas.AutoSize = true;
            this.lblCatracas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCatracas.Location = new System.Drawing.Point(18, 39);
            this.lblCatracas.Name = "lblCatracas";
            this.lblCatracas.Size = new System.Drawing.Size(49, 13);
            this.lblCatracas.TabIndex = 30;
            this.lblCatracas.Text = "Catracas";
            // 
            // cbBoxCatracas
            // 
            this.cbBoxCatracas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cbBoxCatracas.FormattingEnabled = true;
            this.cbBoxCatracas.Items.AddRange(new object[] {
            "iD Block 25",
            "iD Block 26"});
            this.cbBoxCatracas.Location = new System.Drawing.Point(17, 58);
            this.cbBoxCatracas.Name = "cbBoxCatracas";
            this.cbBoxCatracas.Size = new System.Drawing.Size(354, 21);
            this.cbBoxCatracas.TabIndex = 6;
            this.cbBoxCatracas.Text = "Selecione";
            // 
            // cbBoxSentidoGiroCatracas
            // 
            this.cbBoxSentidoGiroCatracas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cbBoxSentidoGiroCatracas.FormattingEnabled = true;
            this.cbBoxSentidoGiroCatracas.ItemHeight = 13;
            this.cbBoxSentidoGiroCatracas.Items.AddRange(new object[] {
            "Ambos",
            "Anti-Horário",
            "Horário"});
            this.cbBoxSentidoGiroCatracas.Location = new System.Drawing.Point(17, 135);
            this.cbBoxSentidoGiroCatracas.Name = "cbBoxSentidoGiroCatracas";
            this.cbBoxSentidoGiroCatracas.Size = new System.Drawing.Size(159, 21);
            this.cbBoxSentidoGiroCatracas.TabIndex = 8;
            this.cbBoxSentidoGiroCatracas.Tag = "";
            this.cbBoxSentidoGiroCatracas.Text = "Ambos";
            // 
            // lblTitulo_AcoesCatracas
            // 
            this.lblTitulo_AcoesCatracas.AutoSize = true;
            this.lblTitulo_AcoesCatracas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_AcoesCatracas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTitulo_AcoesCatracas.Location = new System.Drawing.Point(94, 11);
            this.lblTitulo_AcoesCatracas.Name = "lblTitulo_AcoesCatracas";
            this.lblTitulo_AcoesCatracas.Size = new System.Drawing.Size(170, 20);
            this.lblTitulo_AcoesCatracas.TabIndex = 7;
            this.lblTitulo_AcoesCatracas.Text = "Ações nas Catracas";
            // 
            // btnAbrirUrnaCartoes
            // 
            this.btnAbrirUrnaCartoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnAbrirUrnaCartoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirUrnaCartoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirUrnaCartoes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirUrnaCartoes.Location = new System.Drawing.Point(189, 90);
            this.btnAbrirUrnaCartoes.Name = "btnAbrirUrnaCartoes";
            this.btnAbrirUrnaCartoes.Size = new System.Drawing.Size(182, 23);
            this.btnAbrirUrnaCartoes.TabIndex = 7;
            this.btnAbrirUrnaCartoes.Text = "Abrir Urna Coletora de Cartões";
            this.btnAbrirUrnaCartoes.UseVisualStyleBackColor = false;
            this.btnAbrirUrnaCartoes.Click += new System.EventHandler(this.btnAbrirUrnaCartoes_Click);
            // 
            // btnLiberarCatraca
            // 
            this.btnLiberarCatraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnLiberarCatraca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiberarCatraca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLiberarCatraca.ForeColor = System.Drawing.Color.White;
            this.btnLiberarCatraca.Location = new System.Drawing.Point(189, 133);
            this.btnLiberarCatraca.Name = "btnLiberarCatraca";
            this.btnLiberarCatraca.Size = new System.Drawing.Size(75, 23);
            this.btnLiberarCatraca.TabIndex = 9;
            this.btnLiberarCatraca.Text = "Liberar";
            this.btnLiberarCatraca.UseVisualStyleBackColor = false;
            this.btnLiberarCatraca.Click += new System.EventHandler(this.btnLiberarCatraca_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblDataHora);
            this.panel4.Controls.Add(this.lblEquipamentos_OutrasAcoes);
            this.panel4.Controls.Add(this.dateTimePicker);
            this.panel4.Controls.Add(this.btnAjustarHoraDataEqpto);
            this.panel4.Controls.Add(this.lblTitulo_OutrasAcoes);
            this.panel4.Controls.Add(this.btnReiniciarEqpto);
            this.panel4.Controls.Add(this.cbBoxEquipamentos_OutrasAcoes);
            this.panel4.Controls.Add(this.btnAgora);
            this.panel4.Controls.Add(this.btnLerInfoEqpto);
            this.panel4.Controls.Add(this.btnLerAcessoasEqpto);
            this.panel4.Location = new System.Drawing.Point(805, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 335);
            this.panel4.TabIndex = 30;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblDataHora.Location = new System.Drawing.Point(31, 218);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(58, 13);
            this.lblDataHora.TabIndex = 36;
            this.lblDataHora.Text = "Data/Hora";
            // 
            // lblEquipamentos_OutrasAcoes
            // 
            this.lblEquipamentos_OutrasAcoes.AutoSize = true;
            this.lblEquipamentos_OutrasAcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblEquipamentos_OutrasAcoes.Location = new System.Drawing.Point(31, 49);
            this.lblEquipamentos_OutrasAcoes.Name = "lblEquipamentos_OutrasAcoes";
            this.lblEquipamentos_OutrasAcoes.Size = new System.Drawing.Size(74, 13);
            this.lblEquipamentos_OutrasAcoes.TabIndex = 35;
            this.lblEquipamentos_OutrasAcoes.Text = "Equipamentos";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(95, 212);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // btnAjustarHoraDataEqpto
            // 
            this.btnAjustarHoraDataEqpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnAjustarHoraDataEqpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustarHoraDataEqpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjustarHoraDataEqpto.ForeColor = System.Drawing.Color.White;
            this.btnAjustarHoraDataEqpto.Location = new System.Drawing.Point(220, 241);
            this.btnAjustarHoraDataEqpto.Name = "btnAjustarHoraDataEqpto";
            this.btnAjustarHoraDataEqpto.Size = new System.Drawing.Size(117, 37);
            this.btnAjustarHoraDataEqpto.TabIndex = 15;
            this.btnAjustarHoraDataEqpto.Text = "Ajustar Data e Hora do Equipamento";
            this.btnAjustarHoraDataEqpto.UseVisualStyleBackColor = false;
            this.btnAjustarHoraDataEqpto.Click += new System.EventHandler(this.btnAjustarHoraDataEqpto_Click);
            // 
            // lblTitulo_OutrasAcoes
            // 
            this.lblTitulo_OutrasAcoes.AutoSize = true;
            this.lblTitulo_OutrasAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_OutrasAcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTitulo_OutrasAcoes.Location = new System.Drawing.Point(161, 12);
            this.lblTitulo_OutrasAcoes.Name = "lblTitulo_OutrasAcoes";
            this.lblTitulo_OutrasAcoes.Size = new System.Drawing.Size(118, 20);
            this.lblTitulo_OutrasAcoes.TabIndex = 8;
            this.lblTitulo_OutrasAcoes.Text = "Outras Ações";
            // 
            // btnReiniciarEqpto
            // 
            this.btnReiniciarEqpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnReiniciarEqpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciarEqpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReiniciarEqpto.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarEqpto.Location = new System.Drawing.Point(34, 298);
            this.btnReiniciarEqpto.Name = "btnReiniciarEqpto";
            this.btnReiniciarEqpto.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciarEqpto.TabIndex = 16;
            this.btnReiniciarEqpto.Text = "Reiniciar Equipamento";
            this.btnReiniciarEqpto.UseVisualStyleBackColor = false;
            this.btnReiniciarEqpto.Click += new System.EventHandler(this.btnReiniciarEqpto_Click);
            // 
            // cbBoxEquipamentos_OutrasAcoes
            // 
            this.cbBoxEquipamentos_OutrasAcoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cbBoxEquipamentos_OutrasAcoes.FormattingEnabled = true;
            this.cbBoxEquipamentos_OutrasAcoes.Items.AddRange(new object[] {
            "iD Access 27",
            "iD Access 28",
            "iD Access 29",
            "iD Access 30",
            "iD Access 31",
            "iD Block 25",
            "iD Block 26"});
            this.cbBoxEquipamentos_OutrasAcoes.Location = new System.Drawing.Point(34, 65);
            this.cbBoxEquipamentos_OutrasAcoes.Name = "cbBoxEquipamentos_OutrasAcoes";
            this.cbBoxEquipamentos_OutrasAcoes.Size = new System.Drawing.Size(321, 21);
            this.cbBoxEquipamentos_OutrasAcoes.TabIndex = 10;
            this.cbBoxEquipamentos_OutrasAcoes.Text = "Selecione";
            // 
            // btnAgora
            // 
            this.btnAgora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnAgora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgora.ForeColor = System.Drawing.Color.White;
            this.btnAgora.Location = new System.Drawing.Point(33, 241);
            this.btnAgora.Name = "btnAgora";
            this.btnAgora.Size = new System.Drawing.Size(75, 23);
            this.btnAgora.TabIndex = 14;
            this.btnAgora.Text = "Agora";
            this.btnAgora.UseVisualStyleBackColor = false;
            this.btnAgora.Click += new System.EventHandler(this.btnAgora_Click);
            // 
            // btnLerInfoEqpto
            // 
            this.btnLerInfoEqpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnLerInfoEqpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerInfoEqpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerInfoEqpto.ForeColor = System.Drawing.Color.White;
            this.btnLerInfoEqpto.Location = new System.Drawing.Point(34, 117);
            this.btnLerInfoEqpto.Name = "btnLerInfoEqpto";
            this.btnLerInfoEqpto.Size = new System.Drawing.Size(177, 23);
            this.btnLerInfoEqpto.TabIndex = 11;
            this.btnLerInfoEqpto.Text = "Ler Informações do Equipamento";
            this.btnLerInfoEqpto.UseVisualStyleBackColor = false;
            this.btnLerInfoEqpto.Click += new System.EventHandler(this.btnLerInfoEqpto_Click);
            // 
            // btnLerAcessoasEqpto
            // 
            this.btnLerAcessoasEqpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnLerAcessoasEqpto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerAcessoasEqpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerAcessoasEqpto.ForeColor = System.Drawing.Color.White;
            this.btnLerAcessoasEqpto.Location = new System.Drawing.Point(34, 147);
            this.btnLerAcessoasEqpto.Name = "btnLerAcessoasEqpto";
            this.btnLerAcessoasEqpto.Size = new System.Drawing.Size(177, 23);
            this.btnLerAcessoasEqpto.TabIndex = 12;
            this.btnLerAcessoasEqpto.Text = "Ler Acessos no Equipamento";
            this.btnLerAcessoasEqpto.UseVisualStyleBackColor = false;
            this.btnLerAcessoasEqpto.Click += new System.EventHandler(this.btnLerAcessoasEqpto_Click);
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(355, 23);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(559, 39);
            this.lblTituloPrincipal.TabIndex = 4;
            this.lblTituloPrincipal.Text = "OPÇÕES NOS EQUIPAMENTOS";
            // 
            // lblSaidaInfo
            // 
            this.lblSaidaInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaidaInfo.AutoSize = true;
            this.lblSaidaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblSaidaInfo.Location = new System.Drawing.Point(31, 437);
            this.lblSaidaInfo.Name = "lblSaidaInfo";
            this.lblSaidaInfo.Size = new System.Drawing.Size(100, 13);
            this.lblSaidaInfo.TabIndex = 9;
            this.lblSaidaInfo.Text = "Informações/Ações";
            // 
            // txtSaidaInfo
            // 
            this.txtSaidaInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaidaInfo.BackColor = System.Drawing.Color.White;
            this.txtSaidaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtSaidaInfo.Location = new System.Drawing.Point(34, 453);
            this.txtSaidaInfo.Multiline = true;
            this.txtSaidaInfo.Name = "txtSaidaInfo";
            this.txtSaidaInfo.ReadOnly = true;
            this.txtSaidaInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaidaInfo.Size = new System.Drawing.Size(1206, 216);
            this.txtSaidaInfo.TabIndex = 40;
            this.txtSaidaInfo.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.Image = global::Neomot_Access_Control.Properties.Resources.Logo_neomot;
            this.picBoxLogo.Location = new System.Drawing.Point(1122, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(130, 50);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 24;
            this.picBoxLogo.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogarToolStripMenuItem,
            this.pgInicialToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 41;
            this.menuStrip.Text = "menuStrip1";
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // pgInicialToolStripMenuItem
            // 
            this.pgInicialToolStripMenuItem.Name = "pgInicialToolStripMenuItem";
            this.pgInicialToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pgInicialToolStripMenuItem.Text = "Voltar";
            this.pgInicialToolStripMenuItem.Click += new System.EventHandler(this.pgInicialToolStripMenuItem_Click);
            // 
            // FrmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.txtSaidaInfo);
            this.Controls.Add(this.lblSaidaInfo);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmEquipamento";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEquipamento_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblTitulo_TesteConexao;
        private System.Windows.Forms.Label lblTitulo_AcoesLeitoras;
        private System.Windows.Forms.Label lblTitulo_AcoesCatracas;
        private System.Windows.Forms.Label lblTitulo_OutrasAcoes;
        private System.Windows.Forms.Label lblSaidaInfo;
        private System.Windows.Forms.TextBox txtSaidaInfo;
        private System.Windows.Forms.Label lblEquipamentos_TesteConexao;
        private System.Windows.Forms.ComboBox cbBoxEquipamentos_TesteConexao;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblLeitoras;
        private System.Windows.Forms.ComboBox cbBoxLeitoras;
        private System.Windows.Forms.Button btnAbrirPorta2;
        private System.Windows.Forms.Button btnAbrirPorta1;
        private System.Windows.Forms.Label lblCatracas;
        private System.Windows.Forms.ComboBox cbBoxCatracas;
        private System.Windows.Forms.ComboBox cbBoxSentidoGiroCatracas;
        private System.Windows.Forms.Button btnAbrirUrnaCartoes;
        private System.Windows.Forms.Button btnLiberarCatraca;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblEquipamentos_OutrasAcoes;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAjustarHoraDataEqpto;
        private System.Windows.Forms.Button btnReiniciarEqpto;
        private System.Windows.Forms.ComboBox cbBoxEquipamentos_OutrasAcoes;
        private System.Windows.Forms.Button btnAgora;
        private System.Windows.Forms.Button btnLerInfoEqpto;
        private System.Windows.Forms.Button btnLerAcessoasEqpto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblSentidoGiroCatracas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem pgInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
    }
}