using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabT2Dependency.Controllers;
using LabT2Dependency.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabT2Dependency
{
    [Route("api/")]
    public class ApiRequestSend : Controller, IApiRequestSend<Journey>
    {
        readonly List<Journey> journeys = new List<Journey>();



        public ApiRequestSend(List<Journey> journeys)
        {
            this.journeys = journeys;
        }

        // GET: api/<controller>
        [Route("getAll")]
        [HttpGet]
        public IEnumerable<Journey> GetAllData()
        {
           
            return journeys;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

       

        public void AddEntity(Journey journey)
        {
            throw new NotImplementedException();
        }

        public void ModifyEntity(int id, Journey journey)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Journey journey)
        {
            throw new NotImplementedException();
        }
    }
}
