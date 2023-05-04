using System.Collections.Generic;

namespace FurnitureDBCrudMVCCore.Models
{
    public class SearchByCategoryViewModel
    {

        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }

    }
}
