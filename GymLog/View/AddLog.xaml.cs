using GymLog.ViewModel;
using System.Windows.Controls;

namespace GymLog.View
{
    public partial class AddLog : UserControl
    {
        public AddLog()
        {
            InitializeComponent();
            AddLogViewModel aLg = new AddLogViewModel();
            DataContext = aLg;
        }
    }
}
