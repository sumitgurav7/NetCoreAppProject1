using NetCoreAppProject1.Interface;
using System;

namespace NetCoreAppProject1
{


    public class StudentDirectoryService : IStudentDirectoryServiceInterface
    {
        private IDisplayAll _displayAll = DisplayStudent.DisplayInstance;
        private IDisplayOne _displayOne = DisplayIndividualStudent.DisplayIndividualStudentInstance;
        int _choice;

        IDisplayAll DisplayAll { get => _displayAll;}
        IDisplayOne DisplayOne { get => _displayOne;}
        public int Choice { get => _choice; set => _choice = value; }

        public void StartApp()
        {
            
           StudentOptions displayStudent = new StudentOptions(DisplayAll, DisplayOne);

            Console.WriteLine("Counting");
            Console.WriteLine(displayStudent.CountStudents());

            do
            {
                if (_choice == 0)
                {
                    Console.WriteLine("Welcome to student Directory");
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Enter 1 for displaying data \n" +
                        "Enter 2 for Retrieving data by id \n" +
                        "Enter 3 for Updating Data ");

                    if (int.TryParse(Console.ReadLine(), out _choice))
                    {
                        Console.WriteLine("you have selected choice " + Choice);
                    }
                    else
                    {
                        Choice = 7;
                    } 
                }

                switch (Choice)
                {
                    case 1:
                        foreach(Student student in displayStudent.DisplayAllStudents())
                        {
                            Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " Age: " + student.Age + " Address: " + student.Address);
                        }
                        Choice = 0;
                        break;

                    case 2:
                        Console.WriteLine("Enter ID to Retrieve Data");
                        Console.WriteLine();
                        int id;
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
                            Student student=displayStudent.DisplayStudentById(id);
                            Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " Age: " + student.Age + " Address: " + student.Address);

                            Choice = 0;
                        }
                        else
                        {
                            Console.WriteLine("Please enter proper input");
                            Choice = 0;
                        }

                        break;


                    default:
                        Console.WriteLine("sorry this functionality is yet to develop");
                        break;
                } 
            } while (Choice !=0);
            Console.ReadKey();
        }
    }
}
