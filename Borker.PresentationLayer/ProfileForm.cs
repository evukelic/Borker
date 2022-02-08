using Borker.PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class ProfileForm : Form
    {
        string currentUser;
        private List<BorkerCardForm> _myBorkers = new List<BorkerCardForm>();
        private List<BorkerCardForm> _appliedBorkers = new List<BorkerCardForm>();
        private BorkerService _borkerService;

        public ProfileForm(string username, BorkerService service)
        {
            InitializeComponent();
            currentUser = username;
            labelUsername.Text = currentUser;

            _borkerService = service;

            ShowMyBorkers();
        }

        private void buttonMyBorkers_Click(object sender, EventArgs e)
        {
            ShowMyBorkers();
        }

        public void ShowMyBorkers()
        {
            _myBorkers = _borkerService.GetMyBorkers(currentUser);

            buttonMyBorkers.BackColor = Color.FromArgb(51, 130, 127);
            btnApplied.BackColor = Color.FromArgb(37, 92, 90);
            flowLayoutPanel.Controls.Clear();

            foreach (BorkerCardForm borkerCard in _myBorkers)
            {
                borkerCard.setEditButton();
                borkerCard.setParent(this);
                flowLayoutPanel.Controls.Add(borkerCard.getCard());
            }
            flowLayoutPanel.Invalidate();
        }

        private void btnApplied_Click(object sender, EventArgs e)
        {
            ShowAppliedBorkers();
        }

        private void ShowAppliedBorkers()
        {
            _appliedBorkers = _borkerService.GetAppliedBorkers(currentUser);

            btnApplied.BackColor = Color.FromArgb(51, 130, 127);
            buttonMyBorkers.BackColor = Color.FromArgb(37, 92, 90);
            flowLayoutPanel.Controls.Clear();

            foreach (BorkerCardForm borkerCard in _appliedBorkers)
            {
                borkerCard.removeBtn();
                flowLayoutPanel.Controls.Add(borkerCard.getCard());
            }
            flowLayoutPanel.Invalidate();
        }

        public void openEditForm(BorkerCardForm borker)
        {
            AddBorkerForm childForm = new AddBorkerForm(null, _borkerService, currentUser);

            

            flowLayoutPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel.Controls.Add(childForm);
            flowLayoutPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.setInputs(borker);
            childForm.setEditButton(this);
            childForm.Show();
        }
    }
}
