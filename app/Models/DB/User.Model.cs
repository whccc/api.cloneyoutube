using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.cloneyoutube.Model
{
    [Table("TBL_USER")]
    public class UserModel
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; } = String.Empty;

        [Column("CLAVE")]
        public string Clave { get; set; } = String.Empty;
    }
}