using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto05
{
    class Circulo
    {
        private Punto iCentro;
        private double iRadio;


        public Circulo()
        {
            // Constructor de instancia.
        }

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = pRadio;
        }

        public Punto Centro { get { return this.iCentro; } }

        public double Radio { get { return this.iRadio; } }

        public double Area()
        {
            return Math.PI * Math.Pow(this.iRadio, 2);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * this.iRadio;
        }


    }
}
