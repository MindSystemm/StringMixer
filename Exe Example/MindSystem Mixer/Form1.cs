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
           textBox2.Text = StringMixer.Encrypt(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = StringMixer.Decrypt(textBox1.Text);
        }
    }
}
