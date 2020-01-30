namespace NraDatabaseExport.App.ViewModels
{
	/// <summary>
	/// Represents an enumeration of the export statuses of a database table.
	/// </summary>
	public enum DbTableExportStatus
	{
		/// <summary>
		/// Missing
		/// </summary>
		/// <remarks>
		/// The table is required but missing.
		/// </remarks>
		Missing,

		/// <summary>
		/// Skipped
		/// </summary>
		/// <remarks>
		/// The table has been skipped because it was not selected for export.
		/// </remarks>
		Skipped,

		/// <summary>
		/// Busy
		/// </summary>
		/// <remarks>
		/// The table is being exported.
		/// </remarks>
		Busy,

		/// <summary>
		/// OK
		/// </summary>
		/// <remarks>
		/// The table has been exported successfully.
		/// </remarks>
		Ok,

		/// <summary>
		/// Error
		/// </summary>
		/// <remarks>
		/// An error has occurred during table export.
		/// </remarks>
		Error,
	}
}
