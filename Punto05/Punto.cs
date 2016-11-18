using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto05
{
    class Punto
    {
        private double iX;
        private double iY;

        public Punto() : this(0, 0)
        {
            //Constructor de instancia
        }

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        public double X { get { return this.iX; } }

        public double Y { get { return this.iY; } }

        public double CalcularDistanciaDesde(Punto p)
        {
            double distancia = Math.Sqrt(Math.Pow(this.iX - p.X, 2) + Math.Pow(this.iY - p.Y, 2));
            return distancia;
        }
    }
}
