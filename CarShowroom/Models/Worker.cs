using System.Collections.Generic;

namespace CarShowroom.Models
{
	public class Worker
	{
		public int WorkerId { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Pesel { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int StreetNumber { get; set; }
		public int PositionId { get; set; }

		public virtual Position Position { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}