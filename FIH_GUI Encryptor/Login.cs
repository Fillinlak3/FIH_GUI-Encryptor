using FIH_GUI_Encryptor.AuthClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
{
    public partial class Login : Form
    {
        private readonly string Program_Version = "1.0";

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

        private void Login_Load(object sender, EventArgs e)
        {
            using (System.Net.WebClient web = new System.Net.WebClient())
            {
                while (true)
                {
                    try
                    {
                        if (!web.DownloadString("https://pastebin.com/raw/4WLrwxQ4").Contains("1.0"))
                        {
                            MessageBox.Show($"New FIH Encryptor version available!\nExpected version: {web.DownloadString("https://pastebin.com/raw/4WLrwxQ4")}\nYou have version: {Program_Version}", "FIH Encryptor - Fatal Error");
                            Application.Exit();
                        }
                        ConsoleLog.WriteLine("<Authentificator>", "Program version is OK");
                        return;
                    }
                    catch (Exception ex)
                    {
                        var result = MessageBox.Show("Couldn't retrieve server information. No internet.", "Login - Fatal Error", MessageBoxButtons.RetryCancel);
                        ConsoleLog.WriteLine("<Authentificator>", $"Error obtaining version: {ex.Message}");
                        if (result == DialogResult.Cancel)
                        {
                            // Exit the app.
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private async void Button_SignIn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TextBox_Username.Text) || TextBox_Username.Text.ToLower() == "username" ||
                    String.IsNullOrWhiteSpace(TextBox_Password.Text) || TextBox_Password.Text.ToLower() == "password")
                {
                    MessageBox.Show("Wrong username or password, try again!", "Login - Wrong credentials", MessageBoxButtons.OK);
                    return;
                }
                
                List<User> users = await Program.AuthentificatorInstance.FetchUsers();

                if (users.Count == 0) throw new Exception("The database is empty");

                foreach (var user in users)
                {
                    if (TextBox_Username.Text == user.Username && TextBox_Password.Text == user.Password)
                    {
                        Timer_DateTime.Enabled = false;
                        User thisUser = new(
                            user.Index,
                            user.Username,
                            user.Password,
                            user.Email,
                            user.PrivateKey
                        );

                        this.Hide();
                        new Main_Form(thisUser).ShowDialog();
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Wrong username or password, try again!", "Login - Wrong credentials", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Debug.WriteLine($"Something went wrong: {exception.Message}", "Login - Fatal Failure");
            }
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
            if (Password_Visibility.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                TextBox_Password.Text = String.Empty;
                TextBox_Password.PasswordChar = '\0';
                Debug.WriteLine("[Login] -> Password is shown.");
            }
            else
            {
                Password_Visibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
                TextBox_Password.Text = "Password";
                TextBox_Password.PasswordChar = '*';
                Debug.WriteLine("[Login] -> Password is hidden.");
            }
        }
    }
}
