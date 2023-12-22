using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudents aa=new ManageStudents();
            aa.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ManageStudentsGridView bb=new ManageStudentsGridView();
            bb.Show();
            this.Hide();
        }
    }
}
