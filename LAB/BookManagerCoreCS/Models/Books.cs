using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerCoreCS.Models
{
    public class Books
    {
        public int BookAccNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int Pyear { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
