using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TwitchChatBot {
    class MessagesScanner {
        private TcpClient tcpClient;
        private StreamReader reader;
        private StreamWriter writer;
        private Label Form1ChatLabel;

        readonly string userName, password, channelName, chatCommandId, chatMessagePrefix;
        private DateTime lastMessage;

        private Queue<string> sendMessageQueue;

        /* request */
        public MessagesScanner(Label aLabel) {
            sendMessageQueue = new Queue<string>();
            Form1ChatLabel = aLabel;
            userName = "PUT_YOUR_TWITCH_LOGIN_NAME_HERE".ToLower();
            channelName = userName;
            password = File.ReadAllText("password.txt");  // go to file password.txt
            chatCommandId = "PRIVMSG";
            chatMessagePrefix = $":{userName}!{userName}@{userName}.tmi.twitch.tv {chatCommandId} #{channelName} :";
            
            Reconnect();
        }

        /* log in */
        private void Reconnect() {
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());

            writer.WriteLine("PASS " + password + Environment.NewLine
                + "NICK " + userName + Environment.NewLine
                + "USER " + userName + " 8 * :" + userName);
            writer.WriteLine("JOIN #kekseek228");
            writer.Flush();
            lastMessage = DateTime.Now;
        }

        public void TimerTick() {
            if (!tcpClient.Connected) {
                Reconnect();
            }

            TrySendingMessages();
            TryReceiveMessages();
        }

        /* try to get message from queue and display it */
        private void TrySendingMessages() {
            if (DateTime.Now - lastMessage > TimeSpan.FromSeconds(10)) {
                if (sendMessageQueue.Count > 0) {
                    var message = sendMessageQueue.Dequeue();
                    writer.WriteLine($"{chatMessagePrefix}{message}");
                    writer.Flush();
                    lastMessage = DateTime.Now;
                }
            }
        }

        /* receive and add to queue chat messages */
        private void TryReceiveMessages() {
            if (tcpClient.Available > 0 || reader.Peek() > 0) {
                var message = reader.ReadLine();

                var iCollon = message.IndexOf(":", 1);
                if (iCollon > 0) {
                    var command = message.Substring(1, iCollon);
                    if (command.Contains(chatCommandId)) {
                        var iBang = command.IndexOf("!");

                        if (iBang > 0) {
                            var speaker = command.Substring(0, iBang);
                            var chatMessage = message.Substring(iCollon + 1);

                            ReceiveMessage(speaker, chatMessage);
                        }

                    }
                }

            }
        }

        private void ReceiveMessage(string speaker, string message) {
            Form1ChatLabel.Text += $"\r\n {speaker}: {message}";

            /* react to some keywords in chat
             * list of words: !hi, !roll, !wiki */
            if (message.StartsWith("!hi")) {
                SendMessage($"Hello, {speaker}");
            }

            if (message.StartsWith("!roll")) {
                Random rnd = new Random();
                int value = rnd.Next(1, 100);
                SendMessage($"{speaker} has rolled - {value}");
            }

            // wikipedia search
            if (message.StartsWith("!wiki") && message.Length > 6) {
                string search = WebUtility.UrlEncode(message.Substring(6));
                string url = String.Format("https://ru.wikipedia.org/w/api.php?action=opensearch&search={0}&prop=info&format=json&inprop=url",
                    search);

                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                using (StreamReader stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8)) {
                    dynamic deserialized = JsonConvert.DeserializeObject(stream.ReadToEnd());
                    SendMessage(deserialized[2][0].ToString());
                }
            }
        }

        private void SendMessage(string message) {
            sendMessageQueue.Enqueue(message);
        }
    }
}
