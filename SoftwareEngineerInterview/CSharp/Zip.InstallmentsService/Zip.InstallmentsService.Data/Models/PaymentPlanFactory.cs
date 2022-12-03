using Zip.InstallmentsService.Data;
using Zip.InstallmentsService.Data.Models;

namespace Zip.InstallmentsService.Core.Entities
{
    /// <summary>
    /// This class is responsible for building the PaymentPlan according to the Zip product definition.
    /// </summary>
    public class PaymentPlanFactory 
    {
        /// <summary>
        /// Builds the PaymentPlan instance.
        /// </summary>
        /// <param name="purchaseAmount">The total amount for the purchase that the customer is making.</param>
        /// <returns>The PaymentPlan created with all properties set.</returns>
        public PaymentPlan CreatePaymentPlan(decimal purchaseAmount, int NumberofInstallments, int FrequencyInDays)
        {
            // TODO
            return new PaymentPlan();
        }
	}
}
