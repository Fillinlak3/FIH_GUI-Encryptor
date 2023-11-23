
namespace FIH_GUI_Encryptor
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            Label_Time = new System.Windows.Forms.Label();
            Button_Exit = new FontAwesome.Sharp.IconButton();
            PictureBox_Logo = new System.Windows.Forms.PictureBox();
            Panel_FirstName = new System.Windows.Forms.Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new System.Windows.Forms.Panel();
            TextBox_FirstName = new System.Windows.Forms.TextBox();
            Panel_LastName = new System.Windows.Forms.Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new System.Windows.Forms.Panel();
            TextBox_LastName = new System.Windows.Forms.TextBox();
            Panel_Email = new System.Windows.Forms.Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel6 = new System.Windows.Forms.Panel();
            TextBox_Email = new System.Windows.Forms.TextBox();
            Panel_Username = new System.Windows.Forms.Panel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel8 = new System.Windows.Forms.Panel();
            TextBox_Username = new System.Windows.Forms.TextBox();
            Panel_Password = new System.Windows.Forms.Panel();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            TextBox_Password = new System.Windows.Forms.TextBox();
            panel9 = new System.Windows.Forms.Panel();
            Button_goRegister = new System.Windows.Forms.Button();
            Timer_DateTime = new System.Windows.Forms.Timer(components);
            Button_Back = new FontAwesome.Sharp.IconButton();
            panel2 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            Panel_FirstName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            Panel_LastName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            Panel_Email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            Panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(Label_Time);
            panel1.Controls.Add(Button_Exit);
            panel1.Controls.Add(PictureBox_Logo);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 20);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.MaximumSize = new System.Drawing.Size(790, 90);
            panel1.MinimumSize = new System.Drawing.Size(790, 90);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(790, 90);
            panel1.TabIndex = 3;
            // 
            // Label_Time
            // 
            Label_Time.AutoSize = true;
            Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label_Time.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Label_Time.Location = new System.Drawing.Point(510, 5);
            Label_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_Time.Name = "Label_Time";
            Label_Time.Size = new System.Drawing.Size(140, 31);
            Label_Time.TabIndex = 3;
            Label_Time.Text = "Time Here";
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            Button_Exit.FlatAppearance.BorderSize = 0;
            Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            Button_Exit.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Button_Exit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            Button_Exit.IconColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Button_Exit.IconSize = 32;
            Button_Exit.Location = new System.Drawing.Point(728, 8);
            Button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Rotation = 0D;
            Button_Exit.Size = new System.Drawing.Size(43, 42);
            Button_Exit.TabIndex = 3;
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // PictureBox_Logo
            // 
            PictureBox_Logo.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            PictureBox_Logo.Image = Properties.Resources.Logo_FIH;
            PictureBox_Logo.Location = new System.Drawing.Point(15, 0);
            PictureBox_Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PictureBox_Logo.Name = "PictureBox_Logo";
            PictureBox_Logo.Size = new System.Drawing.Size(164, 94);
            PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox_Logo.TabIndex = 1;
            PictureBox_Logo.TabStop = false;
            // 
            // Panel_FirstName
            // 
            Panel_FirstName.Controls.Add(iconPictureBox2);
            Panel_FirstName.Controls.Add(panel3);
            Panel_FirstName.Controls.Add(TextBox_FirstName);
            Panel_FirstName.Location = new System.Drawing.Point(82, 52);
            Panel_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_FirstName.Name = "Panel_FirstName";
            Panel_FirstName.Size = new System.Drawing.Size(556, 102);
            Panel_FirstName.TabIndex = 20;
            Panel_FirstName.MouseLeave += Panel_FirstName_MouseLeave;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = System.Drawing.Color.White;
            iconPictureBox2.IconSize = 57;
            iconPictureBox2.Location = new System.Drawing.Point(4, 23);
            iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new System.Drawing.Size(57, 57);
            iconPictureBox2.TabIndex = 17;
            iconPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Location = new System.Drawing.Point(17, 83);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(533, 2);
            panel3.TabIndex = 12;
            // 
            // TextBox_FirstName
            // 
            TextBox_FirstName.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_FirstName.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_FirstName.Location = new System.Drawing.Point(69, 29);
            TextBox_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox_FirstName.MaxLength = 101;
            TextBox_FirstName.Name = "TextBox_FirstName";
            TextBox_FirstName.Size = new System.Drawing.Size(352, 34);
            TextBox_FirstName.TabIndex = 11;
            TextBox_FirstName.Text = "First Name";
            TextBox_FirstName.Click += TextBox_FirstName_Click;
            // 
            // Panel_LastName
            // 
            Panel_LastName.Controls.Add(iconPictureBox1);
            Panel_LastName.Controls.Add(panel4);
            Panel_LastName.Controls.Add(TextBox_LastName);
            Panel_LastName.Location = new System.Drawing.Point(82, 163);
            Panel_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_LastName.Name = "Panel_LastName";
            Panel_LastName.Size = new System.Drawing.Size(556, 102);
            Panel_LastName.TabIndex = 21;
            Panel_LastName.MouseLeave += Panel_LastName_MouseLeave;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconSize = 57;
            iconPictureBox1.Location = new System.Drawing.Point(4, 23);
            iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(57, 57);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Location = new System.Drawing.Point(17, 83);
            panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(533, 2);
            panel4.TabIndex = 12;
            // 
            // TextBox_LastName
            // 
            TextBox_LastName.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_LastName.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_LastName.Location = new System.Drawing.Point(69, 29);
            TextBox_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox_LastName.MaxLength = 101;
            TextBox_LastName.Name = "TextBox_LastName";
            TextBox_LastName.Size = new System.Drawing.Size(352, 34);
            TextBox_LastName.TabIndex = 11;
            TextBox_LastName.Text = "Last Name";
            TextBox_LastName.Click += TextBox_LastName_Click;
            // 
            // Panel_Email
            // 
            Panel_Email.Controls.Add(iconPictureBox3);
            Panel_Email.Controls.Add(panel6);
            Panel_Email.Controls.Add(TextBox_Email);
            Panel_Email.Location = new System.Drawing.Point(82, 274);
            Panel_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_Email.Name = "Panel_Email";
            Panel_Email.Size = new System.Drawing.Size(556, 102);
            Panel_Email.TabIndex = 22;
            Panel_Email.MouseLeave += Panel_Email_MouseLeave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            iconPictureBox3.IconColor = System.Drawing.Color.White;
            iconPictureBox3.IconSize = 57;
            iconPictureBox3.Location = new System.Drawing.Point(4, 23);
            iconPictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new System.Drawing.Size(57, 57);
            iconPictureBox3.TabIndex = 17;
            iconPictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.White;
            panel6.Location = new System.Drawing.Point(17, 83);
            panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(533, 2);
            panel6.TabIndex = 12;
            // 
            // TextBox_Email
            // 
            TextBox_Email.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_Email.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_Email.Location = new System.Drawing.Point(69, 29);
            TextBox_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox_Email.MaxLength = 101;
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new System.Drawing.Size(352, 34);
            TextBox_Email.TabIndex = 11;
            TextBox_Email.Text = "Email";
            TextBox_Email.Click += TextBox_Email_Click;
            // 
            // Panel_Username
            // 
            Panel_Username.Controls.Add(iconPictureBox4);
            Panel_Username.Controls.Add(panel8);
            Panel_Username.Controls.Add(TextBox_Username);
            Panel_Username.Location = new System.Drawing.Point(82, 385);
            Panel_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_Username.Name = "Panel_Username";
            Panel_Username.Size = new System.Drawing.Size(556, 102);
            Panel_Username.TabIndex = 23;
            Panel_Username.MouseLeave += Panel_Username_MouseLeave;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox4.IconColor = System.Drawing.Color.White;
            iconPictureBox4.IconSize = 57;
            iconPictureBox4.Location = new System.Drawing.Point(4, 23);
            iconPictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new System.Drawing.Size(57, 57);
            iconPictureBox4.TabIndex = 17;
            iconPictureBox4.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.Color.White;
            panel8.Location = new System.Drawing.Point(17, 83);
            panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(533, 2);
            panel8.TabIndex = 12;
            // 
            // TextBox_Username
            // 
            TextBox_Username.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_Username.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_Username.Location = new System.Drawing.Point(69, 29);
            TextBox_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox_Username.MaxLength = 1001;
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.Size = new System.Drawing.Size(352, 34);
            TextBox_Username.TabIndex = 11;
            TextBox_Username.Text = "Username";
            TextBox_Username.Click += TextBox_Username_Click;
            // 
            // Panel_Password
            // 
            Panel_Password.Controls.Add(iconPictureBox5);
            Panel_Password.Controls.Add(TextBox_Password);
            Panel_Password.Controls.Add(panel9);
            Panel_Password.Location = new System.Drawing.Point(82, 495);
            Panel_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_Password.Name = "Panel_Password";
            Panel_Password.Size = new System.Drawing.Size(556, 102);
            Panel_Password.TabIndex = 24;
            Panel_Password.MouseLeave += Panel_Password_MouseLeave;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            iconPictureBox5.IconColor = System.Drawing.Color.White;
            iconPictureBox5.IconSize = 57;
            iconPictureBox5.Location = new System.Drawing.Point(4, 20);
            iconPictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new System.Drawing.Size(57, 57);
            iconPictureBox5.TabIndex = 18;
            iconPictureBox5.TabStop = false;
            // 
            // TextBox_Password
            // 
            TextBox_Password.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_Password.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_Password.Location = new System.Drawing.Point(71, 26);
            TextBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.Size = new System.Drawing.Size(352, 34);
            TextBox_Password.TabIndex = 13;
            TextBox_Password.Text = "Password";
            TextBox_Password.Click += TextBox_Password_Click;
            // 
            // panel9
            // 
            panel9.BackColor = System.Drawing.Color.White;
            panel9.Location = new System.Drawing.Point(17, 80);
            panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(533, 2);
            panel9.TabIndex = 14;
            // 
            // Button_goRegister
            // 
            Button_goRegister.BackColor = System.Drawing.Color.FromArgb(78, 184, 206);
            Button_goRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_goRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Button_goRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            Button_goRegister.Location = new System.Drawing.Point(154, 26);
            Button_goRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_goRegister.Name = "Button_goRegister";
            Button_goRegister.Size = new System.Drawing.Size(408, 114);
            Button_goRegister.TabIndex = 25;
            Button_goRegister.Text = "Register Account";
            Button_goRegister.UseVisualStyleBackColor = false;
            Button_goRegister.Click += Button_goRegister_Click;
            // 
            // Timer_DateTime
            // 
            Timer_DateTime.Enabled = true;
            Timer_DateTime.Tick += Timer_DateTime_Tick;
            // 
            // Button_Back
            // 
            Button_Back.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            Button_Back.FlatAppearance.BorderSize = 0;
            Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Back.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            Button_Back.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Button_Back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            Button_Back.IconColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Button_Back.IconSize = 32;
            Button_Back.Location = new System.Drawing.Point(16, 1202);
            Button_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_Back.Name = "Button_Back";
            Button_Back.Rotation = 0D;
            Button_Back.Size = new System.Drawing.Size(43, 42);
            Button_Back.TabIndex = 27;
            Button_Back.UseVisualStyleBackColor = false;
            Button_Back.Click += Button_Back_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Button_goRegister);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 876);
            panel2.MaximumSize = new System.Drawing.Size(790, 154);
            panel2.MinimumSize = new System.Drawing.Size(790, 154);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(790, 154);
            panel2.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.Controls.Add(Panel_Password);
            panel5.Controls.Add(Panel_Username);
            panel5.Controls.Add(Panel_Email);
            panel5.Controls.Add(Panel_LastName);
            panel5.Controls.Add(Panel_FirstName);
            panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(0, 110);
            panel5.MaximumSize = new System.Drawing.Size(790, 766);
            panel5.MinimumSize = new System.Drawing.Size(790, 766);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(790, 766);
            panel5.TabIndex = 29;
            // 
            // Register
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(790, 1030);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(Button_Back);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximumSize = new System.Drawing.Size(790, 1030);
            MinimumSize = new System.Drawing.Size(790, 1018);
            Name = "Register";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            Panel_FirstName.ResumeLayout(false);
            Panel_FirstName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            Panel_LastName.ResumeLayout(false);
            Panel_LastName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            Panel_Email.ResumeLayout(false);
            Panel_Email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            Panel_Username.ResumeLayout(false);
            Panel_Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            Panel_Password.ResumeLayout(false);
            Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_Time;
        private FontAwesome.Sharp.IconButton Button_Exit;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Panel Panel_FirstName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.Panel Panel_LastName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.Panel Panel_Email;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Panel Panel_Username;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.Panel Panel_Password;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Button_goRegister;
        private System.Windows.Forms.Timer Timer_DateTime;
        private FontAwesome.Sharp.IconButton Button_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}