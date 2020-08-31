using System;
using System.Windows.Forms;

using Neomot_Access_Control.Utils;
using Neomot_Access_Control.Controladores;
using Neomot_Access_Control.ControladorUtils;
using Neomot_Access_Control.Conexao;
using System.Threading;

namespace Neomot_Access_Control.Screens {
    public partial class FrmCada_Edit : Form {

        Leitora iDAccess31 = new Leitora("172.31.0.31", 80, false, "admin", "admin");

        

        //VARIÁVEIS GLOBAIS
        FuncoesUteis funcoesUteis = new FuncoesUteis();                                                         //variével referente à classe das funções uteis


        int operacao;                                                                                           //variável referente a operação que sera feita na tela

        public FrmCada_Edit() {
            InitializeComponent();
        }

        private void txtBoxCPF_Enter(object sender, EventArgs e) {
            txtBoxCPF.Clear();                                                                                  //limpa o textBox do CPF
        }

        private void txtBoxCPF_Leave(object sender, EventArgs e) {
            if (txtBoxCPF.Text == "")                                                                           //verifica se o textBox do CPF esta vazio
                txtBoxCPF.Text = "___.___.___-__";                                                              //passa o texto padrao para o textBox do CPF
        }     

        private void txtBoxCPF_KeyPress_1(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)                                               //aqui configura o textBox do CPF 
                e.Handled = true;                                                                               //para receber apenas números
            
        }

        private void txtBoxCPF_KeyDown(object sender, KeyEventArgs e) { 
            txtBoxCPF.Text = funcoesUteis.FormataCPF(txtBoxCPF.Text, e.KeyValue);                               //formata o texto do textBox do CPF
            txtBoxCPF.SelectionStart = txtBoxCPF.Text.Length;                                                   //posiciona o cursor no final do texto do textBox
        }

        private void lblCancelarCadastro_MouseEnter(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseEnter(lblCancelarCadastro);                                           //formata label de Cancelamento de Cadastro (quando o mouse estiver sobre ela)
        }

        private void lblCancelarCadastro_MouseLeave(object sender, EventArgs e) {
            funcoesUteis.FormataLabelMouseLeave(lblCancelarCadastro);                                           //formata labelABEL de cancelamento (quando o mause esta sobre ele) 
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            FrmLogin frmLogin = new FrmLogin();                                                                 //variável referente ao 'FrmLogin' (tela de login)
            frmLogin.Show();                                                                                    //mostra a tela de login
        }

        private void pgInicialToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            FrmMain frmMain = new FrmMain();                                                                    //variável referente ao 'FrmMain' (tela inicial)
            frmMain.Show();                                                                                     //mostra a tela inicial
        }

        private void FrmCada_Edit_Shown(object sender, EventArgs e) {
            FrmMain frmMain = new FrmMain();                                                                    //variável referente ao 'FrmMain'
            operacao = frmMain.GetOperacao();                                                                   //variável recebe a operação que sera feita na tela

            if (operacao == 1) {                                                                                //verifica se é uma operação de cadastro
                lblTituloPrincipal.Text = "Cadastrar Usuário";                                                  //coloca no label do titulo o texto de cadastro
                lblCancelarCadastro.Text = "Cancelar Cadastro";                                                 //coloca no label de cancelamento o texto de cancelamento de cadastro
                btnCadastrarUsuario.Text = "Cadastrar";                                                         //coloca no button de Cadastro/Edição de pessoa o texto de cadastro
                btnCadastarBiometria.Text = "Cadastrar Biometria";                                              //coloca no button de Cadastro/Edição de biometria o texto de cadastro
                btnCadastrarCartao.Text = "Cadastrar Cartão";                                                   //coloca no button de Cadastro/Edição de cartão o texto de cadastro
            }
            else {
                lblTituloPrincipal.Text = "Editar Usuário";                                                     //coloca no label do titulo o texto de edição
                lblCancelarCadastro.Text = "Cancelar Edição";                                                   //coloca no label de cancelamento o texto de cancelamento de edição
                btnCadastrarUsuario.Text = "Editar";                                                            //coloca no button de Cadastro/Edição de pesso o texto de edição
                btnCadastarBiometria.Text = "Substituir Biometria";                                             //coloca no button de Cadastro/Edição de biometria o texto de edição
                btnCadastrarCartao.Text = "Substituir Cartão";                                                  //coloca no button de Cadastro/Edição de cartão o texto de edição
            }
        }

        private void FrmCada_Edit_FormClosing(object sender, FormClosingEventArgs e) {
            funcoesUteis.FecharAplicacao(e);
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e) {
            string sql;
            string cmd;

            if (ConexaoDB.Conectar() != null) {
                MessageBox.Show("Conectado ao Banco de Dados");

                if (iDAccess31.ConectarControlador() != null) {

                    sql = "INSERT INTO `acesso`.`users` (`id`, `name`, `pis`, `senha`, `cpf`, `admin`, `inativo`, `contingency`, `deleted`, `idDevice`, `idType`, `blackList`, `idArea`) " +
                        "VALUES ('1002', 'Nome2.0', '0', '0', 'CPF', b'0', b'0', b'0', b'0', 1002, b'0', b'0', b'0');";

                    if (MetodosDB.CadastrarOuEditar(sql) != null) {
                        MessageBox.Show("Pessoa Cadastrada Com Sucesso");

                        cmd = "{\"object\" : \"users\", \"values\": [{\"id\": 1002,\"name\": \"Nome2.0\",\"registration\": \"\",\"password\": \"\",\"salt\": \"\"}]}";

                        if (iDAccess31.CadastrarObjeto(cmd) != null) {
                            MessageBox.Show("Pessoa Cadastrada No Equipamento Com Sucesso ");

                            sql = "INSERT INTO `acesso`.`usergroups` (`idUser`, `idGroup`, `isVisitor`) VALUES ('1002', '1', '0');";

                            if (MetodosDB.CadastrarOuEditar(sql) != null) {
                                MessageBox.Show("Pessoa Associada a um Grupo Com Sucesso");

                                cmd = "{\"object\" : \"user_groups\", \"values\": [{\"user_id\": 1002,\"group_id\": 1}]}";

                                if (iDAccess31.CadastrarObjeto(cmd) != null) {
                                    MessageBox.Show("Pessoa Associada a um Grupo no Equipamento Com Sucesso ");

                                    btnCadastarBiometria.Enabled = true;
                                    btnCadastrarCartao.Enabled = true;
                                    btnConcluirCadastro.Enabled = true;
                                    lblCancelarCadastro.Visible = false;
                                }
                                else
                                    MessageBox.Show("Erro ao Associar a Pessoa a um Grupo no Equipamento");
                            }
                            else
                                MessageBox.Show("Erro ao Associar Pessoa a um Grupo");
                        }
                        else
                            MessageBox.Show("Erro ao Cadastrar a Pessoa no Equipamento");
                    }
                    else
                        MessageBox.Show("Erro ao Cadastrar a Pessoa");
                }
                else
                    MessageBox.Show("Erro de Conexão com a Leitora");
            }
            else
                MessageBox.Show("Erro de Conexão com o Banco de Dados");
        }

        private void btnCadastarBiometria_Click(object sender, EventArgs e) {
            if (iDAccess31.ConectarControlador() != null) {

                Templates biometria = iDAccess31.CadastraBiometriaProcessado(1002);
                if (biometria != null) {
                    MessageBox.Show("Biometria Capturada Com Sucesso");

                    if (ConexaoDB.Conectar() != null) {
                        MessageBox.Show("Conectado ao Banco de Dados");

                        string sql = $"INSERT INTO `acesso`.`templates` (`idUser`, `panic`, `idType`, `templateDevice`) VALUES ('1002', b'0', b'0', '{biometria.template}');";

                        if (MetodosDB.CadastrarOuEditar(sql) != null)
                            MessageBox.Show("Biometroa Cadastrada Com Sucesso no DB");
                        else
                            MessageBox.Show("Erro ao Cadastrar a Biometria no DB");
                    }
                    else
                        MessageBox.Show("Erro de Conexão com o Banco de Dados");
                }
                else
                    MessageBox.Show("Erro ao Capturar a Biometroa");
            }
            else
                MessageBox.Show("Erro de Conexão com a Leitora");
        }

        private void btnCadastrarCartao_Click(object sender, EventArgs e) {
            if (iDAccess31.ConectarControlador() != null) {

                Cards cartao = iDAccess31.CadastraCartaoProcessado(1002);
                if (cartao != null) {
                    MessageBox.Show("Cartão Capturado Com Sucesso");

                    if (ConexaoDB.Conectar() != null) {
                        MessageBox.Show("Conectado ao Banco de Dados");

                        string sql = $"INSERT INTO `acesso`.`cards` (`idUser`, `number`, `idType`, `type`) VALUES('1002', {cartao.card_value}, '1', '2');";

                        if (MetodosDB.CadastrarOuEditar(sql) != null)
                            MessageBox.Show("Cartão Cadastrado Com Sucesso no DB");
                        else
                            MessageBox.Show("Erro ao Cadastrar o Cartão no DB");
                    }
                    else
                        MessageBox.Show("Erro de Conexão com o Banco de Dados");
                }
                else
                    MessageBox.Show("Erro ao Capturar a Biometroa");
            }
            else
                MessageBox.Show("Erro de Conexão com a Leitora");
        }
    }
}
