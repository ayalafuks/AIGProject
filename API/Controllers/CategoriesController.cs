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
    public class CategoriesController : ControllerBase
    {
         private readonly ICategoryRepository _categoryRepository;
       
        public CategoriesController(ICategoryRepository categoryRepository)
        {
          _categoryRepository=categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories(){
            return await _categoryRepository.GetCategories();
        }
    }
}