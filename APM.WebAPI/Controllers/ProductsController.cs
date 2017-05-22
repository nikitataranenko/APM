using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using APM.WebAPI.Models;
using APM.WebAPI.Repository;

namespace APM.WebAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var repo = new ProductRepository();
            return repo.Retrieve();
        }

        public IEnumerable<Product> Get(string search)
        {
            var repo = new ProductRepository();
            var products = repo.Retrieve();
            return products.Where(p => p.ProductCode.Contains(search));
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
