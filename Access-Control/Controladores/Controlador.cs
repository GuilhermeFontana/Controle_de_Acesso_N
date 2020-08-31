using System;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;         //sleep
using System.Windows.Forms;
using Neomot_Access_Control.ControladorUtils;
using Neomot_Access_Control.Utils;

namespace Neomot_Access_Control.Controladores {
    class Controlador {
        //VARIÁVEIS GLOBAIS

        private string IpControlador { get; set; }                                                              //variável referente ao  IP (de conexão) do Controlador
        private int numPortaControlador { get; set; }                                                           //variável referente ao numero da porta (de conexão) do Controlador
        private bool SSLControlador { get; set; }                                                               //variável referente ao SSL de connexão) do Controlador
        private string usuarioControlador { get; set; }                                                         //variável referente ao usuário do Controlador
        private string senhaControlador { get; set; }                                                           //variável referente à senha do usuário do Controlador
        
        protected static string urlDevice = null;                                                               //variável referente à url de conexão com o Controlador
        protected static string session = null;                                                                 //variável referente à sessão de conexão como o Controlador
        protected static string response;                                                                       //variável que executará as interações com o Controlador 

        #region Construtores
        //---------------------------------------------------------------------- CONSTRUTORES ----------------------------------------------------------------------------------------------------
        public Controlador() {                                                                                  //contrutor padrão da classe 'Controlador'
        }

        public Controlador(string IP, int numPorta, bool SSL, string Usuario, string Senha) {                   //construtor completo da classe 'Controlador'
            IpControlador = IP;                                                                                 //'IpControlador' recebe IP de conexão passado por parâmetro
            numPortaControlador = numPorta;                                                                     //'numPortaControlador' recebe numero da porta de conexão passado por parâmetro
            SSLControlador = SSL;                                                                               //'SSLControlador' recebe SSL de conexão passado por parâmetro
            usuarioControlador = Usuario;                                                                       //'usuarioControlador' recebe usuário passado por parâmetro            
            senhaControlador = Senha;                                                                           //'senhaControlador' recebe senha do usuário passada por padrão
        }
        #endregion


        #region Metodos
        //------------------------------------------------------------------------- METODOS ---------------------------------------------------------------------------------------------------------

        #region Interações

        #region ConexoesEquipamentos

        //metodo que realiza conexão com o Controlador (sem parâmetros)
        public string ConectarControlador() {
            try {                                                                                               //tenta realizar conexão com o aparelho
                session = null;                                                                                 //invalida sessão anterior

                if (SSLControlador == true) {                                                                   //verifica se o checkBox do SSL (chkSSL) esta marcado
                    urlDevice = "https://" + IpControlador;                                                     //coloca 'https://' e o  IP (texto do textBox do IP - txtIP) na variável da url do dispositivo (urlDevice)
                    if (numPortaControlador != 443)                                                             //verifica se o número da porta informado é diferente de 443
                        urlDevice += ":" + numPortaControlador.ToString();                                      //adiciona ':' e o número da porta (texto do numPorta) na variável da url do dispositivo (urlDevice)
                }
                else {
                    urlDevice = "http://" + IpControlador;                                                      //coloca 'https://' e o IP (texto do textBox do IP - txtIP) na variável da url do dispositivo
                    if (numPortaControlador != 80)                                                              //verifica se o número da porta é diferente de 80
                        urlDevice += ":" + numPortaControlador.ToString();                                      //adiciona ':' e o número da porta (texto do numPorta) na variável da url do dispositivo (urlDevice)
                }
                urlDevice += "/";                                                                               //adiciona '/' à variável da url do dispositivo (urlDevice)

                response = WebJson.Send(urlDevice + "login", "{\"login\":\"" + usuarioControlador + "\",\"password\":\"" + senhaControlador + "\"}");               //variável responsável por enviar e recber a conexão com o dispositivo

                SalvarControlador(IpControlador, numPortaControlador, SSLControlador, usuarioControlador, senhaControlador);                                        //função que salva controlador para onterações futuras 

                return session;                                                                                 //retorna sessão, de conexão com o Controlador, atual
            }
            catch (Exception ex) {                                                                              //no caso de a conexão dae errado
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro de conexão
            }
        }

        //metodo que realiza conexão com o Controlador (com parâmetros)
        public string ConectarControlador(string IP, int NumPorta, bool SSL, string usuario, string senha) {
            try {                                                                                               //tenta realizar conexão com o aparelho
                session = null;                                                                                 //invalida sessão anterior

                if (SSL == true) {                                                                              //verifica se o checkBox do SSL (chkSSL) esta marcado
                    urlDevice = "https://" + IP;                                                                //coloca 'https://' e o  IP (texto do textBox do IP - txtIP) na variável da url do dispositivo (urlDevice)
                    if (NumPorta != 443)                                                                        //verifica se o número da porta informado é diferente de 443
                        urlDevice += ":" + NumPorta.ToString();                                                 //adiciona ':' e o número da porta (texto do numPorta) na variável da url do dispositivo (urlDevice)
                }
                else {
                    urlDevice = "http://" + IP;                                                                 //coloca 'https://' e o IP (texto do textBox do IP - txtIP) na variável da url do dispositivo
                    if (NumPorta != 80)                                                                         //verifica se o número da porta é diferente de 80
                        urlDevice += ":" + NumPorta.ToString();                                                 //adiciona ':' e o número da porta (texto do numPorta) na variável da url do dispositivo (urlDevice)
                }
                urlDevice += "/";                                                                               //adiciona '/' à variável da url do dispositivo (urlDevice)

                //txtSaida_Info.Text = "Device: " + urlDevice;                                                  //coloca 'Devide' (tradução: Dispositivo) e a url do dispositivo no textBox de saida de informações (txtSaida_Info), para que seja apresentado ao usuário na tela 

                response = WebJson.Send(urlDevice + "login", "{\"login\":\"" + usuario + "\",\"password\":\"" + senha + "\"}");              //variável responsável por enviar e recber a conexão com o dispositivo

                SalvarControlador(IP, NumPorta, SSL, usuario, senha);                                           //função que salva controlador para onterações futuras 

                return session;                                                                                 //retorna sessão, de conexão com o Controlador, atual
            }
            catch (Exception ex) {                                                                              //no caso de a conexão dae errado
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro de conexão
            }
        }

        #endregion

        //metodo que ajusta data e hora do equipamento
        public string AjustarDataHotaEquipamento(DateTime dt) {
            try {                                                                                               //tenta ajustar data e hora do equipamento - aqui abre a variável
                string cmd = "{" +                                                                              //variável que recebe data e hora
                    "\"day\":" + dt.Day +                                                                       //aqui recebe dia
                    ",\"month\":" + dt.Month +                                                                  //aqui recebe mês
                    ",\"year\":" + dt.Year +                                                                    //aqui recebe ano
                    ",\"hour\":" + dt.Hour +                                                                    //aqui recebe hora
                    ",\"minute\":" + dt.Minute +                                                                //aqui recebe minuto
                    ",\"second\":" + dt.Second +                                                                //aqi recebe segundo
                    "}";                                                                                        // aqui fevha a variável

                return WebJson.Send(urlDevice + "set_system_time", cmd, session);                               //aqui configura a data e a hora do quipamento
            }
            catch (Exception ex) {                                                                              //no caso do ajuste dar errado
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }       

        //metodo para reniciar equipamento
        public string ReiniciarEquipamento() {
            try {                                                                                               //tenta reiniciar o aparelho
                return WebJson.Send(urlDevice + "reboot", null, session);                                       //aqui reinicia o aparelho
            }
            catch (Exception ex) {                                                                              //no caso da reiniciação dar errado
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que salva controlador para interações futuras
        public void SalvarControlador(string IP, int NumPorta, bool SSL, string usuario, string senha) {
            if (response.Contains("session")) {                                                                 //verifica se existe 'session' dentro do texto da variável de conexão
                session = response.Split('"')[3];                                                               //quebra a string em uma cadeia 

                //Persiste a conexão nas configurações do aplicativo para facilitar
                Settings.Default.ip = IP;                                                                       //define o IP informado como padrão, para ser utilizado nas interações futuras com o dispositivo
                Settings.Default.port = NumPorta;                                                               //define a porta informada como padrão, para ser utilizada nas interações futuras com o dispositivo
                Settings.Default.ssl = SSL;                                                                     //define o SSL (true ou false) informado como padrão, para ser utilizado nas interações futuras com o dispositivo
                Settings.Default.user = usuario;                                                                //define o nome do usuário informado como padrão, para ser utilizado nas interações futuras com o dispositivo
                Settings.Default.password = senha;                                                              //define a senha informada como padrão, para ser utilizada nas interações futuras com o dispositivo
                Settings.Default.Save();                                                                        //salva as informações padrão difinida acima
            }
        }
        #endregion


        #region Leituras
        //metodo que lê todas as especificações do equipamento (sem processamento)
        public string LeInfoEquipamento() {
            try {                                                                                               //tenta ler as informações do equipamento
                return WebJson.Send(urlDevice + "system_information", null, session);                           //aqui lê e retorna as informações do equipamento
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler as informações
                //MessageBox.Show(ex.Message); 
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os acessos feitos no equipamento (sem processamento de informações)
        public string LeAcessosSemProcessamento() {
            try {                                                                                               //tenta ler os acessos feitos no equipamento
                return WebJson.Send(urlDevice + "load_objects", "{\"object\":\"access_logs\"}", session);       //aqui lê e retorna os acessos feitos no equipamento
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler os acessos
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os usuários cadastrados no equipamento (sem processamento de informações)
        public string LeUsuariosSemProcessamento() {
            try {                                                                                               //tenta ler os usuários cadastrados no equipamento
                return WebJson.Send(urlDevice + "load_objects", "{\"object\":\"users\"}", session);             //aqui lê e retorna os usuários cadastrados no equipamento
            }
            catch (Exception ex) {                                                                              //caso não seja possivel ler os usuários cadastrados no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os acessos feitos no equipamento (com processamento de informações)
        public ResultList LeAcessosParaProcessamento() {
            try {                                                                                                                       //tenta ler os acessos feitos no equipamento
                var list = WebJson.Send<ResultList>(urlDevice + "load_objects", "{\"object\":\"access_logs\"}", session);               //lista recebe todos os acessos feitos no equipamento (ainda sem processamento)

                return list;                                                                                    //retorna essa lista com as informações porcessadas
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler/processar os acessos feitos no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }
        
        //metodo que lê as biometrias cadastradas no equipamento (sem processamento)
        public string LeBiometriasSemProcessamento() {
            try {                                                                                               //tenta ler as biometrias cadastradas no equipamento
                return WebJson.Send(urlDevice + "load_objects", "{\"object\":\"templates\"}", session);         //aqui lê e retorna as biometrias cadastradas no quipamento
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler as biometrias cadastradas no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os usuários cadastrados no equipamento (com processamento de informações)
        public ResultList LeUsuariosParaProcessamento() {
            try {                                                                                               //tenta ler os usuários cadastrados no equipamento 
                string users = WebJson.Send(urlDevice + "load_objects", "{\"object\":\"users\"}", session);     //variável que recebe as informações do usuário

                var serializer = new DataContractJsonSerializer(typeof(ResultList));                            //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(users));                         //transforma o stram em bytes

                var list = serializer.ReadObject(ms) as ResultList;                                             //transforma o stream em uma lista (de strings)

                return list;                                                                                    //retorna a lista com as informações 
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler os usuários cadastrados no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê as biometrias cadastradas no equipamento (com processamneto)
        public ResultList LeBiometriasParaProcessamento() {
            try {                                                                                                           //tenta ler as biometrias cadastradas no equipamento
                string templates = WebJson.Send(urlDevice + "load_objects", "{\"object\":\"templates\"}", session);         //variável recebe as biometrias cadastradas no equipamento

                var serializer = new DataContractJsonSerializer(typeof(ResultList));                            //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(templates));                     //transforma o stram em bytes

                var list = serializer.ReadObject(ms) as ResultList;                                             //transforma o stram em uma lista (de strings)

                return list;                                                                                    //aqui retorna a lista com as biometrias
            }
            catch {                                                                                             //caso não seja possivel ler as biometrias
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os cartões cadastrados no equipamento (sem processamento)
        public string LeCartoesSemProcessamento() {
            try {                                                                                               //tenta ler os cartões cadastrados no equipamento
                return WebJson.Send(urlDevice + "load_objects", "{\"object\":\"cards\"}", session);             //aqui lê e retorna os cartões cadastrados no equipamento
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler os cartões cadastrados no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }

        //metodo que lê os cartões cadastrados no equipamento (com processamneto)
        public ResultList LeCartoesParaProcessamento() {
            try {                                                                                               //tenta ler os cartões cadastrados no equipamento
                string cards = WebJson.Send(urlDevice + "load_objects", "{\"object\":\"cards\"}", session);     //variável recebe os carões cadastradas no equipamento

                var serializer = new DataContractJsonSerializer(typeof(ResultList));                            //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(cards));                         //transforma o stram em bytes

                var list = serializer.ReadObject(ms) as ResultList;                                             //transforma o stram em uma lista (de strings)

                return list;                                                                                    //retorna lista com os cartões cadastrados no equipamento
            }
            catch {                                                                                             //caso não seja possível ler e processar os cartões cadastrados no equipamento
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }
        #endregion


        #region Objetos

        #region Cadastro

        //metodo que cadastra/cria um objeto no equipamento, a partior de um command
        public string CadastrarObjeto(string cmd) {
            try {                                                                                               //tenta cadastrar/criaR um objeto (passado por parametro)
                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que cadastra/cria e recebe o objeto

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar/criaR o objeto
                MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }


        #region Biometria

        //metodo que lê, obtem e salva uma digital
        //retorna (sem processamneto)
        public string CadastraBiometria(int user_id) {
            try {                                                                                                                                                       //tenta ler, obter e salvar (no equipamento) a digital
                string cmd = "{\"type\": \"biometry\", \"user_id\": " + user_id + ", \"message\":\"Posicione o Dedo na Leitora\", \"sync\": true, \"save\": true}";     //comando que lê, obtem e salva (no equipamento) a digital

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                 //obtem, salva (no equipamento) e retorna (sucesso) a digital
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler, salvar (no equipamento) e obter a digital
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que lê e obtem uma digital
        //retorna (com processamneto) e não salva
        public Templates ObtemBiometriaProcessado() {
            try {                                                                                                                           //tenta ler e obter a digital
                string cmd = "{\"type\": \"biometry\", \"message\":\"Posicione o Dedo na Leitora\", \"sync\": true, \"save\": false}";      //comando que lê obtem a digital 

                string templates = WebJson.Send(urlDevice + "remote_enroll", cmd, session);                     //variável recebe a biometria lida no equipamento

                var serializer = new DataContractJsonSerializer(typeof(Templates));                             //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(templates));                     //transforma o stram em bytes

                var digital = serializer.ReadObject(ms) as Templates;                                           //transforma o stram em uma digital 

                return digital;                                                                                 //aqui retorna a biometria
            }
            catch {                                                                                             //caso não seja possivel ler, processar e obter a biometria
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que lê e salva uma digital
        //não retorna
        public string CadastraBiometriaSemRetorno(int user_id) {
            try {                                                                                                                                                           //tenta cadastrar a biometria (no equipamento)
                string cmd = "{\"type\": \"biometry\", \"user_id\": " + user_id + ", \"message\":\"Posicione o Dedo na Leitora\", \"sync\": false, \"save\": true}";        //comando que lê e salva a biometria

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                 //lê, salva (no equipamento) e reetorna a digital
            }
            catch {                                                                                             //caso não seja possivel ler e salvar (no equipamento) a biometria
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que lê e obtem uma digital
        //retorna (sem processamneto) e não salva
        public string ObtemBiometria() {
            try {                                                                                                                           //tenta ler e obter a digital
                string cmd = "{\"type\": \"biometry\", \"message\":\"Posicione o Dedo na Leitora\", \"sync\": true, \"save\": false}";      //comando que lê obtem a digital 

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                 //obtem e retorna (sucesso) a digital
            }
            catch (Exception ex) {                                                                              //caso não seja possível ler e obter a digital
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que lê, obtem e salva uma digital
        //retorna (com processamneto)
        public Templates CadastraBiometriaProcessado(int user_id) {
            try {                                                                                                                                                       //tenta ler, obter e salvar (no equipamento) a digital
                string cmd = "{\"type\": \"biometry\", \"user_id\": " + user_id + ", \"message\":\"Posicione o Dedo na Leitora\", \"sync\": true, \"save\": true}";     //comando que lê, obtem e salva (no equipamento) a digital

                string templates = WebJson.Send(urlDevice + "remote_enroll", cmd, session);                     //variável recebe a biometria lida e salva no equipamento

                var serializer = new DataContractJsonSerializer(typeof(Templates));                             //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(templates));                     //transforma o stram em bytes

                var digital = serializer.ReadObject(ms) as Templates;                                           //transforma o stram em uma digital

                return digital;                                                                                 //aqui retorna a biometria  
            }
            catch {                                                                                             //caso não seja possivel ler, processar, salvar (no equipamento) e obter a biometria
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que cadastra/cria uma biometria no equipamento
        public string CriaBiometria(int user_id, string template, long finger_type) {
            try {                                                                                                                                                                       //tenta cadastrar/criar uma biometira
                string cmd = "{\"object\": \"templates\", \"values\": [{\"finger_type\": " + finger_type + ",\"template\": \"" + template + "\",\"user_id\": " + user_id + "}]}";       //comando que cria a biometria

                var biometria = WebJson.Send(urlDevice + "create_objects", cmd, session);                       //variável que cadastra/cria e recebe a biometria

                return biometria;                                                                               //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar/cria a biometria
                MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        #endregion


        #region CartãoDeAcesso

        //metodo que lê, obtem e salva um cartão
        //retorna (sem processamneto)
        public string CadastraCartao(int user_id) {
            try {                                                                                                                                                       //tenta ler, obter e salvar (no equipamento) o cartão
                string cmd = "{\"type\": \"card\", \"user_id\": " + user_id + ", \"message\":\"Aproxime o Cartão da Leitora\", \"sync\": true, \"save\": true}";        //comando que lê, obtem e salva (no equipamento) o cartão

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                 //lê, obtem, salva (no equipamento) e retorna o cartão (sucesso)
            }
            catch {                                                                                             //caso não seja possivel ler, obter e salvar (no equipamento) o cartão
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }
        
        //metodo que lê, obtem e salva um cartão
        //retorna (com processamneto)
        public Cards CadastraCartaoProcessado(int user_id) {
            try {                                                                                                                                                       //tenta ler, obter e salvar (no equipamento) o carão
                string cmd = "{\"type\": \"card\", \"user_id\": " + user_id + ", \"message\":\"Aproxime o Cartão da Leitora\", \"sync\": true, \"save\": true}";        //comando que lê, obtem e salva (no equipamento) o cartão
 
                string card = WebJson.Send(urlDevice + "remote_enroll", cmd, session);                      //variável que lê, obtem e salva (no equipamento) o cartão

                var serializer = new DataContractJsonSerializer(typeof(Cards));                             //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(card));                      //transforma o stram em bytes

                var cartao = serializer.ReadObject(ms) as Cards;                                            //transforma o stram em um cartão

                return cartao;                                                                              //aqui retorna o cartão
            }
            catch (Exception ex) {                                                                          //caso não seja possível ler, processar, obter e salvar (no equipamento) o cartão
                //MessageBox.Show(ex.Message);
                return null;                                                                                //retorno de falha
            }
        }

        ///metodo que lê e salva uma digital
        //não retorna e salva
        public string CadastraCartaoSemRetorno(int user_id) {
            try {                                                                                                                                                       //tenta ler e salvar (no equipamento) o cartão
                string cmd = "{\"type\": \"card\", \"user_id\": " + user_id + ", \"message\":\"Aproxime o Cartão da Leitora\", \"sync\": false, \"save\": true}";       //comando que lê e salvar (no equipamento) o cartão

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                                                                         //lê, salva (no equipamento) o cartão
            }
            catch (Exception ex) {                                                                          //caso não seja possível ler e salvar (no equipamento) o cartão
                //MessageBox.Show(ex.Message);
                return null;                                                                                //retorno de falha
            }
        }

        //metodo que lê e obtem um cartão
        //retorna (sem processamneto) e não salva
        public string ObtemCartao() {
            try {                                                                                                                       //tenta ler e obter o cartão
                string cmd = "{\"type\": \"card\", \"message\":\"Aproxime o Cartão da Leitora\", \"sync\": true, \"save\": true}";      //comando que lê obtem a digital 

                return WebJson.Send(urlDevice + "remote_enroll", cmd, session);                                 //lê, obtem e retorna o cartão (sucesso)
            }
            catch {                                                                                             //caso não seja possivel ler e obter o cartão
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que lê e obtem um cartão
        //retorna (com processamneto) e não salva
        public Cards ObtemCartaoProcessado() {
            try {                                                                                                                       //tenta ler e obter o carão
                string cmd = "{\"type\": \"card\", \"message\":\"Aproxime o Cartão da Leitora\", \"sync\": true, \"save\": false}";     //comando que lê e obtem o cartão

                string card = WebJson.Send(urlDevice + "remote_enroll", cmd, session);                      //variável que lê e obtem o cartão

                var serializer = new DataContractJsonSerializer(typeof(Cards));                             //variável que serializa objetos para o objeto JSON (transformar um objeto que você possui em um stream de bytes ou de texto)

                var ms = new System.IO.MemoryStream(UTF8Encoding.UTF8.GetBytes(card));                      //transforma o stram em bytes

                var cartao = serializer.ReadObject(ms) as Cards;                                            //transforma o stram em um cartão

                return cartao;                                                                              //aqui retorna o cartão
            }
            catch (Exception ex) {                                                                          //caso não seja possível ler, processar e obter o cartão
                //MessageBox.Show(ex.Message); 
                return null;                                                                                //retorno de falha
            }
        }

        //metodo que cadastra/cria um cartão no equipamento
        public string CriaCartao(int user_id, long card_value) {
            try {                                                                                                                           //tenta cadastrar/criar um cartão
                string cmd = "{\"object\": \"cards\", \"values\": [{\"value\": " + card_value + ", \"user_id\": " + user_id + "}]}";        //comando que cria o cartão

                var biometria = WebJson.Send(urlDevice + "create_objects", cmd, session);                       //variável que cadastra/cria e recebe o cartão

                return biometria;                                                                               //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar/cria o cartão
                MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        #endregion


        #region Grupo/Departamento

        //metodo que cria um grupo sem id definido
        //retorna seu id;
        public string CriaGrupo() {
            try {
                string cmd = "{\"object\": \"groups\",\"values\": [{\"name\": \"Nome do Grupo\"}]}";

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);

                return usuario;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //metodo que cria um grupo com id definido
        //retorna seu id;
        public string CriaGrupo(int group_id) {
            try {
                string cmd = "{\"object\": \"groups\",\"values\": [{\"id\": " + group_id + ", \"name\": \"Nome do Grupo\"}]}";

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);

                return usuario;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        #endregion


        #region Usuario

        //metodo que cadastra um usuário 
        //sem id definido
        //retorna (sem processamneto)
        public string CadastrarUsuario() {
            try {                                                                                                                                           //tenta cadastrar o usuário
                string cmd = "{\"object\" : \"users\", \"values\": [{\"name\": \"Nome\",\"registration\": \"\",\"password\": \"\",\"salt\": \"\"}]}";       //comando para cadatrar um usuário (sem ID definido)

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que cadstra o usuário e recebe seu ID não processado

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar o usuário
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que cadastra um usuário 
        //com id definido
        //retorna (sem processamneto)
        public string CadastrarUsuario(int _id) {                                                               
            try {                                                                                                                                                               //tenta cadastrar o usuário
                string cmd = "{\"object\" : \"users\", \"values\": [{\"id\": " + _id + ",\"name\": \"Nome\",\"registration\": \"\",\"password\": \"\",\"salt\": \"\"}]}";       //comando para cadastrar um usuário (com ID definido - passado por parâmetro)

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que cadastra o usuário e recebe seu id não processado

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar o usuário
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        #endregion


        #region Visitante

        //metodo que cadastra um visitante 
        //sem id definido
        //retorna (sem processamneto)
        public string CadastrarVisitante() {
            try {                                                                                               //tenta cadastrar o visitante
                long agora = FuncoesUteis.ConvertToTimestamp(DateTime.Now);                                     //pega o valor da data atual
                long limite = FuncoesUteis.ConvertToTimestamp(DateTime.Today.AddDays(1));                       //pega o valor da data limite (amanha 00:00:00)

                string cmd = "{\"object\" : \"users\", \"values\": [{\"name\": \"Nome\",\"registration\": \"\",\"password\": \"\",\"salt\": \"\", \"begin_time\": " + agora + ", \"end_time\": " + limite + "}]}";       //comando para cadatrar um visitante (sem ID definido)

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que cadstra o visitante e recebe seu ID não processado

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar o visitante
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que cadastra um visitante 
        //com id definido
        //retorna (sem processamneto)
        public string CadastrarVisitante(int _id) {
            try {                                                                                               //tenta cadastrar o visitante
                long agora = FuncoesUteis.ConvertToTimestamp(DateTime.Now);                                     //pega o valor da data atual
                long limite = FuncoesUteis.ConvertToTimestamp(DateTime.Today.AddDays(1));                       //pega o valor da data limite (amanha 00:00:00)

                string cmd = "{\"object\" : \"users\", \"values\": [{\"id\": " + _id + ",\"name\": \"Nome\",\"registration\": \"\",\"password\": \"\",\"salt\": \"\", \"begin_time\": " + agora + ", \"end_time\": " + limite + "}]}";       //comando para cadastrar um visitante (com ID definido - passado por parâmetro)

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que cadastra o visitante e recebe seu id não processado

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível cadastrar o visitante
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        #endregion


        #region Outros

        //metodo que associa um usuário/visitante a um grupo(departamento)
        public string AssociaGrupo(int user_id, int group_id) {
            try {                                                                                                                               //tenta associar um usuário/visitante a um grupo(departamento)
                string cmd = "{\"object\" : \"user_groups\", \"values\": [{\"user_id\": " + user_id + ",\"group_id\": " + group_id + "}]}";       //comando que associa um usuário/visitante a um grupo

                var usuario = WebJson.Send(urlDevice + "create_objects", cmd, session);                         //variável que associa e recebe a associação

                return usuario;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível associar o usuário/visitante ao grupo(departamento)
                MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }

        }

        #endregion

        #endregion


        #region Deleção

        //metedo que apaga um objeto no equipamento, a partior de um command
        public string ApagarObjeto(string cmd) {
            try {                                                                                       //tenta apagar um objeto (passado por parametro)
                return WebJson.Send(urlDevice + "destroy_objects", cmd, session);                       //apaga o obejto e retorna sucesso
            }
            catch (Exception ex) {                                                                      //caso não seja possível apagar o objeto
                //MessageBox.Show(ex.Message);
                return null;                                                                            //retorno de falha
            }
        }

        //metodo que apaga usuario
        public string ApagarUsuario(long user_id) {
            try {                                                                                                   //tenta apagar o cartão
                string cmd = "{\"object\": \"users\",\"where\": {\"users\": {\"id\": " + user_id + " } } }";        //comando que apaga o cartão

                var aux = WebJson.Send(urlDevice + "destroy_objects", cmd, session);                        //apaga o usuário

                var b = ApagarBiometria(user_id);                                                           //apaga a biometria do usuário
                var c = ApagarCartão(user_id);                                                              //apaga o cartão do usuário

                return aux;                                                                                 //retorno de sucesso
            }
            catch (Exception ex) {                                                                          //caso não seja possível apagar o usuário
                //MessageBox.Show(ex.Message);
                return null;                                                                                //retorno de falha
            }
        }

        //metodo que apaga uma biometria
        //apaga todas que possuem o user_id do parâmetro
        public string ApagarBiometria(long user_id) {
            try {                                                                                                               //tenta apagar a(s) biometria(s)
                string cmd = "{\"object\": \"templates\",\"where\": {\"templates\": {\"user_id\": " + user_id + "} } }";        //comando que apaga a(s) biometria(s)

                return WebJson.Send(urlDevice + "destroy_objects", cmd, session);                           //apaga a(s) biometria(s) e retorna sucesso
            }
            catch (Exception ex) {                                                                          //caso não seja possível apagar a(s) biometria(s)
                //MessageBox.Show(ex.Message);
                return null;                                                                                //retorno de falha
            }
        }

        //metodo que apaga cartão de acesso 
        //apaga todos que possuem o user_id do parâmetro
        public string ApagarCartão(long user_id) {
            try {                                                                                                       //tenta apagar o(s) cartão(s)
                string cmd = "{\"object\": \"cards\",\"where\": {\"cards\": {\"user_id\": " + user_id + " } } }";       //comando que apaga o(s) cartão(s)

                return WebJson.Send(urlDevice + "destroy_objects", cmd, session);                           //apaga o(s) cartão(s) e retorna sucesso                                                          
            }
            catch (Exception ex) {                                                                          //caso não seja possível apagar o(s) cartão(s)
                //MessageBox.Show(ex.Message);
                return null;                                                                                //retorno de falha
            }
        }

        #endregion

        
        #region Utils

        //metodo que processa o ID do usuário
        public int ProcessaID(string usuario) {
            var cd = "";                                                                                        //variável que reebera o processamento do ID do usuário
            for (var i = 8; i <= 14; i++) {                                                                     //laço que percorre o ID não processado (ele possui um tamanho fixo)
                cd += usuario[i];                                                                               //aqui acontece o processamento - variável 'cd' recebe cada número do ID
            }

            return int.Parse(cd);                                                                               //retorno do ID, já processado
        }

        #endregion

        #endregion


        #endregion

    }
}
