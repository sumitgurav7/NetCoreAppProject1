using Microsoft.AspNetCore.Mvc;
using NetCoreAppProject1;
using NetCoreAppProject1.Interface;
using System.Collections.Generic;

namespace TryingWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRetriveController : ControllerBase
    {

        private IDisplayAll displayAll;
            //(IDisplayAll) Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSetting["DisplayAllInstance"],true));

        private IDisplayOne displayOne;
            //(IDisplayOne) Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSetting["DisplayOneInstance"], true));

        public StudentRetriveController(IDisplayAll displayAll, IDisplayOne displayOne)
        {
            this.displayAll = displayAll;
            this.displayOne = displayOne;
        }

        



        [HttpGet]
        public List<Student> GetAllStudents()
        {
            StudentOptions studentOptions = new StudentOptions(displayAll, displayOne);
            return studentOptions.DisplayAllStudents();
        }


        [Route("student/byId/{id}")]
        [HttpGet]
        public Student GetStudentById(string id)
        {
            StudentOptions studentOptions = new StudentOptions(displayAll, displayOne);
            return studentOptions.DisplayStudentById(int.Parse(id));

        }
    }
}