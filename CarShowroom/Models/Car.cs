using System.Collections.Generic;

namespace CarShowroom.Models
{
	public class Car
	{
		public int CarId { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public decimal Price { get; set; }
		public bool IsNew { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}