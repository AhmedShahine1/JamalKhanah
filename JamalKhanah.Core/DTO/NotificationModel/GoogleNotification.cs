using Newtonsoft.Json;

namespace JamalKhanah.Core.DTO.NotificationModel;

public class GoogleNotification
{
    public class DataPayload
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    [JsonProperty("priority")]
    public string Priority { get; set; } = "high";

    [JsonProperty("to")]
    public string Token { get; set; }

    [JsonProperty("notification")]
    public DataPayload Notification { get; set; }
}