using GymLog.ViewModel;
using System.Windows;

namespace GymLog.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseViewModel viewModel = new BaseViewModel();
            DataContext = viewModel;
        }
    }
}