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
using CefSharp;
using CefSharp.Wpf;

namespace ceftest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ChromiumWebBrowser cefWindow = new ChromiumWebBrowser();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button; // Get the button that triggered the event

            if (button?.Tag is string url && !string.IsNullOrEmpty(url))
            {
                cefWindow.Address = url; // Set URL from button Tag

                DemoGrid.Children.Clear();
                DemoGrid.Children.Add(cefWindow);
            }
            else
            {
                Console.WriteLine("Button or URL not defined.");
            }
        }
    }
}
