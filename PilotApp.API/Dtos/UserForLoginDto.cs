using System.ComponentModel.DataAnnotations;

namespace PilotApp.API.Dtos
{
    public class UserForLoginDto
    {

        [Required] 
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}