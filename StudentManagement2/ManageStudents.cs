using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace StudentManagement2
{
    public partial class ManageStudents : Form
    {
        SqlConnection con= new SqlConnection(@"Data Source=SiCks-ROG-G14\MSSQLSERVER01;Initial Catalog=SM2;Integrated Security=True;Encrypt=False");

        public ManageStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into a values( '"+textBox1.Text+"','"+textBox2.Text+ "','"+textBox3.Text +"','"+textBox4.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("INSERTED");
            con.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            UpdateDataGridView1();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE a set name='"+textBox2.Text+"', address = '"+textBox3.Text+"', class = '"+textBox4.Text+"' where id='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
            con.Close();

            UpdateDataGridView1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from a where id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DELETED");
            con.Close();

            UpdateDataGridView1();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            UpdateDataGridView1();
        }
        private void UpdateDataGridView1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM a", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
