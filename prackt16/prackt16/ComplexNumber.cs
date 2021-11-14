using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prackt16
{
    public class ComplexNumber
    {
        //sum (a+b) + (c+d)i
        public string SumComplex(string a, string b, string c, string d)
        {
            int Sum = 0;
            int SumNormal = 0;

            if (a.Contains('i') == true)
            {
                string new_a = a.Remove(a.IndexOf('i'));
                Sum += int.Parse(new_a);
            }
            else
            {
                SumNormal += int.Parse(a);
            }
            if (b.Contains('i') == true)
            {
                string new_b = b.Remove(b.Length-1);
                Sum += int.Parse(new_b);
            }
            else
            {
                SumNormal += int.Parse(b);
            }
            if (c.Contains('i') == true)
            {
                string new_c = c.Remove(c.IndexOf('i'));
                Sum += int.Parse(new_c);
            }
            else
            {
                SumNormal += int.Parse(c);
            }
            if (d.Contains('i') == true)
            {
                string new_d = d.Remove(d.IndexOf('i'));
                Sum += int.Parse(new_d);
            }
            else
            {
                SumNormal += int.Parse(d);
            }
            string answer = null;
            if (Sum == 0) answer = SumNormal.ToString();
            else if (SumNormal == 0) answer = Sum.ToString() + "i";
            else answer = "(" + SumNormal.ToString() + ") + (" + Sum.ToString() + "i)";
            return answer;
        }
        // (a+bi)-(c+di)
        public string SubComplex(string a, string b, string c, string d)
        {
            int Sum = 0;
            int SumNormal = 0;

            if (a.Contains('i') == true)
            {
                string new_a = a.Remove(a.IndexOf('i'));
                Sum += int.Parse(new_a);
            }
            else
            {
                SumNormal += int.Parse(a);
            }
            if (b.Contains('i') == true)
            {
                string new_b = b.Remove(b.Length - 1);
                Sum += int.Parse(new_b);
            }
            else
            {
                SumNormal += int.Parse(b);
            }
            if (c.Contains('i') == true)
            {
                string new_c = c.Remove(c.IndexOf('i'));
                Sum += -int.Parse(new_c);
            }
            else
            {
                SumNormal += -int.Parse(c);
            }
            if (d.Contains('i') == true)
            {
                string new_d = d.Remove(d.IndexOf('i'));
                Sum += -int.Parse(new_d);
            }
            else
            {
                SumNormal += -int.Parse(d);
            }
            string answer = null;
            if (Sum == 0) answer = SumNormal.ToString();
            else if (SumNormal == 0) answer = Sum.ToString() + "i";
            else answer = "(" + SumNormal.ToString() + ") + (" + Sum.ToString() + "i)";
            return answer;
        }

        public string MulComplex(string a, string b, string c, string d)
        {
            if (b.Contains('i') == true) b = b.Remove(b.IndexOf('i'));
            if (d.Contains('i') == true) d = d.Remove(d.IndexOf('i'));
            int part1 = int.Parse(a) * int.Parse(c);
            int part2 = int.Parse(a) * int.Parse(d);
            int part3 = int.Parse(b) * int.Parse(c);
            int part4 = int.Parse(b) * int.Parse(d);
            int sumNorm = part1 - part4;
            int sumComplex = part2 + part3;
            string answer = sumNorm.ToString() + " + " + sumComplex.ToString() + "i";
            return answer;
        }

    }
}
