using GymLog.Model;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Shapes;
namespace GymLog.ViewModel
{
    public class AddLogViewModel : BaseViewModel
    {
        private string kilograms;
        private string numbrOfRepetitions;
        private DateTime? date;
        private string exercise;
        public string NumbrOfRepetitions { get { return numbrOfRepetitions; } set { SetField("NumbrOfRepetitions", ref numbrOfRepetitions, value); } }
        public DateTime? Date { get { return date; } set { SetField("Date", ref date, value); } }
        public RelayCommand ButtonAddLog => new RelayCommand(execute => AddLog(NumbrOfRepetitions, Date, Kilograms, Exercise));
        public string Exercise { get { return exercise; } set { SetField("Exercise", ref exercise, value); } }
        public string Kilograms { get { return kilograms; } set { SetField("Kilograms", ref kilograms, value); } }
        public void AddLog(string NumbrOfRepetitions, DateTime? Date, string Kilograms, string Exercise)
        {
            string Path = "C:\\Users\\Nikodem 4P\\Desktop\\test\\TXTTESTOWY.txt";
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
            if (NumbrOfRepetitions == null || Date == null || Kilograms == null || Exercise == null)
            {
                Logger.GetInstance().Writeline("Wypełnij wszystkie Pola");
            }
            else
            {
                TextWriter tw = new StreamWriter(Path, true);
                tw.WriteLine(Date + " " + Exercise + " " + NumbrOfRepetitions + " " + Kilograms);
                tw.Close();
            }
        }
    }
}
