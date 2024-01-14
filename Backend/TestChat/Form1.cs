using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestChat
{
    public partial class Form1 : Form
    {
        HubConnection hubConnection;
        public Form1()
        {
            InitializeComponent();
            hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7139/chat")
                .Build();
            hubConnection.Closed += HubConnection_Closed;
        }

        private async Task HubConnection_Closed(Exception arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hubConnection.StartAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hubConnection.On<string, string>("ReceiveMessage", (userr, message) =>
            {

            });
        }
    }
}
