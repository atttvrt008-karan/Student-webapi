using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System;


namespace WebApi.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class MarklistsController : ControllerBase
    {


        private List<Marklist> _marklists = new List<Marklist>
        {
            // new Marklist { id=1, rollno = 1, mark1=50,mark2=50,mark3=50,totalmarks=150 }

        };
        private readonly StudentsContext _context;
        private StudentsContext _student;
        public MarklistsController(StudentsContext context, StudentsContext student)
        {
            _context = context;
            _student = student;
            if (_context.Marklists.Count() == 0)
            {
                _context.Marklists.Add(new Marklist { id = 1, rollno = 1, mark1 = 50, mark2 = 50, mark3 = 50, totalmarks = 150 }); _context.SaveChanges();
            }
        }


        [HttpPost]
        [Route("api/[controller]/{page}")]
        public StudentCollection GetAll(int page)

        {
            int maxRows = 2;
            StudentCollection objEmp = new StudentCollection();

            var result = (from s in _student.Students
                          join m in _context.Marklists on s.rollno equals m.rollno
                          select new StudentMark
                          {
                              rollno = s.rollno,
                              id = m.id,
                              firstname = s.firstname,
                              lastname = s.lastname,
                              mark1 = m.mark1,
                              mark2 = m.mark2,
                              mark3 = m.mark3,
                              totalmarks = m.totalmarks
                          }).OrderBy(m => m.id)
                         // .Skip(maxRows* (page - 1))
                         // .Take(maxRows)
                         .ToList();
            double totalpage = (double)((decimal)result.Count() / Convert.ToDecimal(maxRows));

            totalpage = (int)Math.Ceiling(totalpage);
            List<StudentMark> sresult = result.Skip(maxRows * (page - 1))
                         .Take(maxRows)
                         .ToList();
            objEmp.totalpage = totalpage;
            objEmp.result = sresult;
            // result.CurrentPageIndex = Page;
            return objEmp;

        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        //To Add new employee record  
        public int AddMarklist(Marklist marklist)
        {
            try
            {
                _context.Marklists.Add(marklist);
                _context.SaveChanges();
                int id = marklist.id;
                //Debug.WriteLine(rollno); 
                List<Marklist> st = new List<Marklist>();
                st.Add(marklist);
                return id;
            }
            catch
            {
                throw;
            }
        }

        [HttpPut]
        [Route("api/[controller]/Edit/{id}")]

        //To Update the records of a particluar employee    
        public int UpdateMarklists(int id, Marklist marklist)
        {
            try
            {


                var result = _context.Marklists.SingleOrDefault(b => b.id == id);
                if (result != null)
                {
                    result.mark1 = marklist.mark1;
                    result.mark2 = marklist.mark2;

                    result.mark3 = marklist.mark3;
                    result.totalmarks = marklist.totalmarks;
                    _context.SaveChanges();

                    return 1;
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }


        [HttpDelete]
        [Route("api/[controller]/Delete/{id}")]
        //To Delete the record of a particular employee    
        public int DeleteMarklist(int id)
        {
            try
            {
                Marklist emp = _context.Marklists.Find(id);
                _context.Marklists.Remove(emp);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee 

        [HttpGet]
        [Route("api/[controller]/Details/id")]
        public ActionResult<List<Marklist>> GetAll1()
        {
            return _context.Marklists.OrderBy(id => id).ToList();
        }

        [HttpPut]
        [Route("api/[controller]/Search/")]

        //To Update the records of a particluar employee    
        public IActionResult Search(Student st)
        {
            try
            {
                if (st.rollno > 0)
                {
                    var result = (from s in _student.Students
                                  join m in _context.Marklists on s.rollno equals m.rollno
                                  where (m.rollno == st.rollno)
                                  select new StudentMark
                                  {
                                      rollno = s.rollno,
                                      id = m.id,
                                      firstname = s.firstname,
                                      lastname = s.lastname,
                                      mark1 = m.mark1,
                                      mark2 = m.mark2,
                                      mark3 = m.mark3,
                                      totalmarks = m.totalmarks
                                  })
          .OrderBy(m => m.id)
          .ToList();
                    return Ok(result);
                }
                else
                {
                    var result = (from s in _student.Students
                                  join m in _context.Marklists on s.rollno equals m.rollno
                                  where (s.firstname == st.firstname)
                                  select new StudentMark
                                  {
                                      rollno = s.rollno,
                                      id = m.id,
                                      firstname = s.firstname,
                                      lastname = s.lastname,
                                      mark1 = m.mark1,
                                      mark2 = m.mark2,
                                      mark3 = m.mark3,
                                      totalmarks = m.totalmarks
                                  })
          .OrderBy(m => m.id)
          .ToList();
                    return Ok(result);

                }
            }
            catch
            {
                throw;
            }
        }
        [HttpGet]
        [Route("api/[controller]/Markdetail")]
        public List<Data>  GetAlldetail()

        {
            var query =
        
            (
                from s in _student.Students
                join m in _context.Marklists
               on s.rollno equals m.rollno 
                select new Data
                {
                    rollno = s.rollno,
                  
                    firstname = s.firstname,
                    lastname = s.lastname,
                    mark1 = m.mark1,
                    mark2 = m.mark2,
                    mark3 = m.mark3,
                    totalmarks = m.totalmarks,
                    result =m.totalmarks>=280 ? "First class" :m.totalmarks>=220 ? "second class" : "Fail"
                });
        
         
         return query.ToList();

        }
         [HttpGet]
        [Route("api/[controller]/count")]
        public List<Count>  GetAllcount()

        {

          var query =
        
            (
                from s in _student.Students
                join m in _context.Marklists
               on s.rollno equals m.rollno 
                select new Data
                {
                    rollno = s.rollno,
                  
                    firstname = s.firstname,
                    lastname = s.lastname,
                    mark1 = m.mark1,
                    mark2 = m.mark2,
                    mark3 = m.mark3,
                    totalmarks = m.totalmarks,
                    result =m.totalmarks>=280 ? "First class" :m.totalmarks>=220 ? "second class" : "Fail"
                }) .ToList();
    var results = query.GroupBy(
    p => p.result)
    .Select(p =>new Count
    {
      result =p.Key,
      count =p.Count()

    });
     
          return results.ToList();
        }
         [HttpGet]
        [Route("api/[controller]/find/{key}")]
        public List<Data>  GetAllfind(int key)

        {
           

          var query =
        
            (
                from s in _student.Students
                join m in _context.Marklists
               on s.rollno equals m.rollno 
                select new Data
                {
                    rollno = s.rollno,
                  
                    firstname = s.firstname,
                    lastname = s.lastname,
                    mark1 = m.mark1,
                    mark2 = m.mark2,
                    mark3 = m.mark3,
                    totalmarks = m.totalmarks,
                    result =m.totalmarks>=280 ? "First class" :m.totalmarks>=220 ? "second class" : "Fail"
                     }) .ToList();
   if(key == 0)
   {
     var results = query.Where(
    p => p.result=="Fail");
    return results.ToList();
        }
        else if(key == 1)
        {
     var results = query.Where(
    p => p.result=="First class");
    return results.ToList();
        }
    else if(key ==2)
    {
      var results = query.Where(
    p => p.result=="second class");
    return results.ToList();
    }
    return query;
    }
    }
}