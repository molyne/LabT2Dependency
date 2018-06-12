using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LabT2Dependency.Data;
using LabT2Dependency.Models;

namespace LabT2Dependency.Controllers
{
    [Produces("application/json")]
    [Route("api/TravelApi")]
    public class TravelApiController : Controller
    {

        private readonly IApiRequestSend<Journey> apiRequestSend;

        public TravelApiController(IApiRequestSend<Journey> service)
        {
            apiRequestSend = service;
        }
        // GET api/<controller>/5
        [HttpGet]
        public virtual IEnumerable<Journey> GetAllJourneys()
        {
           return apiRequestSend.GetAllData();
        } 
        // DELETE api/<controller>/5
        [HttpDelete()]
        public virtual void DeleteJourney(Journey entity)
        {
            apiRequestSend.DeleteEntity(entity);
        }
        [HttpPost]
        public virtual void AddJourney(Journey entity)
        {
            apiRequestSend.AddEntity(entity);
        }
        [HttpPost]
        public void ModifyJourney(int id, Journey entity)
        {
            apiRequestSend.ModifyEntity(id, entity);
        }
    }
}
