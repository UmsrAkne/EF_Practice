using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice.Models
{
    public class Record
    {
        [Key] // ID などの名前のプロパティがあるときは自動で主キーに指定されるらしい。
        [Required]
        [Column("id")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}