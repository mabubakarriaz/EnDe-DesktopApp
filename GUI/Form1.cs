using EndeApp.Entity;
using EndeApp.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndeApp.GUI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Main GUI form of app
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Hard code list values
            BindingList<Data> _comboItems = new BindingList<Data>();
            _comboItems.Add(new Data { Name = "My App Name", Key = "MySecretKey" });
            _comboItems.Add(new Data { Name = "App2", Key = "MyLongComplexKey.123" });
            _comboItems.Add(new Data { Name = "App3", Key = "QfdfgWE<>LPO{><MM(*&$%%" });

            // bind data to comboBox 
            comboBox1.DataSource = _comboItems;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Key";

        }

        /// <summary>
        /// Encrypt text button
        /// </summary>
        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Encrypt_EncryptedText_textBox.Text= new Encryption().EncryptText(Encrypt_PlainText_textBox.Text, _key_textBox.Text);   
        }

        /// <summary>
        /// Decrypt text button
        /// </summary>
        private void Decrypt_button_Click(object sender, EventArgs e)
        {
           Decrypt_PlainText_textBox.Text= new Encryption().DecryptText(Decrypt_DecryptedText_textBox.Text, _key_textBox.Text);
        }

        /// <summary>
        /// The Key text box changes when the dropdown selection is changed
        /// </summary>
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Get hard coded dropdown list value and show it in 'key' text box
            _key_textBox.Text = comboBox1.SelectedValue.ToString();
        }

        /// <summary>
        /// When the form is completely loaded this function will execute
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the main app icon from saved resource folder
            Icon icon = Icon.ExtractAssociatedIcon("Resources/EnDe-App.ico");

            // Assign icon to the icon property of the form
            this.Icon = icon;
        }

        private void button1_Click(object sender,EventArgs e)
        {
            txtOutput.Text = Hash.GetMD5Hash(txtInput.Text);
        }


       
    }
}
