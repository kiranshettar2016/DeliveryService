using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public interface ICustomerRepository
    {
        Customer  GetCustomer(int CustId);
        IEnumerable<Customer> GetAllCustomer();
        Customer AddCustomer(Customer customer);
        List<Order> GetOrders(int CustId);
    }
}
