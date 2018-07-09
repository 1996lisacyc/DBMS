using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class SchoolMember : Form
    {
        public SchoolMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student f2 = new Student();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dependent f2 = new Dependent();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class f2 = new Class();
            this.Hide();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            director f2 = new director();
            this.Hide();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HT f2 = new HT();
            this.Hide();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Worker f2 = new Worker();
            this.Hide();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PT f2 = new PT();
            this.Hide();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Office f2 = new Office();
            this.Hide();
            f2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ByCode f2 = new ByCode();
            this.Hide();
            f2.Show();
        }
    }
}
