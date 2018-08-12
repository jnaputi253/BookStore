using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nori.Models
{
    [Table("[dbo].[Books]")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
    }
}
