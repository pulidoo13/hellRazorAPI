using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLogic;
using DataContractTormund.Comercial.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Comercial.Branches;
using Model.Common;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace TormundAPI.Controllers
{
    [Route("api/[controller]")]
    public class branchesController : Controller
    {
        public List<Branch> Branches { get; set; }
        
        private Model.Configuration.Context _context { get; set; }
        private readonly ILogger<branchesController> _logger;

        public branchesController(ILogger<branchesController> logger, Model.Configuration.Context context) {

            _logger = logger;
            _context = context;
           
        }
      
       [HttpPost]
        public List<CustomerDC> Post([FromBody]CustomerDC customerDc)
        {
            if (customerDc == null) return new List<CustomerDC>(); 

            switch (customerDc.event_key)
            {
                case "search": {

                       return CustomerManager.customers_search(_context, customerDc);
                    }
                case "new":
                    {
                        return _context.Customers
                                .Where(p => p.Branch != null &&(  p.Branch!=null && customerDc.branch!=null && p.Branch.Id == customerDc.branch.branch_id))
                                .Select(p => new CustomerDC { customer_id = p.Id, customerName = p.Name, branch = customerDc.branch  }).ToList();
                    }
                default:
                    break;
            }
            return new List<CustomerDC>();
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
