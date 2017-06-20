using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatatablesExample.Repository;
using DatatablesExample.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatatablesExample.Controllers
{
    [Route("api/zoho/account")]
    public class ZohoAccountController : Controller
    {
        private readonly IZohoRepository _zohoRepository;
        public ZohoAccountController(IZohoRepository zohoRepository)
        {
            _zohoRepository = zohoRepository;
        }
        // GET: api/values
        //for paging, filter
        //[HttpGet]
        //public async Task<JsonResult> Get()
        //{
        //    var results = _zohoRepository.Accounts.ToArray();
        //    var total = results.Count();
        //    return await Task.FromResult(Json(new { data = results, recordsTotal = total, recordsFiltered = total}));
        //}
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var results = _zohoRepository.Accounts.ToArray();
            var total = results.Count();
            return await Task.FromResult(Json(new { data = results }));
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
