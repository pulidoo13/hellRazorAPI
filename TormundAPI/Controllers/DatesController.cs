using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLogic;
using BussinessLogic.Dates;
using DataContractTormund.Comercial.Customers;
using DataContractTormund.Dates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Comercial.Branches;
using Model.Comercial.Customers;

using Model.Common;
using Model.Dates;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace TormundAPI.Controllers
{
    [Route("api/[controller]")]
    public class DatesController : Controller
    {
        public List<Date> Dates { get; set; }
        
        private Model.Configuration.Context _context { get; set; }
        private readonly ILogger<branchesController> _logger;

        public DatesController(ILogger<branchesController> logger, Model.Configuration.Context context) {

            _logger = logger;
            _context = context;
           
        }
      
       [HttpPost]
        public List<DateDC> Post([FromBody]DateDC dateDC)
        {
            if (dateDC == null) return new List<DateDC>(); 

            switch (dateDC.event_key)
            {
                case "search": {

                       return DatesManager.dates_search(_context, dateDC);
                    }
                case "new_pending_date":
                    {
                        return DatesManager.date_newPending(_context, dateDC);

                    }
                case "update":
                    {

                        return DatesManager.dates_update(_context, dateDC);
                    }
                default:
                    break;
            }

            return new List<DateDC>();
        }



        //// GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        // GET api/values/5
        //[HttpGet("customers")]
        //    public List<CustomerDC> BranchCustomers(int BranchId)
        //    {

        //        return new List<CustomerDC>();
        //    }
    }
}
