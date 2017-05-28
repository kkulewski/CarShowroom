using System.Collections.Generic;

namespace CarShowroom.Models
{
	public class Client
	{
		public int ClientId { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string PESEL { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int StreetNumber { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}