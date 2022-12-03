using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zip.InstallmentsService.Data.Models
{
	public class Installment
	{
        public int Id { get; set; }

       
        public DateTime DueDate { get; set; }

        
        public decimal Amount { get; set; }
		public int PaymentPlanId { get; set; }
		public PaymentPlan PaymentPlan { get; set; }
    }

	public class InstallmentEntityConfiguration : IEntityTypeConfiguration<Installment>
	{
		public void Configure(EntityTypeBuilder<Installment> builder)
		{
			builder.HasOne(x => x.PaymentPlan).WithMany(x => x.Installments).HasForeignKey(x => x.PaymentPlanId);
		}
	}

}
