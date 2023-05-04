using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Angular_WBI_APICore.Models
{
    public class TblDesignation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[StringLength(250)] //Not Compulsory 
        public string Designation { get; set; }

    }
}
