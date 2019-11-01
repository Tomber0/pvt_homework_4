using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_homework_4
{



    class ComplexNumber
    {
        double realPart;
        double imaginaryPart;
        ComplexNumber(double newRealPart, double newImaginaryPart) {
            this.realPart = newRealPart;
            this.imaginaryPart = newImaginaryPart;
        }
        ComplexNumber(int newRealPart, int newImaginaryPart)
        {
            this.realPart = newRealPart;
            this.imaginaryPart = newImaginaryPart;
        }
        public override string ToString()
        {
            string complexNumber;
            if (imaginaryPart <= 0)
            {
                if(imaginaryPart < 0)
                complexNumber = Convert.ToString(this.realPart) + " " + Convert.ToString(this.imaginaryPart) + " * i";
                else
                    complexNumber = Convert.ToString(this.realPart);

            }
            else{

                complexNumber = Convert.ToString(this.realPart) + " + " + Convert.ToString(this.imaginaryPart) + " * i";
            }
            return complexNumber;
        }
        static public ComplexNumber SumComplexNumbers(ComplexNumber complexNumberFirst,ComplexNumber complexNumberSecond) {
            double newImagPart;
            double newRealPart;
            newImagPart = complexNumberFirst.imaginaryPart + complexNumberSecond.imaginaryPart;
            newRealPart = complexNumberFirst.realPart + complexNumberSecond.realPart;
            ComplexNumber resultOfSumComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSumComplexNumber;

        }
        static public ComplexNumber SubstractComplexNumbers(ComplexNumber complexNumberFirst, ComplexNumber complexNumberSecond)
        {
            double newImagPart;
            double newRealPart;
            newImagPart = complexNumberFirst.imaginaryPart - complexNumberSecond.imaginaryPart;
            newRealPart = complexNumberFirst.realPart - complexNumberSecond.realPart;
            ComplexNumber resultOfSubstrationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfSubstrationComplexNumber;

        }
        static public ComplexNumber MutiplicationComplexNumbers(ComplexNumber complexNumberFirst, ComplexNumber complexNumberSecond)
        {
            double newImagPart;
            double newRealPart;
            //x+y*i = Z; u+v*i = C
            //рез выпажение состоит из 2 частей: realpart = .(x*u - y*v) + ImgPart = .(x*v + y*u)*i

            newRealPart = complexNumberFirst.realPart * complexNumberSecond.realPart - 
                            complexNumberFirst.imaginaryPart * complexNumberSecond.imaginaryPart;
            newImagPart = complexNumberFirst.realPart * complexNumberSecond.imaginaryPart +
                            complexNumberFirst.realPart * complexNumberSecond.imaginaryPart;

            ComplexNumber resultOfMutiplicationComplexNumber = new ComplexNumber(newRealPart, newImagPart);
            return resultOfMutiplicationComplexNumber;

        }
        static public ComplexNumber DivisionComplexNumbers(ComplexNumber complexNumberNumerator, ComplexNumber complexNumberDenominator)
        {

            //деление: 1/(x^2 + y^2) *  (операция умножения:)((u*x + v*y) + (v*x - u*)*i)
            //
            double newImagPart;
            double newRealPart;

            double newDenominatorPart ;
            ComplexNumber newInterimMuliplResult = ComplexNumber.MutiplicationComplexNumbers(complexNumberNumerator, complexNumberDenominator);
            //создание промежуточного компексного числа - являющегося результатом множения 2 данных числел

            //x+y*i = Z; u+v*i = C
            //рез выпажение состоит из 2 частей: realpart = .(x*u - y*v) + ImgPart = .(x*v + y*u)*i

            newDenominatorPart = (Math.Pow(complexNumberNumerator.realPart, 2) + Math.Pow(complexNumberNumerator.imaginaryPart, 2));
            double resultRealPart = newInterimMuliplResult.realPart / newDenominatorPart;
            double resultImagPart = newInterimMuliplResult.imaginaryPart / newDenominatorPart;

            ComplexNumber resultOfDivisionComplexNumber = new ComplexNumber(resultRealPart, resultImagPart);

            return resultOfDivisionComplexNumber;

        }
    }
}
