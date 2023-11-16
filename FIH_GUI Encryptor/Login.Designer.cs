
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
            panel2 = new System.Windows.Forms.Panel();
            TextBox_Password = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            TextBox_Username = new System.Windows.Forms.TextBox();
            Panel_Username = new System.Windows.Forms.Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            Panel_Password = new System.Windows.Forms.Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            Password_Visibility = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            Panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Password_Visibility).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(Label_Time);
            panel1.Controls.Add(Button_Exit);
            panel1.Controls.Add(PictureBox_Logo);
            panel1.Location = new System.Drawing.Point(-3, 19);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(724, 94);
            panel1.TabIndex = 2;
            // 
            // Label_Time
            // 
            Label_Time.AutoSize = true;
            Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label_Time.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            Label_Time.Location = new System.Drawing.Point(465, 5);
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
            Button_Exit.Location = new System.Drawing.Point(664, 8);
            Button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Rotation = 0D;
            Button_Exit.Size = new System.Drawing.Size(43, 41);
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
            Button_goRegister.Location = new System.Drawing.Point(157, 919);
            Button_goRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_goRegister.Name = "Button_goRegister";
            Button_goRegister.Size = new System.Drawing.Size(408, 114);
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
            Button_SignIn.Location = new System.Drawing.Point(156, 761);
            Button_SignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Button_SignIn.Name = "Button_SignIn";
            Button_SignIn.Size = new System.Drawing.Size(409, 114);
            Button_SignIn.TabIndex = 15;
            Button_SignIn.Text = "Sign In";
            Button_SignIn.UseVisualStyleBackColor = false;
            Button_SignIn.MouseClick += Button_SignIn_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Location = new System.Drawing.Point(17, 80);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(533, 1);
            panel2.TabIndex = 14;
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
            TextBox_Password.MouseClick += TextBox_Password_MouseClick;
            TextBox_Password.KeyPress += TextBox_Password_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Location = new System.Drawing.Point(17, 82);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(533, 1);
            panel3.TabIndex = 12;
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
            TextBox_Username.MouseClick += TextBox_Username_MouseClick;
            // 
            // Panel_Username
            // 
            Panel_Username.Controls.Add(iconPictureBox2);
            Panel_Username.Controls.Add(panel3);
            Panel_Username.Controls.Add(TextBox_Username);
            Panel_Username.Location = new System.Drawing.Point(83, 380);
            Panel_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_Username.Name = "Panel_Username";
            Panel_Username.Size = new System.Drawing.Size(556, 101);
            Panel_Username.TabIndex = 19;
            Panel_Username.MouseLeave += Panel_Username_MouseLeave;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox2.IconColor = System.Drawing.Color.White;
            iconPictureBox2.IconSize = 57;
            iconPictureBox2.Location = new System.Drawing.Point(4, 22);
            iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new System.Drawing.Size(57, 58);
            iconPictureBox2.TabIndex = 17;
            iconPictureBox2.TabStop = false;
            // 
            // Panel_Password
            // 
            Panel_Password.Controls.Add(iconPictureBox3);
            Panel_Password.Controls.Add(TextBox_Password);
            Panel_Password.Controls.Add(panel2);
            Panel_Password.Location = new System.Drawing.Point(83, 491);
            Panel_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Panel_Password.Name = "Panel_Password";
            Panel_Password.Size = new System.Drawing.Size(556, 101);
            Panel_Password.TabIndex = 20;
            Panel_Password.MouseLeave += Panel_Password_MouseLeave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            iconPictureBox3.IconColor = System.Drawing.Color.White;
            iconPictureBox3.IconSize = 57;
            iconPictureBox3.Location = new System.Drawing.Point(4, 20);
            iconPictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new System.Drawing.Size(57, 58);
            iconPictureBox3.TabIndex = 18;
            iconPictureBox3.TabStop = false;
            // 
            // Password_Visibility
            // 
            Password_Visibility.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            Password_Visibility.IconColor = System.Drawing.Color.White;
            Password_Visibility.IconSize = 57;
            Password_Visibility.Location = new System.Drawing.Point(647, 511);
            Password_Visibility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Password_Visibility.Name = "Password_Visibility";
            Password_Visibility.Size = new System.Drawing.Size(57, 58);
            Password_Visibility.TabIndex = 21;
            Password_Visibility.TabStop = false;
            Password_Visibility.Click += Change_Password_Visibility;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(721, 1102);
            Controls.Add(Password_Visibility);
            Controls.Add(Panel_Password);
            Controls.Add(Panel_Username);
            Controls.Add(Button_goRegister);
            Controls.Add(Button_SignIn);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Opacity = 0.9D;
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FIH Encryptor - Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            Panel_Username.ResumeLayout(false);
            Panel_Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            Panel_Password.ResumeLayout(false);
            Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Password_Visibility).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel Panel_Username;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.TextBox TextBox_Username;
        private FontAwesome.Sharp.IconPictureBox Password_Visibility;
    }
}