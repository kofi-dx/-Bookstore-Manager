namespace Bookstore.Models
{
    public class RequestLog
    {
        public int Id { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string QueryString { get; set; } = string.Empty;
        public string RemoteIp { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int StatusCode { get; set; }
        public long Duration { get; set; } // in milliseconds
        public string UserId { get; set; } = string.Empty;
    }
}