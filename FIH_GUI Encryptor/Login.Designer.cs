
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Button_Exit = new FontAwesome.Sharp.IconButton();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.Button_goRegister = new System.Windows.Forms.Button();
            this.Button_SignIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.Panel_Username = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.Password_Visibility = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.Panel_Username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Visibility)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Label_Time);
            this.panel1.Controls.Add(this.Button_Exit);
            this.panel1.Controls.Add(this.PictureBox_Logo);
            this.panel1.Location = new System.Drawing.Point(-3, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 75);
            this.panel1.TabIndex = 2;
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Label_Time.Location = new System.Drawing.Point(465, 4);
            this.Label_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(140, 31);
            this.Label_Time.TabIndex = 3;
            this.Label_Time.Text = "Time Here";
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Button_Exit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Button_Exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Button_Exit.IconSize = 32;
            this.Button_Exit.Location = new System.Drawing.Point(664, 6);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Rotation = 0D;
            this.Button_Exit.Size = new System.Drawing.Size(43, 33);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PictureBox_Logo.Image = global::FIH_GUI_Encryptor.Properties.Resources.Logo_FIH;
            this.PictureBox_Logo.Location = new System.Drawing.Point(15, 0);
            this.PictureBox_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(164, 75);
            this.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Logo.TabIndex = 1;
            this.PictureBox_Logo.TabStop = false;
            // 
            // Timer_DateTime
            // 
            this.Timer_DateTime.Enabled = true;
            this.Timer_DateTime.Tick += new System.EventHandler(this.Timer_DateTime_Tick);
            // 
            // Button_goRegister
            // 
            this.Button_goRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Button_goRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_goRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_goRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_goRegister.Location = new System.Drawing.Point(157, 735);
            this.Button_goRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_goRegister.Name = "Button_goRegister";
            this.Button_goRegister.Size = new System.Drawing.Size(408, 91);
            this.Button_goRegister.TabIndex = 16;
            this.Button_goRegister.Text = "Register";
            this.Button_goRegister.UseVisualStyleBackColor = false;
            this.Button_goRegister.Click += new System.EventHandler(this.Button_goRegister_Click);
            // 
            // Button_SignIn
            // 
            this.Button_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignIn.Location = new System.Drawing.Point(156, 609);
            this.Button_SignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_SignIn.Name = "Button_SignIn";
            this.Button_SignIn.Size = new System.Drawing.Size(409, 91);
            this.Button_SignIn.TabIndex = 15;
            this.Button_SignIn.Text = "Sign In";
            this.Button_SignIn.UseVisualStyleBackColor = false;
            this.Button_SignIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_SignIn_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(17, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 1);
            this.panel2.TabIndex = 14;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox_Password.Location = new System.Drawing.Point(71, 21);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(352, 34);
            this.TextBox_Password.TabIndex = 13;
            this.TextBox_Password.Text = "Password";
            this.TextBox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_Password_MouseClick);
            this.TextBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Password_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(17, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 1);
            this.panel3.TabIndex = 12;
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox_Username.Location = new System.Drawing.Point(69, 23);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_Username.MaxLength = 1001;
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(352, 34);
            this.TextBox_Username.TabIndex = 11;
            this.TextBox_Username.Text = "Username";
            this.TextBox_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_Username_MouseClick);
            // 
            // Panel_Username
            // 
            this.Panel_Username.Controls.Add(this.iconPictureBox2);
            this.Panel_Username.Controls.Add(this.panel3);
            this.Panel_Username.Controls.Add(this.TextBox_Username);
            this.Panel_Username.Location = new System.Drawing.Point(83, 304);
            this.Panel_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Username.Name = "Panel_Username";
            this.Panel_Username.Size = new System.Drawing.Size(556, 81);
            this.Panel_Username.TabIndex = 19;
            this.Panel_Username.MouseLeave += new System.EventHandler(this.Panel_Username_MouseLeave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 46;
            this.iconPictureBox2.Location = new System.Drawing.Point(4, 18);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 46);
            this.iconPictureBox2.TabIndex = 17;
            this.iconPictureBox2.TabStop = false;
            // 
            // Panel_Password
            // 
            this.Panel_Password.Controls.Add(this.iconPictureBox3);
            this.Panel_Password.Controls.Add(this.TextBox_Password);
            this.Panel_Password.Controls.Add(this.panel2);
            this.Panel_Password.Location = new System.Drawing.Point(83, 393);
            this.Panel_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(556, 81);
            this.Panel_Password.TabIndex = 20;
            this.Panel_Password.MouseLeave += new System.EventHandler(this.Panel_Password_MouseLeave);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconSize = 46;
            this.iconPictureBox3.Location = new System.Drawing.Point(4, 16);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(57, 46);
            this.iconPictureBox3.TabIndex = 18;
            this.iconPictureBox3.TabStop = false;
            // 
            // Password_Visibility
            // 
            this.Password_Visibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Password_Visibility.IconColor = System.Drawing.Color.White;
            this.Password_Visibility.IconSize = 46;
            this.Password_Visibility.Location = new System.Drawing.Point(647, 409);
            this.Password_Visibility.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Visibility.Name = "Password_Visibility";
            this.Password_Visibility.Size = new System.Drawing.Size(57, 46);
            this.Password_Visibility.TabIndex = 21;
            this.Password_Visibility.TabStop = false;
            this.Password_Visibility.Click += new System.EventHandler(this.Change_Password_Visibility);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(721, 1009);
            this.Controls.Add(this.Password_Visibility);
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.Panel_Username);
            this.Controls.Add(this.Button_goRegister);
            this.Controls.Add(this.Button_SignIn);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIH Encryptor - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.Panel_Username.ResumeLayout(false);
            this.Panel_Username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Visibility)).EndInit();
            this.ResumeLayout(false);

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