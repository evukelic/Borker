using Borker.PresentationLayer.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class SignInForm : Form
    {
        private Form activeForm = null;
        private MenuForm parent;
        private string username = "";
        private string password = "";
        private UserService _userService;

        public SignInForm(MenuForm parentForm, UserService service)
        {
            InitializeComponent();
            parent = parentForm;
            _userService = service;
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSignIn.Controls.Add(childForm);
            panelSignIn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                showError();
            }

            bool isUsernameValid = _userService.DoesUserExist(username);
            
            if (isUsernameValid)
            {
                bool isPasswordValid = _userService.IsPasswordValid(username, password);

                if (isPasswordValid)
                {
                    this.parent.setUsername(username);
                    this.Close();
                    this.parent.showMenu();
                } else
                {
                    showError();
                }

            } else
            {
                showError();
            }
        }

        public void setInfoMessage(string text)
        {
            labelInfo.Visible = true;
            labelInfo.Text = text;
            labelInfo.ForeColor = Color.DarkCyan;
            labelError.Visible = false;
            
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            openChildFormInPanel(new RegistrationForm(this, _userService));
        }

        private void showError()
        {
            labelError.Visible = true;
            labelInfo.Visible = false;
            return;
        }
    }
}
