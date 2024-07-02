using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OracleMobileApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
namespace OracleMobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly OracleDbContext _context;

        public StudentController(OracleDbContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<studentModel>>> GetStudents()
        {
            return await _context.students.ToListAsync();
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<studentModel>> GetStudent(int id)
        {
            var student = await _context.students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }
            if (student.Profile_Picture == null)
            {
                student.Profile_Picture = null; // This line is actually redundant but added for clarity
            }
            return student;
        }
    }
}
