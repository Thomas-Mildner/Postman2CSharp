using System;
using System.Collections.Generic;
using System.Text.Json;

namespace MerakiDashboard
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<AddDeleteOrUpdateTheTagsOfASetOfDevicesRequest>(myJsonResponse);
    public class AddDeleteOrUpdateTheTagsOfASetOfDevicesRequest
    {
        public List<string> Tags { get; set; }
        public string UpdateAction { get; set; }
        public List<string> WifiMacs { get; set; }
        public List<string> Ids { get; set; }
        public List<string> Serials { get; set; }
        public List<string> Scope { get; set; }
    }
}