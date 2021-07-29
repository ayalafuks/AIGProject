using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class LectureRepository : ILectureRepository
    {
        private readonly DataContext _context;

        public LectureRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<ActionResult<IEnumerable<Lecture>>> GetLecturesByCategoryId(int id)
        {
            return await Task.Run(() => _context.Lectures.Include(l => l.Category).Where(l => l.Category.Id == id).ToList());
        }
    }
}