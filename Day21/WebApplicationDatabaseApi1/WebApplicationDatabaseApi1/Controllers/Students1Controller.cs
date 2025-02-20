using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDatabaseApi1.Context;
using WebApplicationDatabaseApi1.Models;

namespace WebApplicationDatabaseApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students1Controller : ControllerBase
    {
        DBContext _context;
        public Students1Controller(DBContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Student> students = _context.Students.ToList();
            if (students.Count == 0)
            {
                return NotFound();
            }
            else

                return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else
                return Ok(student);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Created("Record added", student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Remove(student);
                _context.SaveChanges();
                return Ok("student deleteed");
            }
        }

        [HttpPut("{id}")]
        public IActionResult EditStudent(int id, Student obj)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return BadRequest();
            }
            else
            {
                student.Batch = obj.Batch;
                _context.SaveChanges();
                return Ok("record edited");
            }

        }
    }
}
