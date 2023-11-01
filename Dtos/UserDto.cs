using System.ComponentModel.DataAnnotations;

namespace SignarRChatAppBackend.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(15, MinimumLength =3, ErrorMessage ="Name at least {2}, and maximum {1} characters ")]
        public string Name { get; set; }
    }
}
