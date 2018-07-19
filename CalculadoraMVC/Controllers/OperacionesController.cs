using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


    public partial class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult Suma()
        {
        if (Request.HttpMethod == "POST")
        {
            int numero1 = valor1();
            int numero2 = valor2();
            Suma(numero1, numero2);
        }
        return View();
        }

        public ActionResult Resta()
        {
        if (Request.HttpMethod == "POST")
        {
            int numero1 = valor1();
            int numero2 = valor2();
            Resta(numero1, numero2);
        }
        return View();
        }

        public ActionResult Multiplicacion()
        {
        if (Request.HttpMethod == "POST")
        {
            int numero1 = valor1();
            int numero2 = valor2();
            Multiplicacion(numero1, numero2);
        }
        return View();
        }

        public ActionResult Division()
        {
        if (Request.HttpMethod == "POST")
        {
            int numero1 = valor1();
            int numero2 = valor2();
            Division(numero1, numero2);
        }
        return View();
        }

        public ActionResult Potencia()
        {
            if (Request.HttpMethod == "POST")
            {
                int numero1 = valor1();
                int numero2 = valor2();
                Potencia(numero1, numero2);
            }
            return View();
        }

        public ActionResult Raiz()
        {
            if (Request.HttpMethod == "POST")
            {
                int numero1 = valor1();
                Raiz(numero1);
            }
            return View();
        }
        public ActionResult TodoEnUno()
        {
        if (Request.HttpMethod == "POST")
        {
            int numero1 = valor1();
            int numero2 = valor2();

            var operacion = Request["operacion"];

            if(operacion == "Suma")
            {
                Suma(numero1, numero2);
            }else if (operacion == "Resta")
            {
                Resta(numero1, numero2);
            }
            else if (operacion == "Multi")
            {
                Multiplicacion(numero1, numero2);
            }
            else if (operacion == "Division")
            {
                Division(numero1, numero2);
            }
            else if (operacion == "Potencia")
            {
                Potencia(numero1, numero2);
            }
            else if (operacion == "Raiz")
            {
                Raiz(numero1);
            }    
        }
        return View();
    }

    void Imprime(object cadena)
        {
            ViewBag.total += cadena;
        }

        int valor1()
        {
            int numero1 = Convert.ToInt32(Request["num1"]);
            return numero1;
        }
        int valor2()
        {
            int numero2 = Convert.ToInt32(Request["num2"]);
            return numero2;
        }
    }
