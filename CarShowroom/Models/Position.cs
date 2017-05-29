﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Models
{
	[DisplayName("Stanowisko")]
	public class Position
	{
		public int PositionId { get; set; }
		[DisplayName("Tytuł")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Maksymalnie 50 znaków"), Required(ErrorMessage = "Pole wymagane")]
		public string Title { get; set; }
		[DisplayName("Pensja")]
		[DataType(DataType.Currency, ErrorMessage = "Wartość musi być kwotą")]
		[Range(1, 5000000, ErrorMessage = "Pensja musi być od 1 do 5000000"), Required(ErrorMessage = "Pole wymagane")]
		public decimal Salary { get; set; }
		[DisplayName("Pełny etat")]
		public bool IsFullTime { get; set; }
		[DisplayName("Kontrakt")]
		public bool IsContract { get; set; }

		public virtual ICollection<Worker> Workers { get; set; }
	}
}