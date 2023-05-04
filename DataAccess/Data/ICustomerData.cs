using DataAccess.Models;

namespace DataAccess.Data
{
	public interface ICustomerData
	{
		Task<IEnumerable<CustomerModel>> GetCustomers();
		Task<CustomerModel?> GetCustomer(int id);
		Task InsertCustomer(CustomerModel customer);
		Task UpdateCustomer(CustomerModel customer);
		Task DeleteCustomer(int id);
	}
}