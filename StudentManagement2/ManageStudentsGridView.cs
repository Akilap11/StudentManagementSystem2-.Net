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
    public partial class ManageStudentsGridView : Form
    {
        public ManageStudentsGridView()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString();
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells[0].Value.ToString() == textBox1.Text)
                {
                    selectedRow.Cells[1].Value = textBox2.Text;
                    selectedRow.Cells[2].Value = textBox3.Text;
                    selectedRow.Cells[3].Value = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("select a row with the matching ID");
                }
            }
            else
            {
                MessageBox.Show("select a row");
            }
        }
    }
}
