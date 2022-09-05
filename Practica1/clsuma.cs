using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class clsuma
    {
        private double n1;
        private double n2;

        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }




        // constructor
        public clsuma(double n1, double n2)
        {
            this.N1 = n1;
            this.N2 = n2;
        }
        //Metodo, acción, lo que hace 
        public double sumar()
        {
            return (N1 + N2);
        }
        public double multiplicar()
        {
            return (n1 * n2);
        }
        public double restar()
        {
            return (n1 - n2);
        }
        public double dividir()
        {
            return (n1 / n2);
        }


        //Constructor vacío
        public clsuma()
        { 

        }
    }
}
