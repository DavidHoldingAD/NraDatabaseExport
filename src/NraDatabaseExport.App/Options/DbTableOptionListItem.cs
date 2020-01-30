namespace NraDatabaseExport.App.Options
{
	/// <summary>
	/// Represents an item in a list of tables options.
	/// </summary>
	public class DbTableOptionListItem
	{
		/// <summary>
		/// Gets or sets the name of the table.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the name of the owner of the table.
		/// </summary>
		public string? OwnerName { get; set; }

		/// <summary>
		/// Gets or sets the flag indicating whether the table should exist or not.
		/// </summary>
		public bool IsRequired { get; set; }
	}
}
