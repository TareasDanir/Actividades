using Parcial4_2524572019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial4_2524572019.Controllers
{
    public class NumeroController : Controller
    {
        // GET: Numero
        public ActionResult Calcular()
        {
            return View();
        }
        public ActionResult NumerosCalcular()
        {
            Numeros objModel = new Numeros();
            objModel.num1 = double.Parse(Request.Form["num_1"].ToString());
            objModel.num2 = double.Parse(Request.Form["num_2"].ToString());
            
            if (objModel.num1>objModel.num2)
            {
                objModel.suma = objModel.num1 + objModel.num2;
                objModel.diferencia = objModel.num1 - objModel.num2;
                objModel.Resultado = "La suma es: " + objModel.suma;
                objModel.Resultado2 = "La direfencia es: " + objModel.diferencia;
            }
            else 
            {
                if (objModel.num2==0)
                {
                    objModel.Resultado2 = "No se puede dividir entre cero";
                }
                else
                {
                    objModel.division = objModel.num1 / objModel.num2;
                    objModel.Resultado2 = "La division es: " + objModel.division;
                }
                
                objModel.producto= objModel.num1 * objModel.num2;
                objModel.Resultado = "El producto es: "+objModel.producto;
            }

            return View("NumerosCalcular", objModel);
        }
    }
}