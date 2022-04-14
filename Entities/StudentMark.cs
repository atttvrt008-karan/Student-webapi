using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Entities


{
    // [Keyless]
    public class StudentMark
    {
        
        public  int  id { get; set; }

        public int rollno  { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public  int mark1 { get; set; }
         public int mark2 { get; set; }
           public int mark3 { get; set; }
           public int totalmarks { get; set; }
    }
}