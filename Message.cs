using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slack
{
	/// <summary>
	/// Slack Message
	/// </summary>
	public class Message
	{
		/// <summary>
		/// Optional attachment collection
		/// </summary>
		[JsonProperty(PropertyName = "attachments")]
		public List<Attachment> Attachments { get; set; }

		/// <summary>
		/// Optional override of destination channel
		/// </summary>
		[JsonProperty(PropertyName = "channel")]
		public string Channel { get; set; }

		/// <summary>
		/// Optional emoji displayed with the message
		/// </summary>
		[JsonProperty(PropertyName = "icon_emoji")]
		public string IconEmoji { get; set; }

		/// <summary>
		/// Optional url for icon displayed with the message
		/// </summary>
		[JsonProperty(PropertyName = "icon_url")]
		public Uri IconUrl { get; set; }

		/// <summary>
		/// Enable linkification of channel and usernames
		/// </summary>
		[JsonProperty(PropertyName = "linknames")]
		public bool LinkNames { get; set; }

		/// <summary>
		/// Optional override markdown mode. Default: true
		/// </summary>
		[JsonProperty(PropertyName = "mrkdwn")]
		public bool Mrkdwn { get; set; } = true;

		/// <summary>
		/// Parse mode <see cref="ParseMode"/>
		/// </summary>
		[JsonProperty(PropertyName = "parse")]
		public string Parse { get; set; }

		/// <summary>
		/// This is the text that will be posted to the channel
		/// </summary>
		[JsonProperty(PropertyName = "text")]
		public string Text { get; set; }

		/// <summary>
		/// Optional override of the username that is displayed
		/// </summary>
		[JsonProperty(PropertyName = "username")]
		public string Username { get; set; }

		/// <summary>
		/// Clone the <see cref="Message"/> to the new channel
		/// </summary>
		/// <param name="newChannel">The new channel.</param>
		/// <returns>a <see cref="Message"/>.</returns>
		public Message Clone(string newChannel = null)
		{
			return new Message
			{
				Attachments = Attachments,
				Text = Text,
				IconEmoji = IconEmoji,
				IconUrl = IconUrl,
				Username = Username,
				Channel = newChannel ?? Channel
			};
		}
	}
}
