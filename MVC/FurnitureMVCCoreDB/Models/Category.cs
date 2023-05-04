using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FurnitureMVCCoreDB.Models
{
    public partial class Category
    {

        public Category()
        {
            Furniture = new HashSet<Furniture>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


       public virtual ICollection<Furniture> Furniture { get; set; }

    }
}
