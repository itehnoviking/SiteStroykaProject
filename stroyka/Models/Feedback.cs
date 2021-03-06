using stroyka.Entities;
using System.ComponentModel.DataAnnotations;

namespace stroyka.Models
{
    public class Feedback : BaseEntity
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter message")]
        public string Message { get; set; }
    }
}
