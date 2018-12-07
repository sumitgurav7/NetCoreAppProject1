using System;
using NetCoreAppProject1;

namespace TestingFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StudentDirectoryService studentDirectoryService = new StudentDirectoryService();
            studentDirectoryService.Choice = 2;
            studentDirectoryService.StartApp();
        }
    }
}
