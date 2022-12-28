
namespace MyFirstGithubApplication
{
    partial class StudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblFirstExam = new System.Windows.Forms.Label();
            this.LblSecondExam = new System.Windows.Forms.Label();
            this.LblThirdExam = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblGradeAvg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblStudentNumber = new System.Windows.Forms.Label();
            this.LblStudentName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 57);
            this.panel2.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lemon/Milk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(594, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 31);
            this.btnBack.TabIndex = 1;
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
            this.btnExit.Location = new System.Drawing.Point(634, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(183, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(183, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Number :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel3.Location = new System.Drawing.Point(0, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 39);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 123);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(20, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "SECOND EXAM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(20, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "FIRST EXAM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(20, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "THIRD EXAM :";
            // 
            // LblFirstExam
            // 
            this.LblFirstExam.AutoSize = true;
            this.LblFirstExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstExam.ForeColor = System.Drawing.Color.White;
            this.LblFirstExam.Location = new System.Drawing.Point(171, 250);
            this.LblFirstExam.Name = "LblFirstExam";
            this.LblFirstExam.Size = new System.Drawing.Size(0, 20);
            this.LblFirstExam.TabIndex = 8;
            // 
            // LblSecondExam
            // 
            this.LblSecondExam.AutoSize = true;
            this.LblSecondExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSecondExam.ForeColor = System.Drawing.Color.White;
            this.LblSecondExam.Location = new System.Drawing.Point(171, 295);
            this.LblSecondExam.Name = "LblSecondExam";
            this.LblSecondExam.Size = new System.Drawing.Size(0, 20);
            this.LblSecondExam.TabIndex = 9;
            // 
            // LblThirdExam
            // 
            this.LblThirdExam.AutoSize = true;
            this.LblThirdExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThirdExam.ForeColor = System.Drawing.Color.White;
            this.LblThirdExam.Location = new System.Drawing.Point(171, 340);
            this.LblThirdExam.Name = "LblThirdExam";
            this.LblThirdExam.Size = new System.Drawing.Size(0, 20);
            this.LblThirdExam.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel4.Location = new System.Drawing.Point(354, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 163);
            this.panel4.TabIndex = 11;
            // 
            // LblGradeAvg
            // 
            this.LblGradeAvg.AutoSize = true;
            this.LblGradeAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGradeAvg.ForeColor = System.Drawing.Color.White;
            this.LblGradeAvg.Location = new System.Drawing.Point(580, 267);
            this.LblGradeAvg.Name = "LblGradeAvg";
            this.LblGradeAvg.Size = new System.Drawing.Size(0, 20);
            this.LblGradeAvg.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(423, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "GRADE AVERAGE :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(423, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "STATUS :";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(504, 316);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 20);
            this.LblStatus.TabIndex = 12;
            // 
            // LblStudentNumber
            // 
            this.LblStudentNumber.AutoSize = true;
            this.LblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.LblStudentNumber.Location = new System.Drawing.Point(375, 133);
            this.LblStudentNumber.Name = "LblStudentNumber";
            this.LblStudentNumber.Size = new System.Drawing.Size(0, 20);
            this.LblStudentNumber.TabIndex = 15;
            // 
            // LblStudentName
            // 
            this.LblStudentName.AutoSize = true;
            this.LblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStudentName.ForeColor = System.Drawing.Color.White;
            this.LblStudentName.Location = new System.Drawing.Point(375, 89);
            this.LblStudentName.Name = "LblStudentName";
            this.LblStudentName.Size = new System.Drawing.Size(0, 20);
            this.LblStudentName.TabIndex = 14;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.LblStudentNumber);
            this.Controls.Add(this.LblStudentName);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblGradeAvg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LblThirdExam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSecondExam);
            this.Controls.Add(this.LblFirstExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblFirstExam;
        private System.Windows.Forms.Label LblSecondExam;
        private System.Windows.Forms.Label LblThirdExam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblGradeAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LblStudentNumber;
        private System.Windows.Forms.Label LblStudentName;
    }
}