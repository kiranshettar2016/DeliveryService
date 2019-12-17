using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _customerList;
        private List<Order> _orderList;

        public MockCustomerRepository()
        {
            _customerList = new List<Customer>()
            {
                new Customer() { CustomerId = 1,  CustomerName = "Shiv", IsNewCustomer = false, CustomerOrder = new List<Order>{ new Order{ OrderID=10, CustomerId=1, distance=10, floor=0 } } },
                new Customer() { CustomerId = 2,  CustomerName = "Ram", IsNewCustomer = false, CustomerOrder = new List<Order>{ new Order{ OrderID=11, CustomerId=2, distance=30, floor=5 } } },
                new Customer() { CustomerId = 3,  CustomerName = "Vishnu", IsNewCustomer = true, CustomerOrder = new List<Order>{ new Order{ OrderID=12, CustomerId=3, distance=52, floor=7 } } },
                new Customer() { CustomerId = 4,  CustomerName = "Parvati", IsNewCustomer = true, CustomerOrder = new List<Order>{ new Order{ OrderID=14, CustomerId=4, distance=10, floor=15 } } },
            };
            _orderList = new List<Order>()
            {
                new Order{ OrderID=10, CustomerId=1, distance=10, floor=0 },
                new Order{ OrderID=11, CustomerId=2, distance=30, floor=5 },
                new Order{ OrderID=12, CustomerId=3, distance=52, floor=7 } ,
                new Order{ OrderID=14, CustomerId=4, distance=10, floor=15 }

            };
        }
        public Customer AddCustomer(Customer cust)
        {
            cust.CustomerId = _customerList.Max(e => e.CustomerId) + 1;
            _customerList.Add(cust);
            return cust;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerList;
        }

        public Customer GetCustomer(int CustId)
        {
            return this._customerList.FirstOrDefault(e => e.CustomerId == CustId);
        }

        public List<Order> GetOrders(int CustId)
        {
            return this._orderList.FindAll(e => e.CustomerId == CustId).ToList<Order>();
        }
    }
}
