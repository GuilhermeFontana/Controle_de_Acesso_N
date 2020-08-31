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
    public partial class FrmMain : Form {

        //VARIÁVEIS GLOBAIS
        FuncoesUteis funcoesUteis = new FuncoesUteis();                                                         //variável referente à classe de funções uteis

        FrmLogin frmLogin = new FrmLogin();                                                                     //variável referente ao 'FrmLogin' (tela de login)
        FrmCada_Edit frmCada_Edit = new FrmCada_Edit();                                                         //variável referente ao 'FrmCada_Edit' (tela de cadastro/deleção de pessoa)
        FrmEquipamento frmEquipamento = new FrmEquipamento();                                                   //variável referente ao 'FrmEquipamento' (tela de operações com equipamentos)
        FrmPesq_Apag FrmPesq_Apag = new FrmPesq_Apag();                                                         //variável referente ao 'FrmPesq_Apag' (tela de deleção/pesquisa de pessoa)

        public static int operacao;                                                                             //variável referente à operação que sera feita

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //funções uteis


        //função que permite que outras telas identifiquem qual operação que ser feita
        public int GetOperacao() {

            return operacao;

            /// <summary>
            /// 
            /// 1- Cadastrar
            /// 2 - Apagar
            /// 3 - Editar
            /// 4 - Pesquisar 
            /// 
            /// </summary>
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


        public FrmMain() {
            InitializeComponent();
        }

        private void lblOpEquipamentos_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblOpEquipamentos);                                             //forata texto do label de operações dos equipamentos (quando o mouse esta sobre ele)
        }

        private void lblOpEquipamentos_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblOpEquipamentos);                                             //forata texto do label de operações dos equipamentos (quando o mousesai de cima dele)
        }

        private void lblOpPessoas_MouseEnter(object sender, EventArgs e) {
            if(picBoxOpPessoas.Visible == true)                                                                 //verifica se a imagem das operações com pessoa esta visível
                funcoesUteis.FormataLabelMouseEnter(lblOpPessoas);                                              //forma o texto do label de operações com pessoa (quando o mouse esta sobre ele)
            else
                lblOpPessoas.Cursor = DefaultCursor;                                                            //coloca o cursor padrão no label
        }

        private void lblOpPessoas_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblOpPessoas);                                                  //formata o texto do label de operações com pessoa (quando o mouse sai de cima dele)
        }

        private void lblOpPessoas_Click(object sender, EventArgs e) {
            picBoxOpPessoas.Visible = false;                                                                    //esconde a imagem de operações com pessoa
        }

        private void lblApagarPessoa_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblApagarPessoa);                                               //forata texto do label  de apagar pessoa (quando o mouse esta sobre ele)
        }

        private void lblApagarPessoa_MouseLeave(object sender, EventArgs e) {       
            funcoesUteis.FormataLabelMouseLeave(lblApagarPessoa);                                               //forata texto do label de apagr usuario (quando o mouse sai de cima dele)
        }

        private void lblCadastrarPessoa_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblCadastrarPessoa);                                            //forata texto do label de cadastrar pessoa (quando o mouse esta sobre ele)
        }

        private void lblCadastrarPessoa_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblCadastrarPessoa);                                            //forata texto do label de cadastrar pessoa (quando o mouse sai de cima dele)
        }

        private void lblEditarPessoa_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblEditarPessoa);                                               //forata texto do label de editar pessoa (quando o mouse esta sobre ele)
        }

        private void lblEditarPessoa_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblEditarPessoa);                                               //forata texto do label de editar pessoa (quando o mouse sai de cima dele)
        }

        private void lblPesquisarPessoa_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblPesquisarPessoa);                                            //forata texto do label de pesquisa de pessoa (quando o mouse esta sobre ele)
        }

        private void lblPesquisarPessoa_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblPesquisarPessoa);                                            //forata texto do label de pesquisar (quando o mouse sai de cima dele)
        }

        private void picBoxOpEquipamentos_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            frmEquipamento.Show();                                                                              //mostra a tela de operações com os equipamentos
        }                            

        private void picBoxCadastrarPessoa_Click(object sender, EventArgs e) {
            operacao = 1;                                                                                       //define a operação como cadastro
            this.Visible = false;                                                                               //esconde a tela atual
            frmCada_Edit.Show();                                                                                //mostra a tela de cadastro/esdição de pessoa
        }

        private void picBoxApagarPessoa_Click(object sender, EventArgs e) {
            operacao = 2;                                                                                       //define a operação como deleção
            this.Visible = false;                                                                               //esconde a tela atual
            FrmPesq_Apag.Show();                                                                                //mostra a tela de deleção/pesquisa de pessoa
        }

        private void picBoxEditarPessoa_Click(object sender, EventArgs e) {
            operacao = 3;                                                                                       //define a operação como edição
            this.Visible = false;                                                                               //esconde a tela atual
            frmCada_Edit.Show();                                                                                //mostra a tela de cadastro/esdição de pessoa
        }

        private void picBoxPesquisarPessoa_Click(object sender, EventArgs e) {
            operacao = 4;                                                                                       //define a operação como pesquisa
            this.Visible = false;                                                                               //esconde a tela atual
            FrmPesq_Apag.Show();                                                                                //mostra a tela de deleção/pesquisa de pessoa
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            frmLogin.Show();                                                                                    //mostra a tela de login
        }

        private void Form3_VisibleChanged(object sender, EventArgs e) {
            picBoxOpPessoas.Show();                                                                             //mostra a imagem de operações com pessoa
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            funcoesUteis.FecharAplicacao(e);
        }

    }
}
