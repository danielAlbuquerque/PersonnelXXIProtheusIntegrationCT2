using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaPersonnelIntegration.dao.Classes
{
    public class CT2Model
    {
        public string Recno { get; set; }
        public string Data { get; set; }
        public string Lote { get; set; }
        public string SubLote { get; set; }
        public string Doc { get; set; }
        public string Linha { get; set; }
        public string Moeda { get; set; }
        public string DC { get; set; }
        public string CTADEB { get; set; }
        public string CTACRED { get; set;}
        public Decimal Valor { get; set; }
        public string Historico { get; set; }
        public string CCD { get; set; }
        public string CCC { get; set; }
        public string Empori { get; set; }
        public string Filori { get; set; }
        public string TPSald { get; set; }
        public string SEQ { get; set; }
        public string Manual { get; set; }
        public string Origem { get; set; }
        public string Rotina { get; set; }
        public string Aglutina { get; set; }
        public string LP { get; set; }
        public string SEQHIST { get; set; }
        public string SEQLAN { get; set; }
        public string CRCONV { get; set; }
        public string DATAV { get; set; }
        public string MLTSALD { get; set; }
        public string CTLSALD { get; set; }
        public string USERGI { get; set; }
        public string MSFIL { get; set; }

        public void validate()
        {
            
        }
    }
}
