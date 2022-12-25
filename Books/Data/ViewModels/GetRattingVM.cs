using System;

namespace Books.Data.ViewModels
{
    public class GetRattingVM
    {
        public string UserName { get; set; }
        public DateTime RattingTime { get; set; }
        public int Star { get; set; }
        public string Comment { get; set; }
    }
}
