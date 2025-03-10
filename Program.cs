using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Clicks 
    {
        public static int clicks = 0;

        public static void AddClick()
        { 
            clicks++;
        }
        public static void RemoveClick() { clicks = 0; }
    }

    public static class Timer 
    {

    }
}
