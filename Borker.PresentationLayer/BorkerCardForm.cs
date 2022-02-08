using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borker.PresentationLayer.Services;

namespace Borker.PresentationLayer
{
    public partial class BorkerCardForm : Form
    {
        private int _id;
        private string _username;
        private string _location;
        private string _date;
        private string _borkerName;
        private string _breed;
        private float _duration;
        private string _salary;
        private string _currentUser;

        private BorkerService _borkerService;
        private ProfileForm _parentForm;


        public BorkerCardForm(BorkerService service, string user, int id, string username, string location, string date, string borkerName, string breed, float duration, string salary)
        {
            InitializeComponent();

            _id = id;
            _username = username;
            _location = location;
            _date = date;
            _borkerName = borkerName;
            _breed = breed;
            _duration = duration;
            _salary = salary;

            _borkerService = service;
            _currentUser = user;

            initLabels();
        }

        public void initLabels()
        {
            labelUser.Text = _username;
            labelLocation.Text = _location;
            labelDate.Text = _date;
            labelSalary.Text = _salary.ToString();
            labelDuration.Text = _duration.ToString();
            labelBreed.Text = _breed;
            labelName.Text = _borkerName;
        }

        public Panel getCard()
        {
            return panelCard;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (btnApply.Text.Equals("Edit"))
            {
                _parentForm.openEditForm(this);
            } else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to apply?",
                      "Apply", MessageBoxButtons.YesNo);
                switch (dialog)
                {
                    case DialogResult.Yes:
                        {
                            _borkerService.AddApplierToBorker(_currentUser, _id);
                            panelCard.Visible = false;
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }    
            
        }

        public void isMyBorker(string loggedUser)
        {
            if (loggedUser.Equals(_username))
            {
                btnApply.Visible = false;
            }
        }

        public void removeBtn()
        {
            btnApply.Visible = false;
        }

        public bool isBorkerValid()
        {
            return DateTime.ParseExact(_date, "dd.MM.yyyy hh:mm tt", null) > DateTime.Now;
        }

        public void setEditButton()
        {
            if (!_borkerService.HasBorkerApplier(_id) && isBorkerValid())
            {
                btnApply.Visible = true;
                btnApply.Text = "Edit";
            } else
            {
                btnApply.Visible = false;
            }
        }

        public void setParent(ProfileForm parentForm)
        {
            _parentForm = parentForm;
        }

        public string getUsername()
        {
            return _username;
        }

        public string getBorkerName()
        {
            return _borkerName;
        }

        public string getBreed()
        {
            return _breed;
        }

        public string getDate()
        {
            return _date;
        }

        public string getLocation()
        {
            return _location;
        }

        public string getSalary()
        {
            return _salary;
        }

        public float getDuration()
        {
            return _duration;
        }

        public int getid()
        {
            return _id;
        }

    }
}
