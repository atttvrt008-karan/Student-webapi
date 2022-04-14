using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApi.Entities


{
    // [Keyless]
    public class StudentCollection
    {
        public List<StudentMark> result{get;set;}
        public double totalpage {get;set;}
    }
}