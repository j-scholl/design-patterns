namespace SingletonPattern
{
    partial class Form1
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
            this.joinButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.newLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(15, 30);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(100, 50);
            this.joinButton.TabIndex = 0;
            this.joinButton.Text = "Join New Team";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Enabled = false;
            this.leaveButton.Location = new System.Drawing.Point(165, 30);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(100, 50);
            this.leaveButton.TabIndex = 1;
            this.leaveButton.Text = "Leave Team";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(92, 122);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(178, 22);
            this.newTextBox.TabIndex = 2;
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(12, 125);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(74, 17);
            this.newLabel.TabIndex = 3;
            this.newLabel.Text = "New team:";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(15, 157);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(94, 17);
            this.currentLabel.TabIndex = 4;
            this.currentLabel.Text = "Current team:";
            // 
            // currentTextBox
            // 
            this.currentTextBox.Enabled = false;
            this.currentTextBox.Location = new System.Drawing.Point(116, 157);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(154, 22);
            this.currentTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.joinButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.TextBox currentTextBox;
    }
}

