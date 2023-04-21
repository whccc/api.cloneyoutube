using System.ComponentModel.DataAnnotations;

namespace api.cloneyoutube.AuthControllerModel
{
    public class LoginDTO
    {
        [Required]
        public string email { get; set; } = String.Empty;

        [Required]
        public string clave { get; set; } = String.Empty;
    }
}