namespace Com.Mindbridge.EndeApp.GUI
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
            this._key_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_PlainText_textBox = new System.Windows.Forms.TextBox();
            this.Decrypt_DecryptedText_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Encrypt_EncryptedText_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Decrypt_PlainText_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _key_textBox
            // 
            this._key_textBox.Location = new System.Drawing.Point(397, 24);
            this._key_textBox.Name = "_key_textBox";
            this._key_textBox.Size = new System.Drawing.Size(135, 20);
            this._key_textBox.TabIndex = 0;
            // 
            // Encrypt_PlainText_textBox
            // 
            this.Encrypt_PlainText_textBox.Location = new System.Drawing.Point(97, 25);
            this.Encrypt_PlainText_textBox.Name = "Encrypt_PlainText_textBox";
            this.Encrypt_PlainText_textBox.Size = new System.Drawing.Size(342, 20);
            this.Encrypt_PlainText_textBox.TabIndex = 1;
            // 
            // Decrypt_DecryptedText_textBox
            // 
            this.Decrypt_DecryptedText_textBox.Location = new System.Drawing.Point(94, 36);
            this.Decrypt_DecryptedText_textBox.Name = "Decrypt_DecryptedText_textBox";
            this.Decrypt_DecryptedText_textBox.Size = new System.Drawing.Size(342, 20);
            this.Decrypt_DecryptedText_textBox.TabIndex = 2;
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.Location = new System.Drawing.Point(445, 23);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_button.TabIndex = 3;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = true;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.Location = new System.Drawing.Point(442, 34);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_button.TabIndex = 4;
            this.Decrypt_button.Text = "Decrypt";
            this.Decrypt_button.UseVisualStyleBackColor = true;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plain Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decrypted Text:";
            // 
            // Encrypt_EncryptedText_textBox
            // 
            this.Encrypt_EncryptedText_textBox.Location = new System.Drawing.Point(97, 69);
            this.Encrypt_EncryptedText_textBox.Name = "Encrypt_EncryptedText_textBox";
            this.Encrypt_EncryptedText_textBox.ReadOnly = true;
            this.Encrypt_EncryptedText_textBox.Size = new System.Drawing.Size(342, 20);
            this.Encrypt_EncryptedText_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encrypted Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Plain Text:";
            // 
            // Decrypt_PlainText_textBox
            // 
            this.Decrypt_PlainText_textBox.Location = new System.Drawing.Point(94, 80);
            this.Decrypt_PlainText_textBox.Name = "Decrypt_PlainText_textBox";
            this.Decrypt_PlainText_textBox.ReadOnly = true;
            this.Decrypt_PlainText_textBox.Size = new System.Drawing.Size(342, 20);
            this.Decrypt_PlainText_textBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Encrypt_PlainText_textBox);
            this.groupBox1.Controls.Add(this.Encrypt_button);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Encrypt_EncryptedText_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 108);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Decrypt_DecryptedText_textBox);
            this.groupBox2.Controls.Add(this.Decrypt_PlainText_textBox);
            this.groupBox2.Controls.Add(this.Decrypt_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 121);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "EnDe App";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 331);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._key_textBox);
            this.Name = "Form1";
            this.Text = "EnDe App - Rijndael\'s algorithm encryption & decryption App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _key_textBox;
        private System.Windows.Forms.TextBox Encrypt_PlainText_textBox;
        private System.Windows.Forms.TextBox Decrypt_DecryptedText_textBox;
        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.Button Decrypt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Encrypt_EncryptedText_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Decrypt_PlainText_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

