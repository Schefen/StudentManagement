
namespace MyFirstGithubApplication
{
    partial class TeacherPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.TbStudentThirdExam = new System.Windows.Forms.TextBox();
            this.TbStudentSecondExam = new System.Windows.Forms.TextBox();
            this.TbStudentFirstExam = new System.Windows.Forms.TextBox();
            this.TbStudentSurname = new System.Windows.Forms.TextBox();
            this.TbStudentName = new System.Windows.Forms.TextBox();
            this.TbStudentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TbClassAVG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbFailed = new System.Windows.Forms.TextBox();
            this.TbPassed = new System.Windows.Forms.TextBox();
            this.TbAverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StudentsGV = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet = new MyFirstGithubApplication.StudentManagementDataSet();
            this.studentTblTableAdapter = new MyFirstGithubApplication.StudentManagementDataSetTableAdapters.StudentTblTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lemon/Milk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1023, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 31);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lemon/Milk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1063, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.btnUpdateStudent);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Controls.Add(this.TbStudentThirdExam);
            this.panel2.Controls.Add(this.TbStudentSecondExam);
            this.panel2.Controls.Add(this.TbStudentFirstExam);
            this.panel2.Controls.Add(this.TbStudentSurname);
            this.panel2.Controls.Add(this.TbStudentName);
            this.panel2.Controls.Add(this.TbStudentNumber);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 205);
            this.panel2.TabIndex = 5;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(146, 159);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(317, 31);
            this.btnUpdateStudent.TabIndex = 20;
            this.btnUpdateStudent.Text = "UPDATE STUDENT ";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(146, 122);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(317, 31);
            this.btnAddStudent.TabIndex = 19;
            this.btnAddStudent.Text = "ADD STUDENT ";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // TbStudentThirdExam
            // 
            this.TbStudentThirdExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentThirdExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentThirdExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentThirdExam.ForeColor = System.Drawing.Color.White;
            this.TbStudentThirdExam.Location = new System.Drawing.Point(478, 75);
            this.TbStudentThirdExam.Name = "TbStudentThirdExam";
            this.TbStudentThirdExam.Size = new System.Drawing.Size(119, 15);
            this.TbStudentThirdExam.TabIndex = 18;
            // 
            // TbStudentSecondExam
            // 
            this.TbStudentSecondExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentSecondExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentSecondExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentSecondExam.ForeColor = System.Drawing.Color.White;
            this.TbStudentSecondExam.Location = new System.Drawing.Point(497, 47);
            this.TbStudentSecondExam.Name = "TbStudentSecondExam";
            this.TbStudentSecondExam.Size = new System.Drawing.Size(100, 15);
            this.TbStudentSecondExam.TabIndex = 17;
            // 
            // TbStudentFirstExam
            // 
            this.TbStudentFirstExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentFirstExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentFirstExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentFirstExam.ForeColor = System.Drawing.Color.White;
            this.TbStudentFirstExam.Location = new System.Drawing.Point(474, 20);
            this.TbStudentFirstExam.Name = "TbStudentFirstExam";
            this.TbStudentFirstExam.Size = new System.Drawing.Size(123, 15);
            this.TbStudentFirstExam.TabIndex = 16;
            // 
            // TbStudentSurname
            // 
            this.TbStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentSurname.ForeColor = System.Drawing.Color.White;
            this.TbStudentSurname.Location = new System.Drawing.Point(201, 75);
            this.TbStudentSurname.Name = "TbStudentSurname";
            this.TbStudentSurname.Size = new System.Drawing.Size(129, 15);
            this.TbStudentSurname.TabIndex = 15;
            // 
            // TbStudentName
            // 
            this.TbStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentName.ForeColor = System.Drawing.Color.White;
            this.TbStudentName.Location = new System.Drawing.Point(170, 47);
            this.TbStudentName.Name = "TbStudentName";
            this.TbStudentName.Size = new System.Drawing.Size(160, 15);
            this.TbStudentName.TabIndex = 14;
            // 
            // TbStudentNumber
            // 
            this.TbStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbStudentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentNumber.ForeColor = System.Drawing.Color.White;
            this.TbStudentNumber.Location = new System.Drawing.Point(190, 20);
            this.TbStudentNumber.Name = "TbStudentNumber";
            this.TbStudentNumber.Size = new System.Drawing.Size(140, 15);
            this.TbStudentNumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(357, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "THIRD EXAM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(357, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "SECOND EXAM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(357, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "FIRST EXAM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Surname :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Student Number :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.TbClassAVG);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.TbFailed);
            this.panel4.Controls.Add(this.TbPassed);
            this.panel4.Controls.Add(this.TbAverage);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(642, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 205);
            this.panel4.TabIndex = 5;
            // 
            // TbClassAVG
            // 
            this.TbClassAVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbClassAVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbClassAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbClassAVG.ForeColor = System.Drawing.Color.White;
            this.TbClassAVG.Location = new System.Drawing.Point(205, 172);
            this.TbClassAVG.Name = "TbClassAVG";
            this.TbClassAVG.ReadOnly = true;
            this.TbClassAVG.Size = new System.Drawing.Size(119, 15);
            this.TbClassAVG.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(93, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "CLASS AVG :";
            // 
            // TbFailed
            // 
            this.TbFailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbFailed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbFailed.ForeColor = System.Drawing.Color.White;
            this.TbFailed.Location = new System.Drawing.Point(174, 128);
            this.TbFailed.Name = "TbFailed";
            this.TbFailed.ReadOnly = true;
            this.TbFailed.Size = new System.Drawing.Size(119, 15);
            this.TbFailed.TabIndex = 24;
            // 
            // TbPassed
            // 
            this.TbPassed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbPassed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbPassed.ForeColor = System.Drawing.Color.White;
            this.TbPassed.Location = new System.Drawing.Point(174, 78);
            this.TbPassed.Name = "TbPassed";
            this.TbPassed.ReadOnly = true;
            this.TbPassed.Size = new System.Drawing.Size(100, 15);
            this.TbPassed.TabIndex = 23;
            // 
            // TbAverage
            // 
            this.TbAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.TbAverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbAverage.ForeColor = System.Drawing.Color.White;
            this.TbAverage.Location = new System.Drawing.Point(190, 27);
            this.TbAverage.Name = "TbAverage";
            this.TbAverage.ReadOnly = true;
            this.TbAverage.Size = new System.Drawing.Size(123, 15);
            this.TbAverage.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(93, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "FAILED :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(93, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "PASSED :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(93, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "AVERAGE :";
            // 
            // StudentsGV
            // 
            this.StudentsGV.AutoGenerateColumns = false;
            this.StudentsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstexamDataGridViewTextBoxColumn,
            this.secondexamDataGridViewTextBoxColumn,
            this.thirdexamDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.StudentsGV.DataSource = this.studentTblBindingSource;
            this.StudentsGV.Location = new System.Drawing.Point(13, 308);
            this.StudentsGV.Name = "StudentsGV";
            this.StudentsGV.Size = new System.Drawing.Size(1075, 325);
            this.StudentsGV.TabIndex = 6;
            this.StudentsGV.DoubleClick += new System.EventHandler(this.StudentsGV_DoubleClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // firstexamDataGridViewTextBoxColumn
            // 
            this.firstexamDataGridViewTextBoxColumn.DataPropertyName = "first_exam";
            this.firstexamDataGridViewTextBoxColumn.HeaderText = "first_exam";
            this.firstexamDataGridViewTextBoxColumn.Name = "firstexamDataGridViewTextBoxColumn";
            // 
            // secondexamDataGridViewTextBoxColumn
            // 
            this.secondexamDataGridViewTextBoxColumn.DataPropertyName = "second_exam";
            this.secondexamDataGridViewTextBoxColumn.HeaderText = "second_exam";
            this.secondexamDataGridViewTextBoxColumn.Name = "secondexamDataGridViewTextBoxColumn";
            // 
            // thirdexamDataGridViewTextBoxColumn
            // 
            this.thirdexamDataGridViewTextBoxColumn.DataPropertyName = "third_exam";
            this.thirdexamDataGridViewTextBoxColumn.HeaderText = "third_exam";
            this.thirdexamDataGridViewTextBoxColumn.Name = "thirdexamDataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "average";
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // studentManagementDataSet
            // 
            this.studentManagementDataSet.DataSetName = "StudentManagementDataSet";
            this.studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.StudentsGV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.Load += new System.EventHandler(this.TeacherPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TbStudentThirdExam;
        private System.Windows.Forms.TextBox TbStudentSecondExam;
        private System.Windows.Forms.TextBox TbStudentFirstExam;
        private System.Windows.Forms.TextBox TbStudentSurname;
        private System.Windows.Forms.TextBox TbStudentName;
        private System.Windows.Forms.TextBox TbStudentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox TbFailed;
        private System.Windows.Forms.TextBox TbPassed;
        private System.Windows.Forms.TextBox TbAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView StudentsGV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private StudentManagementDataSet studentManagementDataSet;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private StudentManagementDataSetTableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox TbClassAVG;
        private System.Windows.Forms.Label label10;
    }
}