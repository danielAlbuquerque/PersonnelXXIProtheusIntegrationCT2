using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Collections;
using SigaPersonnelIntegration.dao.Classes;
using System.Windows;
using System.Runtime.InteropServices;

namespace SigaPersonnelIntegration.testedb
{
    class Program
    {

        static void Main(string[] args)
        {

            string valor = "0000000000267399";
            //decimal valor2 = Convert.ToDecimal(valor);
            //Console.WriteLine(valor2.ToString());
            Console.WriteLine(Convert.ToDouble(valor).ToString("####.##"));
            Console.ReadKey();

            /*CT2Model c = new CT2Model();

            c.Data = "20150730";
            c.Lote = "008890";
            c.SubLote = "001";
            c.Doc = "000001";
            c.Linha = "001";
            c.Moeda = "01";
            c.DC = "1";
            c.CTADEB = "341010003";
            c.CTACRED = "         ";
            c.Valor = Convert.ToDecimal("18141");
            c.Historico = "ADICIONAL NOTURNO - 30%  6/";
            c.CCD = "11000";
            c.CCC = "     ";
            c.Empori = "01";
            c.Filori = "01";
            c.TPSald = "1";
            c.SEQ = "0000448889";
            c.Manual = "2";
            c.Origem = "TOUTATIS";
            c.Rotina = "TOUTATIS";
            c.Aglutina = "2";
            c.LP = "A01";
            c.SEQHIST = "01";
            c.SEQLAN = "001";
            c.CRCONV = "1";
            c.DATAV = "20150630";
            c.MLTSALD = "1";
            c.CTLSALD = "0";
            c.USERGI = "TI";
            c.MSFIL = "01";

            CT2Repository _repository = new CT2Repository();

            try
            {
                _repository.inserir(c);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            

            /*string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                                  connection.ConnectionString);

                OracleCommand command = connection.CreateCommand();
                string sql = "SELECT * FROM SRA010";
                command.CommandText = sql;

                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string myField = (string)reader["RA_NOME"];
                    Console.WriteLine(myField);
                }
            }*/
        }
    }
}
