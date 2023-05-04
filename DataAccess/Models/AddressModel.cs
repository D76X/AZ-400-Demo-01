namespace DataAccess.Models
{
	public class AddressModel
	{
		public int Id { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
	}
}