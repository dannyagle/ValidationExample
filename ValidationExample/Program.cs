using System;
using ValidationExample.Engines;
using ValidationExample.Models;

namespace ValidationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Thingy Processor!");
            Console.WriteLine();

            var incoming = new Incoming
            {
                Workflow = "Good",
                FirstName = "Joe",
                LastName = "Coolio",
                Nickname = "Joey",
                BirthDate = "01/31/1980"
            };

            try
            {
                var widgetProcessor = new WidgetProcessor();
                widgetProcessor.Process(incoming);
                Console.WriteLine("All good in Widget!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                var megaProcessor = new MegaProcessor();
                megaProcessor.Process(incoming);
                Console.WriteLine("All good in Mega!");
            }
            catch (FluentValidation.ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
