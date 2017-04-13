using HelloWorldApp.Writers;

namespace HelloWorldApp
{
    public class WriterFactory
    {
        private string _output = "";

        public WriterFactory(string outputType = "")
        {
            if (outputType != "")
            {
                _output = outputType;
            }
            else {
                try
                {
                    _output = System.Configuration.ConfigurationManager.AppSettings["Writer.Class"];
                }
                catch
                {
                    _output = "Console";
                }
            }

        }

        public IWriter GetWriter()
        {
            switch (_output)
            {
                case "File":
                    return new FileWriter();
                case "DB":
                    return new DBWriter();
                default:
                    return new ConsoleWriter();
            }
        }
    }
}
