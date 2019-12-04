using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form parentForm;
        public Form4(Form form)
        {
            InitializeComponent();

            this.parentForm = form;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Visible = true;
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsValid(string emailaddress, out string formatExceptionMessage)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                formatExceptionMessage = null;
                return true;
            }
            catch (FormatException e)
            {
                formatExceptionMessage = e.Message;
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ErrorMsg;
            ValidatePassword(passwordTextBox.Text, out ErrorMsg);

            string ConfErrMsg=null;

            if (!String.IsNullOrEmpty(ErrorMsg))
                MessageBox.Show(ErrorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (confirmpasswordTextBox.Text != passwordTextBox.Text)
                {
                    
                    ConfErrMsg = "Password and Confirm Password do not match";
                    MessageBox.Show("Password and Confirm Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string formatExceptionMessage;
            IsValid(emailTextBox.Text, out formatExceptionMessage);

            if (!String.IsNullOrEmpty(formatExceptionMessage))
                MessageBox.Show(formatExceptionMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (String.IsNullOrEmpty(ErrorMsg) && String.IsNullOrEmpty(formatExceptionMessage) && String.IsNullOrEmpty(ConfErrMsg))
            {
                this.Visible = false;
                this.parentForm.Visible = true;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
