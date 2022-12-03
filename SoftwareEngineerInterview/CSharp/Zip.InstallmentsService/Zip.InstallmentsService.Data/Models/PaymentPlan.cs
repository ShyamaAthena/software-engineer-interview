using System;
using System.Collections.Generic;
using System.Text;

namespace Zip.InstallmentsService.Data.Models
{
	public class PaymentPlan
	{
		public int Id { get; set; }

		public decimal PurchaseAmount { get; set; }

		public ICollection<Installment> Installments { get; set; }
	}
}
