using NetCoreAppProject1.Interface;
using System.Collections.Generic;

namespace NetCoreAppProject1
{
    public class StudentOptions
    {
        private IDisplayAll _displayAll;
        private IDisplayOne _displayOne;

        public StudentOptions(IDisplayAll displayAll, IDisplayOne displayOne)
        {
            _displayAll = displayAll;
            _displayOne = displayOne;
        }

        public List<Student> DisplayAllStudents()
        {
            return _displayAll.DisplayAllStudent();
        }

        public Student DisplayStudentById( int id)
        {
            return _displayOne.DisplaySTudentById(id);
        }

        public int CountStudents()
        {
            return _displayAll.CountElements();
        }
    }
}