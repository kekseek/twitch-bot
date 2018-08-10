using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchChatBot {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Recieves user input data. 
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e) {
            OauthErrorHandler.Text = "";
            LoginErrorHandler.Text = "";

            if (TwitchLoginTextBox.Text.Length != 0) {
                Data.TwitchLogin = TwitchLoginTextBox.Text;
            }
            else {
                Console.WriteLine("Write your twitch name.");
                LoginErrorHandler.Text = "Write your twitch name here";
            }

            if (OauthTokenTextBox.Text.Length != 0) {
                Data.OauthToken = OauthTokenTextBox.Text;
            }
            else {
                Console.WriteLine("Write your oauth token.");
                OauthErrorHandler.Text = "Write your oauth token here";
            }

            if (TwitchLoginTextBox.Text.Length != 0 && OauthTokenTextBox.Text.Length != 0) {
                MainForm MainForm = new MainForm();
                MainForm.Show();

                this.Hide();
            }
            else {
                TwitchLoginTextBox.Clear();
                OauthTokenTextBox.Clear();
            }
        }
    }
}
