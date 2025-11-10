using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaCoders.Repositories
{
    public interface IStudentCourseRepository
    {
        int GetNumberOfStudentsForCourse(int courseId);
    }
}
