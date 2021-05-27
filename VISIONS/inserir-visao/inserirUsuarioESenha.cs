using INSTALADOR_EWOD_SERVIDOR.BANCO.BD;
using System;
using System.Windows.Forms;
using static INSTALADOR_EWOD_SERVIDOR.VISIONS.testarConexao;

namespace INSTALADOR_EWOD_SERVIDOR.VISIONS
{
    public partial class inserirUsuarioESenha : Form
    {

        //CLASSE PRINCIPAL TELA DE INSERÇÃO DE SENHA






        #region VÁRIAVEIS E INSTÂNCIAS

        string ipBanco;
        string nomeBancodeDadoss;

        testarConexao testarConex = new testarConexao();

        Conexao con = new Conexao();

        string estadodaconexao = "";

        #endregion






        #region CONSTRUTOR

        public inserirUsuarioESenha()
        {
            InitializeComponent();
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public void coletaDadosDaTelaAnterior()
        {

            ipBanco = enderecoIp.ipBancodeDados;
            nomeBancodeDadoss = nomeBanco.nomeBancodeDados;
        }

        public void coletaInformacoes()
        {

            ipBancoExport.ipBancodeDadosExport = ipBanco;

            nomeBancoExport.nomeBancodeDadosExport = nomeBancodeDadoss;

            usuarioBancoExport.userBancodeDadosExport = txtUser.Text;

            senhaBancoExport.senhaBancodeDadosExport = txtSenha.Text;

        }

        public static class estadoConexao
        {
            public static string estadoConex;
        }

        public static class ipBancoExport
        {
            public static String ipBancodeDadosExport;
        }

        public static class nomeBancoExport
        {
            public static String nomeBancodeDadosExport;
        }

        public static class usuarioBancoExport
        {
            public static String userBancodeDadosExport;
        }

        public static class senhaBancoExport
        {
            public static String senhaBancodeDadosExport;
        }

        public void conectarAoBanco()
        {
            coletaDadosDaTelaAnterior();

            coletaInformacoes();

            con.Conectar();

            String mensagem = con.mensagem;
            if (mensagem == "")
            {
                MessageBox.Show("CONEXÃO COM O BANCO DE DADOS ESTABELECIDA!", "CONECTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                instalador menu = new instalador();
                this.Hide();

                estadoConexao.estadoConex = "Online";

                menu.ShowDialog();

            }
            else
            {
                MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                estadoConexao.estadoConex = "Offline";
                testarConex.ShowDialog();
            }



            con.Desconectar();
        }



        #endregion






        #region DESIGN
        private void btndeslogar_Click(object sender, EventArgs e)
        {
            conectarAoBanco(); //CHAMA O MÉTODO DE TESTE DA CONEXÃO REALIZA AS VALIDAÇÕES E ABRE
            testarConexao teste = new testarConexao(); //FECHA A TELA ATUAL

            teste.Hide(); //FECHA A TELA ATUAL
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //FECHA A TELA ATUAL
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //MINIMIZA A APLICAÇÃO 
            this.WindowState = FormWindowState.Minimized;
        }

        private void inserirUsuarioESenha_Load(object sender, EventArgs e)
        {

        }



        #endregion


    }
}
