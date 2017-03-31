using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAVLogica;
using Persistencia;
using PersistenciaImp;

namespace WindowsFormsApplication1
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
            IPersistencia ip = new PersistenciaImpl();
            ObjPersistente.IP = ip;
            Menu inicio = new Menu();
            inicio.StartPosition = FormStartPosition.Manual;
            Application.Run(inicio);
            //Application.Run(new Menu());
        }
    }
}
