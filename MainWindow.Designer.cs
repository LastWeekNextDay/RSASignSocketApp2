namespace RSASignatureApplication2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.digitalSignLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.Location = new System.Drawing.Point(33, 29);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(113, 23);
            this.publicKeyLabel.TabIndex = 0;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // nLabel
            // 
            this.nLabel.Location = new System.Drawing.Point(12, 52);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(45, 23);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "n";
            // 
            // eLabel
            // 
            this.eLabel.Location = new System.Drawing.Point(12, 89);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(100, 23);
            this.eLabel.TabIndex = 2;
            this.eLabel.Text = "e";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(33, 53);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(230, 22);
            this.nTextBox.TabIndex = 3;
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(33, 89);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(230, 22);
            this.eTextBox.TabIndex = 4;
            // 
            // digitalSignLabel
            // 
            this.digitalSignLabel.Location = new System.Drawing.Point(33, 149);
            this.digitalSignLabel.Name = "digitalSignLabel";
            this.digitalSignLabel.Size = new System.Drawing.Size(113, 23);
            this.digitalSignLabel.TabIndex = 5;
            this.digitalSignLabel.Text = "Digital Signature";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 6;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(33, 244);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(33, 270);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(230, 118);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(33, 406);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(230, 32);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digitalSignLabel);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Name = "MainWindow";
            this.Text = "Application2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;

        private System.Windows.Forms.Label digitalSignLabel;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox eTextBox;

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label eLabel;

        private System.Windows.Forms.Label publicKeyLabel;

        #endregion
    }
}