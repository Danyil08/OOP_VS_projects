using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_WFA
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
    class Goods
    {
        protected double price;
        protected string origin_country, title, package_date, description;
    }
    class Food : Goods
    {
        string expiration_date, measure;
        int count;
    }
    class Book : Goods
    {
        string publishing_house, authors_list;
        short page_count;
    }
}
