using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MEDSOFT.Models;

namespace MEDSOFT.DataAccess
{
    public class PatientRepository
    {
        private readonly string _connectionString;
        public PatientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Patient> GetAllPatients()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Patient>("dbo.SelectAllPatients", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public int InsertPatient(Patient patient)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {

                int newId = db.QuerySingle<int>(
                    sql: "dbo.InsertPatient",
                    param: new 
                    {
                        patient.FullName,
                        patient.Dob,
                        patient.GenderID,
                        patient.Phone,
                        patient.Address,
                        patient.EMail,
                        patient.PNumber
                    },
            commandType: CommandType.StoredProcedure
                );
                return newId;
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    sql: "dbo.UpdatePatient",
                     param: new
                     {
                         patient.ID,
                         patient.FullName,
                         patient.Dob,
                         patient.GenderID,
                         patient.Phone,
                         patient.Address,
                         patient.EMail,
                         patient.PNumber
                     },
                     commandType: CommandType.StoredProcedure
                );
            }
        }
        public void DeletePatient(int patientId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    sql: "dbo.DeletePatient",
                    param: new { ID = patientId }, 
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }

}
