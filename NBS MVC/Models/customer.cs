using System.ComponentModel.DataAnnotations;

namespace NBS_MVC.Models
{
    public class customer
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int number { get; set; }

        public bool IsActive { get; set; }
    }
}
