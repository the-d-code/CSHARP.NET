using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOOKSAPI.Models
{
    public partial class Publicsh
    {
        public Publicsh()
        {
            Book = new HashSet<Book>();
        }

        public int PublicsId { get; set; }
        public string PublisherName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
