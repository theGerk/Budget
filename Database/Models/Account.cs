using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class Account
    {
		public enum AccountType
		{
			Savings,
			Loan,
			BudgetCategory,
		}

		public Guid AccountId { get; set; }
		[Required]
		[MaxLength(50)]
		public string? Name { get; set; }
		public Directory? ParentDirectory { get; set; }
		public uint DirectoryPositioning { get; set; }
		public AccountType Type { get; set; }
		public decimal MinimumBalance { get; set; }
		public List<Target>? Targets { get; set; }
	}

    public class Target
    {
		public enum RecurrenceType
		{
			NoRecurrence,
			Monthly,
			Yearly,
			Weekly,
			Daily,
			Fortnightly,
		}
		public Guid TargetId { get; set; }
		public decimal Amount { get; set; }
		public DateTime DueDate { get; set; }
		public RecurrenceType Recurrence { get; set; }
	}
}
