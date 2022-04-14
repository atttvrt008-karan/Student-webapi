using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;
 using System.Linq;
 using System.Threading.Tasks;
 using System.Data;
 using System.Diagnostics;

namespace WebApi.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        
      
        private List<Student> _students= new List<Student>
        {
            new Student { rollno = 1, firstname = "Karan" ,lastname ="c", gender ="Male" ,phoneno ="8012261027" },
        };
         private readonly StudentsContext _context;
        //    private StudentsContext _image;
        public StudentsController(StudentsContext context )         
{             _context = context; 
            //  _image =image;             
if (_context.Students.Count() == 0)             
{                 
   _context.Students.Add(new Student { rollno= 1,firstname="karan",lastname="c",gender="male",phoneno="8012261027"});                _context.SaveChanges();             
}         
}
//     [HttpGet] 
//     [Route("api/[controller]/rollno")]
//   public ActionResult<List<Student>> GetAll() 

// {
//     return _context.Students.OrderBy(rollno => rollno).ToList(); 

// }
 [HttpGet]
        [Route("api/[controller]/rollno")]
        public List<StudentDetail> GetAllvalue()

        {
            var result = (from s in _context.Students
                          join m in _context.StudentImages on s.rollno equals m.rollno
                          select new StudentDetail
                          {
                               rollno = s.rollno,
                               id = m.id,
                              firstname = s.firstname,
                              lastname = s.lastname,
                              gender =s.gender,
                              phoneno = s.phoneno,
                              image = m.image,

                          }).OrderBy(m => m.id)
                            
                            .ToList();
                             return result;
        }

[HttpPost]  
        [Route("api/[controller]/Create")]  
//To Add new employee record  
  public int AddStudents(StudentList studentlist)  
        {  
            try  
            {  
             
                _context.Students.Add(studentlist.Student[0]);  
               _context.SaveChanges(); 
              var rollno = studentlist.Student[0].rollno;
               //Debug.WriteLine(rollno); 
               studentlist.Image.rollno=rollno;
                _context.StudentImages.Add(studentlist.Image);
                _context.SaveChanges();
             return rollno; 
            }  
            catch  
            {  
                throw;  
            }  
        }
        [HttpPut]  
        [Route("api/[controller]/Edit/{rollno}")]  
 
        //To Update the records of a particluar employee    
        public int UpdateStudents(int rollno, StudentList studentlist)  
        { 
            try
            {

            
    var result = _context.Students.SingleOrDefault(b => b.rollno ==rollno );
    var result1 =_context.StudentImages.SingleOrDefault(b => b.rollno ==rollno );
    if (result != null)
    {
        result.firstname = studentlist.Student[0].firstname;
         result.lastname = studentlist.Student[0].lastname;
          
           result.gender = studentlist.Student[0].gender;
            result.phoneno = studentlist.Student[0].phoneno;
        _context.SaveChanges();

        
    }
    if(result1 !=null)
    {
        result1.image = studentlist.Image.image;
        _context.SaveChanges();
         
    }
    return 1;
            }
    catch  
            {  
                throw;  
            }  
            }

    //        [HttpPut]  
    //     [Route("api/[controller]/Edit/{rollno}")]  
 
    //     //To Update the records of a particluar employee    
    //     public int UpdateStudents(int rollno, Student student)  
    //     { 
    //         try
    //         {

            
    // var result = _context.Students.SingleOrDefault(b => b.rollno ==rollno );
    // if (result != null)
    // {
    //     result.firstname = student.firstname;
    //      result.lastname = student.lastname;
          
    //        result.gender = student.gender;
    //         result.phoneno = student.phoneno;
    //     _context.SaveChanges();

    //     return 1;
    // }
    // return 1;
    //         }
    // catch  
    //         {  
    //             throw;  
    //         }  
    //         }
         [HttpDelete]  
        [Route("api/[controller]/Delete/{rollno}")] 
         //To Delete the record of a particular employee    
        public int DeleteStudents(int rollno)  
        {  
            try  
            {  
              Student emp = _context.Students.Where(b => b.rollno == rollno).First();
                // Student emp = _context.Students.Find(rollno);  
               _context.Students.Remove(emp);  
                _context.SaveChanges();  
                // StudentImage ee =_context.StudentImages.Find(rollno);
                StudentImage ee =_context.StudentImages.Where(b =>b.rollno ==rollno).First();
                _context.StudentImages.Remove(ee);
                _context.SaveChanges();
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  
            
  //Get the details of a particular employee 
  
        // [HttpGet]  
        // [Route("api/[controller]/Details/{rollno}")]     
        // public Student GetStudentsData(int rollno)  
        // {  
        //     try  
        //     {  
        //           Student employee = _context.Students.Find(rollno);  
        //         return employee;  
        //     }  
        //     catch  
        //     {  
        //         throw;  
        //     }  
        // }
   [HttpGet]
        [Route("api/[controller]/{rollno}")]
        public IActionResult GetById(int rollno)
        {
              var product = _context.Students.Find(rollno);
            if (product == null)
                return NotFound();

            return Ok(product);

           
        }
         [HttpGet]
        [Route("api/[controller]/image/{rollno}")]
        public IActionResult GetById1(int rollno)
        {
              var product1 = _context.StudentImages.Where(b =>b.rollno ==rollno);
            if (product1 == null)
                return NotFound();

            return Ok(product1);

           
        }
    } 
}
     
   