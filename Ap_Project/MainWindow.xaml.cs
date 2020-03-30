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

namespace Ap_Project
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            ResetButton_Click(sender, e);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            FirstCheckBox.IsChecked = SecondCheckBox.IsChecked = ThirdCheckBox.IsChecked = FourthCheckBox.IsChecked = FivethCheckBox.IsChecked = SixthCheckBox.IsChecked = false;
            FirstPageBox.Text = "";
            NameBox.Text = FamilyBox.Text = AgeBox.Text = EquationBox.Text = null;
        }

        private void NextpageButton_Click(object sender, RoutedEventArgs e)
        {
            Maintab.SelectedIndex = 1;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            ((CheckBox)sender).FontWeight = FontWeights.Bold;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ((CheckBox)sender).FontWeight = FontWeights.Regular;
        }

        private void AgeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AgeError.Visibility = Visibility.Hidden;
            var x = ((TextBox)sender).Text;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != '0' && x[i] != '1' && x[i] != '2' && x[i] != '3' && x[i] != '4' && x[i] != '5' && x[i] != '6' && x[i] != '7' && x[i] != '8' && x[i] != '9')
                {
                    ((TextBox)sender).Foreground = Brushes.Red;
                    AgeError.Visibility = Visibility.Visible;
                    return;
                }

                else
                {
                    ((TextBox)sender).Foreground = Brushes.Black;
                    AgeError.Visibility = Visibility.Hidden;
                }
                
                
                
                
            }
            

        }
    }
}
