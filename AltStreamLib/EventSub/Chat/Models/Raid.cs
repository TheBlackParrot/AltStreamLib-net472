using Newtonsoft.Json;

namespace AltStreamLib.EventSub.Chat.Models
{
    public class Raid
    {
        [JsonProperty("to")]
        public Author To { get; set; }

        [JsonProperty("from")]
        public Author From { get; set; }
    
        [JsonProperty("viewers")]
        public int Viewers { get; set; }

        [JsonProperty("countdownSeconds")]
        public int? CountdownSeconds { get; set; }

        [JsonProperty("startTime")]
        public long? StartTime { get; set; }

        public Raid(Author to, Author from, int viewers, int? countdownSeconds, long? startTime)
        {
            this.To = to;
            this.From = from;
            this.Viewers = viewers;
            this.CountdownSeconds = countdownSeconds;
            this.StartTime = startTime;
        }

        public Raid() { }
    }
}
