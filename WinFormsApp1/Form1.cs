using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private client ClientInstance;
        public Form1()
        {
            InitializeComponent();
            Rooms.Enabled = false;
        }

        private void OnResponse(string s)
        {
            
        }
        private void PlayerConnecttoServer_Click(object sender, EventArgs e)
        {
            ClientInstance = new client();
            ClientInstance.OnClientConnected += SuccessConnection;
            ClientInstance.OnMessageReceive += OnResponse;
            ClientInstance.StartServer();
            ClientInstance.ClientName = textBox1.Text;
            PlayerConnecttoServer.Enabled = false;
            Rooms.Enabled=true;
        }

        private void SuccessConnection(string msg)
        {
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            Form2 clientForm = new Form2(ClientInstance);
            ClientInstance.form= clientForm;
            clientForm.Show();
        }
    }
}
