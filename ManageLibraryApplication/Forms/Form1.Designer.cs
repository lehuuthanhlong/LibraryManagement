namespace ManageLibraryApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txbPassword = new TextBox();
            txbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = Properties.Resources.library_management_application_high_resolution_logo_transparent1;
            pictureBox1.Image = Properties.Resources.library_management_application_high_resolution_logo_transparent1;
            pictureBox1.Location = new Point(39, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 654);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(407, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 654);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources._11854696;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(325, 351);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._2859382;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(325, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.FixedSingle;
            txbPassword.Location = new Point(356, 352);
            txbPassword.MaxLength = 20;
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(223, 25);
            txbPassword.TabIndex = 4;
            // 
            // txbUsername
            // 
            txbUsername.BorderStyle = BorderStyle.FixedSingle;
            txbUsername.Location = new Point(356, 286);
            txbUsername.MaxLength = 20;
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(223, 25);
            txbUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 332);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 266);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(404, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(877, 654);
            panel3.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.customer;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Image = Properties.Resources.customer;
            pictureBox6.Location = new Point(432, 176);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 70);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources._11854696;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(325, 351);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources._2859382;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(325, 286);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(356, 352);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(223, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(356, 286);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 25);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(329, 332);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(329, 266);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 2;
            label4.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(420, 421);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 7;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 659);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txbPassword;
        private TextBox txbUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox6;
        private Button button1;
    }
}