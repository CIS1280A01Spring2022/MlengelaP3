/***********************************************************************
 * Program: Store Order
 * Programmer: Daudi Mlengela (dmlengela@cnm.edu)
 * Date: 1 March 2022
 * Purpose: Store order class with properties and constructors
 * *********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MlengelaP3
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
            Application.Run(new Form1());
        }
    }
}
