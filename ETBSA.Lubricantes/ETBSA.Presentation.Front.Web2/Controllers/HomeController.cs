using ETBSA.Presentation.Front.Web2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ETBSA.Presentation.Front.Web2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Index(ContactoViewModel model)
        {
            try
            {
                //model.FechaCreacion = DateTime.Now.AddHours(2);

                // Si el modelo es valido se inserta
                if (ModelState.IsValid)
                {
                    SmtpClient client = new SmtpClient("mail.chevronbajio.com");
                    //If you need to authenticate
                    client.Credentials = new NetworkCredential("contacto@chevronbajio.com", "C0NNt4ct0_");
                    //client.Port = 567;

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("contacto@chevronbajio.com");

                    // Agregar correos de la sucursal
                    mailMessage.To.Add("asancenp@gmail.com");
                    mailMessage.To.Add("suarezmario@etbsa.com.mx");
                    mailMessage.To.Add("sanchezdavid@etbsa.com.mx");

                    mailMessage.Subject = "CONTACTO WEB - COMENTARIO";
                    mailMessage.Body = "<img src='http://chevronbajio.com/images/logo2.png' /><br /><br />Nombre: " + model.Nombre + "<br />Correo: " + model.Correo + "<br />Teléfono: " + model.Telefono + 
                        "<br />Mensaje:<strong>" + model.Mensaje +
                        "</strong><br /><br /><i>* Este mensaje se fue enviado desde el sitio web etbsalubricantes.com</i>";
                    mailMessage.IsBodyHtml = true;

                    client.Send(mailMessage);

                    return Json(
                    new
                    {
                        Success = "ok"
                    }
                    , JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new
                    {
                        Error = "Todos los datos son obligatorios. Ingrese los datos faltantes."
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Error = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}