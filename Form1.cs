namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // subscribe to KeyDown so we can detect Enter key presses
            this.txtMessage.KeyDown += txtMessage_KeyDown;
        }
        private void UpdateMessageCount()
        {
            lblCount.Text = $"현재 대화: {lstChat.Items.Count}개";
        }


        private void SendMessage()
        {
            string typedMsg = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(typedMsg))
            {
                txtMessage.Clear();
                txtMessage.Focus();
                return;
            }

            string timeStamp = DateTime.Now.ToString("[HH:mm:ss]");
            string finalMsg = $"{timeStamp} {typedMsg}";

            lstChat.Items.Add(finalMsg);
            UpdateMessageCount();

            txtMessage.Clear();
            txtMessage.Focus();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // Keep the TextChanged handler if the designer references it, but it must not use key-specific members.
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            // Intentionally empty - text changed does not provide key information.
        }

        // Use KeyEventArgs on KeyDown to access KeyCode and SuppressKeyPress
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true;
            }
        }

        private void txtMessage_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true;
            }
        }
       
    }
}
