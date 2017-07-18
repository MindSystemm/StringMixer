using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSystem_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "")
            {
                textBox2.Text = StringMixer.Encrypt(textBox1.Text);
            }
         else
            {
                textBox2.Text = StringMixer.EncryptWithKey(textBox1.Text, textBox3.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox2.Text = StringMixer.Decrypt(textBox1.Text);
            }
            else
            {
                textBox2.Text = StringMixer.DecryptWithKey(textBox1.Text, textBox3.Text);
            }
        }
        public static string Generator(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        private static string PublicKey = " èéâêZHKAJULIBTYXRSEWVGOQCNMPDFzhkajulibtyxrsewvgoqcnmpdf9876543210#@&|}{)(*$";
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace("[Generated]", Generator(PublicKey));
        }
    }
}
