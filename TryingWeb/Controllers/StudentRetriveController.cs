using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAppProject1;
using NetCoreAppProject1.Interface;

namespace TryingWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRetriveController : ControllerBase
    {
        private IDisplayAll displayAll = DisplayStudent.DisplayInstance;
        private IDisplayOne displayOne = DisplayIndividualStudent.DisplayIndividualStudentInstance;

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            StudentOptions studentOptions = new StudentOptions(displayAll, displayOne);
            return studentOptions.DisplayAllStudents();
        }


        [Route("student/byId/{id}")]
        [HttpGet]
        public Student getStudentById(string id)
        {
            StudentOptions studentOptions = new StudentOptions(displayAll, displayOne);
            return studentOptions.DisplayStudentById(int.Parse(id));

        }
    }
}