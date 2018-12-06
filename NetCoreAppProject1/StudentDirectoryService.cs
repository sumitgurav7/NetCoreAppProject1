using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAppProject1.Interface;

namespace NetCoreAppProject1
{
   

    public class StudentDirectoryService : IStudentDirectoryServiceInterface
    {
        private IDisplayAll displayAll = DisplayStudent.DisplayInstance;
        private IDisplayOne displayOne = DisplayIndividualStudent.DisplayIndividualStudentInstance;
        int choice;

        IDisplayAll DisplayAll { get => displayAll; set => displayAll = value; }
        IDisplayOne DisplayOne { get => displayOne; set => displayOne = value; }
        public int Choice { get => choice; set => choice = value; }

        public void startApp()
        {
            
           StudentOptions displayStudent = new StudentOptions(DisplayAll, DisplayOne);

            Console.WriteLine("Counting");
            Console.WriteLine(displayStudent.CountStudents());

            do
            {
                if (choice == 0)
                {
                    Console.WriteLine("Welcome to student Directory");
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Enter 1 for displaying data \n" +
                        "Enter 2 for Retriving data by id \n" +
                        "Enter 3 for Updating Data ");

                    if (int.TryParse(Console.ReadLine(), out choice))
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
                            Console.WriteLine("Id : " + student.Id + " Name : " + student.name + " Age: " + student.Age + " Address: " + student.Address);
                        }
                        Choice = 0;
                        break;

                    case 2:
                        Console.WriteLine("Enter ID to Retrive Data");
                        Console.WriteLine();
                        int ID;
                        if (int.TryParse(Console.ReadLine(), out ID))
                        {
                            Student student=displayStudent.DisplayStudentById(ID);
                            Console.WriteLine("Id : " + student.Id + " Name : " + student.name + " Age: " + student.Age + " Address: " + student.Address);

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
