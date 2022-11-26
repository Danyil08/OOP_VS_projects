using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Timetable_project
{
    
    public partial class Form1 : Form
    {
        Helper helper = new Helper();
        public Form1()
        {
            helper.timer = timer1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form2 form2 = new Form2();
            form2.data = dataGridView1;
            form2.timer = timer1;
            timer1.Start();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                if (Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) <= dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[Convert.ToInt32(textBox1.Text) - 1]);
                    for (int i = Convert.ToInt32(textBox1.Text) - 1; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    }
                }
                else
                    MessageBox.Show("Некоректний ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Некоректний ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            List<Timetable> timetables = helper.To_timetables(dataGridView1);
            string path = "C:/Users/Admin/source/repos/Timetable_project2/data.json";
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fstream, timetables, new JsonSerializerOptions {WriteIndented = true });
            }
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            List<Timetable> timetables = helper.To_timetables(dataGridView1);
            helper.search_by_full_name(timetables, Convert.ToString(textBox2.Text));
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            List<Timetable> timetables = helper.To_timetables(dataGridView1);
            helper.search_by_faculty(timetables, Convert.ToString(textBox2.Text));
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            List<Timetable> timetables = helper.To_timetables(dataGridView1);
            helper.search_by_department(timetables, Convert.ToString(textBox2.Text));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Ви були пасивні протягом 10 секунд", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form3 form3 = new Form3();
            timer1.Start();
            form3.ShowDialog();
        }
    }
    class Timetable
    {
        public Timetable(int id, string full_name, string faculty, string department)
        {
            this.id = id;
            this.full_name = full_name;
            this.faculty = faculty;
            this.department = department;
        }
        public int id { get; }
        public string full_name { get; }
        public string faculty { get; }
        public string department { get; }
        public Details details { get; set; }
    }
    class Details
    {
        public Details(string auditoriums, string curriculum, string students)
        {
            this.auditoriums = auditoriums;
            this.curriculum = curriculum;
            this.students = students;
        }
        public string auditoriums { get; set; }
        public string curriculum { get; set; }
        public string students { get; set; }
    }
    class Helper
    {
        public Timer timer { get; set; }
        public List<Timetable> To_timetables(DataGridView dataGridView)
        {
            List<Timetable> timetables = new List<Timetable>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                Details details = new Details(Convert.ToString(dataGridView.Rows[i].Cells[4].Value), Convert.ToString(dataGridView.Rows[i].Cells[5].Value), Convert.ToString(dataGridView.Rows[i].Cells[6].Value));
                Timetable timetable = new Timetable(Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value), Convert.ToString(dataGridView.Rows[i].Cells[1].Value), Convert.ToString(dataGridView.Rows[i].Cells[2].Value), Convert.ToString(dataGridView.Rows[i].Cells[3].Value));
                timetable.details = details;
                timetables.Add(timetable);
            }
            return timetables;
        }
        string to_ids(List<int> r)
        {
            string res = "";
            foreach (int id in r)
            {
                if (res == "")
                    res = Convert.ToString(id);
                else
                    res = res + ", " + Convert.ToString(id);
            }
            return res;
        }
        public void search_by_full_name(List<Timetable> timetables, string s)
        {
            List<int> r = (from timetable in timetables where timetable.full_name.Contains(s) select timetable.id).ToList();
            string res = to_ids(r);
            MessageBox.Show("За запитом знайдено ID: \n" + res, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void search_by_faculty(List<Timetable> timetables, string s)
        {
            List<int> r = (from timetable in timetables where timetable.faculty.Contains(s) select timetable.id).ToList();
            string res = to_ids(r);
            MessageBox.Show("За запитом знайдено ID: \n" + res, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void search_by_department(List<Timetable> timetables, string s)
        {
            List<int> r = (from timetable in timetables where timetable.department.Contains(s) select timetable.id).ToList();
            string res = to_ids(r);
            MessageBox.Show("За запитом знайдено ID: \n" + res, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
