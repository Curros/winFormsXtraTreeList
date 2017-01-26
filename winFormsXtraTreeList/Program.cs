using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormsXtraTreeList
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(Debugger.IsAttached)
            {
                Application.Run(new frmTreeListX());
            }
            else
            {
                Application.Run(new frmStart());
            }
        }
    }
}
