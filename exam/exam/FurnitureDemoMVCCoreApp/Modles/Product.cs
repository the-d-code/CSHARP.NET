using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FurnitureDemoMVCCoreApp.Modles
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
