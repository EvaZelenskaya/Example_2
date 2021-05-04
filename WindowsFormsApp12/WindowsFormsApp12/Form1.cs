using System;

using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public interface IStrategy
    {
        void Algorithm(string s);
    }
    public partial class Form1 : Form
    {
        Context context;
        public Form1()
        {
            InitializeComponent();
            context = new Context(new ConcreteStartegy1());
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            if (number_radioButton.Checked)
                context.SetStrategy(new ConcreteStartegy1());
            else if (lower_radioButton.Checked)
                context.SetStrategy(new ConcreteStartegy2());
            else if (char_radioButton.Checked)
                context.SetStrategy(new ConcreteStartegy4());
            else  
                context.SetStrategy(new ConcreteStartegy3());

            context.ExecuteOperation(input_TextBox.Text);
        }
        

    }
    public class ConcreteStartegy1 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        MessageBox.Show("Введенная строка - НЕ число!!!");
                        return;
                    }

                }
                MessageBox.Show("Верно");
            }

        }
    }

    public class ConcreteStartegy2 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if (!(c >= 'a' && c <= 'z'|| c == 'ё' || c >= 'а' && c <= 'я'))

                    {
                        MessageBox.Show("Введенная строка - НЕ в нижнем регистре!!!");
                        return;
                    }

                }
                MessageBox.Show("Верно");
            }

        }
    }

    public class ConcreteStartegy3 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if (!(c >= 'A' && c <= 'Z' || c == 'Ё' || c >= 'А' && c <= 'Я'))

                    {
                        MessageBox.Show("Введенная строка - НЕ в верхнем регистре!!!");
                        return;
                    }

                }
                MessageBox.Show("Верно");
            }

        }
    }


    public class ConcreteStartegy4 : IStrategy // СПЕЦ ЗНАКИ
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if ((Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                    //относится к символ Юникода к категории букв или десятичных цифр.
                    //относится ли указанный символ Юникода к категории пробелов.


                    {
                        MessageBox.Show("Введенная строка - НЕ из спецсимволов!!!");
                        return;
                    }

                }
                MessageBox.Show("Верно");
            }

        }
    }
    public class Context
    {
        private IStrategy _strategy;

        public Context (IStrategy strategy)
        {

            _strategy = strategy;
        }
         public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecuteOperation(string s)
        {
            _strategy.Algorithm(s);
        }

    }






}
