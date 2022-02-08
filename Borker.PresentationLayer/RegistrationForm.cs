using Borker.PresentationLayer.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        private SignInForm parent;
        private UserService _userService;

        public RegistrationForm(SignInForm form, UserService service)
        {
            InitializeComponent();
            parent = form;
            _userService = service;
        }

        private bool isInputValid()
        {
            //todo check je li username vec u bazi
            Regex emailValidation = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (String.IsNullOrWhiteSpace(textBoxEmail.Text) || String.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                String.IsNullOrWhiteSpace(textBoxPassword.Text) || String.IsNullOrWhiteSpace(textBoxRepeatPassword.Text))
            {
                labelErr.Text = "All fields are mandatory!";
                labelErr.Visible = true;
            }
            else if (!emailValidation.IsMatch(textBoxEmail.Text))
            {
                labelErr.Text = "Invalid E-mail format!";
                labelErr.Visible = true;
            }
            else if (!textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
            {
                labelErr.Text = "Passwords do not match!";
                labelErr.Visible = true;
            }
            else
            {
                labelErr.Visible = false;

                return true;
            }

            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool isValid = isInputValid();

            if (isValid)
            {
                bool doesUsernameAlreadyExist = _userService.DoesUserExist(textBoxUsername.Text);
                if (doesUsernameAlreadyExist)
                {
                    labelErr.Text = "Username already exists!";
                    labelErr.Visible = true;
                    return;
                }
                _userService.RegisterNewUser(textBoxEmail.Text, textBoxUsername.Text, textBoxPassword.Text);

                parent.setInfoMessage("Registration was successful. Sign in to continue.");
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
