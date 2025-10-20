using MEDSOFT.Models;
using MEDSOFT.Services;
using System;
using System.Windows.Forms;

namespace MEDSOFT
{
    public partial class AddEditPatientForm : Form
    {

        private readonly PatientService _patientService;
        private Patient _currentPatient;
        public AddEditPatientForm(Patient patient, PatientService patientService)
        {
            InitializeComponent();

            _currentPatient = patient;
            _patientService = patientService;

            LoadGenders();

            InitializeUI();
        }

        private void LoadGenders()
        {
            var genders = _patientService.GetGenders();

            cmbGender.DataSource = genders;
            cmbGender.DisplayMember = "GenderName";
            cmbGender.ValueMember = "GenderID";
        }

        private void InitializeUI()
        {
            if (_currentPatient.ID > 0)
            {
                this.Text = "პაციენტის რედაქტირება";
                btnSave.Text = "შენახვა";

                txtFullName.Text = _currentPatient.FullName;
                dtpDob.Value = _currentPatient.Dob;
                txtPhone.Text = _currentPatient.Phone;
                txtAddress.Text = _currentPatient.Address;
                txtMail.Text = _currentPatient.EMail;
                txtPNumber.Text = _currentPatient.PNumber;

                cmbGender.SelectedValue = _currentPatient.GenderID;
            }
            else
            {
                this.Text = "ახალი პაციენტის დამატება";
                btnSave.Text = "დამატება";
                cmbGender.SelectedIndex = -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPatient.FullName = txtFullName.Text;
                _currentPatient.Dob = dtpDob.Value;
                _currentPatient.Phone = txtPhone.Text;
                _currentPatient.Address = txtAddress.Text;
                _currentPatient.EMail = txtMail.Text;
                _currentPatient.PNumber = txtPNumber.Text;

                if (cmbGender.SelectedValue != null)
                {
                    _currentPatient.GenderID = (int)cmbGender.SelectedValue;
                }

                _patientService.SavePatient(_currentPatient);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ვალიდაციის შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
