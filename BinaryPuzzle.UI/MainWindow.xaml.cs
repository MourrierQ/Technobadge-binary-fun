using BinaryPuzzle.UI.ViewModel;
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

namespace BinaryPuzzle.UI
{
   
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if(((Button)sender).Content.ToString() == "0")
            {
                ((Button)sender).Content = "1"; 
                ((Button)sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF8F00"));
            }
            else
            {
                ((Button)sender).Content = "0";
                ((Button)sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2196F3"));
            }
        }
    }
}


