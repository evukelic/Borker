using Borker.PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borker.PresentationLayer
{
    public partial class AddBorkerForm : Form
    {
        private AvailableBorkersForm parent;
        private ProfileForm profile;
        private BorkerService _borkerService;
        private string _username;

        private string _location;
        private DateTime _date;
        private string _borkerName;
        private string _breed;
        private float _duration;
        private string _salary;

        private int _edit_borker_id;

        public AddBorkerForm(AvailableBorkersForm form, BorkerService service, string currentUser)
        {
            parent = form;
            _borkerService = service;
            _username = currentUser;

            InitializeComponent();
            setPickerFormats();
        }

        private void setPickerFormats()
        {
            datePicker.Value = DateTime.Now;
            datePicker.MinDate = DateTime.Now;

            timePicker.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBorker_Click(object sender, EventArgs e)
        {
            if (btnAddBorker.Text.Equals("Edit Borker"))
            { 
                DialogResult dialog = MessageBox.Show("Are you sure you want to update borker?",
                      "Edit", MessageBoxButtons.YesNo);
                switch (dialog)
                {
                    case DialogResult.Yes:
                        {
                            string timeAsStr = timePicker.Value.ToString("hh:mm:ss");
                            DateTime dateWithoutTime = DateTime.Parse(datePicker.Value.ToString("MM/dd/yyyy"));
                            DateTime date = dateWithoutTime.Add(TimeSpan.Parse(timeAsStr));

                            _borkerService.UpdateBorker(_edit_borker_id, textBoxName.Text, textBoxBreed.Text, textBoxLocation.Text, textBoxSalary.Text, (float)numericUpDownDuration.Value, date);
                            this.Close();
                            profile.ShowMyBorkers();
                        }
                        break;
                    case DialogResult.No:
                        break;
                }

            } else
            {
                _borkerName = textBoxName.Text;
                _breed = textBoxBreed.Text;
                _location = textBoxLocation.Text;

                string timeAsStr = timePicker.Value.ToString("hh:mm:ss");
                DateTime dateWithoutTime = DateTime.Parse(datePicker.Value.ToString("MM/dd/yyyy"));
                _date = dateWithoutTime.Add(TimeSpan.Parse(timeAsStr));

                _duration = (int)numericUpDownDuration.Value;
                _salary = textBoxSalary.Text;

                if (string.IsNullOrEmpty(_borkerName) || string.IsNullOrEmpty(_breed) || string.IsNullOrEmpty(_location) || string.IsNullOrEmpty(_salary))
                {
                    labelErr.Text = "All fields are mandatory!";
                    labelErr.Visible = true;

                    return;
                }
                else
                {
                    labelErr.Visible = false;
                    BorkerCardForm newCard = _borkerService.AddBorker(_borkerName, _breed, _location, _salary, _duration, _date, _username);

                    parent.addNewBorker(newCard);
                    parent.showBorkers();
                    this.Close();
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!btnAddBorker.Text.Equals("Edit Borker"))
            {
                parent.show_btn();
            } else
            {
                profile.ShowMyBorkers();
            }
                
        }

        public void setInputs(BorkerCardForm borker)
        {
            textBoxName.Text = borker.getBorkerName();
            textBoxBreed.Text = borker.getBreed();
            textBoxLocation.Text = borker.getLocation();
            textBoxSalary.Text = borker.getSalary();
            numericUpDownDuration.Value = (decimal)borker.getDuration();
            string[] dateTime = borker.getDate().Split(' ');
            string date = dateTime[0];
            string time = dateTime[1] + ' ' + dateTime[2];
            datePicker.Value = DateTime.ParseExact(date, "dd.MM.yyyy", null);
            timePicker.Value = DateTime.ParseExact(time, "hh:mm tt", null);
            _edit_borker_id = borker.getid();
        }

        public void setEditButton(ProfileForm profileForm)
        {
            profile = profileForm;
            btnAddBorker.Text = "Edit Borker";
            buttonDelete.Visible = true;
            labelAddBorker.Text = "Edit Borker";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete borker?",
                      "Delete", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    {
                        _borkerService.DeleteBorker(_edit_borker_id);
                        this.Close();
                        profile.ShowMyBorkers();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
