using System.Net.Http;

namespace RideGuardian
{
    public abstract class Http
    {
        public readonly IHttpClientFactory _clientFactory;

        public Http(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;
        }
    }
}
