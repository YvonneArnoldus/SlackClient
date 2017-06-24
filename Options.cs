using System.ComponentModel.DataAnnotations;

namespace Slack
{
	public class Options
	{
		[Required]
		public string WebhookUrl { get; set; }
	}
}
