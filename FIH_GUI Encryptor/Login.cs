using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
{
    public partial class Login : Form
    {
        private readonly string Program_Version = "1.0";

        public static string username = "";
        public static string password = "";

        public Login()
        {
            InitializeComponent();
        }

        // Move locked WinForm App
        protected override void WndProc(ref Message m)
        {
            /*
                Constants in Windows API
                0x84 = WM_NCHITTEST - Mouse Capture Test
                0x1 = HTCLIENT - Application Client Area
                0x2 = HTCAPTION - Application Title Bar

                This function intercepts all the commands sent to the application. 
                It checks to see of the message is a mouse click in the application. 
                It passes the action to the base action by default. It reassigns 
                the action to the title bar if it occured in the client area
                to allow the drag and move behavior.
            */
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_DateTime_Tick(object sender, EventArgs e)
        {
            Label_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void TextBox_Username_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBox_Username.Text == "Username")
                TextBox_Username.Text = "";
        }

        private void TextBox_Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBox_Password.Text == "Password")
                TextBox_Password.Text = "";
        }

        private void Button_SignIn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TextBox_Username.Text == "Fillinlak3" && TextBox_Password.Text == "admin")
                {
                    Timer_DateTime.Enabled = false;
                    username = TextBox_Username.Text;
                    password = TextBox_Password.Text;

                    Debug.WriteLine($"[Login] - Successfully logged as: {username}:{password}");
                    Debug.WriteLine($"[Timer_DateTime - state] -> {Timer_DateTime.Enabled}");
                    this.Hide();
                    new Main_Form().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password, try again!");
                    Debug.WriteLine($"[Login] -> Login denied, user tried: {username}:{password}");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Debug.WriteLine($"[Login] -> Login exception thrown: {exception.Message}");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using(System.Net.WebClient web = new System.Net.WebClient())
            {
                if (!web.DownloadString("https://pastebin.com/raw/4WLrwxQ4").Contains("1.0"))
                {
                    MessageBox.Show($"New FIH Encryptor version available!\nExpected version: {web.DownloadString("https://pastebin.com/raw/4WLrwxQ4")}\nYou have version: {Program_Version}", "FIH Encryptor - Fatal Error");
                    Application.Exit();
                }
            }
        }

        private void Panel_Username_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_Username.Text))
                TextBox_Username.Text = "Username";
        }

        private void Panel_Password_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_Password.Text))
                TextBox_Password.Text = "Password";
        }

        private void TextBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                Button_SignIn_MouseClick(null, null);
        }

        private void Button_goRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            this.Close();
        }

        private void Change_Password_Visibility(object sender, EventArgs e)
        {
            if(Password_Visibility.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                TextBox_Password.Text = String.Empty;
                TextBox_Password.PasswordChar = '\0';
                Debug.WriteLine("[Login] -> Password is shown.");
            } else
            {
                Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
                TextBox_Password.Text = "Password";
                TextBox_Password.PasswordChar = '*';
                Debug.WriteLine("[Login] -> Password is hidden.");
            }
        }
    }
}
