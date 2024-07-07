namespace cosmos_fitness
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            getPass = new TextBox();
            label3 = new Label();
            getcomPass = new TextBox();
            registerBtn = new Button();
            groupBox1 = new GroupBox();
            loginPage = new Button();
            label4 = new Label();
            getUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 159);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // getPass
            // 
            getPass.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getPass.Location = new Point(40, 183);
            getPass.Name = "getPass";
            getPass.PasswordChar = '*';
            getPass.Size = new Size(277, 31);
            getPass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 244);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // getcomPass
            // 
            getcomPass.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getcomPass.Location = new Point(40, 268);
            getcomPass.Name = "getcomPass";
            getcomPass.PasswordChar = '*';
            getcomPass.Size = new Size(277, 31);
            getcomPass.TabIndex = 5;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Purple;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(40, 341);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(277, 41);
            registerBtn.TabIndex = 7;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loginPage);
            groupBox1.Controls.Add(registerBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(getcomPass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(getPass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(getUser);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Purple;
            groupBox1.Location = new Point(36, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 509);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Get Started.";
            // 
            // loginPage
            // 
            loginPage.BackColor = Color.Purple;
            loginPage.FlatStyle = FlatStyle.Flat;
            loginPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPage.ForeColor = Color.White;
            loginPage.Location = new Point(116, 445);
            loginPage.Name = "loginPage";
            loginPage.Size = new Size(103, 41);
            loginPage.TabIndex = 8;
            loginPage.Text = "Sign in";
            loginPage.UseVisualStyleBackColor = false;
            loginPage.Click += loginPage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(55, 404);
            label4.Name = "label4";
            label4.Size = new Size(247, 21);
            label4.TabIndex = 6;
            label4.Text = "Already have an Account?";
            // 
            // getUser
            // 
            getUser.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getUser.Location = new Point(40, 101);
            getUser.Name = "getUser";
            getUser.Size = new Size(277, 31);
            getUser.TabIndex = 1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 545);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox getPass;
        private Label label3;
        private TextBox getcomPass;
        private Button registerBtn;
        private GroupBox groupBox1;
        private Button loginPage;
        private Label label4;
        private TextBox getUser;
    }
}
