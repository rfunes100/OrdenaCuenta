using OrdenaCuenta.View;
using OrdenaCuenta.View.Cliente;
using OrdenaCuenta.View.Rolfrm;
using OrdenaCuenta.View.Usuariofrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Mainfrm());
            // Application.Run(new ClienteAdd());
          //  Application.Run(new UsuarioShow());

            // Application.Run(new Partidafrm());
        }
    }
}
