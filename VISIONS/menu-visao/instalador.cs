using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Drawing;
using INSTALADOR_EWOD_SERVIDOR.VISIONS;
using static INSTALADOR_EWOD_SERVIDOR.VISIONS.inserirUsuarioESenha;
using System.Diagnostics;

namespace INSTALADOR_EWOD_SERVIDOR
{
    public partial class instalador : Form
    {

        //CLASSE PRINCIPAL TELA MENU





        #region VAIÁVEIS E INSTÂNCIAS

        #endregion






        #region CONSTRUTOR
        public instalador()
        {
            InitializeComponent();
        }
        #endregion








        #region MÉTODOS DE FUNCIONALIDADES
        public void verificaStatusConexao()
        {
            if (estadoConexao.estadoConex == "Online")
            {
                lblconex.Text = "ONLINE";
                lblconex.ForeColor = Color.Lime;
            }
            else
            {
                lblconex.Text = "OFFLINE";
                lblconex.ForeColor = Color.Red;
            }
        }
        #endregion






        #region DESIGN
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btndeslogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            testarConexao testar = new testarConexao();
            testar.ShowDialog();


        }
        private void instalador_Load(object sender, EventArgs e)
        {

            verificaStatusConexao();

        }





        #endregion

        private void btncadastroProdutos_MouseEnter(object sender, EventArgs e)
        {
            btncadastroProdutos.Size = new Size(265, 150);
            label2.Visible = true;
        }

        private void btncadastroProdutos_MouseLeave(object sender, EventArgs e)
        {
            btncadastroProdutos.Size = new Size(265, 127);
            label2.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(265, 150);
            label3.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(265, 127);
            label3.Visible = false;
        }

        private void btncadastroProdutos_Click(object sender, EventArgs e)
        {
            Process bat = Process.Start(
            @"C:\EWOD\radmin.bat");

            


            if (bat.WaitForExit(10000))
            {
                Process RADMIN = Process.Start(
               @"C:\EWOD\radminvpn.exe");

                if (RADMIN.WaitForExit(1000000000))
                {
                    Process ewod = Process.Start(
                    @"C:\EWOD\ewod.bat");

                    if (ewod.WaitForExit(10000))
                    {
                        Process setup = Process.Start(
                        @"C:\EWOD\setup.exe");
                    }
                }
            }

        
        
             
           




        }
    }
}
