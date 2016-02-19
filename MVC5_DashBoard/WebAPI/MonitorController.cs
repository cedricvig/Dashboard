using ND.BO;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ND.MonitorDasboard.Web.WebAPI
{
    public class MonitorController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<MonitorResultBO> Get()
        {
            return MonitorService.GetAll();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // GET api/Monitor?pageIndex={pageIndex}&pageSize={pageSize}
        public IEnumerable<MonitorResultBO> Get(int pageIndex, int pageSize)
        {
            return MonitorService.GetAllPaging(pageIndex, pageSize);   
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}