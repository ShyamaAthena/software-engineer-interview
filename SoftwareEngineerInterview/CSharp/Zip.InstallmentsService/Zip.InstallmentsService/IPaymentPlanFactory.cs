using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip.InstallmentsService
{
	interface IPaymentPlanFactory
	{
		public PaymentPlan CreatePaymentPlan(decimal purchaseAmount, int NumberofInstallments, int Frequency);

	}
}
