using Newtonsoft.Json;

namespace AltStreamLib.Api.v2.Models
{
    public class Redemption
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    
        [JsonProperty("rewardId")]
        public int RewardId { get; set; }
    
        [JsonProperty("rewardName")]
        public string RewardName { get; set; }
    
        [JsonProperty("rewardCost")]
        public int RewardCost { get; set; }
    
        [JsonProperty("userInput")]
        public string UserInput { get; set; }
    
        [JsonProperty("status")]
        public string Status { get; set; }
    
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    
        [JsonProperty("user")]
        public RedemptionUser User { get; set; }

        public Redemption(int id, int rewardId, string rewardName, int rewardCost, string userInput,
            string status, string createdAt, string updatedAt, RedemptionUser user)
        {
            this.Id = id;
            this.RewardId = rewardId;
            this.RewardName = rewardName;
            this.RewardCost = rewardCost;
            this.UserInput = userInput;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.User = user;
        }

        public Redemption() { }
    }

    public enum RedemptionStatus
    {
        None,
        Unfulfilled,
        Fulfilled,
        Refunded
    }
}