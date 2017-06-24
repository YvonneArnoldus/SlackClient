using Newtonsoft.Json;

namespace Slack
{
	/// <summary>
	/// Slack Field. Fields are displayed in a table on the message
	/// </summary>
	public class Field
	{
		/// <summary>
		/// Optional flag indicating whether the `value` is short enough to be displayed side-by-side with other values
		/// </summary>
		[JsonProperty(PropertyName = "short")]
		public bool Short { get; set; }

		/// <summary>
		/// Required Field Title
		/// </summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		/// <summary>
		/// Text value of the field. May contain standard message markup and must be escaped as normal. May be multi-line
		/// </summary>
		[JsonProperty(PropertyName = "value")] 
		public string Value { get; set; }
	}
}
