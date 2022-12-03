using System;
using System.Collections.Generic;
using System.Text;
using Zip.InstallmentsService.Data.Models;

namespace Zip.InstallmentsService.Data.Services
{
	public interface IPaymentPlanServices
	{
		///<summary>
		///Create and save payment plan
		///
		PalnResponseModel SavePaymetPlan(PaymentPlan paymentPlan);
	}
}
