
using BLL;
using BLL.Abstract;
using BLL.Concrete;
using DAL.Entities;
using DAL.Reposotories.SQL;
using Microsoft.Win32;
using System;
using System.Windows;
using TournametGenerator.DAL.DB;
using System.Linq;

namespace Competitors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  

        public MainWindow()
        {
            InitializeComponent();

            using (var db = new TournamentContext())
            {

                var artists = db.Categories.ToList();
                int a = 10;
            }

        
            IPageManager pageManager = new PageManager();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == true)
            {
                var res =  pageManager.ImportFromExcel(openFileDialog.FileName);


            }

         

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
