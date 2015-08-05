using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaPersonnelIntegration.dao.Classes
{
    public class MigrationRepository
    {
        private OracleConnection con;
        public MigrationRepository()
        {
            this.con = ConnectionFactory.GetConnection();
            this.con.Open();
        }

        public void salva(MigrationModel m)
        {
            string sql = "INSERT INTO AMC_PERSONNEL_INTEGRATION(FILE_ID, DESCRIPTION, STATUS) VALUES(:FILE_ID, :DESCRIPTION, :STATUS);";
             
            OracleParameter FILE_ID = new OracleParameter();
            FILE_ID.Value = m.FileId;
            FILE_ID.ParameterName = "FILE_ID";

            OracleParameter DESCRIPTION = new OracleParameter();
            DESCRIPTION.Value = m.Description;
            DESCRIPTION.ParameterName = "DESCRIPTION";

            OracleParameter STATUS = new OracleParameter();
            STATUS.Value = m.status;
            STATUS.ParameterName = "STATUS";

            OracleCommand command = this.con.CreateCommand();
            command.CommandText = sql;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                con.Close();
                throw ex;
            }
        }
    }
}
