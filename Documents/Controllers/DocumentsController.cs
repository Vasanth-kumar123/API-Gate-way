using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Documents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var customers = await _context.Products.ToListAsync();
            //if (customers == null) return NotFound();
            return Ok("Documents Microservice executed !");
        }
    }
}
