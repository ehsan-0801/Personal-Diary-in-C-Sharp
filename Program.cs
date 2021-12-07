using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryMaker
{
   
    static class Program
    {
        public static int User_Id;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int x = 3;
            int y = x * 3;
            int z = y - x;

            Application.Run(new LoginForm());
        }
    }
}
