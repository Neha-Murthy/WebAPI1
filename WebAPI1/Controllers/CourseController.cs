using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI1.Models;


namespace WebAPI1.Controllers
{
    public class CourseController : ApiController
    {
        [Route("api/Course/GetCourses")]
        [HttpPost]
        public List<Course> GetCourses(Course course)
        {
            nehadbEntities db = new nehadbEntities();
            return (from c in db.Courses.Take(5) where c.cname.StartsWith(course.cname)||string.IsNullOrEmpty(course.cname) select c).ToList();
        }
    }
}
