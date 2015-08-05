using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaPersonnelIntegration.testeTab
{
    class Program{
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\daniel_albuquerque\Desktop\enviar.txt");


            foreach (string line in lines)
            {
                string data = line.Substring(85, 40);
                Console.WriteLine(data);
            }

            Console.ReadKey();

            var sepList = new List<string>();
            using (StreamReader sr = new StreamReader(@"C:\Users\daniel_albuquerque\Desktop\enviar.txt"))
            {
                String line = sr.ReadToEnd();

                string data = line.Substring(0,8);
                string lote = line.Substring(8, 6);
                string sublote = line.Substring(14, 3);
                string doc = line.Substring(17, 6);
                string linha = line.Substring(23, 3);
                string moeda = line.Substring(26, 2);
                string dc = line.Substring(28, 1);
                string CTADEB = line.Substring(29, 20);
                string CTACRED = line.Substring(49, 20);
                string valor = line.Substring(69, 16);
                string historico = line.Substring(85, 40);
                string ccd = line.Substring(125, 9);
                string ccc = line.Substring(134, 9);
                string empori = line.Substring(143, 2);
                string filori = line.Substring(145, 2);
                string tpsald = line.Substring(147, 1);
                string seq = line.Substring(148, 10);
                string manual = line.Substring(158, 1);
                string origem = line.Substring(159, 100);
                string rotina = line.Substring(259, 10);
                string aglutina = line.Substring(269, 1);
                string lp = line.Substring(270, 3);
                string seqhist = line.Substring(273, 3);
                string seqlan = line.Substring(276, 3);
                string crconv = line.Substring(279, 1);
                string datav = line.Substring(280, 8);
                string mltsald = line.Substring(288, 20);
                string CTLSALD = line.Substring(308, 1);
                string USERGI = line.Substring(309, 17);
                string msfil = line.Substring(326, 2);

                Console.WriteLine(msfil);
            }
            
            // Suspend the screen.
            Console.ReadLine();
        }

       
    }
}
