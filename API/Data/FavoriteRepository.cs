using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly DataContext _context;

        public FavoriteRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<ActionResult<Lecture>> AddToFavorites(Lecture lecture)
        {
           return await Task.Run(()=>{ Lecture entityLecture = _context.Lectures.Include(l => l.Category).FirstOrDefault(x => x.Id == lecture.Id);
            entityLecture.IsFavorite = true;
            _context.SaveChanges();
            return entityLecture;
           });
        }

        public async Task<ActionResult<IEnumerable<Lecture>>> GetFavorites()
        {
            return await Task.Run(() => _context.Lectures.Include(l => l.Category).Where(l => l.IsFavorite).ToList());
        }

        public async Task<ActionResult<Lecture>> RemoveFromFavorites(Lecture lecture)
        {
          return await Task.Run(()=>{  Lecture entityLecture = _context.Lectures.Include(l => l.Category).FirstOrDefault(l => l.Id == lecture.Id);
            entityLecture.IsFavorite = false;
            _context.SaveChanges();
            return entityLecture;
          });
        }
    }
}