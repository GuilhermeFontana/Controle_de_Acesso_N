using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;

namespace Neomot_Access_Control.Conexao {
    class MetodosDB {

        //GET Cd's para novos cadastros
        static public int GetCdNovo(string sql) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar o código retornado do banco 
            string output = "";                                                                 //para dar a saida ao código

            if (estouConectado != null){                                                        //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui pega o código retoornado do banco

                while (dataReader.Read()) {                                                     //laço para ler o código retorndo do banco
                    output += dataReader.GetValue(0);                                           //passa para a variável o código retornado
                }

                return int.Parse(output) + 1;                                                   //retorna o código +1 (o código retorna o número de cadastros, para ser um código valido para um novo cadastro deve ser 1 valor maior)
            }
            else {
                return -1;                                                                      //retorna que nenhum código foi retornado
            }
        }

        //GET Cd's de algum cadastros
        static public int GetCdExistente(string sql) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar o código retornado do banco
            string output = "";                                                                 //para dar a saida ao código


            if (estouConectado != null){                                                        //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui pega o código retornado do banco

                while (dataReader.Read()){                                                      //laço para ler o código retorndo do banco
                    output += dataReader.GetValue(0);                                           //passa para a variável o código retornado
                }

                return int.Parse(output);                                                       //retorna o código
            }
            else {
                return -1;                                                                      //retorna que nenhum código foi retornado
            }
        }

        //GET Informações (DataTable)
        static public DataTable GetDescrOrName(string sql) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar o código retornado do banco

            if (estouConectado != null){                                                        //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                DataTable dt = new DataTable();                                                 //cria uma tabela para receber os dados do banco
                dt.Load(dataReader);                                                            //prenche a tabela criada

                return dt;

                //comboBox2.DisplayMember = "descrTipo";                                        //define qual campo da tabela criada sera apresentado no comboBox
                //comboBox2.DataSource = dt;                                                    //prenche o comboBox com a tabela
            }
            else {
                DataTable dt = new DataTable();                                                 //cria tabela vazia
                return dt;                                                                      //retorna tabela vazia
            }

        }

        //GET cd's a partir de nomes, descrições ou informações
        static public int GetCdOfInfo(string sql) {
            
            //variávies para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar infrmações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para abrir conexão com o banco
            string output = "";                                                                 //para dar a saida ao código

            if (estouConectado != null){                                                        //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                while (dataReader.Read()) {                                                     //laço para ler o código retorndo do banco
                    output += dataReader.GetValue(0);                                           //passa para a variável o código retornado
                }

                if (output != "") {                                                             //verifica se algum código foi encontrado
                    MessageBox.Show(output);
                    return int.Parse(output);                                                   //retorna o código
                }
                else
                    return -1;                                                                  //retorna que nenhum código foi retornado
            }
            else {
                return -1;                                                                      //retorna que nenhum código foi retornado
            }
        }

        //GET nomes, descrições ou informações a partir de cd's
        static public string GetInfoOfCd(string sql) {
           
            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar a informação retornada do banco
            string output = "";                                                                 //para dar a saida à informações

            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                while (dataReader.Read()){                                                      //laço para ler as informações retorndas do banco
                    output += dataReader.GetValue(0);                                           //passa para a variável a informação retornada
                }

                return output;                                                                  //retorna a informação
            }
            else {
                return "";                                                                      //retorna que nenhuma informação foi retornada
            }
        }

        //GET lista de algum cadastros
        static public List<string> GetListaDeInfo(string sql) {

            //variável para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variável para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar a informação retornada do banco
            var output = new List<string>();                                                       //lista para dar a saida à informações (vazia)


            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                while (dataReader.Read()){                                                      //laço para ler as informações retorndas do banco
                    output.Add(dataReader.GetValue(0).ToString());      //adiciona a informação a lista
                }

                return output;                                                                  //retorna a lista com as informações
            }
            else {
                return output;                                                                  //retorna lista vazia
            }
        }

        //GET lista do código de algum cadastros
        static public List<int> GetListaDeCd(string sql) {

            //variável para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variável para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar a informação retornada do banco
            var output = new List<int>();                                                       //lista para dar a saida à informações (vazia)


            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                while (dataReader.Read()) {                                                     //laço para ler as informações retorndas do banco
                    output.Add(int.Parse(dataReader.GetValue(0).ToString()));                   //adiciona a informação a lista
                }

                return output;                                                                  //retorna a lista com as informações
            }
            else {
                return output;                                                                  //retorna lista vazia
            }
        }

        //GET Foto Usuário
        static public Image GetFoto(string sql) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader dataReader;                                                         //para pegar a foto retornada do banco
            byte[] output = null;                                                               //variável para receber a foto

            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                dataReader = command.ExecuteReader();                                           //aqui lê o banco

                while (dataReader.Read()) {                                                     //laço para ler as informações retorndas do banco
                    output = (byte[])(dataReader["foto"]);                                      //passa a foto para a variável
                }


                //CONVERÇÃO DA IMAGEM DE 'bytes' PARA 'image'                                                         
                if (output != null) {                                                           //verifica se uma imagem foi retornada
                    MemoryStream mStream = new MemoryStream(output);                            //guarda uma quantidade de bytes 
                    return System.Drawing.Image.FromStream(mStream);                            //transforma a imagem de binarios para uma image e retorna ela
                }
                else {
                    return null;                                                                //retorna nulo
                }
            }
            else {
                return null;                                                                    //retorna nulo
            }
        }


        //METODOS 
        //Cadastrar (Exceto Foto do Usuário)
        static public int? CadastrarOuEditar(string sql) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataAdapter adapter = new MySqlDataAdapter();                                  //para pegar a foto retornada do banco

            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida

                try {
                    command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                    adapter.InsertCommand = new MySqlCommand(sql, con);                             //aqui insere comando no banco

                    adapter.InsertCommand.ExecuteNonQuery();                                        //aqui cadastra efetivamente

                    command.Dispose();                                                              //aqui finaliza a conexão
                    con.Close();                                                                    //aqui fecha a conexão
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
                return 1;                                                                       //retorno se o cadatro ou a edição tiverem sidos feitos corretamente
            }
            else
                return null;                                                                    //retorno se o cadatro ou a edição não tiverem sidos feitos corretamente
        }

        
        //Salvar foto do empreendimento/usuário
        static public int? SalvarFoto(string caminhoFoto, int cdFoto, int tipo) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar  

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader reader;                                                             //para pegar a foto retornada do banco

            //outras variáveis
            byte[] imgByte = null;                                                              //variável para receber imagem 

            //CONVERSÃO DA IMAGEM DE 'byte' PARA BINARIO
            FileStream fStream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read);   //'FileStream' usado para inserir os bytes de uma imagem (em binario)
            BinaryReader br = new BinaryReader(fStream);                                        //leitor de dados binarios
            imgByte = br.ReadBytes((int)fStream.Length);                                        //colocamos o dado binario no array

            string sql = $"INSERT INTO cadastros.fotos VALUES (@cdFoto, {tipo}, @foto, 1)";     //sql para salvar a imagem no banco

            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco

                command.Parameters.Add(new MySqlParameter("@cdFoto", cdFoto));                  //aqui adicona um paramtro para salvar imagem no banco de dados (cdFoto - código da foto)
                command.Parameters.Add(new MySqlParameter("@foto", imgByte));                   //aqui adicona um paramtro para salvar imagem no banco de dados (foto - foto propriamente)

                reader = command.ExecuteReader();                                               //aqui cadastra efetivamente

                command.Dispose();                                                              //aqui finaliza a conexão
                con.Close();                                                                    //aqui fecha a conexão

                return 1;                                                                       //retorno se a imagem foi salva com sucesso
            }
            else
                return null;                                                                    //retorno se a imagem não foi salva com sucesso
        }

        //Editar foto do usuário
        static public int? EditarFoto(string caminhoFoto, int cdFoto, int tipo) {

            //variáveis para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar  

            //variáveis para utilizar informações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataReader reader;                                                             //para pegar a foto retornada do banco

            //outras variáveis
            byte[] imgByte = null;
            FileStream fStream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read);   //'FileStream' usado para inserir os bytes de uma imagem (em binario)
            BinaryReader br = new BinaryReader(fStream);                                        //leitor de dados binarios
            imgByte = br.ReadBytes((int)fStream.Length);                                        //colocamos o dado binario no array

            string sql = $"UPDATE cadastros.fotos SET foto = @foto WHERE cdFoto = @cdFoto AND tipoFoto = {tipo}";                //sql para editar a imagem no banco


            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco

                command.Parameters.Add(new MySqlParameter("@cdFoto", cdFoto));                  //aqui adicona um paramtro para editar imagem no banco de dados (cdFoto - código da foto)
                command.Parameters.Add(new MySqlParameter("@foto", imgByte));                   //aqui adicona um paramtro para editar imagem no banco de dados (cdFoto - código da foto)

                reader = command.ExecuteReader();                                               //aqui edita efetivamente

                command.Dispose();                                                              //aqui finaliza a conexão
                con.Close();                                                                    //aqui fecha a conexão

                return 1;                                                                       //retorno se a imagem foi salva com sucesso
            }
            else
                return null;                                                                    //retorno se a imagem foi salva com sucesso

        }

        //Apagar qualquer cadasto
        static public int? Apagar(string sql) {

            //variável para conexão com o banco
            int? estouConectado = ConexaoDB.Conectar();                                         //estabelece conexão com o banco de dados
            MySqlConnection con = ConexaoDB.GetConexao();                                       //pega conexao aberta para utilizar 

            //variável para utilizar infrmações o banco
            MySqlCommand command;                                                               //para abrir conexão com o banco
            MySqlDataAdapter adapter = new MySqlDataAdapter();                                  //para executar o sql no banco

            if (estouConectado != null) {                                                       //verifica se a conexão foi estabelecida
                command = new MySqlCommand(sql, con);                                           //aqui abre a conexão com o banco
                adapter.InsertCommand = new MySqlCommand(sql, con);                             
                adapter.InsertCommand.ExecuteNonQuery();                                        //aqui executa o sql

                command.Dispose();                                                              //aqui finaliza a conexão
                con.Close();                                                                    //aqui fecha a conexão

                return 1;                                                                       //retorno se a deleção foi feita com sucesso
            }
            else
                return null;                                                                    //retorno se a deleção não foi feita com sucesso       
        }
    }
}
