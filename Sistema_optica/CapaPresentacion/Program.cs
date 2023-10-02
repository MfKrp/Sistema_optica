using CapaPresentacion.Sesion;
using CapaPresentacion.Superadmin;
using CapaPresentacion.Secretaria;
using CapaPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Alta_cliente());
        }
    }
}