using System;
using System.Collections.Generic;
using System.Text.Json;

// Root myDeserializedClass = JsonSerializer.Deserialize<REachUplinkOfAllMXAndZNetworksWithinAnOrganizationParameters>(myJsonResponse);
namespace MerakiDashboardv135
{
    public class REachUplinkOfAllMXAndZNetworksWithinAnOrganizationParameters : IQueryParameters
    {
        /// <summary>
        /// The beginning of the timespan for the data. The maximum lookback period is 365 days from today. 
        /// </summary>
        public string T0 { get; set; }
        
        /// <summary>
        /// The end of the timespan for the data. t1 can be a maximum of 14 days after t0. 
        /// </summary>
        public string T1 { get; set; }
        
        /// <summary>
        /// The timespan for which the information will be fetched. If specifying timespan, do not specify 
        /// parameters t0 and t1. The value must be in seconds and be less than or equal to 14 days. The default 
        /// is 1 day. 
        /// </summary>
        public string Timespan { get; set; }

        public Dictionary<string, string?> ToDictionary()
        {
            return new Dictionary<string, string?>
            {
                {
                    "t0",
                    T0
                },
                {
                    "t1",
                    T1
                },
                {
                    "timespan",
                    Timespan
                }
            };
        }
    }
}