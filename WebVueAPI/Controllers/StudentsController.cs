using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebVueModel;
using WebVueService.Interfaces;

namespace WebVueAPI.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student model)
        {
            return Ok(_service.Add(model));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Student model)
        {
            return Ok(_service.Add(model));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
        
    }
}
