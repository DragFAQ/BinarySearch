using BinarySearch.Controller;
using BinarySearch.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Xml.Xsl;

namespace BinarySearch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // TODO : Learn how to use DI here
        SearchController controller;

        public MainWindow()
        {
            InitializeComponent();
            // TODO : Learn how to use DI here
            controller = new SearchController();
        }

        public string TransformXMLToHTML(string inputXml, string xsltFileName)
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(xsltFileName))
            {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(inputXml)))
            {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] separators = { ",", " " };
            string[] strArray = tbArray.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = Array.ConvertAll(strArray, s => int.Parse(s));

            Search entity = new Search(intArray, int.Parse(tbValue.Text));

            string resultObj = controller.searchIndexByValue(entity).GetAsString();

            webBrowser.NavigateToString(TransformXMLToHTML(resultObj, "..\\..\\Resources\\Example.xslt"));
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
