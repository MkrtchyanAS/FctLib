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

            if (int.TryParse(textBox1.Text, out int n))
            {
                FactClass obj = new FactClass();
                int res = obj.Fact(n);
                string s = res.ToString();
                label1.Text = s;
            }
            else
            {
                label1.Text = string.Empty;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        } 

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
