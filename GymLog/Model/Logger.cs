namespace GymLog.Model
{
    public class Logger : PropertyChange
    {
        private string logs;
        private Logger()
        {

        }
        private static readonly Logger Instance = new Logger();

        public string Logs { get { return logs; } set { SetField("Logs", ref logs, value); } }


        public static Logger GetInstance()
        {
            return Instance;
        }
        public void WritelineException(Exception message)
        {
            Logs += message + Environment.NewLine + "-------------------------------";
        }
        public void Writeline(string message)
        {
            Logs += Environment.NewLine + message + "-------------------------------";
        }
    }
}
