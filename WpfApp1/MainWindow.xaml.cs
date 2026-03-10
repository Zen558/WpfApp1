using System;
using System.Windows;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private bool TryGetNumbers(out double first, out double second)
        {
            first = 0;
            second = 0;


            if (!double.TryParse(FirstNumberTextBox.Text, out first))
            {
                MessageBox.Show("Введите корректное первое число!",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return false;
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out second))
            {
                MessageBox.Show("Введите корректное второе число!",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return false;
            }

            return true;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first + second;
                ResultTextBox.Text = result.ToString();
            }
        }


        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first - second;
                ResultTextBox.Text = result.ToString();
            }
        }


        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first * second;
                ResultTextBox.Text = result.ToString();
            }
        }


        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                if (second == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно!",
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                    return;
                }

                double result = first / second;
                ResultTextBox.Text = result.ToString();
            }
        }


        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = Math.Pow(first, second);
                ResultTextBox.Text = result.ToString();
            }
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumberTextBox.Text = string.Empty;
            SecondNumberTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            FirstNumberTextBox.Focus();
        }
    }
}