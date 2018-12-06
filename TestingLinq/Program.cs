using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreAppProject1;
using NetCoreAppProject1.Interface;

namespace TestingLinq
{
    class Program
    {
        private IDisplayAll displayAll = DisplayStudent.DisplayInstance;
        private IDisplayOne displayOne = DisplayIndividualStudent.DisplayIndividualStudentInstance;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.getAllStudent();


            Console.ReadKey();
        }

        private void getAllStudent()
        {
            StudentOptions studentOptions = new StudentOptions(displayAll, displayOne);
            List<Student> students = studentOptions.DisplayAllStudents();

            Console.WriteLine("Student who are younger than 25 years");
            IEnumerable<Student> studentsWithAGe25 = from student in students
                                                     where student.Age < 25
                                                     orderby student.Age
                                                     select student;

            
            foreach(Student st in studentsWithAGe25)
            {
                Console.WriteLine("name " + st.name + " Age: " + st.Age);
            }
        }
    }
}
