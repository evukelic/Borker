using Borker.Controllers;
using Borker.PresentationLayer.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class MenuForm : Form
    {
        private Form activeForm = null;
        private string currentUsername;

        private UserService _userService;
        private BorkerService _borkerService;

        public MenuForm(MainFormController mainFormController)
        {
            InitializeComponent();

            _userService = new UserService(mainFormController);
            _borkerService = new BorkerService(mainFormController);
            hideMenu();
            this.Text = "Borker";
        }

        private void hideMenu()
        {
            btnAvailableBorkers.Visible = false;
            btnInfo.Visible = false;
            btnProfile.Visible = false;
            btnSignOut.Visible = false;
            btnSignIn.Visible = true;

            btnSignIn_Click(null, null);
        }

        public void showMenu()
        {
            btnSignIn.Visible = false;
            btnSignOut.Visible = true;
            btnInfo.Visible = true;
            btnProfile.Visible = true;
            btnAvailableBorkers.Visible = true;

            btnAvailableBorkers_Click(null, null);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.GetType() == typeof(SignInForm))
            {
                return;
            }

            UnselectMenuButtons();

            btnSignIn.BackColor = Color.FromArgb(37, 92, 90);
            openChildFormInPanel(new SignInForm(this, _userService));
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelData.Controls.Add(childForm);
            panelData.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void UnselectMenuButtons()
        {
            btnAvailableBorkers.BackColor = Color.FromArgb(26, 26, 26);
            btnProfile.BackColor = Color.FromArgb(26, 26, 26);
            btnInfo.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnAvailableBorkers_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.GetType() == typeof(AvailableBorkersForm))
            {
                return;
            }

            UnselectMenuButtons();

            btnAvailableBorkers.BackColor = Color.FromArgb(37, 92, 90);
            openChildFormInPanel(new AvailableBorkersForm(_borkerService, currentUsername));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.GetType() == typeof(ProfileForm))
            {
                return;
            }

            UnselectMenuButtons();

            btnProfile.BackColor = Color.FromArgb(37, 92, 90);
            openChildFormInPanel(new ProfileForm(currentUsername, _borkerService));
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.GetType() == typeof(InfoForm))
            {
                return;
            }

            UnselectMenuButtons();

            btnInfo.BackColor = Color.FromArgb(37, 92, 90);
            openChildFormInPanel(new InfoForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to sign out?",
                      "Sign Out", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    {
                        if (activeForm != null)
                            activeForm.Close();
                        hideMenu();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        public void setUsername (string username)
        {
            currentUsername = username;
            _userService.SetCurrentUser(username);
        }
    }
}
