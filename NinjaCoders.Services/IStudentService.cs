using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaCoders.Services
{
    public interface IStudentService 
    {
     bool RegisterStudentForCourse(int studentId, int courseId);
    }
}
