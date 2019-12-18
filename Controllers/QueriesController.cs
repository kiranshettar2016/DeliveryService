using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeliveryService.Model;

namespace DeliveryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        private OrderQuery _query;
        public QueriesController()
        {
            _query = new Query();
        }
        //// GET: api/Queries
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Queries/5
        [HttpGet]
        [Route("getTotalFare/distance/{distance}/floor/{floor}")]
        public ActionResult GetTotalFare(float distance, int floor)
        {
            return Ok(_query.GetTotalDeliveyFare(distance, floor));
        }

        [HttpGet]
        [Route("getDistanceFare/distance/{distance}")]
        public float GetDeliveryDistanceFare(float distance)
        {
            return _query.GetDeliveryDistanceFare(distance);
        }

        [HttpGet]
        [Route("getFloorDeliveryFare/floor/{floor}")]
        public float GetFloorDeliveryFare(int floor)
        {
            return _query.GetFloorDeliveryFare(floor);
        }

        [HttpGet]
        [Route("goldRatedCustomerFare")]
        public float GetGoldRatedCustomeFare()
        {
            return _query.goldRatedCustomerCost;
        }

        [HttpGet]
        [Route("weekEndDeliveryFare")]
        public float GetWeekEndDeliveryFare()
        {
            return _query.weekEndDeliveryCost;
        }

        [HttpGet]
        [Route("customerCuponeDeliveryFare")]
        public float GetDeliveryFareWithCoupen()
        {
            return _query.customerWithCoupenCost;
        }

        //// POST: api/Queries
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Queries/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
