using System;
using System.Windows.Forms;

namespace INSTALADOR_EWOD_SERVIDOR.VISIONS
{
    public partial class testarConexao : Form
    {

        //CLASSE PRINCIPAL TELA INICIAL




        #region VÁRIAVEIS E INSTÃNCIAS
        #endregion






        #region CONSTRUTOR
        public testarConexao()
        {
            InitializeComponent();
            txtIp.Focus(); //MÉTODO PARA INICIAR FOCANDO NO CAMPO IP
        }
        #endregion






        #region MÉTODOS DE FUNCIONALIDADES

        public void coletaInformacoes()
        {
            //IRÁ COLETAR AS INFORMAÇÕES DIGITADAS PELO USUÁRIO, PARA ENCAMINHAR PARA O PRÓXIMO FORMULÁRIO
            enderecoIp.ipBancodeDados = txtIp.Text; //IP
            nomeBanco.nomeBancodeDados = txtInstancia.Text; //NOME 
        }


        public static class enderecoIp
        {
            //CLASSE ESTÁTICA PARa SEMPRE MANTER O MESMO VALOR DEPOIS DE IR PARA A PRÓXIMA TELA  (IP)
            public static string ipBancodeDados;
        }

        public static class nomeBanco
        {
            //CLASSE ESTÁTICA PARa SEMPRE MANTER O MESMO VALOR DEPOIS DE IR PARA A PRÓXIMA TELA  (IP)
            public static string nomeBancodeDados;
        }


        #endregion






        #region DESIGN
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {

            coletaInformacoes(); //CHAMADA DO MÉTODO PARA COLETAR AS INFORMAÇÕES E ARMAZENAR NA CLASSE ESTÁTICA


            inserirUsuarioESenha inserirSenha = new inserirUsuarioESenha(); //INSTÂNCIANDO A TELA DE INSERÇÃO DE USUÁRIO E SENHA 

            this.Hide(); //ESCONDENDO TELA DE IP E NOME
            inserirSenha.Show(); //ABRINDO A TELA DE INSERÇÃO DE USÚÁRIO E SENHA 


        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            //SAIR DA APLICAÇÃO
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //MINIMIZA A APLICAÇÃO
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion


    }
}
