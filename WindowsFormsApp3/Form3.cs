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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        Form parentForm;
        public Form3(Form form)
        {
            InitializeComponent();

            this.parentForm = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ErrorMsg;
            ValidatePassword(passwordTextBox.Text, out ErrorMsg);

            if(!String.IsNullOrEmpty(ErrorMsg))
                MessageBox.Show(ErrorMsg,"Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            string formatExceptionMessage;
            IsValid(emailTextBox.Text, out formatExceptionMessage);

            if (!String.IsNullOrEmpty(formatExceptionMessage))
                MessageBox.Show(formatExceptionMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (String.IsNullOrEmpty(ErrorMsg) && String.IsNullOrEmpty(formatExceptionMessage))
            {
                if( submitData() == DialogResult.Yes)
                {
                    this.Visible = false;
                    this.parentForm.Visible = true;
                }
            }
        }

        private DialogResult submitData()
        {
            string submissionMessage = "";

            submissionMessage += "Name: ";
            submissionMessage += firstnameTextBox.Text + " ";
            submissionMessage += lastnameTextBox.Text + "\n";
            submissionMessage += "Email: ";
            submissionMessage += emailTextBox.Text + "\n";
            submissionMessage += "Phone: ";
            submissionMessage += phoneTextBox.Text + "\n";
            submissionMessage += "Country Code: ";
            submissionMessage += countrycodeTextBox.Text + "\n";
            submissionMessage += "Zip Code: ";
            submissionMessage += zipcodeTextBox.Text + "\n";
     
            submissionMessage += "Education: ";
            if (education1.Checked)
                submissionMessage += education1.Text + " ";
            if (education2.Checked)
                submissionMessage += education2.Text + " ";
            if (education3.Checked)
                submissionMessage += education3.Text + " ";
            submissionMessage += "\n";

            var checkedButton = gender.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            submissionMessage += "Gender: ";
            submissionMessage += checkedButton.Text;

            submissionMessage += "\n" + "Do you want to continue? " + "\n";

            

            return MessageBox.Show(submissionMessage, "Registered", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void firstnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            characterValidation(e);
        }

        private void characterValidation(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void lastnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            characterValidation(e);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numValidation(e);
        }

        private void countrycodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numValidation(e);
        }

        private void zipcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numValidation(e);
        }

        private void numValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
