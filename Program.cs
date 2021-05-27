using INSTALADOR_EWOD_SERVIDOR.VISIONS;
using System;
using System.Windows.Forms;

namespace INSTALADOR_EWOD_SERVIDOR
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new testarConexao());
        }
    }
}
