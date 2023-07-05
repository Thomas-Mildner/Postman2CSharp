using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonSerializer.Deserialize<UpdateSwitchNetworkSettingsRequest>(myJsonResponse);
namespace MerakiDashboard
{
    public class UpdateSwitchNetworkSettingsRequest
    {
        public string Vlan { get; set; }
        public string UseCombinedPower { get; set; }
        public List<PowerExceptions> PowerExceptions { get; set; }
        public VlanTagging3 UplinkClientSampling { get; set; }
    }
}