using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Neomot_Access_Control.Screens;
using Neomot_Access_Control.Controladores;
using Neomot_Access_Control.Conexao;
using Neomot_Access_Control.Utils;

namespace Neomot_Access_Control {
    public partial class FrmLogin : Form {

        //VARIÁVEIS GLOBAIS
        static Controlador controlador = new Controlador();                                                     //variável referente à classe com as interações com os controladores
        static FuncoesUteis funcoesUteis = new FuncoesUteis();                                                  //variável referente à classe com as funções uteis

        static FrmCada_Edit frmCada_Edit = new FrmCada_Edit();                                                  //variável referente a 'FrmCada_Edit' (tela de cadastro e edição de usuário)
        static FrmMain frmMain = new FrmMain();                                                                 //variável referente a 'FrmMain' (tela inicial )
        static FrmEquipamento frmEquipamento = new FrmEquipamento();                                            //variével referente a 'FrmEquipamento' (tela de interação com os equipamentos)
        static FrmPesq_Apag frmPesq_Apag = new FrmPesq_Apag();                                                  //variável referente a 'FrmPesq_Apag' (tela de pesquisa e deleção de usuários)

        public FrmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            frmMain.Show();                                                                                     //mostra a 'FrmMain' (tela inicial)
            this.Visible = false;                                                                               //esconde a tela atual

            //var i = ConexaoDB.Conectar();

            //if (i != null) {
            //    MessageBox.Show("Bem Vindo \nVocê já esra conectado com o banco de dados");
            //    form3.Show();
            //    this.Visible = false;
            //}
            //else
            //    MessageBox.Show("erro");



            //    if (i != null) {

            //        var usuario = txtBoxLoginUsuario.Text.ToUpper();
            //        var senha = txtBoxSenhaUsuario.Text;

            //        if (usuario == "OPERADOR") {
            //            if (senha == "operador") {
            //                MessageBox.Show($"Bem Vindo {usuario}, você já esta conectado");
            //                form3.Show();
            //            }
            //            else
            //                MessageBox.Show("Senha Incorreta");
            //        }
            //        else if (usuario == "ADMIN") {
            //            if (senha == "admin") {
            //                MessageBox.Show($"Bem Vindo {usuario}, você já esta conectado");
            //                form3.Show();
            //            }
            //            else
            //                MessageBox.Show("Senha Incorreta");
            //        }
            //        else
            //            MessageBox.Show("Usuário Não Encontrado");

            //    }
            //    else {
            //        MessageBox.Show("erro");
            //    }

        }

        private void lblCadastrarUsuario_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblCadastrarUsuario);                                           //formata o texto da label de Cadastro de Usuario (quando o mouse estiver sobre ele)
        }

        private void lblCadastrarUsuario_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblCadastrarUsuario);                                           //fomrata o texto da label de Cadastro de Usuário (quando o mause sai de cima dele)
        }

        private void lblCancelarCadastro_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblCancelarCadastro);                                           //fornata o texto da label de Cancelamento de Cadastro de Usuário (quando o mouse estiver sobre ele)
        }

        private void lblCancelarCadastro_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblCancelarCadastro);                                           //formata o texto da label de Cancelamento de Cadastro de Usuário  (quando o mouse sair de cima dele)
        }

        private void lblCancelarCadastro_Click(object sender, EventArgs e) {
            pnlCadastro.Visible = false;                                                                        //esconde o panel de cadastro de Usuário
            pnlLogin.Show();                                                                                    //mostra o panel de Login
        }

        private void lblCadastrarUsuario_Click(object sender, EventArgs e) {
            pnlLogin.Visible = false;                                                                           //esconde o panel de Login
            pnlCadastro.Show();                                                                                 //mostra o panel de Cadastro de Usuário
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e) {
            frmMain.Show();                                                                                     //mostra a 'FrmMain' (tela inicial)
            this.Visible = false;                                                                               //esconde tela atual
        }

        private void FrmLogin_Shown(object sender, EventArgs e) {
            pnlLogin.Show();                                                                                    //mostra o panel de Login
            pnlCadastro.Visible = false;                                                                        //esconde a tela de cadastro de Usuário
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            funcoesUteis.FecharAplicacao(e);
        }
    }
        
}
