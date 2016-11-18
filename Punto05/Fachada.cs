using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto05
{
    class Fachada
    {

        public double CalcularPerimetroTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);
            Punto p3 = new Punto(x3, y3);
            Triangulo t = new Triangulo(p1, p2, p3);
            return t.Perimetro();
        }

        public double CalcularAreaTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);
            Punto p3 = new Punto(x3, y3);
            Triangulo t = new Triangulo(p1, p2, p3);
            return t.Area();
        }

        public double CalcularPerimetroCirculo(double x1, double y1, double radio)
        {
            Punto p1 = new Punto(x1, y1);
            Circulo c = new Circulo(p1, radio);
            return c.Perimetro();
        }

        public double CalcularAreaCirculo(double x1, double y1, double radio)
        {
            Punto p1 = new Punto(x1, y1);
            Circulo c = new Circulo(p1, radio);
            return c.Area();
        }
    }
}
