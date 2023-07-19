using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApi.DTO;
using BlazorApi.Interface.IService;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentservice;
        public StudentController(IStudentService studentService)
        {
            _studentservice = studentService;
        }
        [HttpPost]
        public IActionResult CreateStudent([FromBody] CreateStudentModel filter)
        {
            return Ok(_studentservice.AddStudent(filter));
        }
        [HttpGet ("Get")]
        public IActionResult GetStudent(int id)
        {
            return Ok(_studentservice.GetStudent(id));
        }
        [HttpGet("getAllStudent")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentservice.GetStudentByAll());
        }
        [HttpPut]
        public IActionResult UpdateStudent( int id, [FromBody] UpdateStudentModel filter)
        {
            return Ok(_studentservice.UpdateStudent(id, filter));
        }
        [HttpDelete]       
        
        public IActionResult DeleteStudent(int id)
        {
             _studentservice.DeleteStudent(id);
            return Ok();
        }
    }
}