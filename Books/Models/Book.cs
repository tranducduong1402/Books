using Books.Data;
using Books.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Book:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public uint Count { get; set; }

        public int PageNumber { get; set; }

        public BookCategory BookType { get; set; }

        public string ProfilePicture { get; set; }

        public ICollection<Rattings> Rattings { get; set; }
    }
}
