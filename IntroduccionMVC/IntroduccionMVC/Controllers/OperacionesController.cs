using IntroduccionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            Datos objModelo = new Datos();
            objModelo.Variable_A = 3;
            objModelo.Variable_B = 5;
            objModelo.Resultado = objModelo.Variable_A + objModelo.Variable_B;
            ViewData["Resultado"] = objModelo.Resultado;
            return View();
        }

        public ActionResult Resta()
        {
            Datos objModelo = new Datos();
            objModelo.Variable_A = double.Parse(Request.Form["valor1"].ToString());
            objModelo.Variable_B = double.Parse(Request.Form["valor2"].ToString()); ;
            objModelo.Resultado = objModelo.Variable_A - objModelo.Variable_B;
            return View("Resta",objModelo);
        }

        public ActionResult Fal()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Fal( Datos objModelo)
        {
            
            objModelo.Variable_A = double.Parse(Request.Form["a"].ToString());
            objModelo.Variable_B = double.Parse(Request.Form["b"].ToString()); ;
            int opcion = objModelo.opcion;
            double resultado;

            switch (opcion)
            {
                case 1:
                    //Multiplicar
                    objModelo.Resultado = objModelo.Variable_A * objModelo.Variable_B;
                    ViewBag.Resultado = objModelo.Resultado;
                    break;
                case 2:
                    //Dividir
                    if (objModelo.Variable_B==0)
                    {
                        ViewBag.Resultado = "No se puede dividir entre cero";
                    }
                    else {
                        objModelo.Resultado = objModelo.Variable_A / objModelo.Variable_B;
                        ViewBag.Resultado = objModelo.Resultado;
                    }
                    
                    break;
                case 0:
                    //Sin opcion
                    //resta
                    ViewBag.Resultado = "No a seleccionado ninguna accion";
                    break;
            }
            
            return View();
        }

    }
}