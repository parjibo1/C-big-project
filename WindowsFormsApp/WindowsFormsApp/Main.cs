using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTab set Name =@Name, Age=@Age where ID =@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully Updated!");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where ID=@ID",con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully Deleted!");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values (@iD,@Name,@Age) ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age",  double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully saved!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID",int.Parse(textBox1.Text));      
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt; 
                        da.Fill(dt);


        }

        private void Longin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff ss = new Staff();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
         Form1 ss = new Form1();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values (@iD,@Name,@Age) ", con);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from UserTab ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;



        }
    }
}
