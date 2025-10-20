using Dapper;
using MEDSOFT.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT.DataAccess
{
    public class GenderRepository
    {
        private readonly string _connectionString;

        public GenderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Gender> GetAllGenders()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Gender>("dbo.SelectAllGenders", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
