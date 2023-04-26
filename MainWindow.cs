using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSASignatureApplication2
{
    public partial class MainWindow : Form
    {
        private readonly SocketInteractor _socketInteractor;
        
        public MainWindow()
        {
            _socketInteractor = new SocketInteractor();
            _socketInteractor.Connect();
            var socketT = new Thread(async () =>
            {
                while (true)
                {
                    await _socketInteractor.Listen();
                }
            });
            var t = new Thread(new ThreadStart(CheckChangeLoop));
            t.Start();
            socketT.Start();
            InitializeComponent();
        }

        private void InvokeUI(Action action)
        {
            BeginInvoke(new MethodInvoker(action));
        }

        private void CheckChangeLoop()
        {
            while (true)
            {
                if (_socketInteractor.Change != 1) continue;
                _socketInteractor.Change = 0;
                InvokeUI(() =>
                {
                    var dialogResult = MessageBox.Show($"New message incoming. Do you wish to accept?", 
                        "Incoming.", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) return;
                    var data = _socketInteractor.Data.Split(new string[] { "~|~" }, StringSplitOptions.None);
                    var message = data[1];
                    var signature = data[2];
                    var modulus = data[3];
                    var exponent = data[4];

                    messageTextBox.Text = message;
                    signatureTextBox.Text = signature;
                    nTextBox.Text = modulus;
                    eTextBox.Text = exponent;
                });
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var message = "3~|~" + messageTextBox.Text + "~|~" + signatureTextBox.Text + "~|~" + nTextBox.Text + "~|~" +
                          eTextBox.Text;
            _socketInteractor.Send(message);
        }
    }
}