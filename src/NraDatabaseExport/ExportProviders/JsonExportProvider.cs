﻿#if SUPPORT_JSON
using System;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace NraDatabaseExport.ExportProviders
{
	/// <summary>
	/// Represents an export provider for writing a JSON file.
	/// </summary>
	[ExportProvider(ExportProviderType.Csv, "JSON",
		DefaultExtension = ".json")]
	public class JsonExportProvider : ExportProviderBase
	{
		private Stream _stream;
		private Utf8JsonWriter _jsonWriter;

		#region ExportProviderBase Members

		/// <inheritdoc/>
		public override void OpenWrite(string filePath)
		{
			Stream stream = null;
			Utf8JsonWriter jsonWriter = null;

			try
			{
				stream = File.OpenWrite(filePath);

				var csvConfiguration = new JsonWriterOptions
				{
					Indented = false,
				};

				jsonWriter = new Utf8JsonWriter(stream, csvConfiguration);
			}
			catch
			{
				jsonWriter?.Dispose();
				stream?.Dispose();

				throw;
			}

			_stream = stream;
			_jsonWriter = jsonWriter;

			_jsonWriter.WriteStartArray();
		}

		/// <inheritdoc/>
		public override void WriteHeaderRow(string[] columns)
		{
			if (columns is null)
			{
				throw new ArgumentNullException(nameof(columns));
			}

			_jsonWriter.WriteStartArray();

			foreach (string column in columns)
			{
				if (column is null)
				{
					_jsonWriter.WriteNullValue();
				}
				else
				{
					_jsonWriter.WriteStringValue(column);
				}
			}

			_jsonWriter.WriteEndArray();
		}

		/// <inheritdoc/>
		public override void WriteDataRow(object[] values)
		{
			if (values is null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			_jsonWriter.WriteStartArray();

			foreach (object value in values)
			{
				switch (value)
				{
					case bool b:
						{
							_jsonWriter.WriteBooleanValue(b);
							break;
						}
					case string s:
						{
							_jsonWriter.WriteStringValue(s);
							break;
						}
					case decimal d:
						{
							_jsonWriter.WriteNumberValue(d);
							break;
						}
					case double dbl:
						{
							_jsonWriter.WriteNumberValue(dbl);
							break;
						}
					case float f:
						{
							_jsonWriter.WriteNumberValue(f);
							break;
						}
					case int i:
						{
							_jsonWriter.WriteNumberValue(i);
							break;
						}
					case long l:
						{
							_jsonWriter.WriteNumberValue(l);
							break;
						}
					case uint ui:
						{
							_jsonWriter.WriteNumberValue(ui);
							break;
						}
					case ulong ul:
						{
							_jsonWriter.WriteNumberValue(ul);
							break;
						}
					case DateTime dt:
						{
							string s = dt.ToString("o", CultureInfo.InvariantCulture);
							_jsonWriter.WriteStringValue(s);
							break;
						}
					case DateTimeOffset dto:
						{
							string s = dto.ToString("o", CultureInfo.InvariantCulture);
							_jsonWriter.WriteStringValue(s);
							break;
						}
					case TimeSpan ts:
						{
							string s = ts.ToString("G", CultureInfo.InvariantCulture);
							_jsonWriter.WriteStringValue(s);
							break;
						}
					case byte[] bytes:
						{
							_jsonWriter.WriteBase64StringValue(bytes);
							break;
						}
					case DBNull _:
					case null:
						{
							_jsonWriter.WriteNullValue();
							break;
						}
					default:
						{
							throw new NotSupportedException($"Values of type `{value.GetType()}` cannot be exported to JSON");
						}
				}
			}

			_jsonWriter.WriteEndArray();
		}

		/// <inheritdoc/>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_jsonWriter?.WriteEndArray();

				_jsonWriter?.Flush();
				_jsonWriter?.Dispose();
				_jsonWriter = null;

				_stream?.Dispose();
				_stream = null;
			}

			base.Dispose(disposing);
		}

		#endregion
	}
}
#endif
