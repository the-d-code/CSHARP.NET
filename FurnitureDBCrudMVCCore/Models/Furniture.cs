using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FurnitureDBCrudMVCCore.Models
{
    public partial class Furniture
    {
        public int FurnitureId { get; set; }
        public string FurnitureName { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
