using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOOKMVCCORE.Models
{
    public partial class Auther
    {
        public Auther()
        {
            Book = new HashSet<Book>();
        }

        public int AutherId { get; set; }
        public string AutherName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
