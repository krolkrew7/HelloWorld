using System;
using Microsoft.Owin.Hosting;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = System.Configuration.ConfigurationManager.AppSettings["Api.Base.Address"];

            // Start OWIN host 
            using (WebApp.Start<ApiStartup>(url: baseAddress))
            {
                Console.WriteLine("Press [Enter] to quit.");
                Console.ReadLine();
                Console.WriteLine("GoodBye");
            }
        }
    }
}
