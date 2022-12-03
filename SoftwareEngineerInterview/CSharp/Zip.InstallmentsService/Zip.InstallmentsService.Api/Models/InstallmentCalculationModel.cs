using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zip.InstallmentsService.Api.Models
{
	public class InstallmentCalculationModel
	{
		public DateTime StartDate { get; set; }

		[Required]
		public decimal Amount { get; set; }

		[Required]
		public int Installments { get; set; }

		[Required]
		public int Frequency { get; set; }
	}
}
