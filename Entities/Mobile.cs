using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApi.Entities


{
    [Keyless]
    public class Mobile
    {
        // [Key]
        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

      public int id {get;set;}
        public int rollno {get;set;}
        public string  image {get;set;}
    }
}