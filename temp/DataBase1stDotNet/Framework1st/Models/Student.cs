using System;
using System.Collections.Generic;

namespace Framework1st.Models
{
    public class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public byte[] RowVersion { get; set; }
        public virtual Grade StudentGrade { get; set; }
        public virtual StudentAdress Adress { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}