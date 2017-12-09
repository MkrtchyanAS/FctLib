using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FctLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Введите целое число";

            if (long.TryParse(textBox1.Text, out long n))
            {
                FactClass obj = new FactClass();
                long res = obj.Fact(n);
                string s = res.ToString();
                label1.Text = s;
            }
            else
            {
                label1.Text = string.Empty;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
