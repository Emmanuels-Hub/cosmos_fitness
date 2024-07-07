namespace cosmos_fitness
{
    partial class Jogging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogging));
            groupBox1 = new GroupBox();
            goHome = new Button();
            levelInt = new NumericUpDown();
            calculateBtn = new Button();
            getDur = new TextBox();
            label3 = new Label();
            getWeight = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(goHome);
            groupBox1.Controls.Add(levelInt);
            groupBox1.Controls.Add(calculateBtn);
            groupBox1.Controls.Add(getDur);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(getWeight);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Sans", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Purple;
            groupBox1.Location = new Point(45, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 509);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogging";
            // 
            // goHome
            // 
            goHome.BackColor = Color.Purple;
            goHome.FlatStyle = FlatStyle.Flat;
            goHome.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(313, 441);
            goHome.Name = "goHome";
            goHome.Size = new Size(91, 41);
            goHome.TabIndex = 10;
            goHome.Text = "Home";
            goHome.UseVisualStyleBackColor = false;
            goHome.Click += goHome_Click;
            // 
            // levelInt
            // 
            levelInt.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levelInt.Location = new Point(40, 102);
            levelInt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levelInt.Name = "levelInt";
            levelInt.Size = new Size(277, 36);
            levelInt.TabIndex = 9;
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = Color.Purple;
            calculateBtn.FlatStyle = FlatStyle.Flat;
            calculateBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculateBtn.ForeColor = Color.White;
            calculateBtn.Location = new Point(40, 341);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(277, 41);
            calculateBtn.TabIndex = 7;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // getDur
            // 
            getDur.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getDur.Location = new Point(40, 268);
            getDur.Name = "getDur";
            getDur.Size = new Size(277, 31);
            getDur.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 244);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 4;
            label3.Text = "Duration";
            // 
            // getWeight
            // 
            getWeight.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getWeight.Location = new Point(40, 183);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(277, 31);
            getWeight.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 159);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Intensity";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(492, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Jogging
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 531);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Jogging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogging";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button goHome;
        private NumericUpDown levelInt;
        private Button calculateBtn;
        private TextBox getDur;
        private Label label3;
        private TextBox getWeight;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}