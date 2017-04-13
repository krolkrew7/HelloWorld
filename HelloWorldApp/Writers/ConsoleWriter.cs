using System.IO;

namespace HelloWorldApp.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            string messageToPrint = string.Format("Message from API: [{0}]", message);
            System.Console.WriteLine(messageToPrint);
        }
    }
}
