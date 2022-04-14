using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Entities


{
    // [Keyless]
    public class StudentDetail
    {
        
        public  int  id { get; set; }

        public int rollno  { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public  string gender { get; set; }
         public string phoneno { get; set; }
           public string image { get; set; }
          
    }
}