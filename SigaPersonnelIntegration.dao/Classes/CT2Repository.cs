using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SigaPersonnelIntegration.dao.Classes
{
    public class CT2Repository
    {
        private OracleConnection con;
        private OracleTransaction _transaction;
        private bool usaTransacao = false;
        public CT2Repository()
        {
            this.con = ConnectionFactory.GetConnection();
            
            if (this.con.State != ConnectionState.Open) 
                this.con.Open();
            if(usaTransacao)
                this._transaction = this.con.BeginTransaction();
        }

        public void inserir(CT2Model c)
        {
            //Validações regra de negócio
            c.validate();

            OracleCommand command = this.con.CreateCommand();
            
            if (usaTransacao)
                command.Transaction = this._transaction;
            
            //command.CommandText = this.CriaStringInsert();
            command.CommandText = "P_AMC_PERSONNEL_INTEGRATION";
            command.CommandType = CommandType.StoredProcedure;

            //Cria parametros
            OracleParameter DATA = new OracleParameter();
            DATA.Value = c.Data;
            DATA.ParameterName = "DATA";

            OracleParameter LOTE = new OracleParameter();
            LOTE.Value = c.Lote;
            LOTE.ParameterName = "LOTE";

            OracleParameter SUBLOTE = new OracleParameter();
            SUBLOTE.Value = c.SubLote;
            SUBLOTE.ParameterName = "SUBLOTE";

            OracleParameter DOC = new OracleParameter();
            DOC.Value = c.Doc;
            DOC.ParameterName = "DOC";

            OracleParameter LINHA = new OracleParameter();
            LINHA.Value = c.Linha;
            LINHA.ParameterName = "LINHA";

            OracleParameter MOEDA = new OracleParameter();
            MOEDA.Value = c.Moeda;
            MOEDA.ParameterName = "MOEDA";

            OracleParameter DC = new OracleParameter();
            DC.Value = c.DC;
            DC.ParameterName = "DC";

            OracleParameter CTADEB = new OracleParameter();
            CTADEB.DbType = DbType.String;
            CTADEB.Value = c.CTADEB.Substring(11, 9);
            CTADEB.ParameterName = "CTADEB";

            OracleParameter CTACRED = new OracleParameter();
            CTACRED.Value = c.CTACRED.Substring(11, 9);
            CTACRED.ParameterName = "CTACRED";

            OracleParameter VALOR = new OracleParameter();
            VALOR.DbType = DbType.Decimal;
            VALOR.Value = c.Valor;
            VALOR.ParameterName = "VALOR";

            OracleParameter HISTORICO = new OracleParameter();
            HISTORICO.Value = c.Historico;
            HISTORICO.ParameterName = "HISTORICO";

            OracleParameter CCD = new OracleParameter();
            CCD.Value = c.CCD;
            CCD.ParameterName = "CCD";

            OracleParameter CCC = new OracleParameter();
            CCC.Value = c.CCC;
            CCC.ParameterName = "CCC";

            OracleParameter EMPORI = new OracleParameter();
            EMPORI.Value = c.Empori;
            EMPORI.ParameterName = "EMPORI";

            OracleParameter FILORI = new OracleParameter();
            FILORI.Value = c.Filori;
            FILORI.ParameterName = "FILORI";

            OracleParameter TPSALD = new OracleParameter();
            TPSALD.Value = c.TPSald;
            TPSALD.ParameterName = "TPSALD";

            OracleParameter SEQ = new OracleParameter();
            SEQ.Value = c.SEQ;
            SEQ.ParameterName = "SEQ";

            OracleParameter MANUAL = new OracleParameter();
            MANUAL.Value = c.Manual;
            MANUAL.ParameterName = "MANUAL";

            OracleParameter ORIGEM = new OracleParameter();
            ORIGEM.Value = c.Origem;
            ORIGEM.ParameterName = "ORIGEM";

            OracleParameter ROTINA = new OracleParameter();
            ROTINA.Value = c.Rotina;
            ROTINA.ParameterName = "ROTINA";

            OracleParameter AGLUTINA = new OracleParameter();
            AGLUTINA.Value = c.Aglutina;
            AGLUTINA.ParameterName = "AGLUTINA";

            OracleParameter LP = new OracleParameter();
            LP.Value = c.LP;
            LP.ParameterName = "LP";

            OracleParameter SEQHIST = new OracleParameter();
            SEQHIST.Value = c.SEQHIST;
            SEQHIST.ParameterName = "SEQHIST";

            OracleParameter SEQLAN = new OracleParameter();
            SEQLAN.Value = c.SEQLAN;
            SEQLAN.ParameterName = "SEQLAN";

            OracleParameter CRCONV = new OracleParameter();
            CRCONV.Value = c.CRCONV;
            CRCONV.ParameterName = "CRCONV";

            OracleParameter DATAV = new OracleParameter();
            DATAV.Value = c.DATAV;
            DATAV.ParameterName = "DATAV";

            OracleParameter MLTSALD = new OracleParameter();
            MLTSALD.Value = c.MLTSALD;
            MLTSALD.ParameterName = "MLTSALD";

            OracleParameter CTLSALD = new OracleParameter();
            CTLSALD.Value = c.CTLSALD;
            CTLSALD.ParameterName = "CTLSALD";

            OracleParameter USERGI = new OracleParameter();
            USERGI.Value = c.USERGI;
            USERGI.ParameterName = "USERGI";

            OracleParameter MSFIL = new OracleParameter();
            MSFIL.Value = c.MSFIL;
            MSFIL.ParameterName = "MSFIL";


            command.Parameters.Add(DATA);
            command.Parameters.Add(LOTE);
            command.Parameters.Add(SUBLOTE);
            command.Parameters.Add(DOC);
            command.Parameters.Add(LINHA);
            command.Parameters.Add(MOEDA);
            command.Parameters.Add(DC);
            command.Parameters.Add(CTADEB);
            command.Parameters.Add(CTACRED);
            command.Parameters.Add(VALOR);
            command.Parameters.Add(HISTORICO);
            command.Parameters.Add(CCD);
            command.Parameters.Add(CCC);
            command.Parameters.Add(EMPORI);
            command.Parameters.Add(FILORI);
            command.Parameters.Add(TPSALD);
            command.Parameters.Add(SEQ);
            command.Parameters.Add(MANUAL);
            command.Parameters.Add(ORIGEM);
            command.Parameters.Add(ROTINA);
            command.Parameters.Add(AGLUTINA);
            command.Parameters.Add(LP);
            command.Parameters.Add(SEQHIST);
            command.Parameters.Add(SEQLAN);
            command.Parameters.Add(CRCONV);
            command.Parameters.Add(DATAV);
            command.Parameters.Add(MLTSALD);
            command.Parameters.Add(CTLSALD);
            command.Parameters.Add(USERGI);
            command.Parameters.Add(MSFIL);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                if (usaTransacao)
                    this._transaction.Rollback();

                con.Close();
                throw ex;
            }
           
        }

       
        public void commit()
        {
            try
            {
                if (usaTransacao)
                    this._transaction.Commit();
            }
            catch (OracleException ex)
            {
                if (usaTransacao)
                    this._transaction.Rollback();
                throw ex;
            }
        }

        private string CriaStringInsert()
        {

            string insert = "INSERT INTO CT2010(CT2_FILIAL, CT2_DCD, CT2_DCC,CT2_MOEDAS, CT2_HP,CT2_CLVLDB,CT2_CLVLCR, CT2_ATIVDE,CT2_ATIVCR,CT2_INTERC,CT2_IDENTC,CT2_DTVENC,CT2_SLBASE,CT2_DTLP, CT2_DATATX, CT2_TAXA, CT2_CRITER, CT2_VLR01, CT2_VLR02,CT2_VLR03 ,CT2_VLR04,CT2_VLR05,CT2_KEY, CT2_SEGOFI ,CT2_SEQIDX,D_E_L_E_T_,R_E_C_D_E_L_,CT2_CODCLI, CT2_CODFOR,  CT2_DIACTB, CT2_CONFST, CT2_OBSCNF,CT2_NODIA,CT2_USRCNF ,CT2_DTCONF,CT2_HRCONF,CT2_CODPAR,CT2_AT01DB,CT2_AT01CR,CT2_AT02DB,CT2_AT02CR,CT2_AT03DB,CT2_AT03CR,CT2_AT04DB,CT2_AT04CR,CT2_USERGA,CT2_ITEMD,CT2_ITEMC,CT2_DEBIT2, CT2_CREDI2,CT2_CCD2, CT2_CCC2,CT2_HIST2,CT2_VALOR2,CT2_CTRLSD,CT2_MOEFDB,CT2_MOEFCR, R_E_C_N_O_, CT2_DATA, CT2_LOTE, CT2_SBLOTE, CT2_DOC, CT2_LINHA, CT2_MOEDLC, CT2_DC, CT2_DEBITO, CT2_CREDIT, CT2_VALOR, CT2_HIST," +
                "CT2_CCD, CT2_CCC, CT2_EMPORI, CT2_FILORI, CT2_TPSALD, CT2_SEQUEN, CT2_MANUAL, CT2_ORIGEM, CT2_ROTINA, CT2_AGLUT," +
                "CT2_LP, CT2_SEQHIS, CT2_SEQLAN, CT2_CRCONV, CT2_DTCV3, CT2_MLTSLD, CT2_CTLSLD, CT2_USERGI, CT2_MSFIL) ";

            insert += "values(' ', ' ', ' ', '     ', '888', '         ' ,'         ','                                        ','                                        ',  ' ' ,'                                                  ','        ',' ','        ','        ','0','    ','0','0','0','0','0','                                                                                                                                                                                                        ','          ','     ',' ','0','      ','      ','  ',' ','                                        ','          ','               ','        ','          ','      ','                    ','                    ','                    ','                    ','                    ','                    ','                    ','                    ','                 ','                    ','                    ','                    ','                    ','         ','         ','                                        ','0',' ','  ','  ',(select max(r_e_c_n_o_)+2 from CT2010), :DATA, :LOTE, :SUBLOTE, :DOC, :LINHA, :MOEDA, :DC, :CTADEB, :CTACRED, TO_CHAR(:VALOR, '9999,99'), :HISTORICO, :CCD, :CCC, :EMPORI, :FILORI, :TPSALD, :SEQ, :MANUAL, :ORIGEM, :ROTINA, :AGLUTINA, :LP, :SEQHIST, :SEQLAN, :CRCONV, :DATAV, :MLTSALD, :CTLSALD, :USERGI, :MSFIL)";

            return insert;
        }


    }
}
