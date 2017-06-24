using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;

namespace Slack
{
	/// <summary>
	/// Slack message attachment. A message can have zero or more attachments.
	/// </summary>
	public class Attachment
	{
		/// <summary>
		/// A valid URL that displays a small 16x16px image to the left of the AuthorName.
		/// Will only work if AuthorName is present.
		/// </summary>
		[JsonProperty(PropertyName = "author_icon")]
		public string AuthorIcon { get; set; }

		/// <summary>
		/// A valid URL that will hyperlink the AuthorName.
		/// Will only work if author_name is present.
		/// </summary>
		[JsonProperty(PropertyName = "author_link")]
		public string AuthorLink { get; set; }

		/// <summary>
		/// Small text used to display the author's name.
		/// </summary>
		[JsonProperty(PropertyName = "author_name")]
		public string AuthorName { get; set; }

		/// <summary>
		/// Can either be one of 'good', 'warning', 'danger', or any hex color code
		/// </summary>
		[JsonProperty(PropertyName = "color")]
		public string Color { get; set; }

		/// <summary>
		/// Required text summary of the attachment that is shown by clients that understand attachments but choose not to show
		/// them.
		/// </summary>
		[JsonProperty(PropertyName = "fallback")]
		public string Fallback { get; set; }

		/// <summary>
		/// Fields are displayed in a table on the message
		/// </summary>
		[JsonProperty(PropertyName = "fields")]
		public List<Field> Fields { get; set; }

		/// <summary>
		/// A valid URL to an image file that will be displayed inside a message attachment.
		/// Currently GIF, JPEG, PNG and BMP formats are supported
		/// </summary>
		[JsonProperty(PropertyName = "image_url")]
		public string ImageUrl { get; set; }

		/// <summary>
		/// Optional list of proporties where markdown syntax will be parsed
		/// applicable to fields, title, and pretext
		/// </summary>
		[JsonProperty(PropertyName = "mrkdwnin")]
		public List<string> MrkdwnIn { get; set; }

		/// <summary>
		/// Optional text that should appear above the formatted data
		/// </summary>
		[JsonProperty(PropertyName = "pretext")]
		public string Pretext { get; set; }

		/// <summary>
		/// Optional text that should appear within the attachment
		/// </summary>
		[JsonProperty(PropertyName = "text")]
		public string Text { get; set; }

		/// <summary>
		/// A valid URL to an image file that will be displayed as a thumbnail on the right
		/// side of a message attachment. We currently support the following formats:
		/// GIF, JPEG, PNG, and BMP.
		/// The thumbnail's longest dimension will be scaled down to 75px while maintaining
		/// the aspect ratio of the image. The filesize of the image must also be less than 500 KB.
		/// </summary>
		[JsonProperty(PropertyName = "thumb_url")]
		public string ThumbUrl { get; set; }

		/// <summary>
		/// Optional title, displayed in bold near the top of the message attachment.
		/// </summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		/// <summary>
		/// Optional link applied to the Title if present
		/// </summary>
		[JsonProperty(PropertyName = "title_link")]
		public string TitleLink { get; set; }

		/// <summary>
		/// Optional link applied to the Footer if present
		/// </summary>
		[JsonProperty(PropertyName = "footer")]
		public string Footer { get; set; }

		/// <summary>
		/// Optional link applied to the Footer Icon if present
		/// </summary>
		[JsonProperty(PropertyName = "footer_icon")]
		public string FooterIcon { get; set; }

		/// <summary>
		/// Optional link applied to the Footer Timestamp if present
		/// </summary>
		[JsonProperty(PropertyName = "ts")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime FooterTimestamp { get; set; }
	}
}
