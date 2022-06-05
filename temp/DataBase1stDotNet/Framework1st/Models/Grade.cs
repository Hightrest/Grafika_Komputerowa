using System.Collections.Generic;

namespace Framework1st.Models
{
    public class Grade
    {
        public Grade()
        {
            Students = new HashSet<Student>();
        }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Selection { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}