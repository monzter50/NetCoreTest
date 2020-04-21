using System;
using System.ComponentModel.DataAnnotations;

namespace NetCore.Data
{
    public class Course
    {
        [Key]
        public Guid IdCourse { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public System.DateTime Date_Public { get; set; }
    }
}
