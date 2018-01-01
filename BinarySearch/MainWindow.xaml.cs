using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BinarySearch
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] separators = { ",", " " };
            string[] strArray = tbArray.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = Array.ConvertAll(strArray, s => int.Parse(s));

            int result = Search.SearchItem(intArray, int.Parse(tbValue.Text));
            System.Windows.MessageBox.Show(Convert.ToString(result));
        }

        private void NumberValidationTextBox(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d.]", "");
            ((TextBox)sender).Text = s;
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            var keyEnum = (System.Windows.Input.Key)e.Key;

            e.Handled = !(keyEnum >= System.Windows.Input.Key.D0 && keyEnum <= System.Windows.Input.Key.D9 ||
                keyEnum >= System.Windows.Input.Key.NumPad0 && keyEnum <= System.Windows.Input.Key.NumPad9 ||
                keyEnum == System.Windows.Input.Key.Back || keyEnum == System.Windows.Input.Key.OemComma);
        }
    }
}
