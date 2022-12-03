using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Zip.InstallmentsService.Api.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zip.InstallmentsService.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InstallmentCalculationController : ControllerBase
	{

		private readonly ILogger<InstallmentCalculationController> _logger;
		//private readonly IPaymentPlanFactory _paymentFactory;
		public  InstallmentCalculationController(ILogger<InstallmentCalculationController> logger)
		{
			_logger = logger;
		}

		// POST api/<InstallmentCalculationController>
		[HttpPost]
		public void Post([FromBody] InstallmentCalculationModel installmentCalculationModel)
		{
			_logger.LogInformation($"Create InstallmentPlan for {installmentCalculationModel} API call");

			installmentCalculationModel.StartDate = DateTime.Now;
		}

	}
}
