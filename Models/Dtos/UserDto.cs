using System.ComponentModel.DataAnnotations;

namespace QuizPortal.Models.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
