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
            this.digitalSignLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.RichTextBox();
            this.eTextBox = new System.Windows.Forms.RichTextBox();
            this.signatureTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.Location = new System.Drawing.Point(33, 9);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(113, 23);
            this.publicKeyLabel.TabIndex = 0;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // nLabel
            // 
            this.nLabel.Location = new System.Drawing.Point(12, 32);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(45, 23);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "n";
            // 
            // eLabel
            // 
            this.eLabel.Location = new System.Drawing.Point(12, 114);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(100, 23);
            this.eLabel.TabIndex = 2;
            this.eLabel.Text = "e";
            // 
            // digitalSignLabel
            // 
            this.digitalSignLabel.Location = new System.Drawing.Point(33, 179);
            this.digitalSignLabel.Name = "digitalSignLabel";
            this.digitalSignLabel.Size = new System.Drawing.Size(113, 23);
            this.digitalSignLabel.TabIndex = 5;
            this.digitalSignLabel.Text = "Digital Signature";
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(33, 351);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(33, 377);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(230, 118);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(33, 512);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(230, 32);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(33, 35);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(230, 56);
            this.nTextBox.TabIndex = 10;
            this.nTextBox.Text = "";
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(33, 114);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(230, 51);
            this.eTextBox.TabIndex = 11;
            this.eTextBox.Text = "";
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(33, 205);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(230, 132);
            this.signatureTextBox.TabIndex = 12;
            this.signatureTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 555);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.digitalSignLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Name = "MainWindow";
            this.Text = "Application2";
            this.ResumeLayout(false);
        }

        

        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;

        private System.Windows.Forms.Label digitalSignLabel;
        private System.Windows.Forms.RichTextBox signatureTextBox;
        
        private System.Windows.Forms.RichTextBox nTextBox;
        private System.Windows.Forms.RichTextBox eTextBox;

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label eLabel;

        private System.Windows.Forms.Label publicKeyLabel;

        #endregion
    }
}