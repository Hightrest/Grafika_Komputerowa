using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework1st.Models
{
    internal class SchoolContext : DbContext
    {
        public SchoolContext() : base("Server=.\\SQLExpress;Database=SchoolDb;Trusted_Connection=True;")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentAdress> StudentAdresses { get; set; }
    }
}
