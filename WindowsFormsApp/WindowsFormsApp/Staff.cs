using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Longin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
         
            con.Close();   con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff values (@ID,@Name,@Number,@Adress) ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox4.Text));

            cmd.Parameters.AddWithValue("@Number",  double.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Adress", textBox3.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("successfully saved!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Staff set Name =@Name, Number=@Number , Adress=@Adress where ID =@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox4.Text));

            cmd.Parameters.AddWithValue("@Number", double.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Adress", textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully Updated!");




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Staff where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully Deleted!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Staff where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox4.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff values (@ID,@Name,@Number,@Adress) ", con);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from Staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
