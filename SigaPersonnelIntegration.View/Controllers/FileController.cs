using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SigaPersonnelIntegration.dao.Classes;
namespace SigaPersonnelIntegration.View.Controllers
{
    public class FileController : Controller
    {
        //
        // GET: /File/
        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Upload()
        {
            try
            {
                CT2Repository _repository = new CT2Repository();
                //MigrationRepository _mRepository = new MigrationRepository();
                foreach (string file in Request.Files)
                {
                    var fileContent = Request.Files[file];
                    if (fileContent != null && fileContent.ContentLength > 0)
                    {
                        var stream = fileContent.InputStream;
                        var fileName = GetTimestamp(DateTime.Now);
                        var path = Path.Combine(Server.MapPath("~/App_Data/Files"), fileName);
                        fileContent.SaveAs(path);

                        //ler o arquivo
                        string[] lines = System.IO.File.ReadAllLines(path);
                        

                        foreach (string line in lines)
                        {
                            CT2Model c = new CT2Model();
                            //Preenche o objeto
                            c.Data = line.Substring(0, 8);
                            c.Lote = line.Substring(8, 6);
                            c.SubLote = line.Substring(14, 3);
                            c.Doc = line.Substring(17, 6);
                            c.Linha = line.Substring(23, 3);
                            c.Moeda = line.Substring(26, 2);
                            c.DC = line.Substring(28, 1);
                            c.CTADEB = line.Substring(29, 20);
                            c.CTACRED = line.Substring(49, 20);
                            c.Valor = Convert.ToDecimal(line.Substring(69, 16));
                            c.Historico = line.Substring(85, 40);
                            c.CCD = line.Substring(125, 9);
                            c.CCC = line.Substring(134, 9);
                            c.Empori = line.Substring(143, 2);
                            c.Filori = line.Substring(145, 2);
                            c.TPSald = line.Substring(147, 1);
                            c.SEQ = line.Substring(148, 10);
                            c.Manual = line.Substring(158, 1);
                            c.Origem = line.Substring(159, 100);
                            c.Rotina = line.Substring(259, 10);
                            c.Aglutina = line.Substring(269, 1);
                            c.LP = line.Substring(270, 3);
                            c.SEQHIST = line.Substring(273, 3);
                            c.SEQLAN = line.Substring(276, 3);
                            c.CRCONV = line.Substring(279, 1);
                            c.DATAV = line.Substring(280, 8);
                            c.MLTSALD = line.Substring(288, 20);
                            c.CTLSALD = line.Substring(308, 1);
                            c.USERGI = line.Substring(309, 17);
                            c.MSFIL = line.Substring(326, 2);

                            //Salva no banco(OBS -> UTILIZA TRANSAÇÃO!)
                            _repository.inserir(c);
                        }

                        /*MigrationModel m = new MigrationModel();
                        m.status = "Migrado";
                        m.Description = "Migração realizada em: " + GetTimestamp(DateTime.Now);
                        m.FileId = fileName;
                        _mRepository.salva(m);*/

                    }
                }
                _repository.commit(); // Efetua o commit no banco de dados;
            }
            catch (Exception ex)
            {
               // Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Erro no processamento: " + ex.Message);
            }

            return Json("Arquivo processado com sucesso.");
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
       
	}
}