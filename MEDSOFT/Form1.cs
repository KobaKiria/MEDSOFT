using MEDSOFT.DataAccess;
using MEDSOFT.Models;
using MEDSOFT.Services;
using Microsoft.Extensions.Configuration;

namespace MEDSOFT
{
    public partial class Form1 : Form
    {

        private readonly PatientRepository _patientRepository;
        private readonly GenderRepository _genderRepository;
        private readonly PatientService _patientService;
        public Form1()
        {
            InitializeComponent();

            string connString = Program.Configuration.GetConnectionString("MedsoftDb");

            _patientRepository = new PatientRepository(connString);
            _genderRepository = new GenderRepository(connString);

            _patientService = new PatientService(_patientRepository, _genderRepository);
            LoadPatientsData();
        }

        private void LoadPatientsData()
        {
            try
            {
                var patients = _patientRepository.GetAllPatients();

                dataGridView1.DataSource = patients;
                dataGridView1.Columns["GenderID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"მონაცემების ჩატვირთვის შეცდომა: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();

            using (var addForm = new AddEditPatientForm(newPatient, _patientService))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPatientsData();

                    MessageBox.Show("პაციენტი წარმატებით დაემატა!", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("გთხოვთ, აირჩიოთ პაციენტი რედაქტირებისთვის.", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                var selectedPatient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var editForm = new AddEditPatientForm(selectedPatient, _patientService))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientsData();

                        MessageBox.Show("პაციენტი წარმატებით განახლდა!", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"შეცდომა რედაქტირებისას: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("გთხოვთ, აირჩიოთ პაციენტი წასაშლელად.", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedPatient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;
            int patientIdToDelete = selectedPatient.ID;
            string patientName = selectedPatient.FullName;

            DialogResult confirm = MessageBox.Show(
                $"დარწმუნებული ხართ, რომ გსურთ პაციენტ '{patientName}'-ის წაშლა?",
                "წაშლის დადასტურება",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _patientService.DeletePatient(patientIdToDelete);

                    MessageBox.Show("პაციენტი წარმატებით წაიშალა!", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatientsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"წაშლის შეცდომა: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
