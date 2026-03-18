
namespace CcharpTask3Complexus
{
    /*
     омплексное число

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

        public string ComplexNumberDoubleToString()
        {
            return String.Format("¬ещественна€ часть {0}, ћнима€ {1}", this.realValueA, realValueB);
        }

        public static ComplexNumberDouble operator +(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            var newValueA = a.realValueA + b.realValueA;
            var newValueB = a.realValueB + b.realValueB;

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(newValueA, newValueB);

            return ComplexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, int b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return ComplexNumberDoubleReturn;
        }

        public static ComplexNumberDouble operator +(int a, ComplexNumberDouble b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return ComplexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, float b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return ComplexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator +(float a, ComplexNumberDouble b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return ComplexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator +(ComplexNumberDouble a, double b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(a.realValueA + b, a.realValueB);
            return ComplexNumberDoubleReturn;
        }
        public static ComplexNumberDouble operator +(double a, ComplexNumberDouble b)
        {

            var ComplexNumberDoubleReturn = new ComplexNumberDouble(b.realValueA + a, b.realValueB);
            return ComplexNumberDoubleReturn;
        }


        public static ComplexNumberDouble operator -(ComplexNumberDouble a, ComplexNumberDouble b)
        {
            b.realValueA *= -1;
            b.realValueB *= -1;

            return a + b;
        }
    }

}
