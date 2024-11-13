using GymLog.View;
using GymLog.ViewModel;
using System.Windows;

namespace GymLog
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            BaseViewModel bvm = new BaseViewModel();
            bvm.ExercisesList();
            base.OnStartup(e);
        }
    }
}
