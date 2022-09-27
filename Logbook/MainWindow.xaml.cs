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

namespace Logbook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int dimondsAvailable = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstDimond_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch(cb.Name)
            {
                case "FirstDimond":
                    dimondsAvailable--; break;
                case "SecondDimond":
                    if (!(bool)FirstDimond.IsChecked)
                    {
                        //dimondsAvailable--;
                        FirstDimond.IsChecked = true;
                    }
                    dimondsAvailable--;
                    break;
                case "ThirdDimond":
                    if (!(bool)FirstDimond.IsChecked)
                    {
                        //dimondsAvailable--;
                        FirstDimond.IsChecked = true;
                    }
                    if(!(bool)SecondDimond.IsChecked)
                    { 
                        //dimondsAvailable--;
                        SecondDimond.IsChecked = true;
                    }
                    dimondsAvailable--; break;
            }
            DimondsAv.Text = dimondsAvailable.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Present.IsChecked = true;
        }
    }
}
