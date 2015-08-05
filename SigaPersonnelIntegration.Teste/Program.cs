
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaPersonnelIntegration.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            String sConnectionString = "Provider=MSDAORA.1;User ID=sigausr;password=sigatmp;Data Source=SIGATST;Persist Security Info=False";
            using (var conn = new OracleConnection(sConnectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM sigausr.sra010";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                    }
                }
            }  

            /*
            String sConnectionString = "Provider=MSDAORA.1;User ID=sigausr;password=sigatmp;Data Source=SIGATST;Persist Security Info=False";
            String mySelectQuery = "SELECT * FROM sigausr.sra010";

            OleDbConnection myConnection = new OleDbConnection(sConnectionString);
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            //myCommand.Parameters.Add("@p1", OleDbType.Char, 5).Value = "Test%";
            myConnection.Open();
            OleDbDataReader myReader = myCommand.ExecuteReader();
            int RecordCount=0;
            try
            {
                while (myReader.Read())
                {
                    RecordCount = RecordCount + 1;
                    Console.WriteLine(myReader.GetString(0));
                }
                if (RecordCount == 0)
                {
                    Console.WriteLine("404");
                }
                else
                {
                    Console.WriteLine(myReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }*/

            /*string oradb = "Data Source=SIGATST;User Id=sigausr;Password=sigatmp;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            var cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from ct2010 where d_e_l_e_t_ != ''";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Console.WriteLine(dr.GetString(0));
            Console.Read();
            conn.Dispose();*/
        }
    }
}
