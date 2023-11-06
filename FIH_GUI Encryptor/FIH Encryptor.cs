using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FIH_GUI_Encryptor
{
    public partial class Main_Form : Form
    {
        #region Class's Variables
        private bool Debug_Mode = false;
        protected static string Generated_Key = "";
        private readonly System.Collections.Generic.List<String> file_names = new System.Collections.Generic.List<String>();
        private readonly System.Collections.Generic.List<String> quotes = new System.Collections.Generic.List<String>(5) { "You can select multitple files to encrypt / decrypt.",
            "FIH Encryptor was created on 12/16/2020.", "The developer of the program is only 17 years old.",
            "FIH Encryptor is the most secure encrypting program.", "You can press About button for more informations."};
        #endregion

        #region Main Form Class
        // ================================ Main Form ====================================
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            Setup();
            Label_Username.Text = Login.username;
            Label_GreetinsUser.Text = "Welcome back,\n " + Label_Username.Text;
            UserSettings_Default();
            Pick_Quote();
            Panel_Greetings.Visible = true;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        // Setup
        private void Setup()
        {
            Panel_Encrypt_SubMenu.Visible = false;
            Panel_Decrypt_SubMenu.Visible = false;

            Panel_Encrypt_Files.Visible = false;
            Panel_Encrypt_Text.Visible = false;

            Panel_Decrypt_Files.Visible = false;
            Panel_Decrypt_Text.Visible = false;

            Panel_Description.Visible = false;
            Panel_Greetings.Visible = false;

            Panel_Usercontrol.Visible = false;
        }

        private void Pick_Quote()
        {
            Random random = new Random();
            Label_Random_Quote.Text = quotes[random.Next(5)];
        }

        // Debug Mode
        #region Debug_Mode
        private void Main_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                PictureBox_Logo_Click(null, null);
            else if (e.Control && e.Shift && e.KeyCode == Keys.E)
                Button_Encrypt_Files_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.E)
                Button_Encrypt_Text_Click(null, null);
            else if (e.Control && e.Shift && e.KeyCode == Keys.D)
                Button_Decrypt_Files_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.D)
                Button_Decrypt_Text_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.L)
                Button_SignOut_Click(null, null);



            else if ((e.Control && e.Shift && e.Alt && e.KeyCode == Keys.F5) && Label_Username.Text == "Fillinlak3")
                switch (Debug_Mode)
                {
                    case false:
                    {
                        MessageBox.Show("Debug Mode - ON");
                        Debug_Mode = true;
                        break;
                    }

                    case true:
                    {
                        MessageBox.Show("Debug Mode - OFF");
                        Debug_Mode = false;
                        break;
                    }

                    default:
                        Debug_Mode = false;
                        break;
                }
        }
        #endregion

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
        // ===============================================================================
        #endregion

        #region Left-Side Buttons
        // ============================ Left-Side Buttons ================================
        private void PictureBox_Logo_Click(object sender, EventArgs e)
        {
            Setup();
            Pick_Quote();
            Panel_Greetings.Visible = true;
        }
        private void Button_Encrypt_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_Decrypt_SubMenu.Visible = false;
            if (!Panel_Encrypt_SubMenu.Visible)
                Panel_Encrypt_SubMenu.Visible = true;
            else
                Panel_Encrypt_SubMenu.Visible = false;
        }
        private void Button_Decrypt_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_Encrypt_SubMenu.Visible = false;
            if (!Panel_Decrypt_SubMenu.Visible)
                Panel_Decrypt_SubMenu.Visible = true;
            else
                Panel_Decrypt_SubMenu.Visible = false;
        }
        private void Button_About_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Description.Visible = true;
        }
        private void Button_SignOut_Click(object sender, EventArgs e)
        {
            Generated_Key = "";
            Debug_Mode = false;

            this.Hide();
            new Login().ShowDialog();
            this.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        // ===============================================================================
        #endregion

        #region Left-Side SubButtons
        // ========================== Left-Side SubButtons ===============================
        // Encryptor
        private void Button_Encrypt_Files_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Encrypt_Files.Visible = true;
        }
        private void Button_Encrypt_Text_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Encrypt_Text.Visible = true;
        }

        // Decryptor
        private void Button_Decrypt_Files_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Decrypt_Files.Visible = true;
        }
        private void Button_Decrypt_Text_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Decrypt_Text.Visible = true;
        }
        // ===============================================================================
        #endregion

        #region Encrypt & Decrypt Text
        // ========================= Encrypt & Decrypt Text ==============================
        // Encryptor
        private void Button_TextBox_Encrypt_Text_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox_Encrypt_Text.Text))
                try
                {
                    using (FillInHack fih = new FillInHack())
                    {
                        TextBox_Encrypt_Text.Text = fih.MD5_Encrypt(TextBox_Encrypt_Text.Text, TextBox_Encrypt_Text_Key.Text);
                    }

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "FIH Encryptor - Fatal error");
                }
            else MessageBox.Show("Empty Text", "FIH Encryptor - Fatal error");
        }
        private void Panel_Encrypt_Text_VisibleChanged(object sender, EventArgs e)
        {
            TextBox_Encrypt_Text.Text = "";
            TextBox_Encrypt_Text_Key.Text = "";
        }

        // Decryptor
        private void Button_TextBox_Decrypt_Text_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox_Decrypt_Text.Text))
                try
                {
                    using (FillInHack fih = new FillInHack())
                    {
                        TextBox_Decrypt_Text.Text = fih.MD5_Decrypt(TextBox_Decrypt_Text.Text, TextBox_Decrypt_Text_Key.Text);
                    }

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "FIH Encryptor - Fatal error");
                }
            else MessageBox.Show("Empty Text", "FIH Encryptor - Fatal error");
        }
        private void Panel_Decrypt_Text_VisibleChanged(object sender, EventArgs e)
        {
            TextBox_Decrypt_Text.Text = "";
            TextBox_Decrypt_Text_Key.Text = "";
        }
        // ===============================================================================
        #endregion

        #region Encrypt & Decrypt Files
        // ======================== Encrypt & Decrypt Files ==============================
        // Encryptor
        private void Button_Encrypt_BrowseFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "[FIH ENCRYPTOR -> Encrypt] Select Files";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Encrypted_Files_Selected.Text = "";
                foreach (String files in openFileDialog1.FileNames)
                {
                    if (files.EndsWith(".gxPfZY2TX"))
                    {
                        MessageBox.Show("Can't open file: " + files.Substring(files.LastIndexOf(@"\") + 1) + "\nis already encrypted.");
                        continue;
                    }
                    Encrypted_Files_Selected.Text += files + Environment.NewLine;
                    file_names.Add(files);
                }
            }
            if (file_names.Count == 0)
                Encrypted_Files_Selected.Text = "No files chosen..";

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void Button_Encrypt_ClearList_Click(object sender, EventArgs e)
        {
            file_names.Clear();
            Generated_Key = "";
            Encrypted_Files_Selected.Text = "No files chosen..";
        }
        private void Button_Encrypt_EncryptFiles_Click(object sender, EventArgs e)
        {
            if (file_names.Count != 0)
            {
                using (FillInHack fih = new FillInHack()) Generated_Key = fih.Generate_Key();
                foreach (string file in file_names)
                {
                    string text_data = "";
                    try
                    {
                        text_data = File.ReadAllText(file, System.Text.Encoding.Default);
                        using (FillInHack fih = new FillInHack())
                        {
                            File.WriteAllText(file, $"FillInHack!{fih.Encrypt(text_data, Generated_Key)}", System.Text.Encoding.Default);
                        }
                        File.Move(file, file + ".gxPfZY2TX");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "FIH Encryptor - Fatal error");
                        return;
                    }
                }
                MessageBox.Show("Successfully Encrypted Files!\nKey is copied in your clipboard.");
                Clipboard.SetText(Generated_Key);
                Generated_Key = "";
            }
            else MessageBox.Show("No Files selected..");
        }
        private void Panel_Encrypt_Files_VisibleChanged(object sender, EventArgs e)
        {
            file_names.Clear();
            Encrypted_Files_Selected.Text = "No files chosen..";
        }

        // Decryptor
        private void Button_Decrypt_BrowseFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "[FIH ENCRYPTOR -> Decrypt] Select Files";
            openFileDialog1.Filter = "FIH Files (*.gxPfZY2TX)|*.gxPfZY2TX";
            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Decrypted_Files_Selected.Text = "";
                foreach (String files in openFileDialog1.FileNames)
                {
                    Decrypted_Files_Selected.Text += files + Environment.NewLine;
                    file_names.Add(files);
                }
            }
            if (file_names.Count == 0)
                Encrypted_Files_Selected.Text = "No files chosen..";

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void Panel_Decrypt_Files_VisibleChanged(object sender, EventArgs e)
        {
            file_names.Clear();
            Decrypted_Files_Selected.Text = "No files chosen..";
        }
        private void Button_Decrypt_ClearList_Click(object sender, EventArgs e)
        {
            file_names.Clear();
            Generated_Key = "";
            Decrypted_Files_Selected.Text = "No files chosen..";
        }
        private void Button_Decrypt_DecryptFiles_Click(object sender, EventArgs e)
        {
            if (file_names.Count != 0)
            {
                Generated_Key = Microsoft.VisualBasic.Interaction.InputBox("Enter the secret key", "FIH Encryptor", "", -1, -1);
                if(Generated_Key.Length != 32)
                {
                    MessageBox.Show("Length of secret key should be 32.", "Action Denied");
                    Generated_Key = string.Empty;
                    return;
                }
                
                foreach (string files in file_names)
                {
                    string text_data = "";
                    try
                    {
                        text_data = File.ReadAllText(files, System.Text.Encoding.Default);
                        if (text_data.Contains("FillInHack!") && text_data.StartsWith("FillInHack!") && files.EndsWith(".gxPfZY2TX"))
                        {
                            text_data = text_data.Remove(0, 11);
                            using (FillInHack fih = new FillInHack())
                            {
                                File.WriteAllText(files, fih.Decrypt(text_data, Generated_Key), System.Text.Encoding.Default);
                                Debug.WriteLine($"Text: {text_data}");
                            }
                            File.Move(files, files.Remove(files.Length - 10, 10));
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(("Invalid Key (" + exception.Message + ")"), "FIH Encryptor - Fatal error");
                        return;
                    }
                }
                MessageBox.Show("Successfully Decrypted Files!");
                Generated_Key = "";

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            else MessageBox.Show("No Files selected..");
        }

        // ===============================================================================
        #endregion

        #region About Panel Social Media & Contact
        private void Panel_About_IG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/iambucuriee/");
        }

        private void Panel_About_FB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/iambucuriee");
        }

        private void Panel_About_GM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/?view=cm&fs=1&to=mihai.bucur37@gmail.com&su=CHANGE_HERE_SUBJECT_TOPIC");
        }

        private void Panel_About_YH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://compose.mail.yahoo.com/?to=mihai.bucur37@gmail.com&subject=CHANGE_HERE_SUBJECT_TOPIC");
        }

        private void Panel_About_DS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/channels/@me/266183924512718849");
            MessageBox.Show("Discord: Bucuriee#0944");
        }
        #endregion

        #region User Control - Change Username | Password
        private void Picture_Username_Click(object sender, EventArgs e)
        {
            Setup();
            Panel_Usercontrol.Visible = true;
            UserSettings_Default();
        }

        private void TextBox_NewUsername_Click(object sender, EventArgs e)
        {
            if (TextBox_NewUsername.Text == "Username")
                TextBox_NewUsername.Text = "";
        }

        private void Panel_NewUsername_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_NewUsername.Text))
                TextBox_NewUsername.Text = "Username";
        }

        private void TextBox_OldPassword_Click(object sender, EventArgs e)
        {
            if (TextBox_OldPassword.Text == "Password")
                TextBox_OldPassword.Text = "";
        }

        private void Panel_OldPassword_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_OldPassword.Text))
                TextBox_OldPassword.Text = "Password";
        }

        private void TextBox_NewPassword_Click(object sender, EventArgs e)
        {
            if (TextBox_NewPassword.Text == "Password")
                TextBox_NewPassword.Text = "";
        }

        private void Panel_NewPassword_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_NewPassword.Text))
                TextBox_NewPassword.Text = "Password";
        }

        private void UserSettings_Default()
        {
            TextBox_OldUsername.Text = Login.username;
            TextBox_NewUsername.Text = "Username";
            TextBox_OldPassword.Text = "Password";
            TextBox_NewPassword.Text = "Password";
            CheckBox_Password.CheckState = CheckBox_Username.CheckState = CheckState.Unchecked;
        }

        private void Button_UpdateSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBox_Username.CheckState == CheckState.Unchecked &&
                CheckBox_Password.CheckState == CheckState.Unchecked)
                    throw new Exception("No changes were made.");

                if(CheckBox_Username.CheckState == CheckState.Checked)
                {
                    if (TextBox_OldUsername.Text != Login.username ||
                        TextBox_NewUsername.Text == Login.username ||
                        TextBox_NewUsername.Text == "Username" ||
                        String.IsNullOrEmpty(TextBox_NewUsername.Text))
                        throw new Exception("Invalid username.");

                    // Good username ~ change
                    
                    // Implement username change in accounts local DB.

                    Login.username = TextBox_NewUsername.Text;
                    Label_Username.Text = Login.username;
                    Label_GreetinsUser.Text = "Welcome back,\n " + Label_Username.Text;
                    MessageBox.Show("Succesfully updated username.");
                }
                if(CheckBox_Password.CheckState == CheckState.Checked)
                {
                    if (TextBox_OldPassword.Text != Login.password ||
                        TextBox_NewPassword.Text == Login.password ||
                        TextBox_NewPassword.Text == "Password" ||
                        String.IsNullOrEmpty(TextBox_NewPassword.Text))
                        throw new Exception("Invalid password.");

                    // Good password ~ change

                    // Implement password change in accounts local DB.

                    MessageBox.Show("Succesfully updated password.");
                }
            }
            catch(Exception exception)
            {
                UserSettings_Default();
                MessageBox.Show(exception.Message);
            }
        }
        #endregion
    }
}
