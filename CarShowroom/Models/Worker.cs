using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Models
{
	[DisplayName("Pracownik")]
	public class Worker
	{
		public int WorkerId { get; set; }
		[DisplayName("Nazwisko")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string LastName { get; set; }
		[DisplayName("Imię")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string FirstName { get; set; }
		[DisplayName("CNUM")]
		[StringLength(11, MinimumLength = 11, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string Pesel { get; set; }
		[DisplayName("Miasto")]
		[StringLength(11, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string City { get; set; }
		[DisplayName("Ulica")]
		[StringLength(11, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string Street { get; set; }
		[DisplayName("Numer")]
		[Range(1, 10000, ErrorMessage = "Numer musi być od 1 do 10000"), Required(ErrorMessage = "Pole wymagane")]
		public int StreetNumber { get; set; }
		[DisplayName("Stanowisko")]
		public int PositionId { get; set; }

		public string FullName
		{
			get
			{
				return string.Format("{0} {1}", FirstName, LastName);
			}
		}

		public virtual Position Position { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}