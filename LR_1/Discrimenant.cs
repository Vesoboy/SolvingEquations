using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace LR_1
{
    internal class Equation
    {
        public double a, b, c;


        public Equation(double a, double b, double c)  //Конструктор
        { this.a = a;   this.b = b;     this.c = c; }   //

        //Условия при которых мы понимаем какое уравнение перед нами
        public string Equation_abc()
        {
            if ((a != 0) & (b != 0) & (c != 0))         //стандартное, где есть abc переменные
            {
                var obj = new Equation(a, b, c);
                return obj.Equation_three();
            }
            else if ((a != 0) & (b == 0) & (c != 0))    //не стандартное, где только ac переменные
            {
                var obj = new Equation(a, b, c);
                return obj.Equation_two_a_c();
            }
            else if ((a != 0) & (b != 0) & (c == 0))    //не стандартное, где только ab переменные
            {
                var obj = new Equation(a, b, c);
                return obj.Equation_two_a_b();
            }
            else if ((a == 0) & (b != 0) & (c != 0))    //обычное уравнение, где только bc переменные
            {
                var obj = new Equation(a, b, c);
                return obj.Equation_two_b_c();
            }
            else return ("Уравнение не рашается, неправильное или нет корней");
        }
        //Функция нахождения корней квадратного уравнения стандартного вида
        private string Equation_three()
        {
            double D = b * b - (4 * a * c);
            double D_minus_x = ((b * (-1)) / (2 * a));
            float D_plus_x1 = ((float)((b * (-1) + Sqrt(D)) / (2 * a)));
            float D_plus_x2 = ((float)((b * (-1) - Sqrt(D)) / (2 * a)));

            if (D < 0) return("Дискрименант меньше нуля, корней нет");

            else if (D == 0) return($"Дискрименант равен 0, значит уравнение имеет один корень, \n{a}x^2+({b})x+({c})\nx = {D_minus_x}");

            else return($"Дискрименант положительный, уравнение имеет 2 корня: \n\n{a}x^2+({b})x+({c}) \nx1 = { D_plus_x1} \nx2 = { D_plus_x2}");

        }
        //Функция нахождения корней квадратного уравнения не стандартного вида
        private string Equation_two_a_c()
        {
            double invers_c_div_a = Abs(c / a);
            double x = Sqrt(invers_c_div_a);

            if (((a < 0) & (c < 0)) || (c < 0) || ((a > 0) & (c > 0)))
            {
                return $"Нестандартное квадратное уравнение,\n{a}x^2+({c}) \nx1 =  {x} \nx2 = {-x}";
            }

            else return $"Уравнение  {a}x^2+({c})   ошибочно";
        }
        //Функция нахождения корней квадратного уравнения не стандартного вида
        private string Equation_two_a_b()
        {
            double x = b / a;
            return $"Нестандартное квадратное уравнение,\n {a}x^2+({b})x \nx1 = {-x}  \nx2 = 0";
        }
        //Функция нахождения корней уравнения не стандартного вида
        private string Equation_two_b_c()
        {
            return $"Нестандартное квадратное уравнение,\n{b}x+({c}) \nx = {-c / b}";
        }

    }
}
