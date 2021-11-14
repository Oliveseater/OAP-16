using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prackt16
{
    public class Vector
    {
        //сложение вычитание
        //вычисление скалярного произведения двух векторов и длины вектора
        //операция вычисления косинуса угла между векторами.
        public string SumSub(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            // c = a + b = (x+x; y+y; z+z);
            double cx = x1 + x2;
            double cy = y1 + y2;
            double cz = z1 + z2;
            string Sum = "(" + cx.ToString() + ";" + cy.ToString() + ";" + cz.ToString() + ")";
            //c = a - b = (x-x; y-y; z-z)
            cx = x1 - x2;
            cy = y1 - y2;
            cz = z1 - z2;
            string Sub = "(" + cx.ToString() + ";" + cy.ToString() + ";" + cz.ToString() + ")";
            string answer = Sum + " " + Sub;
            return answer;
        }
        public string Scaliarnoe(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double cx1 = x1 * x2;
            double cy2 = y1 * y2;
            double cz3 = z1 * z2;
            string Multi = "(" + cx1.ToString() + ";" + cy2.ToString() + ";" + cz3.ToString() + ")";
            double longnumb = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
            return Multi + " " + longnumb.ToString();
        }
        public string CosVector(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double cx = x1 * x2;
            double cy = y1 * y2;
            double cz = z1 * z2;
            double cosAlf = (cx + cy + cz) / (Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1) * Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2));
            return cosAlf.ToString();
        }
    }
}
