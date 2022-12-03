using Microsoft.EntityFrameworkCore;
using Zip.InstallmentsService.Data.Models;

namespace Zip.InstallmentsService.Data
{
	public class InstallmentDBContext:DbContext
	{
		public InstallmentDBContext(DbContextOptions<InstallmentDBContext> options): base(options)
		{

		}

		public DbSet<Installment> Installments { get; set; }
		public DbSet<PaymentPlan> PaymentPlans { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new InstallmentEntityConfiguration());

		}
	}
}
