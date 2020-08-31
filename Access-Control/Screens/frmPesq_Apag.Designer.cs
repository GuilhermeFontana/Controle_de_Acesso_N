namespace Neomot_Access_Control.Screens {
    partial class FrmPesq_Apag {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesq_Apag));
            this.lblInfo = new System.Windows.Forms.Label();
            this.chkBoxNome = new System.Windows.Forms.CheckBox();
            this.chkBoxCPF = new System.Windows.Forms.CheckBox();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGVPessoas = new System.Windows.Forms.DataGridView();
            this.colNmPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPFPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.pnlApagar = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPesquisarA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.pnlApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblInfo.Location = new System.Drawing.Point(74, 143);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 20);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Todos Usuários";
            // 
            // chkBoxNome
            // 
            this.chkBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxNome.AutoSize = true;
            this.chkBoxNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxNome.Location = new System.Drawing.Point(622, 504);
            this.chkBoxNome.Name = "chkBoxNome";
            this.chkBoxNome.Size = new System.Drawing.Size(15, 14);
            this.chkBoxNome.TabIndex = 16;
            this.chkBoxNome.UseVisualStyleBackColor = true;
            // 
            // chkBoxCPF
            // 
            this.chkBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxCPF.AutoSize = true;
            this.chkBoxCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxCPF.Location = new System.Drawing.Point(622, 575);
            this.chkBoxCPF.Name = "chkBoxCPF";
            this.chkBoxCPF.Size = new System.Drawing.Size(15, 14);
            this.chkBoxCPF.TabIndex = 15;
            this.chkBoxCPF.UseVisualStyleBackColor = true;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxCPF.Location = new System.Drawing.Point(131, 565);
            this.txtBoxCPF.MaxLength = 14;
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(232, 26);
            this.txtBoxCPF.TabIndex = 20;
            this.txtBoxCPF.Text = "___.___.___-__";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxNome.Location = new System.Drawing.Point(131, 497);
            this.txtBoxNome.MaxLength = 100;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(462, 26);
            this.txtBoxNome.TabIndex = 19;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(456, 39);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(318, 39);
            this.lblTituloPrincipal.TabIndex = 21;
            this.lblTituloPrincipal.Text = "Pesquisar Usuário";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblNome.Location = new System.Drawing.Point(74, 499);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCPF.Location = new System.Drawing.Point(74, 571);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(76, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(175, 60);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dataGVPessoas
            // 
            this.dataGVPessoas.AllowUserToAddRows = false;
            this.dataGVPessoas.AllowUserToDeleteRows = false;
            this.dataGVPessoas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGVPessoas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNmPessoa,
            this.colCPFPessoa,
            this.colTipoPessoa});
            this.dataGVPessoas.Location = new System.Drawing.Point(78, 166);
            this.dataGVPessoas.Name = "dataGVPessoas";
            this.dataGVPessoas.ReadOnly = true;
            this.dataGVPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGVPessoas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGVPessoas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.dataGVPessoas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.dataGVPessoas.Size = new System.Drawing.Size(1109, 280);
            this.dataGVPessoas.TabIndex = 25;
            // 
            // colNmPessoa
            // 
            this.colNmPessoa.HeaderText = "Nome";
            this.colNmPessoa.Name = "colNmPessoa";
            this.colNmPessoa.ReadOnly = true;
            this.colNmPessoa.Width = 540;
            // 
            // colCPFPessoa
            // 
            this.colCPFPessoa.HeaderText = "CPF";
            this.colCPFPessoa.Name = "colCPFPessoa";
            this.colCPFPessoa.ReadOnly = true;
            this.colCPFPessoa.Width = 225;
            // 
            // colTipoPessoa
            // 
            this.colTipoPessoa.HeaderText = "Tipo";
            this.colTipoPessoa.Name = "colTipoPessoa";
            this.colTipoPessoa.ReadOnly = true;
            this.colTipoPessoa.Width = 300;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.Image = global::Neomot_Access_Control.Properties.Resources.Logo_neomot;
            this.picBoxLogo.Location = new System.Drawing.Point(1122, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(130, 50);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 26;
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
            this.menuStrip.TabIndex = 42;
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
            // pnlPesquisar
            // 
            this.pnlPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Location = new System.Drawing.Point(784, 478);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(327, 146);
            this.pnlPesquisar.TabIndex = 43;
            // 
            // pnlApagar
            // 
            this.pnlApagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlApagar.Controls.Add(this.btnApagar);
            this.pnlApagar.Controls.Add(this.btnPesquisarA);
            this.pnlApagar.Location = new System.Drawing.Point(772, 456);
            this.pnlApagar.Name = "pnlApagar";
            this.pnlApagar.Size = new System.Drawing.Size(357, 168);
            this.pnlApagar.TabIndex = 44;
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(88, 100);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(175, 45);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarA
            // 
            this.btnPesquisarA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnPesquisarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarA.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarA.Location = new System.Drawing.Point(88, 32);
            this.btnPesquisarA.Name = "btnPesquisarA";
            this.btnPesquisarA.Size = new System.Drawing.Size(175, 45);
            this.btnPesquisarA.TabIndex = 26;
            this.btnPesquisarA.Text = "Pesquisar";
            this.btnPesquisarA.UseVisualStyleBackColor = false;
            // 
            // FrmPesq_Apag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlApagar);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGVPessoas);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.txtBoxCPF);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkBoxNome);
            this.Controls.Add(this.chkBoxCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmPesq_Apag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPesq_Apag_FormClosing);
            this.Shown += new System.EventHandler(this.FrmPesq_Apag_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlApagar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkBoxNome;
        private System.Windows.Forms.CheckBox chkBoxCPF;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGVPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPFPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPessoa;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem pgInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.Panel pnlApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPesquisarA;
    }
}