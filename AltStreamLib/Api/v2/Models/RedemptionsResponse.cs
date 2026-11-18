using System.Collections.Generic;
using Newtonsoft.Json;

namespace AltStreamLib.Api.v2.Models
{
    public class RedemptionsResponse
    {
        [JsonProperty("redemptions")]
        public List<Redemption> Redemptions { get; set; }

        public RedemptionsResponse(List<Redemption> redemptions)
        {
            this.Redemptions = redemptions;
        }

        public RedemptionsResponse() { }
    }
}
