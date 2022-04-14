using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Entities


{
    // [Keyless]
    public class Marklist
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int  id { get; set; }
        public int  rollno { get; set; }
        public int mark1 { get; set; }
        public int mark2 { get; set; }
        public int mark3 { get; set; }
         public int totalmarks { get; set; }
    }
}