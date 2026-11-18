using System.Collections.Generic;
using Newtonsoft.Json;
using AltStreamLib.Api.v2.Models;

namespace AltStreamLib.Api.v1.Models
{
    public class AchievementsResponse
    {
        [JsonProperty("user")]
        public RedemptionUser User { get; set; }
    
        [JsonProperty("selectedBadges")]
        public string[] SelectedBadges { get; set; }
    
        [JsonProperty("achievements")]
        public List<Achievement> Achievements { get; set; }

        public AchievementsResponse(RedemptionUser user, string[] selectedBadges, List<Achievement> achievements)
        {
            this.User = user;
            this.SelectedBadges = selectedBadges;
            this.Achievements = achievements;
        }

        public AchievementsResponse() { }
    }
}
