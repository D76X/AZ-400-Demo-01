using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
	public interface IAddressData
	{
		Task<IEnumerable<AddressModel>> GetAddresses();
		Task<AddressModel?> GetAddress(int id);
		Task InsertCustomer(AddressModel address);
		Task UpdateCustomer(AddressModel address);
		Task DeleteAddress(int id);
	}

	public class AddressData : IAddressData
	{
		private readonly ISqlDataAccess _db;

		public AddressData(ISqlDataAccess db) => _db = db;

		public Task<IEnumerable<AddressModel>> GetAddresses() =>
			_db.LoadData<AddressModel, dynamic>("dbo.spAddress_GetAll", new { });

		public async Task<AddressModel?> GetAddress(int id)
		{
			IEnumerable<AddressModel?> results = await _db.LoadData<AddressModel, dynamic>(
				"dbo.spAddress_Get", new { Id = id });
			return results.FirstOrDefault();
		}

		public Task InsertCustomer(AddressModel address) =>
			_db.SaveData("dbo.spAddress_Insert", new
			{
				address.Country, 
				address.ZipCode, 
				address.AddressLine1,
				address.AddressLine2
			});

		public Task UpdateCustomer(AddressModel address) =>
			_db.SaveData("dbo.spAddress_Update", address);

		public Task DeleteAddress(int id) =>
			_db.SaveData("dbo.spAddress_Delete", new { Id = id });

	}
}