
namespace CcharpTask3Complexus
{
    /*
    Комплексное число

    сложение
     вычитание
      умножение
       деление двух комплексных чисел
         сравнение (как сравнение векторов соотвествующих комплексному числу)

    справка:
    (два комплексных числа равны между собой тогда и только тогда, когда равны их вещественные и мнимые части).

    */
    public class ComplexNumberDouble
    {
        // a + b * i
        private double realValueA;
        private double realValueB;

        public ComplexNumberDouble(double realValueA, double realValueB)
        {
            this.realValueA = realValueA;
            this.realValueB = realValueB;
        }

        public string ToString()
        {
            return String.Format("Вещественная часть {0}, Мнимая {1}", this.realValueA, realValueB);
        }

        public bool ComplexСomparisonEquality(ComplexNumberDouble b)
        {
            if (this.realValueA == b.realValueA)
            {
                if (this.realValueB == b.realValueB)
                {
                    return true;
                }
            }
            return false;
        }

        public static ComplexNumberDouble operator +(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            var newValueA = a.realValueA + b.realValueA;
            var newValueB = a.realValueB + b.realValueB;

            var complexNumberDoubleReturn = new ComplexNumberDouble(newValueA, newValueB);

            return complexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, int b)
        {

            var complexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return complexNumberDoubleReturn;
        }

        public static ComplexNumberDouble operator +(int a, ComplexNumberDouble b)
        {

            var complexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return complexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, float b)
        {

            var complexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return complexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator +(float a, ComplexNumberDouble b)
        {

            var complexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return complexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, double b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return ComplexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator +(double a, ComplexNumberDouble b)
        {

            var complexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return complexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator -(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            b.realValueA *= -1;
            b.realValueB *= -1;
            return a + b;
        }

        public static ComplexNumberDouble operator -(ComplexNumberDouble a, int b)
        {
            a.realValueA -= b;
            return a;
        }
        public static ComplexNumberDouble operator -(int a, ComplexNumberDouble b)
        {
            b.realValueA = a - b.realValueA;
            return b;
        }

        public static ComplexNumberDouble operator -(ComplexNumberDouble a, float b)
        {
            a.realValueA -= b;
            return a;
        }
        public static ComplexNumberDouble operator -(float a, ComplexNumberDouble b)
        {
            b.realValueA = a - b.realValueA;
            return b;
        }

        public static ComplexNumberDouble operator -(ComplexNumberDouble a, double b)
        {
            a.realValueA -= b;
            return a;
        }
        public static ComplexNumberDouble operator -(double a, ComplexNumberDouble b)
        {
            b.realValueA = a - b.realValueA;
            return b;
        }


        public static ComplexNumberDouble operator *(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            var realProduct = (a.realValueA * b.realValueA) - (a.realValueB * b.realValueB);
            var imaginaryProduct = ((a.realValueB * b.realValueA) + (a.realValueA * b.realValueB));

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }

        public static ComplexNumberDouble operator *(ComplexNumberDouble a, int b)
        {
            var realProduct = (a.realValueA * b);
            var imaginaryProduct = (a.realValueB * b);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator *(int a, ComplexNumberDouble b)
        {
            var realProduct = (b.realValueA * a);
            var imaginaryProduct = (b.realValueB * a);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }

        public static ComplexNumberDouble operator *(ComplexNumberDouble a, float b)
        {
            var realProduct = (a.realValueA * b);
            var imaginaryProduct = (a.realValueB * b);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator *(float a, ComplexNumberDouble b)
        {
            var realProduct = (b.realValueA * a);
            var imaginaryProduct = (b.realValueB * a);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }

        public static ComplexNumberDouble operator *(ComplexNumberDouble a, double b)
        {
            var realProduct = (a.realValueA * b);
            var imaginaryProduct = (a.realValueB * b);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator *(double a, ComplexNumberDouble b)
        {
            var realProduct = (b.realValueA * a);
            var imaginaryProduct = (b.realValueB * a);

            var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);
            return complexNumberDoubleReturn;
        }



        public static ComplexNumberDouble operator /(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            if (b.realValueA != 0 || b.realValueB != 0)
            {
                var realProduct = ((a.realValueA * b.realValueA) + (a.realValueB * b.realValueB)) / (b.realValueA * b.realValueA + b.realValueB * b.realValueB);
                var imaginaryProduct = ((a.realValueB * b.realValueA) - (a.realValueA * b.realValueB)) / (b.realValueA * b.realValueA + b.realValueB * b.realValueB);

                

                var complexNumberDoubleReturn = new ComplexNumberDouble(realProduct, imaginaryProduct);

                return complexNumberDoubleReturn;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(ComplexNumberDouble a, int b)
        {
            if (b != 0)
            {

                var complexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA / b, a.realValueB);
                return complexNumberDoubleReturn;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(ComplexNumberDouble a, float b)
        {
            if (b != 0)
            {

                var complexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA / b, a.realValueB);
                return complexNumberDoubleReturn;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(ComplexNumberDouble a, double b)
        {
            if (b != 0)
            {

                var complexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA / b, a.realValueB);
                return complexNumberDoubleReturn;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(int a, ComplexNumberDouble b)
        {
            if (a != 0)
            {
                var complexA = new ComplexNumberDouble(a, 0);
                return complexA / b;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(float a, ComplexNumberDouble b)
        {
            if (a != 0)
            {
                var complexA = new ComplexNumberDouble(a, 0);
                return complexA / b;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public static ComplexNumberDouble operator /(double a, ComplexNumberDouble b)
        {
            if (a != 0)
            {
                var complexA = new ComplexNumberDouble(a, 0);
                return complexA / b;
            }
            // var complexNumberDoubleReturnZero = new ComplexNumberDouble(0, 0);
            // return complexNumberDoubleReturnZero;
            throw new NotImplementedException();// ide само предложило объект исключения
            // Тут либо исключение бросать (вроде так правильно) либо, как я сейчас сделал оставлять нулевыми
        }

        public override bool Equals(object? obj)
        {
            if (obj is ComplexNumberDouble other)
            {
                return realValueA == other.realValueA && realValueB == other.realValueB;
            }
            return false;
        }


    }

}
