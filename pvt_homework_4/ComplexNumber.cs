using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_homework_4
{



    class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;
        public double GetImaginaryPart()
        {
            return this.imaginaryPart;
        }
        public double GetRealPart()
        {
            return this.realPart;
        }

        public ComplexNumber(double newRealPart, double newImaginaryPart) {
            this.realPart = newRealPart;
            this.imaginaryPart = newImaginaryPart;
        }
        public  ComplexNumber(int newRealPart, int newImaginaryPart)
        {
            this.realPart = newRealPart;
            this.imaginaryPart = newImaginaryPart;
        }
        static public ComplexNumber SumComplexNumbers(ComplexNumber complexNumberFirst,ComplexNumber complexNumberSecond) {
            //сумма комплексных числел

            double newImagPart;
            double newRealPart;
            newImagPart = complexNumberFirst.imaginaryPart + complexNumberSecond.imaginaryPart;
            newRealPart = complexNumberFirst.realPart + complexNumberSecond.realPart;
            ComplexNumber resultOfSumComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSumComplexNumber;

        }
        static public ComplexNumber SubstractComplexNumbers(ComplexNumber complexNumberFirst, ComplexNumber complexNumberSecond)
        {
            //разность комплексных числел

            double newImagPart;
            double newRealPart;
            newImagPart = complexNumberFirst.imaginaryPart - complexNumberSecond.imaginaryPart;
            newRealPart = complexNumberFirst.realPart - complexNumberSecond.realPart;
            ComplexNumber resultOfSubstrationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSubstrationComplexNumber;

        }
        static public ComplexNumber MutiplicationComplexNumbers(ComplexNumber complexNumberFirst, ComplexNumber complexNumberSecond)
        {
            //произведение комплексных числел

            double newImagPart;
            double newRealPart;
            //x+y*i = Z; u+v*i = C
            //рез выпажение состоит из 2 частей: realpart = .(x*u - y*v) + ImgPart = .(x*v + y*u)*i

            newRealPart = complexNumberFirst.realPart * complexNumberSecond.realPart -
                            complexNumberFirst.imaginaryPart * complexNumberSecond.imaginaryPart;
            newImagPart = complexNumberFirst.realPart * complexNumberSecond.imaginaryPart +
                            complexNumberFirst.imaginaryPart * complexNumberSecond.realPart;

            ComplexNumber resultOfMutiplicationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfMutiplicationComplexNumber;

        }
        static public ComplexNumber DivisionComplexNumbers(ComplexNumber complexNumberNumerator, ComplexNumber complexNumberDenominator)
        {
            //частное комплексных числел
            double newImagPart;
            double newRealPart;


            double newDenominatorPart;

            //x+y*i = Z; u+v*i = C
            //рез выпажение состоит из 2 частей: realpart = .(x*u + y*v) + ImgPart = .(y*u - x*v)*i

            newDenominatorPart = (Math.Pow(complexNumberDenominator.realPart, 2) + Math.Pow(complexNumberDenominator.imaginaryPart, 2));

            newRealPart = (complexNumberNumerator.realPart * complexNumberDenominator.realPart +
                           complexNumberNumerator.imaginaryPart * complexNumberDenominator.imaginaryPart) / newDenominatorPart;
            newImagPart = (complexNumberNumerator.imaginaryPart * complexNumberDenominator.realPart -
                complexNumberNumerator.realPart * complexNumberDenominator.imaginaryPart) / newDenominatorPart;

            ComplexNumber resultOfDivisionComplexNumber = new ComplexNumber(newImagPart, newImagPart);

            return resultOfDivisionComplexNumber;

        }

        public ComplexNumber SumComplexNumber(ComplexNumber complexNumberToSum)
        {
            //сумма комплексных числел

            double newImagPart;
            double newRealPart;
            newImagPart = this.imaginaryPart + complexNumberToSum.imaginaryPart;
            newRealPart = this.realPart + complexNumberToSum.realPart;
            ComplexNumber resultOfSumComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSumComplexNumber;

        }
        public ComplexNumber SubstractComplexNumber(ComplexNumber complexNumberSecond)
        {
            //разность комплексных числел

            double newImagPart;
            double newRealPart;
            newImagPart = this.imaginaryPart - complexNumberSecond.imaginaryPart;
            newRealPart = this.realPart - complexNumberSecond.realPart;
            ComplexNumber resultOfSubstrationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSubstrationComplexNumber;

        }
        public ComplexNumber MutiplicationComplexNumbers(ComplexNumber complexNumberMult)
        {
            //произведение комплексных числел

            double newImagPart;
            double newRealPart;
            //x+y*i = Z; u+v*i = C
            //рез выпажение состоит из 2 частей: realpart = .(x*u - y*v) + ImgPart = .(x*v + y*u)*i

            newRealPart = this.realPart * complexNumberMult.realPart -
                            this.imaginaryPart * complexNumberMult.imaginaryPart;
            newImagPart = this.realPart * complexNumberMult.imaginaryPart +
                            this.imaginaryPart * complexNumberMult.realPart;

            ComplexNumber resultOfMutiplicationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfMutiplicationComplexNumber;

        }
        public ComplexNumber DivisionComplexNumbers(ComplexNumber complexNumberDenominator)
        {
            //частное комплексных числел

            //деление: 1/(x^2 + y^2) *  (операция умножения:)((u*x + v*y) + (v*x - u*)*i)
            //
            double newImagPart;

            double newRealPart;
           

           double newDenominatorPart;
           //x+y*i = Z; u+v*i = C
           //рез выпажение состоит из 2 частей: realpart = .(x*u + y*v) + ImgPart = .(y*u - x*v)*i
           
           newDenominatorPart = (Math.Pow(complexNumberDenominator.realPart, 2) + Math.Pow(complexNumberDenominator.imaginaryPart, 2));

            newImagPart = (this.realPart * complexNumberDenominator.realPart +
                           this.imaginaryPart * complexNumberDenominator.imaginaryPart) / newDenominatorPart;
            newImagPart = (this.imaginaryPart * complexNumberDenominator.realPart - 
                this.realPart * complexNumberDenominator.imaginaryPart) / newDenominatorPart;
           
           ComplexNumber resultOfDivisionComplexNumber = new ComplexNumber(newImagPart, newImagPart);
           
            return resultOfDivisionComplexNumber;

        }
        public override string ToString()
        {
            //вывод числа 
            string complexNumber;
            if (imaginaryPart <= 0)
            {
                if (imaginaryPart < 0)
                    complexNumber = Convert.ToString(this.realPart) + " " + Convert.ToString(this.imaginaryPart) + " * i";
                else
                    complexNumber = Convert.ToString(this.realPart);

            }
            else
            {

                complexNumber = Convert.ToString(this.realPart) + " + " + Convert.ToString(this.imaginaryPart) + " * i";
            }
            return complexNumber;
        }



    }
}
