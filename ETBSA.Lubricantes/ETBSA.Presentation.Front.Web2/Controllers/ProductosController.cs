using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETBSA.Presentation.Front.Web2.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult TransporteComercial()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ActionName("Aceites-Para-Motores-de-Servicio-Pesado")]
        public ActionResult AceitesMotorServicioPesado()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ActionName("Refrigerantes-Antocongelantes")]
        public ActionResult RefrigerantesAntocongelantes()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ActionName("Grasas")]
        public ActionResult Grasas()
        {
            return View();
        }
    }
}