
namespace MyFirstGithubApplication
{
    partial class LoginPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbTeacherUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TbTeacherPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbStudentPassword = new System.Windows.Forms.TextBox();
            this.TbStudentUsername = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 57);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lemon/Milk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(713, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 31);
            this.btnExit.TabIndex = 15;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 57);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(36, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 222);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TbTeacherUsername
            // 
            this.TbTeacherUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.TbTeacherUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbTeacherUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbTeacherUsername.ForeColor = System.Drawing.Color.White;
            this.TbTeacherUsername.Location = new System.Drawing.Point(165, 307);
            this.TbTeacherUsername.Name = "TbTeacherUsername";
            this.TbTeacherUsername.Size = new System.Drawing.Size(122, 19);
            this.TbTeacherUsername.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel3.Location = new System.Drawing.Point(359, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 386);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(463, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 186);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // TbTeacherPassword
            // 
            this.TbTeacherPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.TbTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbTeacherPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbTeacherPassword.ForeColor = System.Drawing.Color.White;
            this.TbTeacherPassword.Location = new System.Drawing.Point(165, 341);
            this.TbTeacherPassword.Name = "TbTeacherPassword";
            this.TbTeacherPassword.PasswordChar = '*';
            this.TbTeacherPassword.Size = new System.Drawing.Size(122, 19);
            this.TbTeacherPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(33, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERNAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(37, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "PASSWORD :";
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.Location = new System.Drawing.Point(133, 385);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(89, 33);
            this.btnTeacherLogin.TabIndex = 9;
            this.btnTeacherLogin.Text = "LOGİN";
            this.btnTeacherLogin.UseVisualStyleBackColor = true;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentLogin.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.Location = new System.Drawing.Point(527, 385);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(89, 33);
            this.btnStudentLogin.TabIndex = 10;
            this.btnStudentLogin.Text = "LOGİN";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(432, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "PASSWORD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(428, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "USERNAME :";
            // 
            // TbStudentPassword
            // 
            this.TbStudentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.TbStudentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentPassword.ForeColor = System.Drawing.Color.White;
            this.TbStudentPassword.Location = new System.Drawing.Point(560, 341);
            this.TbStudentPassword.Name = "TbStudentPassword";
            this.TbStudentPassword.PasswordChar = '*';
            this.TbStudentPassword.Size = new System.Drawing.Size(122, 19);
            this.TbStudentPassword.TabIndex = 4;
            // 
            // TbStudentUsername
            // 
            this.TbStudentUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.TbStudentUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbStudentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbStudentUsername.ForeColor = System.Drawing.Color.White;
            this.TbStudentUsername.Location = new System.Drawing.Point(560, 307);
            this.TbStudentUsername.Name = "TbStudentUsername";
            this.TbStudentUsername.Size = new System.Drawing.Size(122, 19);
            this.TbStudentUsername.TabIndex = 3;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbStudentPassword);
            this.Controls.Add(this.TbStudentUsername);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.btnTeacherLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TbTeacherPassword);
            this.Controls.Add(this.TbTeacherUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbTeacherUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TbTeacherPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbStudentPassword;
        private System.Windows.Forms.TextBox TbStudentUsername;
        private System.Windows.Forms.Button btnExit;
    }
}

