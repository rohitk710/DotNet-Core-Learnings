using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiWithDapper.Models
{
	//These fields will be added to all the tables that needs them
	//These are basically needed for logging purpose.
	public abstract class CommonFields
	{
		// ? stands for optional
		public int? CreatedBy { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public int? ModifiedBy { get; set; }
		public DateTime? ModifiedAt { get; set; }
		public bool IsActive { get; set; } = true;
	}
}
