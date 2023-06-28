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
using TheWpfApp.Models;
using TheWpfApp.ViewModels;

namespace TheWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel=new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            //PersonalInfo Info = new PersonalInfo("סרגיי", "המגניב", "0545558745");
            DataContext = viewModel;
            
            // MVVM
            // M - Models :class
            // V - View : UI
            // VM View Models : class
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Info = new PersonalInfo("Sergey","Vinhorn");
            viewModel.Info.FName = "Avisar";
           
        }

        private void TBAge_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {

                int age_value = int.Parse(TBAge.Text);
                if (age_value < 0 || age_value < 18)
                {
                    TBAge.Background = Brushes.Red;
                }
                else
                {
                    TBAge.Background = Brushes.White;
                }
            }
            catch
            {

            }
        }

        private void TBEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TBEmail.Text.Contains('@')==false || TBEmail.Text.Contains('.') == false || TBEmail.Text.IndexOf('@')>TBEmail.Text.LastIndexOf('.')) // =into  ==equal
            {
                TBEmail.Background = Brushes.Red;
            }
            else
            {
                TBEmail.Background = Brushes.White;
            }
        }
    }
}
