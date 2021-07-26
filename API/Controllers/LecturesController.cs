using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LecturesController : ControllerBase
    {
        private readonly DataContext _context;
        public LecturesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Entities.Lecture>>> GetLecturesByCategoryId(int id)
        {
            return await Task.Run(() => _context.Lectures.Where(l => l.Category.Id == id).ToList());
        }
    }
}