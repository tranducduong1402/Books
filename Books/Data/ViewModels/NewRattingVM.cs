using Books.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Books.Data.ViewModels
{
    public class NewRattingVM
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public List<Rattings> ListOfComments { get; set; }
        public int Star { get; set; }
        public string UserName { get; set; }
        public int BookId { get; set; }
        public int RecordId { get; set; }
    }
}
