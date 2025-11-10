using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaCoders.Common
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new();
              

    }
}
