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

namespace UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ComponentLabel : UserControl
    {
 

        public ComponentLabel()
        {
            InitializeComponent();

        }

        #region menu Events 
        private void TestControl_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Add logic...
        }

        // or

        private void TestControl_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Add logic...
        }

        // or

        private void TestControl_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Add logic...
        }
        #endregion
        //-------------------------------------------------------------------------------



        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public double UserControlToolTipX
        {
            get { return this.UserControlToolTipXY.X; }
            set { this.UserControlToolTipXY.X = value; }
        }

        public double UserControlToolTipY
        {
            get { return this.UserControlToolTipXY.Y; }
            set { this.UserControlToolTipXY.Y = value; }
        }

        

        public string UserControlToolTipTitle
        {
            get { return ToolTipTitle.Text; }
            set { ToolTipTitle.Text = value; }
        }

        public event RoutedEventHandler MenuEventClick1;
        public event RoutedEventHandler MenuEventClick2;
        public event RoutedEventHandler MenuEventClick3;

        private void Menu1_Click(object sender, RoutedEventArgs e)
        {
            if (MenuEventClick1 != null)
            {
                MenuEventClick1(this, new RoutedEventArgs());
            }
        }


        private void Menu2_Click(object sender, RoutedEventArgs e)
        {
            if (MenuEventClick2 != null)
            {
                MenuEventClick2(this, new RoutedEventArgs());
            }
        }
        private void Menu3_Click(object sender, RoutedEventArgs e)
        {
            if (MenuEventClick3 != null)
            {
                MenuEventClick3(this, new RoutedEventArgs());
            }
        }

        public event RoutedEventHandler CustomClick;
        private void TheClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomClick != null)
            {
                CustomClick(this, new RoutedEventArgs());
            }
        }
    }
}
