using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LecturesController : ControllerBase
    {

        private readonly ILectureRepository _lectureRepository;
        public LecturesController(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Entities.Lecture>>> GetLecturesByCategoryId(int id)
        {
            return await _lectureRepository.GetLecturesByCategoryId(id);
        }
    }
}