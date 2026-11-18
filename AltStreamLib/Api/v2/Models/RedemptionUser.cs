using Newtonsoft.Json;

namespace AltStreamLib.Api.v2.Models
{
    public class RedemptionUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    
        [JsonProperty("username")]
        public string Username { get; set; }
    
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    
        [JsonProperty("image")]
        public string Image { get; set; }

        public RedemptionUser(string id, string username, string displayName, string image)
        {
            this.Id = id;
            this.Username = username;
            this.DisplayName = displayName;
            this.Image = image;
        }

        public RedemptionUser() { }
    }
}
