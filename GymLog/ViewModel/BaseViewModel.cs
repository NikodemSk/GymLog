using GymLog.Model;
using System.IO;

namespace GymLog.ViewModel
{
    public class BaseViewModel : PropertyChange
    {
        private string exercises;
        public string Exercises { get { return exercises; } set { SetField("Exercises", ref exercises, value); } }
        public RelayCommand Test => new RelayCommand(execute => ExercisesList());

        public Logger LoggerInstance { get; set; }

        public BaseViewModel()
        {
            LoggerInstance = Logger.GetInstance();
        }

        public void ExercisesList()
        {
            try
            {
                using StreamReader streamReader = new StreamReader("Exercises.txt");
                streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Logger.GetInstance().WritelineException(ex);
            }
        }
    }
}
