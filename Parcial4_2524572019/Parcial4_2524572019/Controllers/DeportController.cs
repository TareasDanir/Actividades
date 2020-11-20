using Parcial4_2524572019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Parcial4_2524572019.Controllers
{
    public class DeportController : Controller
    {
        // GET: Deport
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Deportis()
        {
            Deportista objModel = new Deportista();
            objModel.edad = int.Parse(Request.Form["eda"].ToString());
            objModel.estatura = double.Parse(Request.Form["esta"].ToString());
            objModel.peso = double.Parse(Request.Form["pes"].ToString());
            if (objModel.edad<=18 && objModel.estatura>180 && objModel.peso<=80)
            {
                objModel.Resultado = "Usted, Cumple con los Requisitos Bienvenido al equipo";
            }
            else
            {
                objModel.Resultado = "Usted, No Cumple con los Requisitos por eso ha sido rechazado por el equipo";
            }
            
            return View("Deportis", objModel);
        }
    }
}