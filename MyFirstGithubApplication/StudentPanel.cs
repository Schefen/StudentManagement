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
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
        }
        LoginPanel loginpanel = new LoginPanel();
        public string username;

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            loginpanel.connection.Open();
            LblStudentName.Text = username;
            string query = "Select * from StudentTbl where username=@p1";
            SqlCommand cmd = new SqlCommand(query, loginpanel.connection);
            cmd.Parameters.AddWithValue("@p1", username);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LblStudentName.Text = dr["name"].ToString() + " " + dr["surname"].ToString();
                LblStudentNumber.Text = dr["number"].ToString();
                LblFirstExam.Text = dr["first_exam"].ToString();
                LblSecondExam.Text = dr["second_exam"].ToString();
                LblThirdExam.Text = dr["third_exam"].ToString();
                LblGradeAvg.Text = dr["average"].ToString();
                LblStatus.Text = dr["status"].ToString();
                if (LblStatus.Text == "True")
                {
                    LblStatus.Text = "Passed";
                }
                else
                {
                    LblStatus.Text = "Failed";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginpanel.Show();
            this.Hide();
            loginpanel.connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
