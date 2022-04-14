using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApi.Entities


{
    // [Keyless]
    public class StudentList
    {
      
        public List<Student>Student{get;set;}
        public StudentImage  Image {get;set;}
    }
}