using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NetCoreAppProject1.Interface;



namespace NetCoreAppProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IStudentDirectoryServiceInterface students = new StudentDirectoryService();
            
            students.startApp();
        }
    }
}
