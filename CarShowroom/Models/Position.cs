using System.Collections.Generic;

namespace CarShowroom.Models
{
	public class Position
	{
		public int PositionId { get; set; }
		public string Title { get; set; }
		public decimal Salary { get; set; }
		public bool IsFullTime { get; set; }
		public bool IsContract { get; set; }

		public virtual ICollection<Worker> Workers { get; set; }
	}
}