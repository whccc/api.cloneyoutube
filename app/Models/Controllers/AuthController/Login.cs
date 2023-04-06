using System.ComponentModel.DataAnnotations;

namespace api.cloneyoutube.AuthControllerModel
{
    public class Login
    {
        [Required]
        public string email { get; set; } = String.Empty;

        [Required]
        public string clave { get; set; } = String.Empty;
    }
}