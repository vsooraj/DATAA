using System.Collections.Generic;
using System.Linq;

namespace DATAA.Models
{
    public class OrderRepository
    {
        DATAADBContext context = new DATAADBContext();
        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        internal Order GetOrder(int id)
        {
            return context.Orders.Find(id);
        }
    }
}