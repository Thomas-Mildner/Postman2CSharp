using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonSerializer.Deserialize<BindANetworkToATemplateRequest>(myJsonResponse);
namespace MerakiDashboardv135
{
    public class BindANetworkToATemplateRequest
    {
        public string ConfigTemplateId { get; set; }
        public string AutoBind { get; set; }
    }
}