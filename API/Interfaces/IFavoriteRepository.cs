using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<ActionResult<IEnumerable<Lecture>>> GetFavorites();
        Task<ActionResult<Lecture>> AddToFavorites(Lecture lecture);
        Task<ActionResult<Lecture>> RemoveFromFavorites(Lecture lecture);
    }
}