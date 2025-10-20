using MEDSOFT.DataAccess;
using MEDSOFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT.Services
{
    public class PatientService
    {
        private readonly PatientRepository _patientRepository;
        private readonly GenderRepository _genderRepository;
        public PatientService(PatientRepository patientRepository, GenderRepository genderRepository)
        {
            _patientRepository = patientRepository;
            _genderRepository = genderRepository; 
        }

        private void ValidatePatient(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.FullName))
            {
                throw new Exception("პაციენტის სრული სახელი სავალდებულოა.");
            }

            if (patient.Dob == default(DateTime) || patient.Dob > DateTime.Today)
            {
                throw new Exception("დაბადების თარიღი არასწორია.");
            }

            if (patient.GenderID <= 0)
            {
                throw new Exception("სქესის არჩევა სავალდებულოა.");
            }
            if (!string.IsNullOrWhiteSpace(patient.EMail))
            {
                string EMail = patient.EMail;
                if (!EMail.Contains("@"))
                {
                    throw new Exception("ელ. ფოსტა არასწორია.");
                }
            }

            if (!string.IsNullOrWhiteSpace(patient.Phone))
            {
                string phone = patient.Phone.Trim();

                if (phone.Length != 9)
                {
                    throw new Exception("ტელეფონის ნომერი უნდა იყოს ზუსტად 9 ციფრი.");
                }

                if (!phone.StartsWith("5"))
                {
                    throw new Exception("ტელეფონის ნომერი უნდა იწყებოდეს ციფრით 5.");
                }

                if (!phone.All(char.IsDigit))
                {
                    throw new Exception("ტელეფონის ნომერი უნდა შედგებოდეს მხოლოდ ციფრებისგან.");
                }
            }
            if (!string.IsNullOrWhiteSpace(patient.PNumber))
            {
                string PNumber = patient.PNumber.Trim();

                if (PNumber.Length != 11)
                {
                    throw new Exception("პირადი ნომერი უნდა იყოს ზუსტად 11 ციფრი.");
                }

                if (!PNumber.All(char.IsDigit))
                {
                    throw new Exception("პირადი ნომერი უნდა შედგებოდეს მხოლოდ ციფრებისგან.");
                }
            }

        }

        public List<Gender> GetGenders()
        {
            return _genderRepository.GetAllGenders();
        }

        public void SavePatient(Patient patient)
        {
            ValidatePatient(patient);

            if (patient.ID > 0)
            {
                _patientRepository.UpdatePatient(patient);
            }
            else
            {
                _patientRepository.InsertPatient(patient);
            }
        }

        public void DeletePatient(int patientId)
        {
            if (patientId <= 0)
            {
                throw new Exception("წაშლისთვის საჭიროა მონიშნოთ პაციენტი.");
            }

            _patientRepository.DeletePatient(patientId);
        }
    }
}
