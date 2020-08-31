using System;

using Neomot_Access_Control.ControladorUtils;


namespace Neomot_Access_Control.Controladores {
    class Catraca : Controlador {

        #region Contrutores

        public Catraca() : base() { }                                                                           //contrutor padrão (utilizando o contrutor padrão da classe 'Controlador')
        public Catraca(string IP, int numPorta, bool SSL, string Usuario, string Senha) :                       //contrutor com parâmetros (utilizando o contrutor com parâmetros da classe 'Controlador')
            base(IP, numPorta, SSL, Usuario, Senha) { }                                                         //aqui os parametros são enviados para o contrutor da "classe pai"

        #endregion

        #region Interacoes

        //metodo que abre urna coletora de cortões
        public int? AbrirUrnaColetoraDeCartoes() {                                                                                                
            try {                                                                                               //tenta liberar abrir a urna coletora
                string cmd = "{\"actions\":[{\"action\": \"open_collector\", \"parameters\":\"\"}]}";           //variável para executar o comando de abrir o relê


                response = WebJson.Send(urlDevice + "execute_actions", cmd, session);                           //aqui executa o comando e retorna o resultado
                return 1;                                                                                       //retorno de sucesso
            }
            catch (Exception ex) {                                                                              //caso não seja possível abrir a urna coletora
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de falha
            }
        }

        //metodo que libera catraca 
        public string LiberaCatraca(int indexGiro) {
            try {                                                                                               //tenta liberar a catraca
                if (indexGiro == 1)                                                                                                                                                 //verifica se o indice de giro informado no parâmetro é igual a 1
                    return WebJson.Send(urlDevice + "execute_actions", "{\"actions\":[{\"action\": \"catra\", \"parameters\":\"allow=clockwise\"}]}", session);                     //executa o comando de giro (sentido horário) e o retorna
                else if (indexGiro == 2)                                                                                                                                            //verifica se o indice de giro informado no parâmetro é igual a 1
                    return WebJson.Send(urlDevice + "execute_actions", "{\"actions\":[{\"action\": \"catra\", \"parameters\":\"allow=anticlockwise\"}]}", session);                 //executa o comande de giro (sentido anti-horário) e o retorna
                else                                                                                                                                                                //(indice 0)
                    return WebJson.Send(urlDevice + "execute_actions", "{\"actions\":[{\"action\": \"catra\", \"parameters\":\"allow=both\"}]}", session);                          //executa o comando de giro (qualquer sentido) e o retorna

            }
            catch (Exception ex) {                                                                              //caso não seja possível liberar a catraca
                //MessageBox.Show(ex.Message);
                return null;                                                                                    //retorno de erro
            }
        }
        
        #endregion
    }
}
