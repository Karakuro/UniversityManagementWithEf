using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementV2.Data;

namespace UniversityManagementV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private UniversityDbContext _ctx;

        public StudentController(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ctx.Students.ToList());
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            student.StudentId = 0;
            _ctx.Students.Add(student);
            _ctx.SaveChanges();
            return Ok(student);
        }
    }
}
