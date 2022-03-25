using System.ComponentModel.DataAnnotations;

namespace OtmCore.Models
{
    public class College
    {
        [Key]
        public int CollegeId { get; set; }
        public string? CollegeName { get; set; }
        public string? CollegeAddress { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}