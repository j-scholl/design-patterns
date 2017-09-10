namespace IteratorPattern
{
    partial class clientForm
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
            this.fullListBox = new System.Windows.Forms.ListBox();
            this.standardButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.otherIteratorButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullListBox
            // 
            this.fullListBox.FormattingEnabled = true;
            this.fullListBox.ItemHeight = 16;
            this.fullListBox.Location = new System.Drawing.Point(55, 98);
            this.fullListBox.Name = "fullListBox";
            this.fullListBox.Size = new System.Drawing.Size(120, 276);
            this.fullListBox.TabIndex = 0;
            // 
            // standardButton
            // 
            this.standardButton.Location = new System.Drawing.Point(247, 98);
            this.standardButton.Name = "standardButton";
            this.standardButton.Size = new System.Drawing.Size(155, 23);
            this.standardButton.TabIndex = 1;
            this.standardButton.Text = "Standard Iterator";
            this.standardButton.UseVisualStyleBackColor = true;
            this.standardButton.Click += new System.EventHandler(this.standardButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(247, 237);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(155, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // otherIteratorButton
            // 
            this.otherIteratorButton.Location = new System.Drawing.Point(247, 128);
            this.otherIteratorButton.Name = "otherIteratorButton";
            this.otherIteratorButton.Size = new System.Drawing.Size(155, 23);
            this.otherIteratorButton.TabIndex = 3;
            this.otherIteratorButton.Text = "Other Iterator";
            this.otherIteratorButton.UseVisualStyleBackColor = true;
            this.otherIteratorButton.Click += new System.EventHandler(this.otherIteratorButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(247, 157);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(155, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(247, 186);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search Iterator";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 483);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.otherIteratorButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.standardButton);
            this.Controls.Add(this.fullListBox);
            this.Name = "clientForm";
            this.Text = "Iterator Pattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fullListBox;
        private System.Windows.Forms.Button standardButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button otherIteratorButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

