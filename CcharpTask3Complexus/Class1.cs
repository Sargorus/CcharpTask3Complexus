
namespace CcharpTask3Complexus
{
    /*
    Комплексное число

    сложение
     вычитание
      умножение
       деление двух комплексных чисел
         сравнение (как сравнение векторов соотвествующих комплексному числу)
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
            return String.Format("Вещественная часть {0}, Мнимая {1}", this.realValueA, realValueB);
        }
    }

}
