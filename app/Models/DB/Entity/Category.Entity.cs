using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.cloneyoutube.Entity
{

    [Table("TBLCATEGORIES")]
    public class CategoryEntity
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }

        [Column("DESCRIPTION")]
        public string description { get; set; } = string.Empty;


    }
}