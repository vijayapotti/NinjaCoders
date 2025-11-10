using System.ComponentModel.DataAnnotations;

namespace NinjaCoders.Common
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;
        public bool IsActive  { get; set; }

        public List<Course> Courses { get; set; } = new();
      
    }
}
