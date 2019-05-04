using System.Threading.Tasks;

namespace RideGuardian.Domain.Interfaces
{
    public interface IWebhookService
    {
        Task GetWebhook();
    }
}
