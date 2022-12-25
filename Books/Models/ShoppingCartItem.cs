using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Book Book { get; set; }
        public uint Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
