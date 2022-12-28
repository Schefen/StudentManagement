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
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }
        LoginPanel loginpanel = new LoginPanel();
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (TbStudentNumber.Text == "" || TbStudentName.Text == "" || TbStudentSurname.Text == "" || TbStudentFirstExam.Text == "" || TbStudentSecondExam.Text == "" || TbStudentThirdExam.Text == "")
            {
                MessageBox.Show("Please fill the blanks correctly", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                avg();
                loginpanel.connection.Open();
                string query = "insert into StudentTbl (number,name,surname,first_exam,second_exam,third_exam,average,status) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(query, loginpanel.connection);
                cmd.Parameters.AddWithValue("@p1", TbStudentNumber.Text);
                cmd.Parameters.AddWithValue("@p2", TbStudentName.Text);
                cmd.Parameters.AddWithValue("@p3", TbStudentSurname.Text);
                cmd.Parameters.AddWithValue("@p4", TbStudentFirstExam.Text);
                cmd.Parameters.AddWithValue("@p5", TbStudentSecondExam.Text);
                cmd.Parameters.AddWithValue("@p6", TbStudentThirdExam.Text);
                cmd.Parameters.AddWithValue("@p7", decimal.Parse(TbAverage.Text));
                cmd.Parameters.AddWithValue("@p8",status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student has been added successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studentTblTableAdapter.Fill(this.studentManagementDataSet.StudentTbl);            
                clear();
            }
            loginpanel.connection.Close();
            TbPassed.Text = Succeed().ToString();
            TbFailed.Text = failed().ToString();
            TbClassAVG.Text = classAvg().ToString();
            
            

        }

        private void TeacherPanel_Load(object sender, EventArgs e)
        {

            this.studentTblTableAdapter.Fill(this.studentManagementDataSet.StudentTbl);
            TbPassed.Text = Succeed().ToString();
            TbFailed.Text = failed().ToString();
            TbClassAVG.Text = classAvg().ToString();
            
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (TbStudentNumber.Text == "")
            {
                MessageBox.Show("Please enter the number", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {      
                avg();
                loginpanel.connection.Open();
                SqlCommand cmd = new SqlCommand("update StudentTbl set name=@p1,surname=@p2,first_exam=@p3,second_exam=@p4,third_exam=@p5,average=@p6,status=@p7 where number=@p8", loginpanel.connection);
                cmd.Parameters.AddWithValue("@p1",TbStudentName.Text);
                cmd.Parameters.AddWithValue("@p2",TbStudentSurname.Text);
                cmd.Parameters.AddWithValue("@p3",TbStudentFirstExam.Text);
                cmd.Parameters.AddWithValue("@p4",TbStudentSecondExam.Text);
                cmd.Parameters.AddWithValue("@p5",TbStudentThirdExam.Text);
                cmd.Parameters.AddWithValue("@p6",decimal.Parse(TbAverage.Text));
                cmd.Parameters.AddWithValue("@p7",status);
                cmd.Parameters.AddWithValue("@p8",TbStudentNumber.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student information has updated successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studentTblTableAdapter.Fill(this.studentManagementDataSet.StudentTbl);
                clear();
               
            }
            loginpanel.connection.Close();
            TbPassed.Text = Succeed().ToString();
            TbFailed.Text = failed().ToString();
            TbClassAVG.Text = classAvg().ToString();
        }
        private void fillBlanks()
        {
            int selected = StudentsGV.SelectedCells[0].RowIndex;
            TbStudentNumber.Text = StudentsGV.Rows[selected].Cells[0].Value.ToString();
            TbStudentName.Text = StudentsGV.Rows[selected].Cells[1].Value.ToString();
            TbStudentSurname.Text = StudentsGV.Rows[selected].Cells[2].Value.ToString();
            TbStudentFirstExam.Text = StudentsGV.Rows[selected].Cells[3].Value.ToString();
            TbStudentSecondExam.Text = StudentsGV.Rows[selected].Cells[4].Value.ToString();
            TbStudentThirdExam.Text = StudentsGV.Rows[selected].Cells[5].Value.ToString();
            avg();
        }

        private void StudentsGV_DoubleClick(object sender, EventArgs e)
        {
            fillBlanks();
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
        string status;
        private void avg()
        {
            double first, second, third, avg;
            

            first = Convert.ToDouble(TbStudentFirstExam.Text);
            second = Convert.ToDouble(TbStudentSecondExam.Text);
            third = Convert.ToDouble(TbStudentThirdExam.Text);

            avg = (first + second + third) / 3;
            TbAverage.Text = avg.ToString();

            if (avg<=49.50)
            {
                status = "False";
            }
            else
            {
                status = "True";
            }
        }
        int Succeed()
        {
            int succeed = 0;
            loginpanel.connection.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from StudentTbl where status=1", loginpanel.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                succeed = Convert.ToInt16(dr[0]);
            }
            dr.Close();
            loginpanel.connection.Close();
            return succeed;
            
        }
        int failed()
        {
            int failed = 0;
            loginpanel.connection.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from StudentTbl where status=0", loginpanel.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                failed = Convert.ToInt16(dr[0]);
            }
            dr.Close();
            loginpanel.connection.Close();
            return failed;
        }
        double classAvg()
        {
            double average = 0;
            loginpanel.connection.Open();
            SqlCommand cmd = new SqlCommand("Select AVG (average) from StudentTbl", loginpanel.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                average = Convert.ToDouble(dr[0]);
            }
            dr.Close();
            loginpanel.connection.Close();
            TbClassAVG.Text = average.ToString();
            return average;
        }
        private void clear()
        {
            TbStudentNumber.Text = "";
            TbStudentName.Text = "";
            TbStudentSurname.Text = "";
            TbStudentFirstExam.Text = "";
            TbStudentSecondExam.Text = "";
            TbStudentThirdExam.Text = "";
            TbAverage.Text = "";
        }

    }
}
