using DataAccess.DbAccess;
using DataAccess.Models;
using System;

namespace DataAccess.Data
{
	public class CustomerData : ICustomerData
	{
		private readonly ISqlDataAccess _db;

		public CustomerData(ISqlDataAccess db) => _db = db;

		public Task<IEnumerable<CustomerModel>> GetCustomers() =>
			_db.LoadData<CustomerModel,dynamic>("dbo.spCustomer_GetAll", new { });

		public async Task<CustomerModel?> GetCustomer(int id)
		{
			IEnumerable<CustomerModel?> results = await _db.LoadData<CustomerModel, dynamic>(
				"dbo.spCustomer_Get", new { Id = id });
			return results.FirstOrDefault();
		}

		public Task InsertCustomer(CustomerModel customer) =>
			_db.SaveData("dbo.spCustomer_Insert", new { customer.Name, customer.Surname });

		public Task UpdateCustomer(CustomerModel customer) =>
			_db.SaveData("dbo.spCustomer_Update", customer);

		public Task DeleteCustomer(int id) =>
			_db.SaveData("dbo.spCustomer_Delete", new { Id = id } );

	}
}
