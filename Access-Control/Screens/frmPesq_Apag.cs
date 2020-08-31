using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Neomot_Access_Control.Utils;

namespace Neomot_Access_Control.Screens {
    public partial class FrmPesq_Apag : Form {

        //VARIÁVEIS GLOBAIS
        FuncoesUteis funcoesUteis = new FuncoesUteis();                                                         //variável referente a classe de funções uteis
        int operacao;                                                                                           //variável referente as operações que serão realizadas na tela atual

        
        public FrmPesq_Apag() {
            InitializeComponent();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //sconde a tela atual
            FrmLogin frmLogin = new FrmLogin();                                                                 //variável referente ao 'FrmLogin' (tela de login)
            frmLogin.Show();                                                                                    //mostra a tela de login
        }

        private void pgInicialToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            FrmMain frmMain = new FrmMain();                                                                    //variável referente ao 'FrmMain' (tela inicial)
            frmMain.Show();                                                                                     //mostra a tela inicial
        }

        private void FrmPesq_Apag_Shown(object sender, EventArgs e) {
            FrmMain frmMain = new FrmMain();                                                                    //variável referente ao 'FrmMain' (tela inicial)
            operacao = frmMain.GetOperacao();                                                                   //variável recebe a operação que sera realizada na tela atual

            dataGVPessoas.Rows.Add("Usuario Teste", "000.000.000-00", "Visitante");                             //cria um usuário e o coloca na grid, para fins de exemplo

            if (operacao == 2) {                                                                                //verifica se é umaoperação de deleção
                lblTituloPrincipal.Text = "Apagar Usuário";                                                     //coloca no texto do label do titulo o texto de deleção
                pnlApagar.Show();                                                                               //mostra o panel de deleção
                pnlPesquisar.Visible = false;                                                                   //esconde o panel de pesquisa
            }
            else {
                lblTituloPrincipal.Text = "Pesquisar Usuário";                                                  //coloca no texto do label do titulo o texto de pesquisa
                pnlPesquisar.Show();                                                                            //mostra o panel de pesquisa
                pnlApagar.Visible = false;                                                                      //esconde o panel de deleção
            }
        }

        private void FrmPesq_Apag_FormClosing(object sender, FormClosingEventArgs e) {
            funcoesUteis.FecharAplicacao(e);
        }
    }
}
