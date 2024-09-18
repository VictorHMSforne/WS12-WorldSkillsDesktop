﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
            //Adaptando a string flexível criada, para poder pegar o diretório atual do arquivo
            AppDomain.CurrentDomain.SetData("DataDirecotry", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
