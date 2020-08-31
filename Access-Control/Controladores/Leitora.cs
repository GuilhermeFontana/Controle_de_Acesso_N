using System;

using Neomot_Access_Control.ControladorUtils;


namespace Neomot_Access_Control.Controladores {
    class Leitora : Controlador {

        #region Contrutores

        public Leitora() : base() { }                                                                           //contrutor padrão (utilizando o contrutor padrão da classe 'Controlador')
        public Leitora(string IP, int numPorta, bool SSL, string Usuario, string Senha) :                       //contrutor com parâmetros (utilizando o contrutor com parâmetros da classe 'Controlador')
            base(IP, numPorta, SSL, Usuario, Senha) { }                                                         //aqui os parametros são enviados para o contrutor da "classe pai"

        #endregion

        #region Interacoes

        //metodo que liga rele do controlador
        public int? LigarReleControlador(int NumRele) {
            try {                                                                                               //tenta realizar ligar o rele do aparelho

                // Eventualmente pode ser necessário habilitar o rele em questão
                // WebJson.Send(urlDevice + "set_configuration", "{\"general\":{\"relay1_enabled\": \"1\",\"relay2_enabled\": \"1\"}}");  


                string cmd = "{\"actions\":[{\"action\": \"door\", \"parameters\":\"door=" + NumRele + "\"}]}";     //variável para executar o comando de abrir o relê                                  

                response = WebJson.Send(urlDevice + "execute_actions", cmd, session);                           //aqui executa o comando e mostra resultado na tela
                return 1;                                                                                       //retorno de rele ligado com exito
            }
            catch (Exception ex) {                                                                              //no caso de o rele não ligar
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro 
            }
        }

        #endregion

    }
}
