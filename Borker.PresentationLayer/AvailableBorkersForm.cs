using Borker.PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class AvailableBorkersForm : Form
    {
        private Form activeForm = null;
        private List<BorkerCardForm> cards = new List<BorkerCardForm>();
        private BorkerService _borkerService;
        private string _currentUser;

        public AvailableBorkersForm(BorkerService service, string username)
        {
            InitializeComponent();
            _currentUser = username;
            _borkerService = service;
            cards = _borkerService.GetAvailableBorkers(_currentUser);
            showBorkers();
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBorkers.Controls.Add(childForm);
            panelBorkers.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void addNewBorker(BorkerCardForm newBorker)
        {
            cards.Add(newBorker);
            flowLayoutPanel.Controls.Add(newBorker.getCard());
            this.show_btn();
        }

        public void showBorkers()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (BorkerCardForm borkerCard in cards)
            {
                if (!borkerCard.isBorkerValid())
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(_currentUser))
                {
                    borkerCard.isMyBorker(_currentUser);
                }

                flowLayoutPanel.Controls.Add(borkerCard.getCard());
            }
            flowLayoutPanel.Invalidate();
        }

        private void btnAddBorker_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddBorkerForm(this, _borkerService, _currentUser));
            btnAddBorker.Visible = false;
        }

        public void show_btn()
        {
            btnAddBorker.Visible = true;
        }
    }
}
