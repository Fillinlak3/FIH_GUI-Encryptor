
namespace FIH_GUI_Encryptor
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            Label_Time = new System.Windows.Forms.Label();
            Button_Exit = new FontAwesome.Sharp.IconButton();
            PictureBox_Logo = new System.Windows.Forms.PictureBox();
            Timer_DateTime = new System.Windows.Forms.Timer(components);
            Button_goRegister = new System.Windows.Forms.Button();
            Button_SignIn = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            Password_Visibility = new FontAwesome.Sharp.IconPictureBox();
            Panel_Password = new System.Windows.Forms.Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            TextBox_Password = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            Panel_Username = new System.Windows.Forms.Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new System.Windows.Forms.Panel();
            TextBox_Username = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Password_Visibility).BeginInit();
            Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            Panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            panel1.Margin = new System.Windows.Forms.Padding(5);
            panel1.MaximumSize = new System.Drawing.Size(790, 90);
            panel1.MinimumSize = new System.Drawing.Size(790, 90);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(790, 90);
            panel1.TabIndex = 2;
            // 
            // Label_Time
            // 
            Label_Time.AutoSize = true;
            Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label_Time.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Label_Time.Location = new System.Drawing.Point(510, 5);
            Label_Time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            Button_Exit.Margin = new System.Windows.Forms.Padding(5);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Rotation = 0D;
            Button_Exit.Size = new System.Drawing.Size(48, 39);
            Button_Exit.TabIndex = 3;
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // PictureBox_Logo
            // 
            PictureBox_Logo.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            PictureBox_Logo.Image = Properties.Resources.Logo_FIH;
            PictureBox_Logo.Location = new System.Drawing.Point(16, 0);
            PictureBox_Logo.Margin = new System.Windows.Forms.Padding(5);
            PictureBox_Logo.Name = "PictureBox_Logo";
            PictureBox_Logo.Size = new System.Drawing.Size(180, 88);
            PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox_Logo.TabIndex = 1;
            PictureBox_Logo.TabStop = false;
            // 
            // Timer_DateTime
            // 
            Timer_DateTime.Enabled = true;
            Timer_DateTime.Tick += Timer_DateTime_Tick;
            // 
            // Button_goRegister
            // 
            Button_goRegister.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
            Button_goRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_goRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Button_goRegister.ForeColor = System.Drawing.SystemColors.Control;
            Button_goRegister.Location = new System.Drawing.Point(170, 161);
            Button_goRegister.Margin = new System.Windows.Forms.Padding(5);
            Button_goRegister.Name = "Button_goRegister";
            Button_goRegister.Size = new System.Drawing.Size(446, 108);
            Button_goRegister.TabIndex = 16;
            Button_goRegister.Text = "Register";
            Button_goRegister.UseVisualStyleBackColor = false;
            Button_goRegister.Click += Button_goRegister_Click;
            // 
            // Button_SignIn
            // 
            Button_SignIn.BackColor = System.Drawing.Color.FromArgb(78, 184, 206);
            Button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Button_SignIn.Location = new System.Drawing.Point(170, 28);
            Button_SignIn.Margin = new System.Windows.Forms.Padding(5);
            Button_SignIn.Name = "Button_SignIn";
            Button_SignIn.Size = new System.Drawing.Size(448, 108);
            Button_SignIn.TabIndex = 15;
            Button_SignIn.Text = "Sign In";
            Button_SignIn.UseVisualStyleBackColor = false;
            Button_SignIn.MouseClick += Button_SignIn_MouseClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(Button_goRegister);
            panel5.Controls.Add(Button_SignIn);
            panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(0, 745);
            panel5.Margin = new System.Windows.Forms.Padding(2);
            panel5.MaximumSize = new System.Drawing.Size(790, 285);
            panel5.MinimumSize = new System.Drawing.Size(790, 285);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(790, 285);
            panel5.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(Password_Visibility);
            panel2.Controls.Add(Panel_Password);
            panel2.Controls.Add(Panel_Username);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 110);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.MaximumSize = new System.Drawing.Size(790, 635);
            panel2.MinimumSize = new System.Drawing.Size(790, 635);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(790, 635);
            panel2.TabIndex = 24;
            // 
            // Password_Visibility
            // 
            Password_Visibility.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            Password_Visibility.IconColor = System.Drawing.Color.White;
            Password_Visibility.IconSize = 55;
            Password_Visibility.Location = new System.Drawing.Point(672, 329);
            Password_Visibility.Margin = new System.Windows.Forms.Padding(5);
            Password_Visibility.Name = "Password_Visibility";
            Password_Visibility.Size = new System.Drawing.Size(62, 55);
            Password_Visibility.TabIndex = 24;
            Password_Visibility.TabStop = false;
            // 
            // Panel_Password
            // 
            Panel_Password.Controls.Add(iconPictureBox3);
            Panel_Password.Controls.Add(TextBox_Password);
            Panel_Password.Controls.Add(panel3);
            Panel_Password.Location = new System.Drawing.Point(54, 310);
            Panel_Password.Margin = new System.Windows.Forms.Padding(5);
            Panel_Password.Name = "Panel_Password";
            Panel_Password.Size = new System.Drawing.Size(608, 95);
            Panel_Password.TabIndex = 23;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            iconPictureBox3.IconColor = System.Drawing.Color.White;
            iconPictureBox3.IconSize = 55;
            iconPictureBox3.Location = new System.Drawing.Point(5, 19);
            iconPictureBox3.Margin = new System.Windows.Forms.Padding(5);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new System.Drawing.Size(62, 55);
            iconPictureBox3.TabIndex = 18;
            iconPictureBox3.TabStop = false;
            // 
            // TextBox_Password
            // 
            TextBox_Password.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_Password.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_Password.Location = new System.Drawing.Point(78, 25);
            TextBox_Password.Margin = new System.Windows.Forms.Padding(5);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.Size = new System.Drawing.Size(385, 34);
            TextBox_Password.TabIndex = 13;
            TextBox_Password.Text = "Password";
            TextBox_Password.MouseClick += TextBox_Password_MouseClick;
            TextBox_Password.KeyPress += TextBox_Password_KeyPress;
            TextBox_Password.MouseLeave += Panel_Password_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Location = new System.Drawing.Point(19, 75);
            panel3.Margin = new System.Windows.Forms.Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(582, 1);
            panel3.TabIndex = 14;
            // 
            // Panel_Username
            // 
            Panel_Username.Controls.Add(iconPictureBox2);
            Panel_Username.Controls.Add(panel4);
            Panel_Username.Controls.Add(TextBox_Username);
            Panel_Username.Location = new System.Drawing.Point(54, 205);
            Panel_Username.Margin = new System.Windows.Forms.Padding(5);
            Panel_Username.Name = "Panel_Username";
            Panel_Username.Size = new System.Drawing.Size(608, 95);
            Panel_Username.TabIndex = 22;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox2.IconColor = System.Drawing.Color.White;
            iconPictureBox2.IconSize = 55;
            iconPictureBox2.Location = new System.Drawing.Point(5, 20);
            iconPictureBox2.Margin = new System.Windows.Forms.Padding(5);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new System.Drawing.Size(62, 55);
            iconPictureBox2.TabIndex = 17;
            iconPictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Location = new System.Drawing.Point(19, 78);
            panel4.Margin = new System.Windows.Forms.Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(582, 1);
            panel4.TabIndex = 12;
            // 
            // TextBox_Username
            // 
            TextBox_Username.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBox_Username.ForeColor = System.Drawing.SystemColors.Window;
            TextBox_Username.Location = new System.Drawing.Point(75, 28);
            TextBox_Username.Margin = new System.Windows.Forms.Padding(5);
            TextBox_Username.MaxLength = 1001;
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.Size = new System.Drawing.Size(385, 34);
            TextBox_Username.TabIndex = 11;
            TextBox_Username.Text = "Username";
            TextBox_Username.MouseClick += TextBox_Username_MouseClick;
            TextBox_Username.MouseLeave += Panel_Username_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(790, 1030);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(790, 1031);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(790, 1018);
            Name = "Login";
            Opacity = 0.9D;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FIH Encryptor - Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Password_Visibility).EndInit();
            Panel_Password.ResumeLayout(false);
            Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            Panel_Username.ResumeLayout(false);
            Panel_Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Button_Exit;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Timer Timer_DateTime;
        private System.Windows.Forms.Button Button_goRegister;
        private System.Windows.Forms.Button Button_SignIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox Password_Visibility;
        private System.Windows.Forms.Panel Panel_Password;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Panel_Username;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBox_Username;
    }
}