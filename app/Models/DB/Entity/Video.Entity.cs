using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api.cloneyoutube.Entity
{

    [Table("TBLVIDEOS")]
    public class VideoEntity
    {

        [Key]
        [Column("ID")]
        public int id { get; set; }


        [Column("TITLE")]
        public string title { get; set; } = string.Empty;


        [Column("IDCATEGORY")]
        public string idCategory { get; set; } = string.Empty;

        [Column("DESCRIPTION")]
        public string description { get; set; } = string.Empty;

        [Column("IDUSER")]
        public int idUser { get; set; }

        [JsonIgnore]
        [ForeignKey("idUser")]
        public UserEntity? user { get; set; }
    }

}