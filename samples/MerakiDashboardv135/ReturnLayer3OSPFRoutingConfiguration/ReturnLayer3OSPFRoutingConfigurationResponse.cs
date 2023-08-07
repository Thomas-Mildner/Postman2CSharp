using System;
using System.Collections.Generic;
using System.Text.Json;

namespace MerakiDashboard
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<ReturnLayer3OSPFRoutingConfigurationResponse>(myJsonResponse);
    public class ReturnLayer3OSPFRoutingConfigurationResponse
    {
        public bool Enabled { get; set; }
        public int HelloTimerInSeconds { get; set; }
        public int DeadTimerInSeconds { get; set; }
        public List<Areas> Areas { get; set; }
        public V3 V3 { get; set; }
        public bool Md5AuthenticationEnabled { get; set; }
        public Md5AuthenticationKey Md5AuthenticationKey { get; set; }
    }

    public class V3
    {
        public bool Enabled { get; set; }
        public int HelloTimerInSeconds { get; set; }
        public int DeadTimerInSeconds { get; set; }
        public List<Areas> Areas { get; set; }
    }

    public class Areas
    {
        public string AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaType { get; set; }
    }

    public class Md5AuthenticationKey
    {
        public int Id { get; set; }
        public string Passphrase { get; set; }
    }
}