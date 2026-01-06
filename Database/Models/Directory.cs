using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Directory
    {
		public Guid DirectoryId { get; set; }
		public string Name { get; set; }
		public Directory ParentDirectory { get; set; }
	}
}
