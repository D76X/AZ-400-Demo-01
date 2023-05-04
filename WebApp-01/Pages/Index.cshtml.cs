using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_01.Pages
{
	public class IndexModel : PageModel
	{
		public IList<CustomerModel> Customers { get; set; }

		private readonly ICustomerData _customerData;
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(
			ICustomerData customerData,
			ILogger<IndexModel> logger)
		{
			_customerData = customerData;
			_logger = logger;
		}

		//public void OnGet()
		//{
		//}

		public async Task OnGetAsync()
		{
			try
			{
				var customers = await _customerData.GetCustomers();
				Customers = customers.ToList();
			}
			catch (Exception e)
			{
				// do anything you may here.
				// In this case we keep as simple as possible as it is just demo code.
				_logger.LogError(e.Message);
				throw;
			}
		}
	}
}