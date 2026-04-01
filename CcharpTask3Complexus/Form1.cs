namespace CcharpTask3Complexus
{
    public partial class Form1 : Form
    {
        // добавили функцию для рассчета
        private void Calculate()
        {
            try
            {
                var aRealValue = double.Parse(textRealValueA.Text);
                var aImaginaryValue = double.Parse(textImaginaryValueA.Text);

                var bRealValue = double.Parse(textRealValueB.Text);
                var bImaginaryValue = double.Parse(textImaginaryValueB.Text);

                var firstComplex = new ComplexNumberDouble(aRealValue, aImaginaryValue);
                var secondComplex = new ComplexNumberDouble(bRealValue, bImaginaryValue);

                ComplexNumberDouble result = new ComplexNumberDouble(0, 0);
                string resultmsg = "";
                var flagMsg = false;
                switch (cmdOperator.Text)
                {
                    case "+":
                        // если плюсик выбрали, то складываем
                        result = firstComplex + secondComplex;
                        break;
                    case "-":
                        result = firstComplex - secondComplex;
                        break;
                    case "*":
                        result = firstComplex * secondComplex;
                        break;
                    case "/":
                        result = firstComplex / secondComplex;
                        break;
                    case "=":
                        // если минус, то вычитаем
                        if (firstComplex.ComplexСomparisonEquality(secondComplex))
                        {
                            resultmsg = "Равны";
                        }
                        else
                        {
                            resultmsg = "Не равны";
                        }
                        flagMsg = true;
                        break;
                    default:
                        // а если что-то другое, то просто 0 выводим,
                        // такое маловероятно, но надо указать иначе не скомпилится
                        flagMsg = true;
                        resultmsg = "Нет оператора";
                        break;
                }
                if (flagMsg)
                {
                    textResult.Text = resultmsg;
                }
                else
                {
                    textResult.Text = result.ToString();
                }

            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textRealValueA_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textImaginaryValueA_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textRealValueB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textImaginaryValueB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmdOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

    }
}
