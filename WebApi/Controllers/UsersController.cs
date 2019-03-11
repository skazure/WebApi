using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        private User[] users = new User[] {
                                new User { productId = 1, productName = "Indian Coffee", price = 120},
                                new User { productId = 2, productName = "Starbucks Chai latte", price = 150},
                                new User { productId = 3, productName = "Orange Juice", price =125},
                                new User { productId = 4, productName = "Lemon Soda",  price = 90},
                                new User { productId = 5, productName = "Mixed fruit Juice",  price = 160} };


        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))] 
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
