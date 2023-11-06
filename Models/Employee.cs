using System.ComponentModel.DataAnnotations;

namespace AssignmentEmployee.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Range(16,60,ErrorMessage = "Ages 16-60 only")]
        public string Age { get; set; }
        
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid, enter like # or #.## ")]
        public string Salary { get; set; }
        
        public string Department { get; set; }
        
        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public string Sex{ get; set; }
    }
}
