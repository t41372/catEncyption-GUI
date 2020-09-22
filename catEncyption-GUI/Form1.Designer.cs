namespace catEncyption_GUI
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
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.meowTextLabel = new System.Windows.Forms.Label();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.meowTextBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.languageButton = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(62, 38);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(205, 24);
            this.plainTextLabel.TabIndex = 0;
            this.plainTextLabel.Text = "Plain Text (Uncoded)";
            // 
            // meowTextLabel
            // 
            this.meowTextLabel.AutoSize = true;
            this.meowTextLabel.Location = new System.Drawing.Point(440, 38);
            this.meowTextLabel.Name = "meowTextLabel";
            this.meowTextLabel.Size = new System.Drawing.Size(214, 24);
            this.meowTextLabel.TabIndex = 1;
            this.meowTextLabel.Text = "Meow Text (Encoded)";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(66, 95);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(281, 291);
            this.plainTextBox.TabIndex = 2;
            this.plainTextBox.TextChanged += new System.EventHandler(this.plainTextBox_TextChanged);
            // 
            // meowTextBox
            // 
            this.meowTextBox.Location = new System.Drawing.Point(444, 95);
            this.meowTextBox.Multiline = true;
            this.meowTextBox.Name = "meowTextBox";
            this.meowTextBox.Size = new System.Drawing.Size(281, 291);
            this.meowTextBox.TabIndex = 3;
            this.meowTextBox.TextChanged += new System.EventHandler(this.meowTextBox_TextChanged);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(104, 392);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(195, 66);
            this.encodeButton.TabIndex = 4;
            this.encodeButton.Text = "Encode Plain Text";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(477, 392);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(216, 66);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.Text = "Decode Meow Text";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(354, 258);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 73);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // languageButton
            // 
            this.languageButton.Location = new System.Drawing.Point(354, 148);
            this.languageButton.Name = "languageButton";
            this.languageButton.Size = new System.Drawing.Size(84, 73);
            this.languageButton.TabIndex = 6;
            this.languageButton.Text = "喵";
            this.languageButton.UseVisualStyleBackColor = true;
            this.languageButton.Click += new System.EventHandler(this.languageButton_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.Location = new System.Drawing.Point(151, 461);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(490, 109);
            this.exceptionLabel.TabIndex = 7;
            this.exceptionLabel.Text = "Fine";
            this.exceptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exceptionLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.languageButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.meowTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.meowTextLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Name = "Form1";
            this.Text = "cat encoder ver. 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label meowTextLabel;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.TextBox meowTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button languageButton;
        private System.Windows.Forms.Label exceptionLabel;
    }
}

