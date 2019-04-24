using RideGuardian.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RideGuardian.BO
{
    public class WebhookBO : Http
    {
        public WebhookBO(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }

        public async Task GetWebhook()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api-corp.99app.com/v1/webhooks/");
            var client = this._clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var webhook = await response.Content.ReadAsAsync<Authentication>();
            }
        }
    }
}
