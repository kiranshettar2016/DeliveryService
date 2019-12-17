using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly DSContext dSContext;

        public SQLCustomerRepository(DSContext dSContext)
        {
            this.dSContext = dSContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            dSContext.Add(customer);
            dSContext.SaveChanges();
            return customer;
        }


        public  IEnumerable<Customer> GetAllCustomer()
        {
           return dSContext.Customers.AsEnumerable();
        }

        public Customer GetCustomer(int CustId)
        {
            var cust = dSContext.Customers.Find(CustId);
            if(cust!=null)
            {
                cust.CustomerOrder = GetOrders(CustId);
                return cust;
            }
            return null;
            
        }

        public List<Order> GetOrders(int CustId)
        {
            return dSContext.Orders.Where(e => e.CustomerId == CustId).ToList<Order>();
        }
    }
}
