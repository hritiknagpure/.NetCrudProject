using AspCoreWebApiGetRecords.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebApiGetRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly codefirstDBContext contex;

        public StudentApiController(codefirstDBContext contex )
        {
            this.contex = contex;
        }
        [HttpGet]
        public async Task <ActionResult<List<Student>>> GetStudent()
        {
            var data = await contex.Students.ToListAsync();
            return Ok(data);
        }
    }
}
