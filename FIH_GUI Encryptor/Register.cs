using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Windows.Services.Maps;

namespace FIH_GUI_Encryptor
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static bool IsValidUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9](?!.*[._-]{2})[a-zA-Z0-9._-]*[a-zA-Z0-9]$";
            return Regex.IsMatch(username, pattern);
        }
        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private static bool IsValidName(string lastName)
        {
            string pattern = @"^[a-zA-Z]+[- ]?[a-zA-Z]+$";
            return Regex.IsMatch(lastName, pattern);
        }

        public static string GeneratePrivateKey()
        {
            short length = 32;
            const string availablecharacters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890~!@#$%^*()-_=[]{}|;:,./?";
            Random rand = new Random();

            string privatekey = new string(availablecharacters
            .OrderBy(c => rand.Next(0, availablecharacters.Length - 1))
            .Distinct()
            .Take(length)
            .ToArray());

            return privatekey;
        }

        private async void Button_goRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Username restrictions.
                if (String.IsNullOrWhiteSpace(TextBox_Username.Text))
                    throw new Exception("Username cannot be an empty field!");
                if (TextBox_Username.Text.Contains(' '))
                    throw new Exception("Username cannot have whitespaces!");
                if (IsValidUsername(TextBox_Username.Text) == false)
                    throw new Exception("Username contains unallowed characters. See the help for more information.");

                // Password restrictions.
                if (String.IsNullOrWhiteSpace(TextBox_Password.Text))
                    throw new Exception("Password cannot be an empty field!");
                if (IsValidPassword(TextBox_Password.Text) == false)
                    throw new Exception("Password must have at least one uppercase letter, one lowercase letter, one digit, one special character, and a minimum length of 8 characters. See the help for more information.");

                // Email restrictions.
                if (String.IsNullOrWhiteSpace(TextBox_Email.Text))
                    throw new Exception("Email cannot be an empty field!");
                if (IsValidEmail(TextBox_Email.Text) == false)
                    throw new Exception("Email doesn't follow the specific rules. See the help for more information.");

                // First-Name restrictions.
                if (String.IsNullOrWhiteSpace(TextBox_FirstName.Text))
                    throw new Exception("First-Name cannot be an empty field!");
                if (IsValidName(TextBox_FirstName.Text) == false)
                    throw new Exception("First-Name can have one space or dash and only letters. See the help for more information.");

                // First-Name restrictions.
                if (String.IsNullOrWhiteSpace(TextBox_LastName.Text))
                    throw new Exception("Last-Name cannot be an empty field!");
                if (IsValidName(TextBox_LastName.Text) == false)
                    throw new Exception("Last-Name can have one space or dash and only letters. See the help for more information.");

                List<Authentificator.User> users = await Authentificator.FetchUsers();
                // Check if the username is unique.
                if(users.Any(user => user.Username == TextBox_Username.Text))
                    throw new Exception("Username is already registered!");

                // Generate an unique private key that is different for each user.
                string privatekey = string.Empty;
                do
                {
                    privatekey = GeneratePrivateKey();
                } while (users.Any(user => user.PrivateKey == privatekey));

                // Everything is fine, register the user.
                users.Add(new Authentificator.User()
                {
                    Index = users.Count > 0 ? users[users.Count - 1].Index + 1 : 1,
                    Username = TextBox_Username.Text,
                    Password = TextBox_Password.Text,
                    Email = TextBox_Email.Text,
                    PrivateKey = privatekey
                });
                await Authentificator.UpdateUsers(users, true);
                MessageBox.Show("Account successfully registered!", "Register - Successfull");

                this.Hide();
                new Login().ShowDialog();
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured whilst attempting to register: {ex.Message}", "Register - Fatal Failure");
            }
        }

        #region Keep textboxes filled and empty on click
        private void TextBox_FirstName_Click(object sender, EventArgs e)
        {
            if (TextBox_FirstName.Text == "First Name")
                TextBox_FirstName.Text = "";
        }
        private void TextBox_LastName_Click(object sender, EventArgs e)
        {
            if (TextBox_LastName.Text == "Last Name")
                TextBox_LastName.Text = "";
        }
        private void TextBox_Email_Click(object sender, EventArgs e)
        {
            if (TextBox_Email.Text == "Email")
                TextBox_Email.Text = "";
        }
        private void TextBox_Username_Click(object sender, EventArgs e)
        {
            if (TextBox_Username.Text == "Username")
                TextBox_Username.Text = "";
        }
        private void TextBox_Password_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "Password")
                TextBox_Password.Text = "";
        }

        private void Panel_FirstName_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_FirstName.Text))
                TextBox_FirstName.Text = "First Name";
        }
        private void Panel_LastName_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_LastName.Text))
                TextBox_LastName.Text = "Last Name";
        }
        private void Panel_Email_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_Email.Text))
                TextBox_Email.Text = "Email";
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
        #endregion

        // Display date & time
        private void Timer_DateTime_Tick(object sender, EventArgs e)
        {
            Label_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
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
        // Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Timer_DateTime.Enabled = false;
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
    }
}
