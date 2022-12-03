using System;
using System.Collections.Generic;
using System.Text;
using Zip.InstallmentsService.Data.Models;

namespace Zip.InstallmentsService.Data.Services
{
	public class PaymentPlanService : IPaymentPlanServices
	{
		private InstallmentDBContext _installmentDBContext;

		public PaymentPlanService(InstallmentDBContext installmentDBContext)
		{
			_installmentDBContext = installmentDBContext;
		}
		public PalnResponseModel SavePaymetPlan(PaymentPlan paymentPlan)
		{
			PalnResponseModel planResponseModel =new  PalnResponseModel();
			try
			{
				_installmentDBContext.Add<PaymentPlan>(paymentPlan);
				planResponseModel.PlanMessage = "New PaymentPlan created";
				_installmentDBContext.SaveChanges();
				planResponseModel.IsPlanCreated = true;
			}
			catch(Exception ex)
			{
				planResponseModel.IsPlanCreated = false;
				planResponseModel.PlanMessage = "Error creating plan";
			}
			return planResponseModel;
		}
	}
}
