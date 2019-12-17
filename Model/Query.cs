using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class Query : OrderQuery
    {
        public override float GetDeliveryDistanceFare(float distance)
        {
            float cost = 0;
            cost =  distance < 10 ? 99.9f : (distance > 50 ? (float) (249.75+((distance-50)* costForKM)) :  249.75f);
            return cost;
        }

        public override float GetFloorDeliveryFare(int floor)
        {
            float cost = 0;
            if (floor == 0)
            {
                return cost;
            } 
            else if(floor<5) {
                cost = 49.95f;
            }
            else
            {
                cost = (floor - 5) * 2;
            }
            return cost;
        }

        public override float GetTotalDeliveyFare(float distance, int floor)
        {
            return baseFare+ GetDeliveryDistanceFare(distance) + GetFloorDeliveryFare(floor);
        }

        public float GetFareForGoldRatedCustomer()
        {
            return goldRatedCustomerCost;
        }

        public float GetWeekEndDeliveryFare()
        {
            return weekEndDeliveryCost;
        }
    }
}
