using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto05
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        static Triangulo()
        { }

        public Triangulo()
        { }

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;

        }

        public Punto Punto1 { get { return this.iPunto1; } }

        public Punto Punto2 { get { return this.iPunto2; } }

        public Punto Punto3 { get { return this.iPunto3; } }

        public double Area()
        {
            double ladoA = iPunto1.CalcularDistanciaDesde(iPunto2);
            double ladoB = iPunto1.CalcularDistanciaDesde(iPunto3);
            double ladoC = iPunto2.CalcularDistanciaDesde(iPunto3);
            double semPer = (double)(ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(semPer * (semPer - ladoA) * (semPer - ladoB) * (semPer - ladoC));
        }

        public double Perimetro()
        {
            return this.iPunto1.CalcularDistanciaDesde(iPunto2) + this.iPunto1.CalcularDistanciaDesde(iPunto3) + this.iPunto2.CalcularDistanciaDesde(iPunto3);
        }
    }
}
