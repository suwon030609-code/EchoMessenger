namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typedMsg = txtMessage.Text;
            lstChat.Items.Add(typedMsg);
            txtMessage.Clear();
        }
    }
}
