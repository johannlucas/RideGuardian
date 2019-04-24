namespace RideGuardian.Models
{
    public class Webhook
    {
        public string Url { get; set; }
        public Authentication Authentication { get; set; }
        public string[] Subscriptions { get; set; }
    }
}
