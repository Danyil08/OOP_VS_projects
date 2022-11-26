using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_project
{
    public partial class Form2 : Form
    {
        public Timer timer;
        public DataGridView data;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            data.Rows.Add(data.Rows.Count + 1, textBox1.Text, textBox2.Text, textBox3.Text);
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            try
            {
                if (Convert.ToInt32(textBox7.Text) > 0 && Convert.ToInt32(textBox7.Text) <= data.Rows.Count)
                {
                    data.Rows[Convert.ToInt32(textBox7.Text) - 1].Cells[4].Value = textBox4.Text;
                    data.Rows[Convert.ToInt32(textBox7.Text) - 1].Cells[5].Value = textBox5.Text;
                    data.Rows[Convert.ToInt32(textBox7.Text) - 1].Cells[6].Value = textBox6.Text;
                }
                else
                    MessageBox.Show("Некоректний ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Некоректний ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
