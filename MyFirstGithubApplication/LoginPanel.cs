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

namespace MyFirstGithubApplication
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }
        public SqlConnection connection = new SqlConnection(@"Data Source=SCHEFEN\BABAONLİNE;Initial Catalog=StudentManagement;Integrated Security=True");
        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "Select * from TeacherLoginTbl where username=@p1 and password=@p2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p1", TbTeacherUsername.Text);
            cmd.Parameters.AddWithValue("@p2", TbTeacherPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Welcome to student management system", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeacherPanel teacherpanel = new TeacherPanel();
                teacherpanel.Show();
                this.Hide();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbTeacherUsername.Text = "";
                TbTeacherPassword.Text = "";
                connection.Close();
            }
            dr.Close();
            
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "Select * from StudentTbl where username=@p1 and password=@p2";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p1", TbStudentUsername.Text);
            cmd.Parameters.AddWithValue("@p2", TbStudentPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Welcome to student management system", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentPanel studentpanel = new StudentPanel();
                studentpanel.username = TbStudentUsername.Text;
                studentpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbStudentUsername.Text = "";
                TbStudentPassword.Text = "";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
