using System;           
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Neomot_Access_Control.Conexao{
    class ConexaoDB {
        
        //VARIÁVEIS GLOBAIS
        private static MySqlConnection con;                                                     //variável para estabelecer conexão com o banco de dados

        //função que estabeleve conexão com o DB 
        public static int? Conectar() {                                                 

            //USA-SE A PORTA PADRÃO 3306, PORTANTO OS DADOS SÃO INCERIDOS NO MariaDB
            SqlConnectionStringBuilder connectionstring = new SqlConnectionStringBuilder();     //cria a string para conectar com o banco de dados
            connectionstring.DataSource = "127.0.0.1";                                          //ip de conexão
            connectionstring.InitialCatalog = "acesso";                                         //banco de dados que sera conectado
            connectionstring.UserID = "root";                                                   //nome do usuário do banco de dados
            connectionstring.Password = "controlid";                                            //senha do usuário do banco de dados

            try {  //tenta fazer a conexão
                
                              
                
                con = new MySqlConnection(connectionstring.ToString());                         //estabelece conexão
                con.Open();                                                                     //abre a conexão

                return 1;                                                                       //retorno de conexão aberta

            }                                                                                   //se não conextar
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

                return null;                                                                    //retorno se a conexão não for aberta
            }

        }


        //função que retorna o objeto de conexão
        public static MySqlConnection GetConexao() {                                            //retorna o objeto de conexão
            return con;                                                                         //retorna aqui

        }

    }
}
