using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                // конвертируем строку из компонента TextBox в вещественный тип
                double x = Convert.ToDouble(TbNumberX.Text);
                TextBlockAnswer.Text = $" Точка {x:n2} {CheckNumberX(x)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }


        public static string CheckNumberX(double x)
        {
            if ((-3 <= x && x <= 3) || (9 <= x && x <= 15))
                return "принадлежит";
            else
                return "не принадлежит";
        }
    }
}
