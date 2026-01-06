using System;
using System.Collections.Generic;
using System.Numerics;
using Database.Models;
using Microsoft.EntityFrameworkCore;

public class DatabaseContext: DbContext
{
	public DbSet<Account> Accounts { get; set; }


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Budget;Integrated Security=True;TrustServerCertificate=True;", o => o.UseCompatibilityLevel(170));
	}
}