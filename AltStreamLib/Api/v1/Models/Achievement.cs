using Newtonsoft.Json;

namespace AltStreamLib.Api.v1.Models
{
    public class Achievement
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    
        [JsonProperty("name")]
        public string Name { get; set; }
    
        [JsonProperty("type")]
        public string Type { get; set; }
    
        [JsonProperty("category")]
        public string Category { get; set; }
    
        [JsonProperty("description")]
        public string Description { get; set; }
    
        [JsonProperty("isUnlocked")]
        public bool IsUnlocked { get; set; }
    
        [JsonProperty("unlockedAt")]
        public string UnlockedAt { get; set; }
    
        [JsonProperty("unlockedDetails")]
        public string UnlockedDetails { get; set; }
    
        [JsonProperty("lockedReason")]
        public string LockedReason { get; set; }
    
        [JsonProperty("progress")]
        public Progress Progress { get; set; }

        public Achievement(string id, string name, string type, string category, string description,
            bool isUnlocked, string unlockedAt, string unlockedDetails, string lockedReason, Progress progress)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Category = category;
            this.Description = description;
            this.IsUnlocked = isUnlocked;
            this.UnlockedAt = unlockedAt;
            this.UnlockedDetails = unlockedDetails;
            this.LockedReason = lockedReason;
            this.Progress = progress;
        }

        public Achievement() { }
    }

    public class Progress
    {
        [JsonProperty("current")]
        public int Current { get; set; }
    
        [JsonProperty("target")]
        public int Target { get; set; }

        public Progress(int current, int target)
        {
            this.Current = current;
            this.Target = target;
        }

        public Progress() { }
    }
}
