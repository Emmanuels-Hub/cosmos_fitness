namespace cosmos_fitness
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            registerPage = new Button();
            loginBtn = new Button();
            label4 = new Label();
            getlogpass = new TextBox();
            label2 = new Label();
            getloguser = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(492, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(registerPage);
            groupBox1.Controls.Add(loginBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(getlogpass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(getloguser);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Purple;
            groupBox1.Location = new Point(45, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 509);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome User.";
            // 
            // registerPage
            // 
            registerPage.BackColor = Color.Purple;
            registerPage.FlatStyle = FlatStyle.Flat;
            registerPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPage.ForeColor = Color.White;
            registerPage.Location = new Point(143, 392);
            registerPage.Name = "registerPage";
            registerPage.Size = new Size(103, 41);
            registerPage.TabIndex = 8;
            registerPage.Text = "Sign up";
            registerPage.UseVisualStyleBackColor = false;
            registerPage.Click += registerPage_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Purple;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(67, 288);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(277, 41);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(82, 351);
            label4.Name = "label4";
            label4.Size = new Size(227, 21);
            label4.TabIndex = 6;
            label4.Text = "Don't have an Account?";
            // 
            // getlogpass
            // 
            getlogpass.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getlogpass.Location = new Point(72, 222);
            getlogpass.Name = "getlogpass";
            getlogpass.PasswordChar = '*';
            getlogpass.Size = new Size(277, 31);
            getlogpass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 198);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // getloguser
            // 
            getloguser.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getloguser.Location = new Point(72, 140);
            getloguser.Name = "getloguser";
            getloguser.Size = new Size(277, 31);
            getloguser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(67, 117);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 546);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button registerPage;
        private Button loginBtn;
        private Label label4;
        private TextBox getlogpass;
        private Label label2;
        private TextBox getloguser;
        private Label label1;
    }
}