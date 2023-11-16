using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_goRegister_Click(object sender, EventArgs e)
        {
            
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
