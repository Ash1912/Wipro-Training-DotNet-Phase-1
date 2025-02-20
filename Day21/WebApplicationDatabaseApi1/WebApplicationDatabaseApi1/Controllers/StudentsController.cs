using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDatabaseApi1.Context;
using WebApplicationDatabaseApi1.Models;

namespace WebApplicationDatabaseApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
     DBContext _context;
    public StudentsController(DBContext context)
    {
        _context = context;

    }
    [HttpGet]
    public List<Student> Get()
    {
        return (_context.Students.ToList());
    }
    [HttpGet("{id}")]
    public Student GetStudentById(int id)
    {
        return _context.Students.FirstOrDefault(x => x.Id == id);
    }
    [HttpPost]
    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void DeleteStudent(int id)
    {
        Student student = _context.Students.FirstOrDefault(x => x.Id == id);
        _context.Remove(student);
        _context.SaveChanges();
    }

    [HttpPut("{id}")]
    public void EditStudent(int id, Student obj)
    {
        Student student = _context.Students.FirstOrDefault(x => x.Id == id);
        student.Batch = obj.Batch;
        _context.SaveChanges();
    }
    }
}
