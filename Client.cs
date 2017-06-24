using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Slack
{
	public class Client
	{
		/// <summary>
		/// Holds the HttpClient to Slack
		/// </summary>
		private static readonly HttpClient HttpClient = new HttpClient
		{
			BaseAddress = new Uri("https://hooks.slack.com")
		};

		private readonly Uri _webhookUri;

		public Client(IOptions<Options> options)
		{
			if (options == null) 
				throw new ArgumentNullException(nameof(options));

			if (!Uri.TryCreate(options.Value.WebhookUrl, UriKind.Absolute, out Uri webhookUri))
				throw new ArgumentException("Please enter a valid Slack webhook url");

			_webhookUri = webhookUri;
		}

		public async Task<HttpResponseMessage> PostAsync(Message message)
		{
			var content = new StringContent(JsonConvert.SerializeObject(message), Encoding.UTF8, "application/json");

			return await HttpClient.PostAsync(_webhookUri.AbsolutePath, content);
		}
	}
}
