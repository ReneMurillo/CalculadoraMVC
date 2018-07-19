using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public partial class OperacionesController
    {
        void Suma(int valor1, int valor2)
        {
            Imprime("El resultado de la suma es: ");
            int suma = valor1 + valor2;
            Imprime(suma);
        }

        void Resta(int valor1, int valor2)
        {
            Imprime("El resultado de la resta es: ");
            int resta = valor1 - valor2;
            Imprime(resta);
        }
        void Multiplicacion(int valor1, int valor2)
        {
            Imprime("El resultado de la multiplicación es: ");
            int multi = valor1 * valor2;
            Imprime(multi);
        }

        void Division(int valor1, int valor2)
        {
            if(valor2 != 0)
            { 
                Imprime("El resultado de la división es: ");
                int division = valor1 / valor2;
                Imprime(division);
            }
            else
            {
                Imprime("Imposible dividir entre 0");
            }
        }
        void Potencia(int valorBase, int valorPotencia)
        {
            Imprime("El resultado de la potencia es: ");
            int potencia = Convert.ToInt32(Math.Pow(valorBase, valorPotencia));
            Imprime(potencia);
        }

        void Raiz(double valor)
        {
            Imprime("El resultado de la raíz es: ");
            double potencia = Math.Sqrt(valor);
            Imprime(Math.Round(potencia, 2));
        }
}
