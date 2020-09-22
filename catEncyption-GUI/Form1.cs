using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catEncyption_GUI
{
    public partial class Form1 : Form
    {
        public static string meow = "喵";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //execute while plain text box changed
        private void plainTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //execute while Meow text box changed
        private void meowTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            exceptionHide();
            if (plainTextBox.Text.Length >= 1)
            {

                meowTextBox.Text = catEncryption.encrypt(plainTextBox.Text, meow);
            }
            else meowTextBox.Text = "";
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            exceptionHide();

            if (meowTextBox.Text.Length >= 1)
            {
                try
                {
                    plainTextBox.Text = catEncryption.decode(meowTextBox.Text, meow);
                }
                catch (Exception)
                {
                    exceptionShow("illegal characters. The ciphertext you've provided contains some characters that are not " + meow);
                }
            }
            else plainTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            meowTextBox.Text = "";
            plainTextBox.Text = "";
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            if (meow.Equals("Meow")) meow = "喵";
            else meow = "Meow";
            
                languageButton.Text = meow;



        }

        private void exceptionShow(string exceptionInfo)
        {
            exceptionLabel.Text = exceptionInfo;
            exceptionLabel.Show();
        }
        private void exceptionHide()
        {
            exceptionLabel.Hide();
        }
    }
}
