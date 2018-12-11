using NetCoreAppProject1.Interface;
using System;



namespace NetCoreAppProject1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            IStudentDirectoryServiceInterface students = new StudentDirectoryService();
            
            students.StartApp();
        }
    }
}
