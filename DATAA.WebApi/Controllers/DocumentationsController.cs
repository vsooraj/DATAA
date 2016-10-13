using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DATAA.WebApi.Models;

namespace DATAA.WebApi.Controllers
{
    public class DocumentationsController : ApiController
    {
        List<Documentation> _help = new List<Documentation>()
        {
            new Documentation{Id=0,Caption="ErisDATAA",Description="Your Data your future",ImageUrl="",VideoUrl="", IsActive=true },
            new Documentation{Id=1,Caption="Sales",Description="SALES A sale is the exchange of a commodity or money as the price of a good or a service.[1] Sales (plural only) is activity related to selling or the amount of goods or services sold in a given time period..",ImageUrl="",VideoUrl="", IsActive=true },
            new Documentation{Id=2,Caption="Invoice",Description="A sales invoice can be simply defined as the request of payment by the customer for goods sold or services provided the seller. An invoice generally lists the description and the quantity of the item sold or service provided. The document is also a record of the sale for both the seller and the buyer.",ImageUrl="",VideoUrl="", IsActive=true },
            new Documentation{Id=3,Caption="Order",Description="The Sales Order is a confirmation document sent to the customers before delivering the goods or services. Sales Order (SO) can be created once the quote is accepted by your prospective customer (potential) and the Purchase Order (PO) is sent by the customer for further processing.",ImageUrl="",VideoUrl="", IsActive=true },
            new Documentation{Id=4,Caption="Customer",Description="Customer",ImageUrl="",VideoUrl="", IsActive=true },
            new Documentation{Id=5,Caption="Salesman",Description="Salesman",ImageUrl="",VideoUrl="", IsActive=true }
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var help = _help.Where(w => w.Id == id).FirstOrDefault();
            return help.Description;

        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
