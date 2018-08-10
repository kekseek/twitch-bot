using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchChatBot
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }


    /// <summary>
    /// Class that stores main auth info. 
    /// </summary>
    class Data {
        public static string TwitchLogin {
            get;
            set; 
        }

        public static string OauthToken {
            get;
            set;
        }
    }
}
