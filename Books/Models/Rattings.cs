using Books.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Rattings : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
        public DateTime RattingDate { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int RecordId { get; set; }
    }
}
