using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var customers = await _context.Products.ToListAsync();
            //if (customers == null) return NotFound();
            return Ok("Assets Microservice executed !");
        }
    }
}