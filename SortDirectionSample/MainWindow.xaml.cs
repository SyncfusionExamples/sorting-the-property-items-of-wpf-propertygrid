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

namespace SortDirectionSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ascending.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if(radioButton != null && radioButton.IsChecked.Value)
            {
                if (radioButton.Content.ToString() == "Ascending")
                    pgrid.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
                else if (radioButton.Content.ToString() == "Descending")
                    pgrid.SortDirection = System.ComponentModel.ListSortDirection.Descending;
                else
                    pgrid.SortDirection = null;
            }
        }
    }
}
