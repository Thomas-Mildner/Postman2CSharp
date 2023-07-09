using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonSerializer.Deserialize<EdNetworkIntoIndividualNetworksForEachTypeOfDeviceResponse>(myJsonResponse);
namespace MerakiDashboardv135
{
    public class EdNetworkIntoIndividualNetworksForEachTypeOfDeviceResponse
    {
        public List<ResultingNetworks> ResultingNetworks { get; set; }
    }

    public class ResultingNetworks
    {
        public string Id { get; set; }
        public string OrganizationId { get; set; }
        public string Name { get; set; }
        public List<string> ProductTypes { get; set; }
        public string TimeZone { get; set; }
        public List<string> Tags { get; set; }
        public string EnrollmentString { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }
        public bool IsBoundToConfigTemplate { get; set; }
    }
}