using System.Net.Http;
using System.Threading.Tasks;
using RideGuardian.Domain.Interfaces;

namespace RideGuardian.Domain.Services
{
    public class WebhookService : IWebhookService
    {
        public readonly IHttpClientFactory _clientFactory;

        public WebhookService(IHttpClientFactory httpClientFactory)
        {
            this._clientFactory = httpClientFactory;
        }

        public Task GetWebhook()
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://api-corp.99app.com/v1/webhooks/");
            //var client = this._clientFactory.CreateClient();

            //var response = await client.SendAsync(request);

            //if (response.IsSuccessStatusCode)
            //{
            //    var webhook = await response.Content.ReadAsAsync<Authentication>();
            //}

            return null;
        }
    }
}
