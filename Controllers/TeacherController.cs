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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherservice;
        public TeacherController(ITeacherService teacherservice)
        {
            _teacherservice = teacherservice;
        }
        [HttpPost]
        public IActionResult CreateTeacher([FromBody] CreateTeacherModel filter)
        {
            return Ok(_teacherservice.AddTeacher(filter));
        }
        [HttpGet("Get")]
        public IActionResult GetReacher( int id)
        {
            return Ok(_teacherservice.GetTeacher(id));
        }
        [HttpGet("GetAllTeacher")]
        public IActionResult GetAllTeachers()
        {
            return Ok(_teacherservice.GetAllTeacher());
        }
        [HttpPut]
        public IActionResult UpdateStudent( int id, [FromBody] UpdateTeacherModel filter)
        {
            return Ok(_teacherservice.UpdateTeacher(id, filter));
        }
        [HttpDelete]       
        
        public IActionResult DeleteStudent(int id)
        {
             _teacherservice.DeleteTeacher(id);
            return Ok();
        }
    }
}