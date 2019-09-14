using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 1, c ;
            int n = Convert.ToInt16(textBox1.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add(0);
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;

                listBox1.Items.Add(a.ToString());

            }
        }
    }
}
