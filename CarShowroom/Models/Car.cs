using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Models
{
	[DisplayName("Samochód")]
	public class Car
	{
		public int CarId { get; set; }
		[DisplayName("Marka")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string Brand { get; set; }
		[DisplayName("Model")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string Model { get; set; }
		[DisplayName("Cena")]
		[DataType(DataType.Currency, ErrorMessage = "Wartość musi być kwotą")]
		[Range(1000, 5000000, ErrorMessage = "Cena musi być od 1000 do 5000000"), Required(ErrorMessage = "Pole wymagane")]
		public decimal Price { get; set; }
		[DisplayName("Nowy")]
		public bool IsNew { get; set; }

		public string BrandModel
		{
			get
			{
				return string.Format("{0} {1}", Brand, Model);
			}
		}

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}