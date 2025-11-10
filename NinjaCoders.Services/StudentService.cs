using NinjaCoders.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NinjaCoders.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentCourseRepository _repo;

        public StudentService(IStudentCourseRepository repo)
        {
            _repo = repo;
        }
        public bool RegisterStudentForCourse(int studentId, int courseId)
        {
            // Get the number of students currently enrolled in course
            var numberOfStutentsInCourse = _repo.GetNumberOfStudentsForCourse(courseId);

            // If the number of students is 5, then show message that the class is full

            if (numberOfStutentsInCourse >= 5)
            {
                throw new Exception("Course is Full");           
            }
            else   // Else Add the student to the course and Save changes
            {
                return true;
            }
        }
    }
}
