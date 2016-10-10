using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using oopsAPI.DBA; 
using oopsAPI.Models;


namespace oopsAPI.Controllers
{
    public class OopsAPIController : ApiController
    {
        ApiDbContext dbContext = null;

        public OopsAPIController()
        {
            dbContext = new ApiDbContext();
        }

        [HttpPost]
        public IHttpActionResult InsertOops(Oops oops)
        {

            dbContext.Oops.Add(oops);
            dbContext.SaveChangesAsync();

            return Ok(oops.ID);
        }

        public IEnumerable<Oops> GetAllOops()
        {
            var list = dbContext.Oops.ToList();

            return list;
        }

        [HttpGet]
        public IHttpActionResult DeleteStudent(int id)
        {
            var oops = dbContext.Oops.Find(id);

            dbContext.Oops.Remove(oops);

            dbContext.SaveChangesAsync();

            return Ok(oops.EventType + " " + oops.Action + " is deleted successfully.");

        }

        [HttpGet]
        public IHttpActionResult ViewStudent(int id)
        {
            var oops = dbContext.Oops.Find(id);
            return Ok(oops);
        }
        [HttpPost]
        public IHttpActionResult UpdateStudent(Oops oops)
        {

            var std = dbContext.Oops.Find(oops.ID);

            std.EventType = oops.EventType;
            std.Action = oops.Action;
            std.TimeStamp = DateTime.Now;
            

            dbContext.Entry(std).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
