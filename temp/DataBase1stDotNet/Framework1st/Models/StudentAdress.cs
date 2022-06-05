using System.ComponentModel.DataAnnotations.Schema;

namespace Framework1st.Models
{
    public class StudentAdress
    {
        [ForeignKey("RelatedStudent")]
        public int StudentAdressId { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student RelatedStudent { get; set; }
    }
}