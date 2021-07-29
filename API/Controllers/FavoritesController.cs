using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class FavoritesController : ControllerBase
    {
        private readonly IFavoriteRepository _favoriteRepository;
        public FavoritesController(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lecture>>> GetFavorites()
        {
            return await _favoriteRepository.GetFavorites();
        }

        [HttpPost]
        [Route("add")]
        public Task<ActionResult<Lecture>> AddToFavorites(Lecture lecture)
        {
            //return await _context.Lectures.FindAsync(l=>l.id==lecture.Id).
            return _favoriteRepository.AddToFavorites(lecture);
        }

        [HttpPost]
        [Route("remove")]
        public Task<ActionResult<Lecture>> RemoveFromFavorites(Lecture lecture)
        {
            return _favoriteRepository.RemoveFromFavorites(lecture);
        }

    }
}