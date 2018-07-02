using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLogic;
using BussinessLogic.Comercial.Solution.Users;
using DataContractTormund.Comercial.Customers;
using DataContractTormund.Solution.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Common;
using Model.Solution.Users;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace TormundAPI.Controllers
{
    [Route("api/[controller]")]
    public class usersController : Controller
    {
        public List<User> Users { get; set; }
        
        private Model.Configuration.Context _context { get; set; }
        private readonly ILogger<usersController> _logger;

        public usersController(ILogger<usersController> logger, Model.Configuration.Context context) {

            _logger = logger;
            _context = context;
           
        }
      
       [HttpPost]
        public List<UserDC> Post([FromBody]UserDC userDC)
        {
            if (userDC == null) return new List<UserDC>(); 

            switch (userDC.event_key)
            {
                case "search": {

                       return UserManager.users_search(_context, userDC);
                    }
                case "new":
                    {
                        if (UserManager.users_exists(_context, userDC))
                        {
                            return UserManager.users_search(_context, userDC);
                           
                        }
                        else {
                            return UserManager.users_create(_context, userDC);
                        }
                    }
                default:
                    break;
            }
            return new List<UserDC>();
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
