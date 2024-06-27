using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AverageCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var numbers = NumbersInput.Text.Split(',')
                                 .Select(int.Parse)
                                 .ToList();

                if (numbers.Count <= 3)
                {
                    ResultTextBlock.Text = "Список должен содержать больше 3 элементов.";
                    return;
                }

                numbers.RemoveAt(2);
                numbers.RemoveAt(1);
                double average = numbers.Average();

                ResultTextBlock.Text = $"Среднее арифметическое (без 2-го и 3-го элементов): {average}";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
