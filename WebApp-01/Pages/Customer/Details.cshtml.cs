using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_01.Pages.Customer
{
	public class DetailsModel : PageModel
	{
		public CustomerModel Customer { get; set; }

		private readonly ICustomerData _customerData;
		private readonly ILogger<DetailsModel> _logger;

		public DetailsModel(
			ICustomerData customerData,
			ILogger<DetailsModel> logger)
		{
			_customerData = customerData;
			_logger = logger;
		}

		//public void OnGet()
		//{
		//}

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			try
			{
				if (id == null) return NotFound();
				var customer = await _customerData.GetCustomer(id.Value);
				if (customer == null) return NotFound();
				Customer = customer;
				return Page();
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
