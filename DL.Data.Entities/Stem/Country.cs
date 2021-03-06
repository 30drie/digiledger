namespace DL.Data.Entities.Stem
{
	public class Country
	{
		public string CountryId { get; set; }

		public string CountryName { get; set; }

		public string CurrencyId { get; set; }

		public Currency Currency { get; set; }
	}
}
