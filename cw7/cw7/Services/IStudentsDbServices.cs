using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw7.DTO.Requests;
using cw7.Models;

namespace cw7.Services
{
    interface IStudentsDbServices
    {
        public bool PromoteStudent(PromoteStudentRequest promoteStudentRequest);

        public StudentEnrollment EnrollStudent(EnrollStudentRequest enrollStudentRequest);

        public Study GetStudy(string studyName);
    }
}
