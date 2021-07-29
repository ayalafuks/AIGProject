using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await Task.Run(()=> _context.Categories.Where(c=>c.Language=="en" && c.Country=="il").ToList());
        }
    }
}