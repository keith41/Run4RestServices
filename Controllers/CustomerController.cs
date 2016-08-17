using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

using Run4RestServices.Data;
using Run4RestServices.Models;
using Newtonsoft.Json;

namespace Run4RestServices.Controllers
{
    public class CustomerController : ApiController
    {        
        public IEnumerable<MemberDTO> Get()
        {
            using (ksalomon_listEntities entities = new ksalomon_listEntities())
            {
                entities.Database.Connection.Open();

                var members = (from m in entities.Members
                             select new MemberDTO()
                             {                                 
                                 memberFirstName = m.FirstName != null ? m.FirstName.Trim() : string.Empty,
                                 memberLastName = m.LastName != null ? m.LastName.Trim() : string.Empty,
                                 memberAddress = m.Address != null ? m.Address.Trim() : string.Empty,
                                 memberCity = m.City != null ? m.City.Trim() : string.Empty,
                                 memberState = m.State != null ? m.State.Trim() : string.Empty,
                                 memberZip = m.Zip != null ? m.Zip.Trim() : string.Empty
                             }).ToList();

                if (members == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                                
                return members;
            }

        }

        // GET api/Customer/5
        [HttpGet]
        public Member Get(int id)
        {
            Member member;
            try
            {
                using (ksalomon_listEntities entities = new ksalomon_listEntities())
                {
                    //entities.Database.Connection.Open();

                    member = (from mem in entities.Members where mem.id == id select mem).FirstOrDefault();
                    //var communications = from c in database.Communications where c.Year == year select c;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (member == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return member;
            
        }

        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage Post(Member member)
        {
            if (ModelState.IsValid)
            {
                using (ksalomon_listEntities entities = new ksalomon_listEntities())
                {

                }

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


        /*[Route("api/ptemployees")]
        public HttpResponseMessage Post(Employee e)
        {
            var employees = EmployeesRepository.InsertEmployee(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees")]
        public HttpResponseMessage Put(Employee e)
        {
            var employees = EmployeesRepository.UpdateEmployee(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/ptemployees")]
        public HttpResponseMessage Delete(Employee e)
        {
            var employees = EmployeesRepository.DeleteEmployee(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }*/
    }
}