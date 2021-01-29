using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cw7.DTO.Requests;
using cw7.DTO.Responses;
using cw7.Services;

namespace cw7.Controllers
{
    [ApiController]
    [Route("api/enrollments")]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IStudentsDbServices _dbService;

        

        [HttpPost("promotions")]
        public IActionResult PromoteStudent(PromoteStudentRequest request)
        {
            if (this._dbService.PromoteStudent(request))
            {
                return Ok();
            };

            return BadRequest();
        }

        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {

            StudentEnrollment studentEnrollment = this._dbService.EnrollStudent(request);

            EnrollStudentResponse enrollStudentResponse = new EnrollStudentResponse()
            {
                Semester = studentEnrollment.Semester,
                LastName = studentEnrollment.LastName,
                StartDate = studentEnrollment.StartDate
            };

            return Ok(enrollStudentResponse);
        }
    }
}