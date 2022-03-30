using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Rectangulo
    {
        double p1;
        double p2;
        double p3;
        double p4;
        double perimetro;
        double suma_de_areas;
        double area;
        double cx, cy;
        double dd1, dd2, dd3, dd4;
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
        public Punto punto4 { get; set; }
        public double Area()
        {
            suma_de_areas = Math.Abs((punto1.x * punto2.y + punto2.x * punto3.y + punto3.x * punto4.y + punto4.x * punto1.y) - (punto1.x * punto4.y + punto4.x * punto3.y + punto3.x * punto2.y + punto2.x * punto1.y));
            area = suma_de_areas / 2;
            return area;
        }
        public double Perimetro()
        {
            p1 = Math.Sqrt(Math.Pow(punto1.x - punto2.x, 2) + Math.Pow(punto1.y - punto2.y, 2));
            p2 = Math.Sqrt(Math.Pow(punto2.x - punto3.x, 2) + Math.Pow(punto2.y - punto3.y, 2));
            p3 = Math.Sqrt(Math.Pow(punto3.x - punto4.x, 2) + Math.Pow(punto3.y - punto4.y, 2));
            p4 = Math.Sqrt(Math.Pow(punto4.x - punto1.x, 2) + Math.Pow(punto4.y - punto1.y, 2));
            perimetro = p1 + p2 + p3 + p4;
            return perimetro;
        }


        //<--SE INTNETO HACER UN CODIGO QUE VERIQUE SI ES UN RECTANGULO O NO--->
        //public bool Rectangulo_o_no()
        //{
        //cx = (punto1.x + punto2.x + punto3.x + punto4.x) / 4;
        //cy = (punto1.y + punto2.y + punto3.y + punto4.y) / 4;

        //dd1 = Math.Sqrt(cx - punto1.x) + Math.Sqrt(cy - punto1.y);
        //dd2 = Math.Sqrt(cx - punto2.x) + Math.Sqrt(cy - punto2.y);
        //dd3 = Math.Sqrt(cx - punto3.x) + Math.Sqrt(cy - punto3.y);
        //dd4 = Math.Sqrt(cx - punto4.x) + Math.Sqrt(cy - punto4.y);
        //if (dd1 == dd2 && dd1 == dd3 && dd1 == dd4)
        //{
        //return true;
        //}
        //else
        //{
        //return false;
        //}
        //}
    }
}
