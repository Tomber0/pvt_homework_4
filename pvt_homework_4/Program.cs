using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber1 = new ComplexNumber(1, 5);

            ComplexNumber complexNumber2 = new ComplexNumber(3, -3);
            Console.Out.WriteLine(complexNumber1.ToString());
            Console.Out.WriteLine(complexNumber2.ToString());
            Console.Out.WriteLine("<++++>");

            
            ComplexNumber sumOfNums =
                complexNumber1.SumComplexNumber(complexNumber2);
            Console.Out.WriteLine("Сумма = {0}",sumOfNums.ToString());
            ComplexNumber difOfNums =
                complexNumber1.SubstractComplexNumber(complexNumber2);
            Console.Out.WriteLine("Разность = {0}", difOfNums.ToString());
            ComplexNumber multOfNums =
                complexNumber1.MutiplicationComplexNumbers(complexNumber2);
            Console.Out.WriteLine("Произведение = {0}", multOfNums.ToString());
            ComplexNumber divOfNums =
                complexNumber1.DivisionComplexNumbers(complexNumber2);
            Console.Out.WriteLine("Деление = {0}", divOfNums.ToString());



        }
    }
}
