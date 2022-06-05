using Framework1st.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework1st
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var grade = new Grade
                {
                    GradeName="A",
                    Selection = "excellent"
                };
                context.Grades.Add(grade);
                context.SaveChanges();
            }
        }
    }
}
