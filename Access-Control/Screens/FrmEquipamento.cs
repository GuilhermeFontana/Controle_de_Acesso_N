using System;
using System.Windows.Forms;

using Neomot_Access_Control.Utils;
using Neomot_Access_Control.Controladores;
using Neomot_Access_Control.ControladorUtils;

namespace Neomot_Access_Control.Screens {
    public partial class FrmEquipamento : Form {

        Catraca iDBlock25 = new Catraca("172.31.0.25", 80, false, "admin", "admin");
        Catraca iDBlock26 = new Catraca("172.31.0.26", 80, false, "admin", "admin");

        Leitora iDAccess27 = new Leitora("172.31.0.27", 80, false, "admin", "admin");
        Leitora iDAccess28 = new Leitora("172.31.0.28", 80, false, "admin", "admin");
        Leitora iDAccess29 = new Leitora("172.31.0.29", 80, false, "admin", "admin");
        Leitora iDAccess30 = new Leitora("172.31.0.30", 80, false, "admin", "admin");
        Leitora iDAccess31 = new Leitora("172.31.0.31", 80, false, "admin", "admin");


        //VARIÁVEIS GLOBAIS
        FuncoesUteis funcoesUteis = new FuncoesUteis();                                                         //variável referente as funcções uteis


        public FrmEquipamento() {
            InitializeComponent();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esconde a tela atual
            FrmLogin frmLogin = new FrmLogin();                                                                 //cria uma instância (variável) do 'FemLogin' (tela de login)
            frmLogin.Show();                                                                                    //mostra a tela de login
        }

        private void pgInicialToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Visible = false;                                                                               //esonde a tela atual
            FrmMain frmMain = new FrmMain();                                                                    //cria uma instância (variável) do 'FrmMain' (tela inicial)
            frmMain.Show();                                                                                     //mostra a tela inicial
        }

        private void FrmEquipamento_FormClosing(object sender, FormClosingEventArgs e) {
            funcoesUteis.FecharAplicacao(e);
        }

        private void btnConectar_Click(object sender, EventArgs e) {
            txtSaidaInfo.Text = "Testando Conexão... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxEquipamentos_TesteConexao.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 5:
                    if (iDBlock25.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;
                case 6:
                    if (iDBlock26.ConectarControlador() != null)
                        txtSaidaInfo.Text = "Conectado";
                    else
                        txtSaidaInfo.Text = "Desconectado";
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }

        }

        private void btnAbrirPorta1_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Abrir a Porta";

            txtSaidaInfo.Text = "Abrindo... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxLeitoras.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        if (iDAccess27.LigarReleControlador(1) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) {
                        if (iDAccess28.LigarReleControlador(1) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        if (iDAccess29.LigarReleControlador(1) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        if (iDAccess30.LigarReleControlador(1) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        if (iDAccess31.LigarReleControlador(1) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnAbrirPorta2_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Abrir a Porta";

            txtSaidaInfo.Text = "Abrindo... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxLeitoras.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        if (iDAccess27.LigarReleControlador(2) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) {
                        if (iDAccess28.LigarReleControlador(2) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        if (iDAccess29.LigarReleControlador(2) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        if (iDAccess30.LigarReleControlador(2) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        if (iDAccess31.LigarReleControlador(2) != null)
                            txtSaidaInfo.Text = "Aberto";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnAbrirUrnaCartoes_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Urna";

            txtSaidaInfo.Text = "Abrindo... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxCatracas.SelectedIndex) {
                case 0:
                    if (iDBlock25.ConectarControlador() != null) {
                        if (iDBlock25.AbrirUrnaColetoraDeCartoes() != null)
                            txtSaidaInfo.Text = "Aberta";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDBlock26.ConectarControlador() != null) {
                        if (iDBlock25.AbrirUrnaColetoraDeCartoes() != null)
                            txtSaidaInfo.Text = "Aberta";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnLiberarCatraca_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Liberar Catraca";

            txtSaidaInfo.Text = "Liberando... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            if (cbBoxSentidoGiroCatracas.SelectedIndex == -1)
                cbBoxSentidoGiroCatracas.SelectedIndex = 0;

            switch (cbBoxCatracas.SelectedIndex) {
                case 0:
                    if (iDBlock25.ConectarControlador() != null) {
                        if (iDBlock25.LiberaCatraca(cbBoxSentidoGiroCatracas.SelectedIndex) != null)
                            txtSaidaInfo.Text = "Liberada";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDBlock26.ConectarControlador() != null) {
                        if (iDBlock25.LiberaCatraca(cbBoxSentidoGiroCatracas.SelectedIndex) != null)
                            txtSaidaInfo.Text = "Liberada";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnLerInfoEqpto_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Ler as Informações do Equipamento";

            txtSaidaInfo.Text = "Lendo Informações do Equipamento... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxEquipamentos_OutrasAcoes.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        var result = iDAccess27.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) { 
                        var result = iDAccess28.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        var result = iDAccess29.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        var result = iDAccess30.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        var result = iDAccess31.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 5:
                    if (iDBlock25.ConectarControlador() != null) {
                        var result = iDBlock25.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 6:
                    if (iDBlock26.ConectarControlador() != null) {
                        var result = iDBlock26.LeInfoEquipamento();
                        if (result != null)
                            txtSaidaInfo.Text = result;
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnLerAcessoasEqpto_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Ler os Acessos do Equipamento";

            string eventType = "";
            ResultList resultLista = new ResultList();
            bool verificacao = true;

            txtSaidaInfo.Text = "Lendo os Acessos do Equipamento... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxEquipamentos_OutrasAcoes.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        resultLista = iDAccess27.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) {
                        resultLista = iDAccess28.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        resultLista = iDAccess29.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        resultLista = iDAccess30.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        resultLista = iDAccess31.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 5:
                    if (iDBlock25.ConectarControlador() != null) {
                        resultLista = iDBlock25.LeAcessosParaProcessamento();
                    } {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;
                case 6:
                    if (iDBlock26.ConectarControlador() != null) {
                        resultLista = iDBlock26.LeAcessosParaProcessamento();
                    }
                    else {
                        verificacao = false;
                        txtSaidaInfo.Text = erro1;
                    }
                    break;

                default:
                    verificacao = false;
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }

            if (verificacao == true) {
                if (resultLista.access_logs.Length > 0) {
                    txtSaidaInfo.Clear();

                    for (int i = 0; i < resultLista.access_logs.Length; i++) {

                        if (resultLista.access_logs[i].EventType.ToString() == "Allow")                                    //verifica se o acesso foi "Allow" (permitido)
                            eventType = "Acesso Permitido";                                                         //define a informação como "Acesso Permitido"
                        else
                            eventType = "Acesso Negado";                                                            //define a informação como "Acesso Negado"

                        txtSaidaInfo.Text += $"\r\n{resultLista.access_logs[i].id}: {resultLista.access_logs[i].user_id} - {eventType} - Hora: {resultLista.access_logs[i].Date}";
                    }
                }
                else
                    txtSaidaInfo.Text = erro2;
            }
        }

        private void btnAgora_Click(object sender, EventArgs e) {
            dateTimePicker.Value = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnReiniciarEqpto_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Reiniciar Equipamento";

            txtSaidaInfo.Text = "Reiniciando Equipamento... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxEquipamentos_OutrasAcoes.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        if (iDAccess27.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) {
                        if (iDAccess28.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        if (iDAccess29.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        if (iDAccess30.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        if (iDAccess31.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 5:
                    if (iDBlock25.ConectarControlador() != null) {
                        if (iDBlock25.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 6:
                    if (iDBlock26.ConectarControlador() != null) {
                        if (iDBlock26.ReiniciarEquipamento() != null)
                            txtSaidaInfo.Text = "Reiniciando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }

        private void btnAjustarHoraDataEqpto_Click(object sender, EventArgs e) {
            string erro1 = "Erro de Conexão com o Equipamento";
            string erro2 = "Não Foi Possível Ajustar Data/Hora do Equipamento";

            txtSaidaInfo.Text = "Ajustando Data/Hora do Equipamento... Por favor, aguarde\r\n";
            txtSaidaInfo.Text += "(Isso pode demorar alguns instantes)";

            switch (cbBoxEquipamentos_OutrasAcoes.SelectedIndex) {
                case 0:
                    if (iDAccess27.ConectarControlador() != null) {
                        if (iDAccess27.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 1:
                    if (iDAccess28.ConectarControlador() != null) {
                        if (iDAccess28.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 2:
                    if (iDAccess29.ConectarControlador() != null) {
                        if (iDAccess29.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustado";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 3:
                    if (iDAccess30.ConectarControlador() != null) {
                        if (iDAccess30.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 4:
                    if (iDAccess31.ConectarControlador() != null) {
                        if (iDAccess31.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 5:
                    if (iDBlock25.ConectarControlador() != null) {
                        if (iDBlock25.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;
                case 6:
                    if (iDBlock26.ConectarControlador() != null) {
                        if (iDBlock26.AjustarDataHotaEquipamento(dateTimePicker.Value) != null)
                            txtSaidaInfo.Text = "Ajustando";
                        else
                            txtSaidaInfo.Text = erro2;
                    }
                    else
                        txtSaidaInfo.Text = erro1;
                    break;

                default:
                    txtSaidaInfo.Text = "Nenhum Equipamento Selecionado";
                    break;
            }
        }
    }
}
