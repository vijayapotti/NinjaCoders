using Moq;
using NinjaCoders.Repositories;
using NinjaCoders.Services;

namespace NinjaCoders.Test
{
    public class StudentServiceTests
    {
        StudentService _studentService;
        
        [Fact]
        public void IfCouseIsFullReturnException()
        {
            //Arrage
            var mockStudentCourseRepo = new Mock<IStudentCourseRepository>();
            mockStudentCourseRepo.Setup(x => x.GetNumberOfStudentsForCourse(It.IsAny<int>())).Returns(6);
            _studentService = new StudentService(mockStudentCourseRepo.Object);

           //Act and Assert
            var exception = Assert.Throws<Exception>(() => _studentService.RegisterStudentForCourse(1, 4));
            Assert.Equal("Course is Full", exception.Message);
        }
    }
}