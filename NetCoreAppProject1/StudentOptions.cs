using NetCoreAppProject1.Interface;
using System.Collections.Generic;

namespace NetCoreAppProject1
{
    public class StudentOptions
    {
        private IDisplayAll displayAll;
        private IDisplayOne displayOne;

        public StudentOptions(IDisplayAll displayAll, IDisplayOne displayOne)
        {
            this.displayAll = displayAll;
            this.displayOne = displayOne;
        }

        public List<Student> DisplayAllStudents()
        {
            return displayAll.DisplayAllStudent();
        }

        public Student DisplayStudentById( int ID)
        {
            return displayOne.DisplaySTudentById(ID);
        }

        public int CountStudents()
        {
            return displayAll.CountElements();
        }
    }
}