using System;
using System.Data.SqlClient;
using static INSTALADOR_EWOD_SERVIDOR.VISIONS.inserirUsuarioESenha;

namespace INSTALADOR_EWOD_SERVIDOR.BANCO.BD
{
    public class Conexao
    {
        
        //CLASSE DE CONEXAO E TESTE DE CONEXAO





        #region VARIÁVEIS E INSTÂNCIAS

        #region SQL
        SqlConnection con = new SqlConnection();


        public String mensagem = "";
        public bool verificaConexao = false;
        #endregion

        #region VEM DO FORM

           

            #endregion

        #endregion






        #region CONSTRUTOR

        public Conexao()
        {
            
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

     

        public SqlConnection Conectar()
        {
            con.ConnectionString = @"Data Source= tcp: " + ipBancoExport.ipBancodeDadosExport + ";Initial Catalog=" + 
                nomeBancoExport.nomeBancodeDadosExport + ";User ID=" + usuarioBancoExport.userBancodeDadosExport + 
                ";Password=" + senhaBancoExport.senhaBancodeDadosExport + ";connection timeout = 1";

            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    
                    con.Open();
                    this.mensagem = "";
                }

                catch (SqlException)
                {

                    this.mensagem = "ERRO DE CONEXÃO COM O SERVIDOR";
                }
                
            }
            return con;
        } //CONECTA

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        } //DESCONECTA
        #endregion






    }
}