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

namespace TestCustomComponent
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

        private void OnCustomButtonClick(object sender, RoutedEventArgs e)
        {

            int a = 10;//do something ...
            ((UserControls.ComponentLabel)sender).Visibility = Visibility.Hidden;
        }

        #region menus
        private void OnCustomButtonClick1(object sender, RoutedEventArgs e)
        {
            var customerID = ((UserControls.ComponentLabel)sender).CustomerID;
            var customerName = ((UserControls.ComponentLabel)sender).CustomerName;
            //TODO: for test 

            var text = String.Format("ID {0}, Name :  {1}", customerID, customerName);
            MessageBox.Show(text, "caption", MessageBoxButton.OK);
        }


        private void OnCustomButtonClick2(object sender, RoutedEventArgs e)
        {

            int a = 14;//do something ...
        }

        private void OnCustomButtonClick3(object sender, RoutedEventArgs e)
        {

            int a = 16;//do something ...
        }

        #endregion
    }
}
