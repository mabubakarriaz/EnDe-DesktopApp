using Com.Mindbridge.EndeApp.Entity;
using Com.Mindbridge.EndeApp.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Mindbridge.EndeApp.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hard code list values
            BindingList<Data> _comboItems = new BindingList<Data>();
            _comboItems.Add(new Data { Name = "MBPortal", Key = "MBPortal" });

            comboBox1.DataSource = _comboItems;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Key";

        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Encrypt_EncryptedText_textBox.Text= new Encryption().EncryptText(Encrypt_PlainText_textBox.Text, _key_textBox.Text);   
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
           Decrypt_PlainText_textBox.Text= new Encryption().DecryptText(Decrypt_DecryptedText_textBox.Text, _key_textBox.Text);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _key_textBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon icon = Icon.ExtractAssociatedIcon("Resources/EnDe-App.ico");
            this.Icon = icon;
        }
    }
}
