using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public abstract class OrderQuery
    {
        public float baseFare = 999;
        public float costForKM = 0.25f;
        public float goldRatedCustomerCost = 899.1f;
        public float weekEndDeliveryCost = 1498.5f;
        public float customerWithCoupenCost = 799.2f;

        public abstract float GetDeliveryDistanceFare(float distance);
        public abstract float GetFloorDeliveryFare(int floor);

        public abstract float GetTotalDeliveyFare(float distance, int floor);
    }
}
