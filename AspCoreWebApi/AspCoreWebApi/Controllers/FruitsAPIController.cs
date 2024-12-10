using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<String> fruits = new List<String>()
        {
            "Apple",
            "Banana",
            "Mango"

        };
        [HttpGet]
        public List<string> GetFrutis()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public string GetFrutisByIndex(int id)
        {
            return fruits.ElementAt(id);
        }

    }
}
