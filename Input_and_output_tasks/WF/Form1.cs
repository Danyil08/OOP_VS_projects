using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                MessageBox.Show($"Ви ввели число {x}");
            }
            catch
            {
                MessageBox.Show("N не є цілим числом");
            }
        }
    }
}
