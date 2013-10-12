using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TRANSPORTESANITARIO.Interface;

namespace TRANSPORTESANITARIO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new frmFichadeAtendimento(5995));
           // Application.Run(new frmGerenciaEmpenhos());
        }
    }
}
