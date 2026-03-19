namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            lblTitle = new Label();
            lstChat = new ListBox();
            txtMessage = new TextBox();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GrayText;
            btnSend.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1184, 777);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(216, 92);
            btnSend.TabIndex = 0;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblTitle
            // 
            lblTitle.AllowDrop = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(182, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(704, 126);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Echo Messenger";
            // 
            // lstChat
            // 
            lstChat.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(200, 156);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(1200, 535);
            lstChat.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtMessage.Location = new Point(200, 804);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(900, 65);
            txtMessage.TabIndex = 3;
            txtMessage.TextChanged += txtMessage_TextChanged;
            txtMessage.KeyDown += txtMessage_KeyDown_1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(1173, 704);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(227, 45);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1574, 929);
            Controls.Add(lblCount);
            Controls.Add(txtMessage);
            Controls.Add(lstChat);
            Controls.Add(lblTitle);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblTitle;
        private ListBox lstChat;
        private TextBox txtMessage;
        private Label lblCount;

    }
}
