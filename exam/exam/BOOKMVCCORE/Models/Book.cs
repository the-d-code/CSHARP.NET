using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOOKMVCCORE.Models
{
    public partial class Book
    {
        public int BookAccId { get; set; }
        public string BookName { get; set; }
        public int AutherId { get; set; }
        public int PublicsId { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string PublicingYear { get; set; }

        public virtual Auther Auther { get; set; }
        public virtual Publicsh Publics { get; set; }
    }
}
