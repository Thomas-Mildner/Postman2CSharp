using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonSerializer.Deserialize<ReturnsSenseSettingsForAGivenCameraResponse>(myJsonResponse);
namespace MerakiDashboardv135
{
    public class ReturnsSenseSettingsForAGivenCameraResponse
    {
        public bool SenseEnabled { get; set; }
        public AudioDetection AudioDetection { get; set; }
        public string MqttBrokerId { get; set; }
        public List<string> MqttTopics { get; set; }
    }

    public class AudioDetection
    {
        public bool Enabled { get; set; }
    }
}