using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.cloneyoutube.Entity
{
    [Table("TBLUSERS")]
    public class UserEntity
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }
        [Column("EMAIL")]
        public string email { get; set; } = string.Empty;

        [Column("CLAVE")]
        public string clave { get; set; } = string.Empty;

        public ICollection<VideoEntity>? videos { get; set; }
    }
}