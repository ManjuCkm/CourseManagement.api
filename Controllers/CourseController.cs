using CourseManagement.api.Commands;
using CourseManagement.api.Queries;
using CourseManagement.core.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagement.api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ISender _sender;

        

        public CourseController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]   
        public async Task<ActionResult>GetCourses()
        {
            var courselist = await _sender.Send(new GetCoursesQuery());
            return Ok(courselist);
        }

        [HttpGet("{id:int}",Name ="GetCourseById")]

        public async Task<ActionResult>GetCourseById(int id)
        {
            var courselists = await _sender.Send(new GetCourseByIdQuery(id));
            return Ok(courselists);
               
        }



        [HttpPost]

        public async Task<ActionResult> AddCourses([FromBody] CourseDetails coursedetails)
        {
            await _sender.Send(new AddCoursesCommand(coursedetails));
            return StatusCode(201);
        }

        [HttpPut]

        public async Task<ActionResult> UpdateCourses([FromBody] CourseDetails coursedetails)
        {
            await _sender.Send(new UpdateCourseCommand(coursedetails));
            return StatusCode(200);
        }
            


        [HttpDelete]

        public async Task<ActionResult>DeleteCourses(int Id)
        {
            await _sender.Send(new DeleteCourseCommand(Id));

            return StatusCode(204);
        }
    }
    
}
