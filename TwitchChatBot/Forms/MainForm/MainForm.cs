using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TwitchChatBot {
    public partial class MainForm : Form {
        MessagesScanner messagesScanner;

        public MainForm() {
            InitializeComponent();
            messagesScanner = new MessagesScanner(aLabel);
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            messagesScanner.TimerTick();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
        
    }
}
