using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface ILectureRepository
    {
        Task<ActionResult<IEnumerable<Entities.Lecture>>> GetLecturesByCategoryId(int id);
    }
}