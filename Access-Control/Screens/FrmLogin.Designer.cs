namespace Neomot_Access_Control {
    partial class FrmLogin {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblCadastrarUsuario = new System.Windows.Forms.Label();
            this.picBoxLogin = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.lblCancelarCadastro = new System.Windows.Forms.Label();
            this.lblCadastraSenhaUsuario2 = new System.Windows.Forms.Label();
            this.txtBoxSenhaCad2 = new System.Windows.Forms.TextBox();
            this.picBoxLoginCad = new System.Windows.Forms.PictureBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.txtBoxUsuarioCad = new System.Windows.Forms.TextBox();
            this.lblCadastraSenhaUsuario1 = new System.Windows.Forms.Label();
            this.txtBoxSenhaCad1 = new System.Windows.Forms.TextBox();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginCad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(143, 483);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(497, 68);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Logar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxLoginUsuario
            // 
            this.txtBoxLoginUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxLoginUsuario.Location = new System.Drawing.Point(242, 355);
            this.txtBoxLoginUsuario.Name = "txtBoxLoginUsuario";
            this.txtBoxLoginUsuario.Size = new System.Drawing.Size(398, 26);
            this.txtBoxLoginUsuario.TabIndex = 1;
            // 
            // txtBoxSenhaUsuario
            // 
            this.txtBoxSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxSenhaUsuario.Location = new System.Drawing.Point(242, 424);
            this.txtBoxSenhaUsuario.Name = "txtBoxSenhaUsuario";
            this.txtBoxSenhaUsuario.PasswordChar = '*';
            this.txtBoxSenhaUsuario.Size = new System.Drawing.Size(398, 26);
            this.txtBoxSenhaUsuario.TabIndex = 2;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblLoginUsuario.Location = new System.Drawing.Point(139, 361);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblLoginUsuario.TabIndex = 16;
            this.lblLoginUsuario.Text = "Usuário";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblSenhaLogin.Location = new System.Drawing.Point(139, 427);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(56, 20);
            this.lblSenhaLogin.TabIndex = 17;
            this.lblSenhaLogin.Text = "Senha";
            // 
            // lblCadastrarUsuario
            // 
            this.lblCadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastrarUsuario.AutoSize = true;
            this.lblCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCadastrarUsuario.Location = new System.Drawing.Point(535, 567);
            this.lblCadastrarUsuario.Name = "lblCadastrarUsuario";
            this.lblCadastrarUsuario.Size = new System.Drawing.Size(105, 17);
            this.lblCadastrarUsuario.TabIndex = 4;
            this.lblCadastrarUsuario.Text = "ou Cadastre-se";
            this.lblCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCadastrarUsuario.Click += new System.EventHandler(this.lblCadastrarUsuario_Click);
            this.lblCadastrarUsuario.MouseEnter += new System.EventHandler(this.lblCadastrarUsuario_MouseEnter);
            this.lblCadastrarUsuario.MouseLeave += new System.EventHandler(this.lblCadastrarUsuario_MouseLeave);
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLogin.Image = global::Neomot_Access_Control.Properties.Resources.icons8_usuário_homem_com_círculo_100;
            this.picBoxLogin.Location = new System.Drawing.Point(309, 86);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(191, 202);
            this.picBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogin.TabIndex = 18;
            this.picBoxLogin.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.Image = global::Neomot_Access_Control.Properties.Resources.Logo_neomot;
            this.picBoxLogo.Location = new System.Drawing.Point(1122, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(130, 50);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 13;
            this.picBoxLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.Controls.Add(this.picBoxLogin);
            this.pnlLogin.Controls.Add(this.lblCadastrarUsuario);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtBoxLoginUsuario);
            this.pnlLogin.Controls.Add(this.lblSenhaLogin);
            this.pnlLogin.Controls.Add(this.txtBoxSenhaUsuario);
            this.pnlLogin.Controls.Add(this.lblLoginUsuario);
            this.pnlLogin.Location = new System.Drawing.Point(241, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(739, 681);
            this.pnlLogin.TabIndex = 19;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCadastro.Controls.Add(this.lblCancelarCadastro);
            this.pnlCadastro.Controls.Add(this.lblCadastraSenhaUsuario2);
            this.pnlCadastro.Controls.Add(this.txtBoxSenhaCad2);
            this.pnlCadastro.Controls.Add(this.picBoxLoginCad);
            this.pnlCadastro.Controls.Add(this.btnCadastrarUsuario);
            this.pnlCadastro.Controls.Add(this.txtBoxUsuarioCad);
            this.pnlCadastro.Controls.Add(this.lblCadastraSenhaUsuario1);
            this.pnlCadastro.Controls.Add(this.txtBoxSenhaCad1);
            this.pnlCadastro.Controls.Add(this.lblCadastroUsuario);
            this.pnlCadastro.Location = new System.Drawing.Point(277, 0);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(755, 681);
            this.pnlCadastro.TabIndex = 20;
            this.pnlCadastro.Visible = false;
            // 
            // lblCancelarCadastro
            // 
            this.lblCancelarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCancelarCadastro.AutoSize = true;
            this.lblCancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCancelarCadastro.Location = new System.Drawing.Point(558, 599);
            this.lblCancelarCadastro.Name = "lblCancelarCadastro";
            this.lblCancelarCadastro.Size = new System.Drawing.Size(64, 17);
            this.lblCancelarCadastro.TabIndex = 21;
            this.lblCancelarCadastro.Text = "Cancelar";
            this.lblCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCancelarCadastro.Click += new System.EventHandler(this.lblCancelarCadastro_Click);
            this.lblCancelarCadastro.MouseEnter += new System.EventHandler(this.lblCancelarCadastro_MouseEnter);
            this.lblCancelarCadastro.MouseLeave += new System.EventHandler(this.lblCancelarCadastro_MouseLeave);
            // 
            // lblCadastraSenhaUsuario2
            // 
            this.lblCadastraSenhaUsuario2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastraSenhaUsuario2.AutoSize = true;
            this.lblCadastraSenhaUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastraSenhaUsuario2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCadastraSenhaUsuario2.Location = new System.Drawing.Point(89, 445);
            this.lblCadastraSenhaUsuario2.Name = "lblCadastraSenhaUsuario2";
            this.lblCadastraSenhaUsuario2.Size = new System.Drawing.Size(129, 20);
            this.lblCadastraSenhaUsuario2.TabIndex = 20;
            this.lblCadastraSenhaUsuario2.Text = "Confirmar Senha";
            // 
            // txtBoxSenhaCad2
            // 
            this.txtBoxSenhaCad2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSenhaCad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenhaCad2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxSenhaCad2.Location = new System.Drawing.Point(224, 442);
            this.txtBoxSenhaCad2.Name = "txtBoxSenhaCad2";
            this.txtBoxSenhaCad2.PasswordChar = '*';
            this.txtBoxSenhaCad2.Size = new System.Drawing.Size(398, 26);
            this.txtBoxSenhaCad2.TabIndex = 19;
            // 
            // picBoxLoginCad
            // 
            this.picBoxLoginCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLoginCad.Image = global::Neomot_Access_Control.Properties.Resources.icons8_usuário_homem_com_círculo_100;
            this.picBoxLoginCad.Location = new System.Drawing.Point(275, 57);
            this.picBoxLoginCad.Name = "picBoxLoginCad";
            this.picBoxLoginCad.Size = new System.Drawing.Size(191, 202);
            this.picBoxLoginCad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLoginCad.TabIndex = 18;
            this.picBoxLoginCad.TabStop = false;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.btnCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(93, 516);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(529, 68);
            this.btnCadastrarUsuario.TabIndex = 3;
            this.btnCadastrarUsuario.Text = "Logar";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // txtBoxUsuarioCad
            // 
            this.txtBoxUsuarioCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsuarioCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuarioCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxUsuarioCad.Location = new System.Drawing.Point(224, 341);
            this.txtBoxUsuarioCad.Name = "txtBoxUsuarioCad";
            this.txtBoxUsuarioCad.Size = new System.Drawing.Size(398, 26);
            this.txtBoxUsuarioCad.TabIndex = 1;
            // 
            // lblCadastraSenhaUsuario1
            // 
            this.lblCadastraSenhaUsuario1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastraSenhaUsuario1.AutoSize = true;
            this.lblCadastraSenhaUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastraSenhaUsuario1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCadastraSenhaUsuario1.Location = new System.Drawing.Point(89, 395);
            this.lblCadastraSenhaUsuario1.Name = "lblCadastraSenhaUsuario1";
            this.lblCadastraSenhaUsuario1.Size = new System.Drawing.Size(56, 20);
            this.lblCadastraSenhaUsuario1.TabIndex = 17;
            this.lblCadastraSenhaUsuario1.Text = "Senha";
            // 
            // txtBoxSenhaCad1
            // 
            this.txtBoxSenhaCad1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSenhaCad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenhaCad1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.txtBoxSenhaCad1.Location = new System.Drawing.Point(224, 392);
            this.txtBoxSenhaCad1.Name = "txtBoxSenhaCad1";
            this.txtBoxSenhaCad1.PasswordChar = '*';
            this.txtBoxSenhaCad1.Size = new System.Drawing.Size(398, 26);
            this.txtBoxSenhaCad1.TabIndex = 2;
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.lblCadastroUsuario.Location = new System.Drawing.Point(89, 344);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblCadastroUsuario.TabIndex = 16;
            this.lblCadastroUsuario.Text = "Usuário";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.picBoxLogo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(136)))), ((int)(((byte)(199)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginCad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TextBox txtBoxLoginUsuario;
        private System.Windows.Forms.TextBox txtBoxSenhaUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.PictureBox picBoxLogin;
        private System.Windows.Forms.Label lblCadastrarUsuario;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lblCancelarCadastro;
        private System.Windows.Forms.Label lblCadastraSenhaUsuario2;
        private System.Windows.Forms.TextBox txtBoxSenhaCad2;
        private System.Windows.Forms.PictureBox picBoxLoginCad;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.TextBox txtBoxUsuarioCad;
        private System.Windows.Forms.Label lblCadastraSenhaUsuario1;
        private System.Windows.Forms.TextBox txtBoxSenhaCad1;
        private System.Windows.Forms.Label lblCadastroUsuario;
    }
}

