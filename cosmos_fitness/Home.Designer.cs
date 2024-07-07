namespace cosmos_fitness
{
    partial class Home
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
            groupBox1 = new GroupBox();
            calData = new Label();
            label4 = new Label();
            getCal = new TextBox();
            setCal = new Button();
            groupBox2 = new GroupBox();
            runPage = new Button();
            walkPage = new Button();
            yogaPage = new Button();
            swimPage = new Button();
            sprintPage = new Button();
            jogPage = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(calData);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(getCal);
            groupBox1.Controls.Add(setCal);
            groupBox1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Purple;
            groupBox1.Location = new Point(13, 35);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(447, 477);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calories Limit";
            // 
            // calData
            // 
            calData.AutoSize = true;
            calData.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calData.Location = new Point(122, 183);
            calData.Name = "calData";
            calData.Size = new Size(148, 55);
            calData.TabIndex = 11;
            calData.Text = "0000";
            calData.Click += calData_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 279);
            label4.Name = "label4";
            label4.Size = new Size(324, 27);
            label4.TabIndex = 10;
            label4.Text = "Set your calory burn limit";
            // 
            // getCal
            // 
            getCal.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getCal.Location = new Point(51, 329);
            getCal.Name = "getCal";
            getCal.Size = new Size(208, 31);
            getCal.TabIndex = 9;
            // 
            // setCal
            // 
            setCal.BackColor = Color.Purple;
            setCal.FlatStyle = FlatStyle.Flat;
            setCal.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setCal.ForeColor = Color.White;
            setCal.Location = new Point(265, 324);
            setCal.Name = "setCal";
            setCal.Size = new Size(110, 41);
            setCal.TabIndex = 8;
            setCal.Text = "Set";
            setCal.UseVisualStyleBackColor = false;
            setCal.Click += setcal_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(runPage);
            groupBox2.Controls.Add(walkPage);
            groupBox2.Controls.Add(yogaPage);
            groupBox2.Controls.Add(swimPage);
            groupBox2.Controls.Add(sprintPage);
            groupBox2.Controls.Add(jogPage);
            groupBox2.Font = new Font("Lucida Sans", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Purple;
            groupBox2.Location = new Point(487, 35);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(444, 477);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose from the Below Activities.";
            // 
            // runPage
            // 
            runPage.BackColor = Color.Purple;
            runPage.FlatStyle = FlatStyle.Flat;
            runPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runPage.ForeColor = Color.White;
            runPage.Location = new Point(84, 129);
            runPage.Name = "runPage";
            runPage.Size = new Size(277, 41);
            runPage.TabIndex = 13;
            runPage.Text = "Running";
            runPage.UseVisualStyleBackColor = false;
            runPage.Click += runPage_Click;
            // 
            // walkPage
            // 
            walkPage.BackColor = Color.Purple;
            walkPage.FlatStyle = FlatStyle.Flat;
            walkPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            walkPage.ForeColor = Color.White;
            walkPage.Location = new Point(84, 56);
            walkPage.Name = "walkPage";
            walkPage.Size = new Size(277, 41);
            walkPage.TabIndex = 12;
            walkPage.Text = "Walking";
            walkPage.UseVisualStyleBackColor = false;
            walkPage.Click += walkPage_Click;
            // 
            // yogaPage
            // 
            yogaPage.BackColor = Color.Purple;
            yogaPage.FlatStyle = FlatStyle.Flat;
            yogaPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yogaPage.ForeColor = Color.White;
            yogaPage.Location = new Point(84, 338);
            yogaPage.Name = "yogaPage";
            yogaPage.Size = new Size(277, 41);
            yogaPage.TabIndex = 11;
            yogaPage.Text = "Yoga";
            yogaPage.UseVisualStyleBackColor = false;
            yogaPage.Click += yogaPage_Click;
            // 
            // swimPage
            // 
            swimPage.BackColor = Color.Purple;
            swimPage.FlatStyle = FlatStyle.Flat;
            swimPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            swimPage.ForeColor = Color.White;
            swimPage.Location = new Point(84, 406);
            swimPage.Name = "swimPage";
            swimPage.Size = new Size(277, 41);
            swimPage.TabIndex = 10;
            swimPage.Text = "Swimming";
            swimPage.UseVisualStyleBackColor = false;
            swimPage.Click += swimPage_Click;
            // 
            // sprintPage
            // 
            sprintPage.BackColor = Color.Purple;
            sprintPage.FlatStyle = FlatStyle.Flat;
            sprintPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sprintPage.ForeColor = Color.White;
            sprintPage.Location = new Point(84, 197);
            sprintPage.Name = "sprintPage";
            sprintPage.Size = new Size(277, 41);
            sprintPage.TabIndex = 9;
            sprintPage.Text = "Sprinting";
            sprintPage.UseVisualStyleBackColor = false;
            sprintPage.Click += sprintPage_Click;
            // 
            // jogPage
            // 
            jogPage.BackColor = Color.Purple;
            jogPage.FlatStyle = FlatStyle.Flat;
            jogPage.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jogPage.ForeColor = Color.White;
            jogPage.Location = new Point(84, 265);
            jogPage.Name = "jogPage";
            jogPage.Size = new Size(277, 41);
            jogPage.TabIndex = 8;
            jogPage.Text = "Jogging";
            jogPage.UseVisualStyleBackColor = false;
            jogPage.Click += jogPage_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 537);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button setCal;
        private Button runPage;
        private Button walkPage;
        private Button yogaPage;
        private Button swimPage;
        private Button sprintPage;
        private Button jogPage;
        private TextBox getCal;
        private Label calData;
        private Label label4;
    }
}