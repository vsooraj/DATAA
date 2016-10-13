using System.Collections.Generic;
using System.Web.Http;
using DATAA.Models;

namespace DATAA.Controllers
{
    public class SalesController : ApiController
    {
        // GET: api/Sales
        public IEnumerable<Order> Get()
        {
            var orders = new OrderRepository();
            return orders.GetOrders();
        }

        // GET: api/Sales/5
        public Order Get(int id)
        {
            var orders = new OrderRepository();
            return orders.GetOrder(id);
        }

        // POST: api/Sales
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sales/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sales/5
        public void Delete(int id)
        {
        }
    }
}
