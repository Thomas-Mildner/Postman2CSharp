using System.Net.Http.Headers;
using System.Text;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

// Generated using Postman2CSharp https://postman2csharp.com/Convert
namespace MerakiDashboardv135
{
    public class MerakiDashboardv135ApiClient : IMerakiDashboardv135ApiClient
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl = "https://api.meraki.com/api/v1";
        private readonly string _apiKey;
        public MerakiDashboardv135ApiClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri($"https://{_baseUrl}/");
    
            _apiKey = config["Path:ToApiKey"];
        }
    
        /// <summary>
        /// List the organizations that the user has privileges on 
        /// </summary>
        public async Task<ListTheOrganizationsResponse> ListTheOrganizations()
        {
            var headers = new Dictionary<string, string>()
            {
                { $"X-Cisco-Meraki-API-Key", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheOrganizationsResponse>($"organizations", headers);
        }
    
        /// <summary>
        /// List the networks that the user has privileges on in an organization 
        /// </summary>
        /// <param name="organizationId">(Required) </param>
        public async Task<ListTheNetworksInAnOrganizationResponse> ListTheNetworksInAnOrganization(ListTheNetworksInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"X-Cisco-Meraki-API-Key", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/networks", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheNetworksInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the devices in an organization 
        /// </summary>
        /// <param name="organizationId">(Required) </param>
        public async Task<ListTheDevicesInAnOrganizationResponse> ListTheDevicesInAnOrganization(ListTheDevicesInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"X-Cisco-Meraki-API-Key", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheDevicesInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the clients that have used this network in the timespan 
        /// </summary>
        /// <param name="networkId">(Required) </param>
        public async Task<ListTheClientsInANetworkResponse> ListTheClientsInANetwork(ListTheClientsInANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"X-Cisco-Meraki-API-Key", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/clients", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheClientsInANetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Returns the identity of the current user. 
        /// </summary>
        public async Task<ReturnsTheIdentityOfTheCurrentUserResponse> ReturnsTheIdentityOfTheCurrentUser()
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsTheIdentityOfTheCurrentUserResponse>($"administered/identities/me", headers);
        }
    
        /// <summary>
        /// Return the DHCP subnet information for an appliance 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheDHCPSubnetInformationForAnApplianceResponse> ReturnTheDHCPSubnetInformationForAnAppliance(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheDHCPSubnetInformationForAnApplianceResponse>($"devices/{serial}/appliance/dhcp/subnets", headers);
        }
    
        /// <summary>
        /// Return the performance score for a single MX. Only primary MX devices supported. If no data is 
        /// available, a 204 error code is returned. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnThePerformanceScoreForASingleMXResponse> ReturnThePerformanceScoreForASingleMX(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnThePerformanceScoreForASingleMXResponse>($"devices/{serial}/appliance/performance", headers);
        }
    
        /// <summary>
        /// Return current delegated IPv6 prefixes on an appliance. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnCurrentDelegatedIPv6PrefixesOnAnApplianceResponse> ReturnCurrentDelegatedIPv6PrefixesOnAnAppliance(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnCurrentDelegatedIPv6PrefixesOnAnApplianceResponse>($"devices/{serial}/appliance/prefixes/delegated", headers);
        }
    
        /// <summary>
        /// List the security events for a client. Clients can be identified by a client key or either the MAC 
        /// or IP depending on whether the network uses Track-by-IP. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<ListTheSecurityEventsForAClientResponse> ListTheSecurityEventsForAClient(ListTheSecurityEventsForAClientParameters queryParameters, string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/appliance/clients/{clientId}/security/events", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheSecurityEventsForAClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the security events for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheSecurityEventsForAClientResponse> ListTheSecurityEventsForANetwork(ListTheSecurityEventsForANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/appliance/security/events", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheSecurityEventsForAClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the security events for an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheSecurityEventsForAClientResponse> ListTheSecurityEventsForAnOrganization(ListTheSecurityEventsForAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/appliance/security/events", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheSecurityEventsForAClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get the sent and received bytes for each uplink of a network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<GetTheSentAndReceivedBytesForEachUplinkOfANetworkResponse> GetTheSentAndReceivedBytesForEachUplinkOfANetwork(GetTheSentAndReceivedBytesForEachUplinkOfANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/appliance/uplinks/usageHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<GetTheSentAndReceivedBytesForEachUplinkOfANetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the uplink status of every Meraki MX and Z series appliances in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse> EveryMerakiMXAndZSeriesAppliancesInTheOrganization(EveryMerakiMXAndZSeriesAppliancesInTheOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/appliance/uplink/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get the sent and received bytes for each uplink of all MX and Z networks within an organization. If 
        /// more than one device was active during the specified timespan, then the sent and received bytes will 
        /// be aggregated by interface. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<REachUplinkOfAllMXAndZNetworksWithinAnOrganizationResponse> REachUplinkOfAllMXAndZNetworksWithinAnOrganization(REachUplinkOfAllMXAndZNetworksWithinAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/appliance/uplinks/usage/byNetwork", parametersDict);
            return await _httpClient.GetFromJsonAsync<REachUplinkOfAllMXAndZNetworksWithinAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Show VPN history stat for networks in an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ShowVPNHistoryStatForNetworksInAnOrganizationResponse> ShowVPNHistoryStatForNetworksInAnOrganization(ShowVPNHistoryStatForNetworksInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/appliance/vpn/stats", parametersDict);
            return await _httpClient.GetFromJsonAsync<ShowVPNHistoryStatForNetworksInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Show VPN status for networks in an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ShowVPNStatusForNetworksInAnOrganizationResponse> ShowVPNStatusForNetworksInAnOrganization(ShowVPNStatusForNetworksInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/appliance/vpn/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<ShowVPNStatusForNetworksInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the radio settings of an appliance 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheRadioSettingsOfAnApplianceResponse> ReturnTheRadioSettingsOfAnAppliance(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheRadioSettingsOfAnApplianceResponse>($"devices/{serial}/appliance/radio/settings", headers);
        }
    
        /// <summary>
        /// Update the radio settings of an appliance
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// rfProfileId| string| The ID of an RF profile to assign to the device. If the value of this 
        /// parameter is null, the appropriate basic RF profile (indoor or outdoor) will be assigned to the 
        /// device. Assigning an RF profile will clear ALL manually configured overrides on the device (channel 
        /// width, channel, power).
        /// twoFourGhzSettings| object| Manual radio settings for 2.4 
        /// GHz.
        /// fiveGhzSettings| object| Manual radio settings for 5 GHz.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/appliance/radio/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheRadioSettingsOfAnApplianceResponse> UpdateTheRadioSettingsOfAnAppliance(ReturnTheRadioSettingsOfAnApplianceResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheRadioSettingsOfAnApplianceResponse>($"devices/{serial}/appliance/radio/settings", request, headers);
        }
    
        /// <summary>
        /// Return the uplink settings for an MX appliance 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheUplinkSettingsForAnMXApplianceResponse> ReturnTheUplinkSettingsForAnMXAppliance(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheUplinkSettingsForAnMXApplianceResponse>($"devices/{serial}/appliance/uplinks/settings", headers);
        }
    
        /// <summary>
        /// Update the uplink settings for an MX appliance
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// interfaces| object| Interface settings.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/appliance/uplinks/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheUplinkSettingsForAnMXApplianceResponse> UpdateTheUplinkSettingsForAnMXAppliance(ReturnTheUplinkSettingsForAnMXApplianceResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheUplinkSettingsForAnMXApplianceResponse>($"devices/{serial}/appliance/uplinks/settings", request, headers);
        }
    
        /// <summary>
        /// Generate a new vMX authentication token 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<GenerateANewVMXAuthenticationTokenResponse> GenerateANewVMXAuthenticationToken(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<GenerateANewVMXAuthenticationTokenResponse>($"devices/{serial}/appliance/vmx/authenticationToken", headers);
        }
    
        /// <summary>
        /// Return the connectivity testing destinations for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse> RnTheConnectivityTestingDestinationsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse>($"networks/{networkId}/appliance/connectivityMonitoringDestinations", headers);
        }
    
        /// <summary>
        /// Update the connectivity testing destinations for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// destinations| array| The list of connectivity monitoring destinations
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/connectivityMonitoringDestinations` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse> TeTheConnectivityTestingDestinationsForAnMXNetwork(RnTheConnectivityTestingDestinationsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse>($"networks/{networkId}/appliance/connectivityMonitoringDestinations", request, headers);
        }
    
        /// <summary>
        /// Return the content filtering settings for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheContentFilteringSettingsForAnMXNetworkResponse> ReturnTheContentFilteringSettingsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheContentFilteringSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/contentFiltering", headers);
        }
    
        /// <summary>
        /// Update the content filtering settings for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// allowedUrlPatterns| array| A list of URL patterns that are allowed
        /// blockedUrlPatterns| array| A 
        /// list of URL patterns that are blocked
        /// blockedUrlCategories| array| A list of URL categories to 
        /// block
        /// urlCategoryListSize| string| URL category list size which is either 'topSites' or 'fullList'
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheContentFilteringSettingsForAnMXNetworkResponse> UpdateTheContentFilteringSettingsForAnMXNetwork(ReturnTheContentFilteringSettingsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheContentFilteringSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/contentFiltering", request, headers);
        }
    
        /// <summary>
        /// Return the cellular firewall rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnTheCellularFirewallRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/cellularFirewallRules", headers);
        }
    
        /// <summary>
        /// Update the cellular firewall rules of an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the firewall rules (not including the default rule)
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdateTheCellularFirewallRulesOfAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/cellularFirewallRules", request, headers);
        }
    
        /// <summary>
        /// List the appliance services and their accessibility rules 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheApplianceServicesAndTheirAccessibilityRulesResponse> ListTheApplianceServicesAndTheirAccessibilityRules(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheApplianceServicesAndTheirAccessibilityRulesResponse>($"networks/{networkId}/appliance/firewall/firewalledServices", headers);
        }
    
        /// <summary>
        /// Return the accessibility settings of the given service ('ICMP', 'web', or 'SNMP') 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="service">(Required) Service</param>
        public async Task<ListTheApplianceServicesAndTheirAccessibilityRulesResponse> CcessibilitySettingsOfTheGivenServiceICMPWebOrSNMP(string networkId, string service)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheApplianceServicesAndTheirAccessibilityRulesResponse>($"networks/{networkId}/appliance/firewall/firewalledServices/{service}", headers);
        }
    
        /// <summary>
        /// Updates the accessibility settings for the given service ('ICMP', 'web', or 'SNMP')
        ///  #### Body 
        /// Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: 
        /// |:-------------: 
        /// access| string| A string indicating the rule for which IPs are allowed to use the 
        /// specified service. Acceptable values are "blocked" (no remote IPs can access the service), 
        /// "restricted" (only allowed IPs can access the service), and "unrestriced" (any remote IP can access 
        /// the service). This field is required
        /// allowedIps| array| An array of allowed IPs that can access the 
        /// service. This field is required if "access" is set to "restricted". Otherwise this field is ignored
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="service">(Required) Service</param>
        public async Task<ListTheApplianceServicesAndTheirAccessibilityRulesResponse> CessibilitySettingsForTheGivenServiceICMPWebOrSNMP(ListTheApplianceServicesAndTheirAccessibilityRulesResponse request, string networkId, string service)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheApplianceServicesAndTheirAccessibilityRulesResponse>($"networks/{networkId}/appliance/firewall/firewalledServices/{service}", request, headers);
        }
    
        /// <summary>
        /// Return the inbound cellular firewall rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<Rules> EturnTheInboundCellularFirewallRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<Rules>($"networks/{networkId}/appliance/firewall/inboundCellularFirewallRules", headers);
        }
    
        /// <summary>
        /// Update the inbound cellular firewall rules of an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the firewall rules (not including the default rule)
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<Rules> UpdateTheInboundCellularFirewallRulesOfAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<Rules>($"networks/{networkId}/appliance/firewall/inboundCellularFirewallRules", request, headers);
        }
    
        /// <summary>
        /// Return the inbound firewall rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheInboundFirewallRulesForAnMXNetworkResponse> ReturnTheInboundFirewallRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheInboundFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/inboundFirewallRules", headers);
        }
    
        /// <summary>
        /// Update the inbound firewall rules of an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the firewall rules (not including the default rule)
        /// syslogDefaultRule| 
        /// boolean| Log the special default rule (boolean value - enable only if you've configured a syslog 
        /// server) (optional)
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheInboundFirewallRulesForAnMXNetworkResponse> UpdateTheInboundFirewallRulesOfAnMXNetwork(UpdateTheInboundFirewallRulesOfAnMXNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheInboundFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/inboundFirewallRules", request, headers);
        }
    
        /// <summary>
        /// Return the L3 firewall rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnTheL3FirewallRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/l3FirewallRules", headers);
        }
    
        /// <summary>
        /// Update the L3 firewall rules of an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the firewall rules (not including the default rule)
        /// syslogDefaultRule| 
        /// boolean| Log the special default rule (boolean value - enable only if you've configured a syslog 
        /// server) (optional)
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdateTheL3FirewallRulesOfAnMXNetwork(UpdateTheInboundFirewallRulesOfAnMXNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/l3FirewallRules", request, headers);
        }
    
        /// <summary>
        /// List the MX L7 firewall rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ListTheMXL7FirewallRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/l7FirewallRules", headers);
        }
    
        /// <summary>
        /// Update the MX L7 firewall rules for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the MX L7 firewall rules
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/firewall/l7FirewallRules` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdateTheMXL7FirewallRulesForAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/l7FirewallRules", request, headers);
        }
    
        /// <summary>
        /// Return the 1:Many NAT mapping rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnThe1ManyNATMappingRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/oneToManyNatRules", headers);
        }
    
        /// <summary>
        /// Set the 1:Many NAT mapping rules for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An array of 1:Many nat rules
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> SetThe1ManyNATMappingRulesForAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/oneToManyNatRules", request, headers);
        }
    
        /// <summary>
        /// Return the 1:1 NAT mapping rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnThe11NATMappingRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/oneToOneNatRules", headers);
        }
    
        /// <summary>
        /// Set the 1:1 NAT mapping rules for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An array of 1:1 nat rules
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> SetThe11NATMappingRulesForAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/oneToOneNatRules", request, headers);
        }
    
        /// <summary>
        /// Return the port forwarding rules for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnThePortForwardingRulesForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/portForwardingRules", headers);
        }
    
        /// <summary>
        /// Update the port forwarding rules for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An array of port forwarding params
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdateThePortForwardingRulesForAnMXNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/appliance/firewall/portForwardingRules", request, headers);
        }
    
        /// <summary>
        /// Return the firewall settings for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheFirewallSettingsForThisNetworkResponse> ReturnTheFirewallSettingsForThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheFirewallSettingsForThisNetworkResponse>($"networks/{networkId}/appliance/firewall/settings", headers);
        }
    
        /// <summary>
        /// Update the firewall settings for this network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// spoofingProtection| object| Spoofing protection settings
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheFirewallSettingsForThisNetworkResponse> UpdateTheFirewallSettingsForThisNetwork(ReturnTheFirewallSettingsForThisNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheFirewallSettingsForThisNetworkResponse>($"networks/{networkId}/appliance/firewall/settings", request, headers);
        }
    
        /// <summary>
        /// List per-port VLAN settings for all ports of a MX. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListPerPortVLANSettingsForAllPortsOfAMXResponse> ListPerPortVLANSettingsForAllPortsOfAMX(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListPerPortVLANSettingsForAllPortsOfAMXResponse>($"networks/{networkId}/appliance/ports", headers);
        }
    
        /// <summary>
        /// Return per-port VLAN settings for a single MX port. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="portId">(Required) Port ID</param>
        public async Task<ListPerPortVLANSettingsForAllPortsOfAMXResponse> ReturnPerPortVLANSettingsForASingleMXPort(string networkId, string portId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListPerPortVLANSettingsForAllPortsOfAMXResponse>($"networks/{networkId}/appliance/ports/{portId}", headers);
        }
    
        /// <summary>
        /// Update the per-port VLAN settings for a single MX port.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// enabled| boolean| The status of the port
        /// dropUntaggedTraffic| boolean| Trunk port can Drop all 
        /// Untagged traffic. When true, no VLAN is required. Access ports cannot have dropUntaggedTraffic set 
        /// to true.
        /// type| string| The type of the port: 'access' or 'trunk'.
        /// vlan| integer| Native VLAN when 
        /// the port is in Trunk mode. Access VLAN when the port is in Access mode.
        /// allowedVlans| string| 
        /// Comma-delimited list of the VLAN ID's allowed on the port, or 'all' to permit all VLAN's on the 
        /// port.
        /// accessPolicy| string| The name of the policy. Only applicable to Access ports. Valid values 
        /// are: 'open', '8021x-radius', 'mac-radius', 'hybris-radius' for MX64 or Z3 or any MX supporting the 
        /// per port authentication feature. Otherwise, 'open' is the only valid value and 'open' is the default 
        /// value if the field is missing.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/ports/{portId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="portId">(Required) Port ID</param>
        public async Task<ListPerPortVLANSettingsForAllPortsOfAMXResponse> UpdateThePerPortVLANSettingsForASingleMXPort(UpdateThePerPortVLANSettingsForASingleMXPortRequest request, string networkId, string portId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListPerPortVLANSettingsForAllPortsOfAMXResponse>($"networks/{networkId}/appliance/ports/{portId}", request, headers);
        }
    
        /// <summary>
        /// List static delegated prefixes for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListStaticDelegatedPrefixesForANetworkResponse> ListStaticDelegatedPrefixesForANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListStaticDelegatedPrefixesForANetworkResponse>($"networks/{networkId}/appliance/prefixes/delegated/statics", headers);
        }
    
        /// <summary>
        /// Add a static delegated prefix from a network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// prefix| 
        /// string| A static IPv6 prefix
        /// origin| object| The origin of the prefix
        /// description| string| A name or 
        /// description for the prefix
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/prefixes/delegated/statics` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListStaticDelegatedPrefixesForANetworkResponse> AddAStaticDelegatedPrefixFromANetwork(ReturnCurrentDelegatedIPv6PrefixesOnAnApplianceResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListStaticDelegatedPrefixesForANetworkResponse>($"networks/{networkId}/appliance/prefixes/delegated/statics", request, headers);
        }
    
        /// <summary>
        /// Return a static delegated prefix from a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticDelegatedPrefixId">(Required) Static delegated prefix ID</param>
        public async Task<ListStaticDelegatedPrefixesForANetworkResponse> ReturnAStaticDelegatedPrefixFromANetwork(string networkId, string staticDelegatedPrefixId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListStaticDelegatedPrefixesForANetworkResponse>($"networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}", headers);
        }
    
        /// <summary>
        /// Update a static delegated prefix from a network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// prefix| 
        /// string| A static IPv6 prefix
        /// origin| object| The origin of the prefix
        /// description| string| A name or 
        /// description for the prefix
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}` 
        /// | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticDelegatedPrefixId">(Required) Static delegated prefix ID</param>
        public async Task<ListStaticDelegatedPrefixesForANetworkResponse> UpdateAStaticDelegatedPrefixFromANetwork(ReturnCurrentDelegatedIPv6PrefixesOnAnApplianceResponse request, string networkId, string staticDelegatedPrefixId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListStaticDelegatedPrefixesForANetworkResponse>($"networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}", request, headers);
        }
    
        /// <summary>
        /// Delete a static delegated prefix from a network
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}` 
        /// | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticDelegatedPrefixId">(Required) Static delegated prefix ID</param>
        public async Task<EmptyResponse> DeleteAStaticDelegatedPrefixFromANetwork(string networkId, string staticDelegatedPrefixId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}", headers);
        }
    
        /// <summary>
        /// List the RF profiles for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheRFProfilesForThisNetworkResponse> ListTheRFProfilesForThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheRFProfilesForThisNetworkResponse>($"networks/{networkId}/appliance/rfProfiles", headers);
        }
    
        /// <summary>
        /// Returns all supported intrusion settings for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsAllSupportedIntrusionSettingsForAnMXNetworkResponse> ReturnsAllSupportedIntrusionSettingsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsAllSupportedIntrusionSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/security/intrusion", headers);
        }
    
        /// <summary>
        /// Set the supported intrusion settings for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// mode| 
        /// string| Set mode to 'disabled'/'detection'/'prevention' (optional - omitting will leave current 
        /// config unchanged)
        /// idsRulesets| string| Set the detection ruleset 
        /// 'connectivity'/'balanced'/'security' (optional - omitting will leave current config unchanged). 
        /// Default value is 'balanced' if none currently saved
        /// protectedNetworks| object| Set the 
        /// included/excluded networks from the intrusion engine (optional - omitting will leave current config 
        /// unchanged). This is available only in 'passthrough' mode
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsAllSupportedIntrusionSettingsForAnMXNetworkResponse> SetTheSupportedIntrusionSettingsForAnMXNetwork(ReturnsAllSupportedIntrusionSettingsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsAllSupportedIntrusionSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/security/intrusion", request, headers);
        }
    
        /// <summary>
        /// Returns all supported intrusion settings for an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<UrnsAllSupportedIntrusionSettingsForAnOrganizationResponse> UrnsAllSupportedIntrusionSettingsForAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<UrnsAllSupportedIntrusionSettingsForAnOrganizationResponse>($"organizations/{organizationId}/appliance/security/intrusion", headers);
        }
    
        /// <summary>
        /// Sets supported intrusion settings for an organization
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// allowedRules| array| Sets a list of specific SNORT signatures to allow
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<UrnsAllSupportedIntrusionSettingsForAnOrganizationResponse> SetsSupportedIntrusionSettingsForAnOrganization(UrnsAllSupportedIntrusionSettingsForAnOrganizationResponse request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<UrnsAllSupportedIntrusionSettingsForAnOrganizationResponse>($"organizations/{organizationId}/appliance/security/intrusion", request, headers);
        }
    
        /// <summary>
        /// Returns all supported malware settings for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsAllSupportedMalwareSettingsForAnMXNetworkResponse> ReturnsAllSupportedMalwareSettingsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsAllSupportedMalwareSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/security/malware", headers);
        }
    
        /// <summary>
        /// Set the supported malware settings for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// mode| 
        /// string| Set mode to 'enabled' to enable malware prevention, otherwise 'disabled'
        /// allowedUrls| array| 
        /// The urls that should be permitted by the malware detection engine. If omitted, the current config 
        /// will remain unchanged. This is available only if your network supports AMP allow 
        /// listing
        /// allowedFiles| array| The sha256 digests of files that should be permitted by the malware 
        /// detection engine. If omitted, the current config will remain unchanged. This is available only if 
        /// your network supports AMP allow listing
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsAllSupportedMalwareSettingsForAnMXNetworkResponse> SetTheSupportedMalwareSettingsForAnMXNetwork(ReturnsAllSupportedMalwareSettingsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsAllSupportedMalwareSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/security/malware", request, headers);
        }
    
        /// <summary>
        /// Return the appliance settings for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheApplianceSettingsForANetworkResponse> ReturnTheApplianceSettingsForANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheApplianceSettingsForANetworkResponse>($"networks/{networkId}/appliance/settings", headers);
        }
    
        /// <summary>
        /// Update the appliance settings for a network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// clientTrackingMethod| string| Client tracking method of a network
        /// deploymentMode| string| 
        /// Deployment mode of a network
        /// dynamicDns| object| Dynamic DNS settings for a network
        /// 
        /// #### Supports 
        /// Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheApplianceSettingsForANetworkResponse> UpdateTheApplianceSettingsForANetwork(ReturnTheApplianceSettingsForANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheApplianceSettingsForANetworkResponse>($"networks/{networkId}/appliance/settings", request, headers);
        }
    
        /// <summary>
        /// Return single LAN configuration 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnSingleLANConfigurationResponse> ReturnSingleLANConfiguration(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnSingleLANConfigurationResponse>($"networks/{networkId}/appliance/singleLan", headers);
        }
    
        /// <summary>
        /// Update single LAN configuration
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// subnet| string| The subnet of the single LAN 
        /// configuration
        /// applianceIp| string| The appliance IP address of the single LAN
        /// ipv6| object| IPv6 
        /// configuration on the VLAN
        /// mandatoryDhcp| object| Mandatory DHCP will enforce that clients connecting 
        /// to this LAN must use the IP address assigned by the DHCP server. Clients who use a static IP address 
        /// won't be able to associate. Only available on firmware versions 17.0 and above
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/singleLan` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnSingleLANConfigurationResponse> UpdateSingleLANConfiguration(ReturnSingleLANConfigurationResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnSingleLANConfigurationResponse>($"networks/{networkId}/appliance/singleLan", request, headers);
        }
    
        /// <summary>
        /// List the MX SSIDs in a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheMXSSIDsInANetworkResponse> ListTheMXSSIDsInANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMXSSIDsInANetworkResponse>($"networks/{networkId}/appliance/ssids", headers);
        }
    
        /// <summary>
        /// Return a single MX SSID 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="number">(Required) Number</param>
        public async Task<ListTheMXSSIDsInANetworkResponse> ReturnASingleMXSSID(string networkId, string number)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMXSSIDsInANetworkResponse>($"networks/{networkId}/appliance/ssids/{number}", headers);
        }
    
        /// <summary>
        /// Update the attributes of an MX SSID
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of the SSID.
        /// enabled| 
        /// boolean| Whether or not the SSID is enabled.
        /// defaultVlanId| integer| The VLAN ID of the VLAN 
        /// associated to this SSID. This parameter is only valid if the network is in routed mode.
        /// authMode| 
        /// string| The association control method for the SSID ('open', 'psk', '8021x-meraki' or 
        /// '8021x-radius').
        /// psk| string| The passkey for the SSID. This param is only valid if the authMode is 
        /// 'psk'.
        /// radiusServers| array| The RADIUS 802.1x servers to be used for authentication. This param is 
        /// only valid if the authMode is '8021x-radius'.
        /// encryptionMode| string| The psk encryption mode for 
        /// the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'.
        /// wpaEncryptionMode| 
        /// string| The types of WPA encryption. ('WPA1 and WPA2', 'WPA2 only', 'WPA3 Transition Mode' or 'WPA3 
        /// only'). This param is only valid if (1) the authMode is 'psk' & the encryptionMode is 'wpa' OR (2) 
        /// the authMode is '8021x-meraki' OR (3) the authMode is '8021x-radius'
        /// visible| boolean| Boolean 
        /// indicating whether the MX should advertise or hide this SSID.
        /// dhcpEnforcedDeauthentication| object| 
        /// DHCP Enforced Deauthentication enables the disassociation of wireless clients in addition to 
        /// Mandatory DHCP. This param is only valid on firmware versions >= MX 17.0 where the associated LAN 
        /// has Mandatory DHCP Enabled 
        /// dot11w| object| The current setting for Protected Management Frames 
        /// (802.11w).
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/ssids/{number}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="number">(Required) Number</param>
        public async Task<ListTheMXSSIDsInANetworkResponse> UpdateTheAttributesOfAnMXSSID(UpdateTheAttributesOfAnMXSSIDRequest request, string networkId, string number)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheMXSSIDsInANetworkResponse>($"networks/{networkId}/appliance/ssids/{number}", request, headers);
        }
    
        /// <summary>
        /// List the static routes for an MX or teleworker network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse> ListTheStaticRoutesForAnMXOrTeleworkerNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse>($"networks/{networkId}/appliance/staticRoutes", headers);
        }
    
        /// <summary>
        /// Add a static route for an MX or teleworker network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new static route
        /// subnet| string| The subnet of the static route
        /// gatewayIp| 
        /// string| The gateway IP (next hop) of the static route
        /// gatewayVlanId| string| The gateway IP (next 
        /// hop) VLAN ID of the static route
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<AddAStaticRouteForAnMXOrTeleworkerNetworkResponse> AddAStaticRouteForAnMXOrTeleworkerNetwork(AddAStaticRouteForAnMXOrTeleworkerNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<AddAStaticRouteForAnMXOrTeleworkerNetworkResponse>($"networks/{networkId}/appliance/staticRoutes", request, headers);
        }
    
        /// <summary>
        /// Return a static route for an MX or teleworker network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse> ReturnAStaticRouteForAnMXOrTeleworkerNetwork(string networkId, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse>($"networks/{networkId}/appliance/staticRoutes/{staticRouteId}", headers);
        }
    
        /// <summary>
        /// Update a static route for an MX or teleworker network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the static route
        /// subnet| string| The subnet of the static route
        /// gatewayIp| 
        /// string| The gateway IP (next hop) of the static route
        /// gatewayVlanId| string| The gateway IP (next 
        /// hop) VLAN ID of the static route
        /// enabled| boolean| The enabled state of the static 
        /// route
        /// fixedIpAssignments| object| The DHCP fixed IP assignments on the static route. This should be 
        /// an object that contains mappings from MAC addresses to objects that themselves each contain "ip" and 
        /// "name" string fields. See the sample request/response for more details.
        /// reservedIpRanges| array| The 
        /// DHCP reserved IP ranges on the static route
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse> UpdateAStaticRouteForAnMXOrTeleworkerNetwork(UpdateAStaticRouteForAnMXOrTeleworkerNetworkRequest request, string networkId, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheStaticRoutesForAnMXOrTeleworkerNetworkResponse>($"networks/{networkId}/appliance/staticRoutes/{staticRouteId}", request, headers);
        }
    
        /// <summary>
        /// Delete a static route from an MX or teleworker network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<EmptyResponse> DeleteAStaticRouteFromAnMXOrTeleworkerNetwork(string networkId, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/appliance/staticRoutes/{staticRouteId}", headers);
        }
    
        /// <summary>
        /// Display the traffic shaping settings for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<DisplayTheTrafficShapingSettingsForAnMXNetworkResponse> DisplayTheTrafficShapingSettingsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<DisplayTheTrafficShapingSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/trafficShaping", headers);
        }
    
        /// <summary>
        /// Update the traffic shaping settings for an MX network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// globalBandwidthLimits| object| Global per-client bandwidth limit
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<DisplayTheTrafficShapingSettingsForAnMXNetworkResponse> UpdateTheTrafficShapingSettingsForAnMXNetwork(DisplayTheTrafficShapingSettingsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<DisplayTheTrafficShapingSettingsForAnMXNetworkResponse>($"networks/{networkId}/appliance/trafficShaping", request, headers);
        }
    
        /// <summary>
        /// List the VLANs for an MX network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheVLANsForAnMXNetworkResponse> ListTheVLANsForAnMXNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheVLANsForAnMXNetworkResponse>($"networks/{networkId}/appliance/vlans", headers);
        }
    
        /// <summary>
        /// Add a VLAN
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// id| string| The VLAN ID of the new VLAN (must be between 1 and 
        /// 4094)
        /// name| string| The name of the new VLAN
        /// subnet| string| The subnet of the VLAN
        /// applianceIp| 
        /// string| The local IP of the appliance on the VLAN
        /// groupPolicyId| string| The id of the desired group 
        /// policy to apply to the VLAN
        /// templateVlanType| string| Type of subnetting of the VLAN. Applicable 
        /// only for template network.
        /// cidr| string| CIDR of the pool of subnets. Applicable only for template 
        /// network. Each network bound to the template will automatically pick a subnet from this pool to build 
        /// its own VLAN.
        /// mask| integer| Mask used for the subnet of all bound to the template networks. 
        /// Applicable only for template network.
        /// ipv6| object| IPv6 configuration on the VLAN
        /// mandatoryDhcp| 
        /// object| Mandatory DHCP will enforce that clients connecting to this VLAN must use the IP address 
        /// assigned by the DHCP server. Clients who use a static IP address won't be able to associate. Only 
        /// available on firmware versions 17.0 and above
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/vlans` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheVLANsForAnMXNetworkResponse> AddAVLAN(AddAVLANRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheVLANsForAnMXNetworkResponse>($"networks/{networkId}/appliance/vlans", request, headers);
        }
    
        /// <summary>
        /// Return a VLAN 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="vlanId">(Required) Vlan ID</param>
        public async Task<ListTheVLANsForAnMXNetworkResponse> ReturnAVLAN(string networkId, string vlanId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheVLANsForAnMXNetworkResponse>($"networks/{networkId}/appliance/vlans/{vlanId}", headers);
        }
    
        /// <summary>
        /// Update a VLAN
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// name| string| The name of the VLAN
        /// subnet| string| The subnet of 
        /// the VLAN
        /// applianceIp| string| The local IP of the appliance on the VLAN
        /// groupPolicyId| string| The 
        /// id of the desired group policy to apply to the VLAN
        /// vpnNatSubnet| string| The translated VPN subnet 
        /// if VPN and VPN subnet translation are enabled on the VLAN
        /// dhcpHandling| string| The appliance's 
        /// handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' 
        /// or 'Do not respond to DHCP requests'
        /// dhcpRelayServerIps| array| The IPs of the DHCP servers that 
        /// DHCP requests should be relayed to
        /// dhcpLeaseTime| string| The term of DHCP leases if the appliance 
        /// is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 
        /// day' or '1 week'
        /// dhcpBootOptionsEnabled| boolean| Use DHCP boot options specified in other 
        /// properties
        /// dhcpBootNextServer| string| DHCP boot option to direct boot clients to the server to load 
        /// the boot file from
        /// dhcpBootFilename| string| DHCP boot option for boot filename
        /// fixedIpAssignments| 
        /// object| The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings 
        /// from MAC addresses to objects that themselves each contain "ip" and "name" string fields. See the 
        /// sample request/response for more details.
        /// reservedIpRanges| array| The DHCP reserved IP ranges on 
        /// the VLAN
        /// dnsNameservers| string| The DNS nameservers used for DHCP responses, either "upstream_dns", 
        /// "google_dns", "opendns", or a newline seperated string of IP addresses or domain names
        /// dhcpOptions| 
        /// array| The list of DHCP options that will be included in DHCP responses. Each object in the list 
        /// should have "code", "type", and "value" properties.
        /// templateVlanType| string| Type of subnetting of 
        /// the VLAN. Applicable only for template network.
        /// cidr| string| CIDR of the pool of subnets. 
        /// Applicable only for template network. Each network bound to the template will automatically pick a 
        /// subnet from this pool to build its own VLAN.
        /// mask| integer| Mask used for the subnet of all bound to 
        /// the template networks. Applicable only for template network.
        /// ipv6| object| IPv6 configuration on the 
        /// VLAN
        /// mandatoryDhcp| object| Mandatory DHCP will enforce that clients connecting to this VLAN must 
        /// use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to 
        /// associate. Only available on firmware versions 17.0 and above
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/vlans/{vlanId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="vlanId">(Required) Vlan ID</param>
        public async Task<ListTheVLANsForAnMXNetworkResponse> UpdateAVLAN(UpdateAVLANRequest request, string networkId, string vlanId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheVLANsForAnMXNetworkResponse>($"networks/{networkId}/appliance/vlans/{vlanId}", request, headers);
        }
    
        /// <summary>
        /// Delete a VLAN from a network
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/vlans/{vlanId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="vlanId">(Required) Vlan ID</param>
        public async Task<EmptyResponse> DeleteAVLANFromANetwork(string networkId, string vlanId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/appliance/vlans/{vlanId}", headers);
        }
    
        /// <summary>
        /// Return a Hub BGP Configuration 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnAHubBGPConfigurationResponse> ReturnAHubBGPConfiguration(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnAHubBGPConfigurationResponse>($"networks/{networkId}/appliance/vpn/bgp", headers);
        }
    
        /// <summary>
        /// Update a Hub BGP Configuration
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// enabled| boolean| Boolean value to enable or 
        /// disable the BGP configuration. When BGP is enabled, the asNumber (ASN) will be autopopulated with 
        /// the preconfigured ASN at other Hubs or a default value if there is no ASN configured.
        /// asNumber| 
        /// integer| An Autonomous System Number (ASN) is required if you are to run BGP and peer with another 
        /// BGP Speaker outside of the Auto VPN domain. This ASN will be applied to the entire Auto VPN domain. 
        /// The entire 4-byte ASN range is supported. So, the ASN must be an integer between 1 and 4294967295. 
        /// When absent, this field is not updated. If no value exists then it defaults to 64512.
        /// ibgpHoldTimer| 
        /// integer| The IBGP holdtimer in seconds. The IBGP holdtimer must be an integer between 12 and 240. 
        /// When absent, this field is not updated. If no value exists then it defaults to 240.
        /// neighbors| 
        /// array| List of BGP neighbors. This list replaces the existing set of neighbors. When absent, this 
        /// field is not updated.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/vpn/bgp` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnAHubBGPConfigurationResponse> UpdateAHubBGPConfiguration(UpdateAHubBGPConfigurationRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnAHubBGPConfigurationResponse>($"networks/{networkId}/appliance/vpn/bgp", request, headers);
        }
    
        /// <summary>
        /// Return the site-to-site VPN settings of a network. Only valid for MX networks. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheSiteToSiteVPNSettingsOfANetworkResponse> ReturnTheSiteToSiteVPNSettingsOfANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheSiteToSiteVPNSettingsOfANetworkResponse>($"networks/{networkId}/appliance/vpn/siteToSiteVpn", headers);
        }
    
        /// <summary>
        /// Update the site-to-site VPN settings of a network. Only valid for MX networks in NAT mode. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheSiteToSiteVPNSettingsOfANetworkResponse> UpdateTheSiteToSiteVPNSettingsOfANetwork(ReturnTheSiteToSiteVPNSettingsOfANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheSiteToSiteVPNSettingsOfANetworkResponse>($"networks/{networkId}/appliance/vpn/siteToSiteVpn", request, headers);
        }
    
        /// <summary>
        /// Return the third party VPN peers for an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnTheThirdPartyVPNPeersForAnOrganizationResponse> ReturnTheThirdPartyVPNPeersForAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheThirdPartyVPNPeersForAnOrganizationResponse>($"organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers", headers);
        }
    
        /// <summary>
        /// Update the third party VPN peers for an organization
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// peers| 
        /// array| The list of VPN peers
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers` | update
        /// 
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnTheThirdPartyVPNPeersForAnOrganizationResponse> UpdateTheThirdPartyVPNPeersForAnOrganization(ReturnTheThirdPartyVPNPeersForAnOrganizationResponse request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheThirdPartyVPNPeersForAnOrganizationResponse>($"organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers", request, headers);
        }
    
        /// <summary>
        /// Return the firewall rules for an organization's site-to-site VPN 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UrnTheFirewallRulesForAnOrganizationsSiteToSiteVPN(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"organizations/{organizationId}/appliance/vpn/vpnFirewallRules", headers);
        }
    
        /// <summary>
        /// Update the firewall rules of an organization's site-to-site VPN
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the firewall rules (not including the default rule)
        /// syslogDefaultRule| 
        /// boolean| Log the special default rule (boolean value - enable only if you've configured a syslog 
        /// server) (optional)
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> DateTheFirewallRulesOfAnOrganizationsSiteToSiteVPN(UpdateTheInboundFirewallRulesOfAnMXNetworkRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"organizations/{organizationId}/appliance/vpn/vpnFirewallRules", request, headers);
        }
    
        /// <summary>
        /// Return MX warm spare settings 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnMXWarmSpareSettingsResponse> ReturnMXWarmSpareSettings(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnMXWarmSpareSettingsResponse>($"networks/{networkId}/appliance/warmSpare", headers);
        }
    
        /// <summary>
        /// Update MX warm spare settings
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// enabled| boolean| Enable warm spare
        /// spareSerial| 
        /// string| Serial number of the warm spare appliance
        /// uplinkMode| string| Uplink mode, either virtual or 
        /// public
        /// virtualIp1| string| The WAN 1 shared IP
        /// virtualIp2| string| The WAN 2 shared IP
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/appliance/warmSpare` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnMXWarmSpareSettingsResponse> UpdateMXWarmSpareSettings(UpdateMXWarmSpareSettingsRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnMXWarmSpareSettingsResponse>($"networks/{networkId}/appliance/warmSpare", request, headers);
        }
    
        /// <summary>
        /// Swap MX primary and warm spare appliances 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnMXWarmSpareSettingsResponse> SwapMXPrimaryAndWarmSpareAppliances(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<ReturnMXWarmSpareSettingsResponse>($"networks/{networkId}/appliance/warmSpare/swap", headers);
        }
    
        /// <summary>
        /// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
        ///  
        /// #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: 
        /// |:-------------: 
        /// timestamp| string| [optional] The snapshot will be taken from this time on the 
        /// camera. The timestamp is expected to be in ISO 8601 format. If no timestamp is specified, we will 
        /// assume current time.
        /// fullframe| boolean| [optional] If set to "true" the snapshot will be taken at 
        /// full sensor resolution. This will error if used with timestamp.
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<EraSeesAtTheSpecifiedTimeAndReturnALinkToThatImageResponse> EraSeesAtTheSpecifiedTimeAndReturnALinkToThatImage(EraSeesAtTheSpecifiedTimeAndReturnALinkToThatImageRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<EraSeesAtTheSpecifiedTimeAndReturnALinkToThatImageResponse>($"devices/{serial}/camera/generateSnapshot", request, headers);
        }
    
        /// <summary>
        /// Return custom analytics settings for a camera 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnCustomAnalyticsSettingsForACameraResponse> ReturnCustomAnalyticsSettingsForACamera(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnCustomAnalyticsSettingsForACameraResponse>($"devices/{serial}/camera/customAnalytics", headers);
        }
    
        /// <summary>
        /// Update custom analytics settings for a camera
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// enabled| boolean| Enable custom analytics
        /// artifactId| string| The ID of the custom analytics 
        /// artifact
        /// parameters| array| Parameters for the custom analytics workload
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/camera/customAnalytics` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnCustomAnalyticsSettingsForACameraResponse> UpdateCustomAnalyticsSettingsForACamera(UpdateCustomAnalyticsSettingsForACameraRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnCustomAnalyticsSettingsForACameraResponse>($"devices/{serial}/camera/customAnalytics", request, headers);
        }
    
        /// <summary>
        /// Returns quality and retention settings for the given camera 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<EturnsQualityAndRetentionSettingsForTheGivenCameraResponse> EturnsQualityAndRetentionSettingsForTheGivenCamera(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<EturnsQualityAndRetentionSettingsForTheGivenCameraResponse>($"devices/{serial}/camera/qualityAndRetention", headers);
        }
    
        /// <summary>
        /// Update quality and retention settings for the given camera
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// profileId| string| The ID of a quality and retention profile to assign to the camera. The profile's 
        /// settings will override all of the per-camera quality and retention settings. If the value of this 
        /// parameter is null, any existing profile will be unassigned from the 
        /// camera.
        /// motionBasedRetentionEnabled| boolean| Boolean indicating if motion-based retention is 
        /// enabled(true) or disabled(false) on the camera.
        /// audioRecordingEnabled| boolean| Boolean indicating 
        /// if audio recording is enabled(true) or disabled(false) on the camera
        /// restrictedBandwidthModeEnabled| 
        /// boolean| Boolean indicating if restricted bandwidth is enabled(true) or disabled(false) on the 
        /// camera. This setting does not apply to MV2 cameras.
        /// quality| string| Quality of the camera. Can be 
        /// one of 'Standard', 'High' or 'Enhanced'. Not all qualities are supported by every camera 
        /// model.
        /// resolution| string| Resolution of the camera. Can be one of '1280x720', '1920x1080', 
        /// '1080x1080', '2058x2058', '2112x2112', '2880x2880', '2688x1512' or '3840x2160'.Not all resolutions 
        /// are supported by every camera model.
        /// motionDetectorVersion| integer| The version of the motion 
        /// detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/camera/qualityAndRetention` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<EturnsQualityAndRetentionSettingsForTheGivenCameraResponse> UpdateQualityAndRetentionSettingsForTheGivenCamera(UpdateQualityAndRetentionSettingsForTheGivenCameraRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<EturnsQualityAndRetentionSettingsForTheGivenCameraResponse>($"devices/{serial}/camera/qualityAndRetention", request, headers);
        }
    
        /// <summary>
        /// Returns sense settings for a given camera 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsSenseSettingsForAGivenCameraResponse> ReturnsSenseSettingsForAGivenCamera(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsSenseSettingsForAGivenCameraResponse>($"devices/{serial}/camera/sense", headers);
        }
    
        /// <summary>
        /// Update sense settings for the given camera
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// senseEnabled| boolean| Boolean indicating if sense(license) is enabled(true) or disabled(false) on 
        /// the camera
        /// mqttBrokerId| string| The ID of the MQTT broker to be enabled on the camera. A value of 
        /// null will disable MQTT on the camera
        /// audioDetection| object| The details of the audio detection 
        /// config.
        /// detectionModelId| string| The ID of the object detection model
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/camera/sense` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsSenseSettingsForAGivenCameraResponse> UpdateSenseSettingsForTheGivenCamera(UpdateSenseSettingsForTheGivenCameraRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsSenseSettingsForAGivenCameraResponse>($"devices/{serial}/camera/sense", request, headers);
        }
    
        /// <summary>
        /// Returns video settings for the given camera 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsVideoSettingsForTheGivenCameraResponse> ReturnsVideoSettingsForTheGivenCamera(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsVideoSettingsForTheGivenCameraResponse>($"devices/{serial}/camera/video/settings", headers);
        }
    
        /// <summary>
        /// Update video settings for the given camera
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// externalRtspEnabled| boolean| Boolean indicating if external rtsp stream is exposed
        /// 
        /// #### Supports 
        /// Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/camera/video/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsVideoSettingsForTheGivenCameraResponse> UpdateVideoSettingsForTheGivenCamera(UpdateVideoSettingsForTheGivenCameraRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsVideoSettingsForTheGivenCameraResponse>($"devices/{serial}/camera/video/settings", request, headers);
        }
    
        /// <summary>
        /// Returns video link to the specified camera. If a timestamp is supplied, it links to that timestamp. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListTheOrganizationsResponse> ReturnsVideoLinkToTheSpecifiedCamera(ReturnsVideoLinkToTheSpecifiedCameraParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/camera/videoLink", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheOrganizationsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Returns wireless profile assigned to the given camera 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsWirelessProfileAssignedToTheGivenCameraResponse> ReturnsWirelessProfileAssignedToTheGivenCamera(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsWirelessProfileAssignedToTheGivenCameraResponse>($"devices/{serial}/camera/wirelessProfiles", headers);
        }
    
        /// <summary>
        /// Assign wireless profiles to the given camera. Incremental updates are not supported, all profile 
        /// assignment need to be supplied at once. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnsWirelessProfileAssignedToTheGivenCameraResponse> AssignWirelessProfilesToTheGivenCamera(ReturnsWirelessProfileAssignedToTheGivenCameraResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsWirelessProfileAssignedToTheGivenCameraResponse>($"devices/{serial}/camera/wirelessProfiles", request, headers);
        }
    
        /// <summary>
        /// Creates a new camera wireless profile for this network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the camera wireless profile. This parameter is required.
        /// ssid| object| The 
        /// details of the SSID config.
        /// identity| object| The identity of the wireless profile. Required for 
        /// creating wireless profiles in 8021x-radius auth mode.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<CreatesANewCameraWirelessProfileForThisNetworkResponse> CreatesANewCameraWirelessProfileForThisNetwork(CreatesANewCameraWirelessProfileForThisNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<CreatesANewCameraWirelessProfileForThisNetworkResponse>($"networks/{networkId}/camera/wirelessProfiles", request, headers);
        }
    
        /// <summary>
        /// List the camera wireless profiles for this network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<CreatesANewCameraWirelessProfileForThisNetworkResponse> ListTheCameraWirelessProfilesForThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<CreatesANewCameraWirelessProfileForThisNetworkResponse>($"networks/{networkId}/camera/wirelessProfiles", headers);
        }
    
        /// <summary>
        /// Retrieve a single camera wireless profile. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="wirelessProfileId">(Required) Wireless profile ID</param>
        public async Task<CreatesANewCameraWirelessProfileForThisNetworkResponse> RetrieveASingleCameraWirelessProfile(string networkId, string wirelessProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<CreatesANewCameraWirelessProfileForThisNetworkResponse>($"networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}", headers);
        }
    
        /// <summary>
        /// Update an existing camera wireless profile in this network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the camera wireless profile.
        /// ssid| object| The details of the SSID 
        /// config.
        /// identity| object| The identity of the wireless profile. Required for creating wireless 
        /// profiles in 8021x-radius auth mode.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="wirelessProfileId">(Required) Wireless profile ID</param>
        public async Task<CreatesANewCameraWirelessProfileForThisNetworkResponse> UpdateAnExistingCameraWirelessProfileInThisNetwork(CreatesANewCameraWirelessProfileForThisNetworkRequest request, string networkId, string wirelessProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<CreatesANewCameraWirelessProfileForThisNetworkResponse>($"networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}", request, headers);
        }
    
        /// <summary>
        /// Delete an existing camera wireless profile for this network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="wirelessProfileId">(Required) Wireless profile ID</param>
        public async Task<EmptyResponse> EleteAnExistingCameraWirelessProfileForThisNetwork(string networkId, string wirelessProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}", headers);
        }
    
        /// <summary>
        /// List the quality retention profiles for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheQualityRetentionProfilesForThisNetworkResponse> ListTheQualityRetentionProfilesForThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheQualityRetentionProfilesForThisNetworkResponse>($"networks/{networkId}/camera/qualityRetentionProfiles", headers);
        }
    
        /// <summary>
        /// Creates new quality retention profile for this network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique. This parameter is 
        /// required.
        /// motionBasedRetentionEnabled| boolean| Deletes footage older than 3 days in which no motion 
        /// was detected. Can be either true or false. Defaults to false. This setting does not apply to MV2 
        /// cameras.
        /// restrictedBandwidthModeEnabled| boolean| Disable features that require additional bandwidth 
        /// such as Motion Recap. Can be either true or false. Defaults to false. This setting does not apply to 
        /// MV2 cameras.
        /// audioRecordingEnabled| boolean| Whether or not to record audio. Can be either true or 
        /// false. Defaults to false.
        /// cloudArchiveEnabled| boolean| Create redundant video backup using Cloud 
        /// Archive. Can be either true or false. Defaults to false.
        /// motionDetectorVersion| integer| The version 
        /// of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to 
        /// v2.
        /// scheduleId| string| Schedule for which this camera will record video, or 'null' to always 
        /// record.
        /// maxRetentionDays| integer| The maximum number of days for which the data will be stored, or 
        /// 'null' to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 
        /// 7, 8, 9, 10, 14, 30, 60, 90] days.
        /// videoSettings| object| Video quality and resolution settings for 
        /// all the camera models.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheQualityRetentionProfilesForThisNetworkResponse> CreatesNewQualityRetentionProfileForThisNetwork(CreatesNewQualityRetentionProfileForThisNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheQualityRetentionProfilesForThisNetworkResponse>($"networks/{networkId}/camera/qualityRetentionProfiles", request, headers);
        }
    
        /// <summary>
        /// Update an existing quality retention profile for this network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique.
        /// motionBasedRetentionEnabled| boolean| Deletes 
        /// footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to 
        /// false. This setting does not apply to MV2 cameras.
        /// restrictedBandwidthModeEnabled| boolean| Disable 
        /// features that require additional bandwidth such as Motion Recap. Can be either true or false. 
        /// Defaults to false. This setting does not apply to MV2 cameras.
        /// audioRecordingEnabled| boolean| 
        /// Whether or not to record audio. Can be either true or false. Defaults to false.
        /// cloudArchiveEnabled| 
        /// boolean| Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to 
        /// false.
        /// motionDetectorVersion| integer| The version of the motion detector that will be used by the 
        /// camera. Only applies to Gen 2 cameras. Defaults to v2.
        /// scheduleId| string| Schedule for which this 
        /// camera will record video, or 'null' to always record.
        /// maxRetentionDays| integer| The maximum number 
        /// of days for which the data will be stored, or 'null' to keep data until storage space runs out. If 
        /// the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days.
        /// videoSettings| 
        /// object| Video quality and resolution settings for all the camera models.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qualityRetentionProfileId">(Required) Quality retention profile ID</param>
        public async Task<ListTheQualityRetentionProfilesForThisNetworkResponse> AteAnExistingQualityRetentionProfileForThisNetwork(CreatesNewQualityRetentionProfileForThisNetworkRequest request, string networkId, string qualityRetentionProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheQualityRetentionProfilesForThisNetworkResponse>($"networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}", request, headers);
        }
    
        /// <summary>
        /// Delete an existing quality retention profile for this network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qualityRetentionProfileId">(Required) Quality retention profile ID</param>
        public async Task<EmptyResponse> EteAnExistingQualityRetentionProfileForThisNetwork(string networkId, string qualityRetentionProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}", headers);
        }
    
        /// <summary>
        /// Retrieve a single quality retention profile 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qualityRetentionProfileId">(Required) Quality retention profile ID</param>
        public async Task<ListTheQualityRetentionProfilesForThisNetworkResponse> RetrieveASingleQualityRetentionProfile(string networkId, string qualityRetentionProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheQualityRetentionProfilesForThisNetworkResponse>($"networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}", headers);
        }
    
        /// <summary>
        /// Returns a list of all camera recording schedules. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheOrganizationsResponse> ReturnsAListOfAllCameraRecordingSchedules(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheOrganizationsResponse>($"networks/{networkId}/camera/schedules", headers);
        }
    
        /// <summary>
        /// Fetch onboarding status of cameras 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<FetchOnboardingStatusOfCamerasResponse> FetchOnboardingStatusOfCameras(FetchOnboardingStatusOfCamerasParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/camera/onboarding/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<FetchOnboardingStatusOfCamerasResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Notify that credential handoff to camera has completed
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// serial| 
        /// string| Serial of camera
        /// wirelessCredentialsSent| boolean| Note whether credentials were sent 
        /// successfully
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<NotifyThatCredentialHandoffToCameraHasCompletedResponse> NotifyThatCredentialHandoffToCameraHasCompleted(NotifyThatCredentialHandoffToCameraHasCompletedRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<NotifyThatCredentialHandoffToCameraHasCompletedResponse>($"organizations/{organizationId}/camera/onboarding/statuses", request, headers);
        }
    
        /// <summary>
        /// Show the LAN Settings of a MG 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ShowTheLANSettingsOfAMGResponse> ShowTheLANSettingsOfAMG(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ShowTheLANSettingsOfAMGResponse>($"devices/{serial}/cellularGateway/lan", headers);
        }
    
        /// <summary>
        /// Update the LAN Settings for a single MG.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// reservedIpRanges| array| list of all reserved IP ranges for a single MG
        /// fixedIpAssignments| array| 
        /// list of all fixed IP assignments for a single MG
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/cellularGateway/lan` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ShowTheLANSettingsOfAMGResponse> UpdateTheLANSettingsForASingleMG(ShowTheLANSettingsOfAMGResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ShowTheLANSettingsOfAMGResponse>($"devices/{serial}/cellularGateway/lan", request, headers);
        }
    
        /// <summary>
        /// Returns the port forwarding rules for a single MG. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnsThePortForwardingRulesForASingleMG(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"devices/{serial}/cellularGateway/portForwardingRules", headers);
        }
    
        /// <summary>
        /// Updates the port forwarding rules for a single MG.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An array of port forwarding params
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/cellularGateway/portForwardingRules` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdatesThePortForwardingRulesForASingleMG(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"devices/{serial}/cellularGateway/portForwardingRules", request, headers);
        }
    
        /// <summary>
        /// Return the connectivity testing destinations for an MG network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse> RnTheConnectivityTestingDestinationsForAnMGNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse>($"networks/{networkId}/cellularGateway/connectivityMonitoringDestinations", headers);
        }
    
        /// <summary>
        /// Update the connectivity testing destinations for an MG network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// destinations| array| The list of connectivity monitoring destinations
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/cellularGateway/connectivityMonitoringDestinations` | 
        /// update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse> TeTheConnectivityTestingDestinationsForAnMGNetwork(RnTheConnectivityTestingDestinationsForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<RnTheConnectivityTestingDestinationsForAnMXNetworkResponse>($"networks/{networkId}/cellularGateway/connectivityMonitoringDestinations", request, headers);
        }
    
        /// <summary>
        /// List common DHCP settings of MGs 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListCommonDHCPSettingsOfMGsResponse> ListCommonDHCPSettingsOfMGs(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListCommonDHCPSettingsOfMGsResponse>($"networks/{networkId}/cellularGateway/dhcp", headers);
        }
    
        /// <summary>
        /// Update common DHCP settings of MGs
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// dhcpLeaseTime| string| DHCP Lease time for all MG 
        /// of the network. Possible values are '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 
        /// week'.
        /// dnsNameservers| string| DNS name servers mode for all MG of the network. Possible values are: 
        /// 'upstream_dns', 'google_dns', 'opendns', 'custom'.
        /// dnsCustomNameservers| array| list of fixed IPs 
        /// representing the the DNS Name servers when the mode is 'custom'
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/cellularGateway/dhcp` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListCommonDHCPSettingsOfMGsResponse> UpdateCommonDHCPSettingsOfMGs(ListCommonDHCPSettingsOfMGsResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListCommonDHCPSettingsOfMGsResponse>($"networks/{networkId}/cellularGateway/dhcp", request, headers);
        }
    
        /// <summary>
        /// Return the subnet pool and mask configured for MGs in the network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheSubnetPoolAndMaskConfiguredForMGsInTheNetworkResponse> RnTheSubnetPoolAndMaskConfiguredForMGsInTheNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<RnTheSubnetPoolAndMaskConfiguredForMGsInTheNetworkResponse>($"networks/{networkId}/cellularGateway/subnetPool", headers);
        }
    
        /// <summary>
        /// Update the subnet pool and mask configuration for MGs in the network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// mask| 
        /// integer| Mask used for the subnet of all MGs in  this network.
        /// cidr| string| CIDR of the pool of 
        /// subnets. Each MG in this network will automatically pick a subnet from this pool.
        /// 
        /// #### Supports 
        /// Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/cellularGateway/subnetPool` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<RnTheSubnetPoolAndMaskConfiguredForMGsInTheNetworkResponse> HeSubnetPoolAndMaskConfigurationForMGsInTheNetwork(AddAVLANRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<RnTheSubnetPoolAndMaskConfiguredForMGsInTheNetworkResponse>($"networks/{networkId}/cellularGateway/subnetPool", request, headers);
        }
    
        /// <summary>
        /// Returns the uplink settings for your MG network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsTheUplinkSettingsForYourMGNetworkResponse> ReturnsTheUplinkSettingsForYourMGNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsTheUplinkSettingsForYourMGNetworkResponse>($"networks/{networkId}/cellularGateway/uplink", headers);
        }
    
        /// <summary>
        /// Updates the uplink settings for your MG network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// bandwidthLimits| object| The bandwidth settings for the 'cellular' uplink
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/cellularGateway/uplink` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsTheUplinkSettingsForYourMGNetworkResponse> UpdatesTheUplinkSettingsForYourMGNetwork(ReturnsTheUplinkSettingsForYourMGNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsTheUplinkSettingsForYourMGNetworkResponse>($"networks/{networkId}/cellularGateway/uplink", request, headers);
        }
    
        /// <summary>
        /// List the uplink status of every Meraki MG cellular gateway in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse> TusOfEveryMerakiMGCellularGatewayInTheOrganization(TusOfEveryMerakiMGCellularGatewayInTheOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/cellularGateway/uplink/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the sensor roles for a given sensor or camera device. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListTheSensorRolesForAGivenSensorOrCameraDeviceResponse> ListTheSensorRolesForAGivenSensorOrCameraDevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSensorRolesForAGivenSensorOrCameraDeviceResponse>($"devices/{serial}/sensor/relationships", headers);
        }
    
        /// <summary>
        /// Assign one or more sensor roles to a given sensor or camera device.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// livestream| object| A role defined between an MT sensor and an MV camera that adds the camera's 
        /// livestream to the sensor's details page. Snapshots from the camera will also appear in alert 
        /// notifications that the sensor triggers.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/sensor/relationships` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListTheSensorRolesForAGivenSensorOrCameraDeviceResponse> GnOneOrMoreSensorRolesToAGivenSensorOrCameraDevice(ListTheSensorRolesForAGivenSensorOrCameraDeviceResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheSensorRolesForAGivenSensorOrCameraDeviceResponse>($"devices/{serial}/sensor/relationships", request, headers);
        }
    
        /// <summary>
        /// List the sensor roles for devices in a given network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheSensorRolesForDevicesInAGivenNetworkResponse> ListTheSensorRolesForDevicesInAGivenNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSensorRolesForDevicesInAGivenNetworkResponse>($"networks/{networkId}/sensor/relationships", headers);
        }
    
        /// <summary>
        /// Lists all sensor alert profiles for a network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListsAllSensorAlertProfilesForANetworkResponse> ListsAllSensorAlertProfilesForANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListsAllSensorAlertProfilesForANetworkResponse>($"networks/{networkId}/sensor/alerts/profiles", headers);
        }
    
        /// <summary>
        /// Creates a sensor alert profile for a network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| Name of the sensor alert profile.
        /// schedule| object| The sensor schedule to use with the 
        /// alert profile.
        /// conditions| array| List of conditions that will cause the profile to send an 
        /// alert.
        /// recipients| object| List of recipients that will receive the alert.
        /// serials| array| List of 
        /// device serials assigned to this sensor alert profile.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/sensor/alerts/profiles` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListsAllSensorAlertProfilesForANetworkResponse> CreatesASensorAlertProfileForANetwork(ListsAllSensorAlertProfilesForANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListsAllSensorAlertProfilesForANetworkResponse>($"networks/{networkId}/sensor/alerts/profiles", request, headers);
        }
    
        /// <summary>
        /// Show details of a sensor alert profile for a network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="id">(Required) ID</param>
        public async Task<ListsAllSensorAlertProfilesForANetworkResponse> ShowDetailsOfASensorAlertProfileForANetwork(string networkId, string id)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListsAllSensorAlertProfilesForANetworkResponse>($"networks/{networkId}/sensor/alerts/profiles/{id}", headers);
        }
    
        /// <summary>
        /// Updates a sensor alert profile for a network.
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| Name of the sensor alert profile.
        /// schedule| object| The sensor schedule to use with the 
        /// alert profile.
        /// conditions| array| List of conditions that will cause the profile to send an 
        /// alert.
        /// recipients| object| List of recipients that will receive the alert.
        /// serials| array| List of 
        /// device serials assigned to this sensor alert profile.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/sensor/alerts/profiles/{id}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="id">(Required) ID</param>
        public async Task<ListsAllSensorAlertProfilesForANetworkResponse> UpdatesASensorAlertProfileForANetwork(ListsAllSensorAlertProfilesForANetworkResponse request, string networkId, string id)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListsAllSensorAlertProfilesForANetworkResponse>($"networks/{networkId}/sensor/alerts/profiles/{id}", request, headers);
        }
    
        /// <summary>
        /// Deletes a sensor alert profile from a network.
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/sensor/alerts/profiles/{id}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="id">(Required) ID</param>
        public async Task<EmptyResponse> DeletesASensorAlertProfileFromANetwork(string networkId, string id)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/sensor/alerts/profiles/{id}", headers);
        }
    
        /// <summary>
        /// List the sensor settings of all MQTT brokers for this network. To get the brokers themselves, use 
        /// /networks/{networkId}/mqttBrokers. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse> IstTheSensorSettingsOfAllMQTTBrokersForThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse>($"networks/{networkId}/sensor/mqttBrokers", headers);
        }
    
        /// <summary>
        /// Return the sensor settings of an MQTT broker. To get the broker itself, use 
        /// /networks/{networkId}/mqttBrokers/{mqttBrokerId}. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="mqttBrokerId">(Required) Mqtt broker ID</param>
        public async Task<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse> ReturnTheSensorSettingsOfAnMQTTBroker(string networkId, string mqttBrokerId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse>($"networks/{networkId}/sensor/mqttBrokers/{mqttBrokerId}", headers);
        }
    
        /// <summary>
        /// Update the sensor settings of an MQTT broker. To update the broker itself, use 
        /// /networks/{networkId}/mqttBrokers/{mqttBrokerId}. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="mqttBrokerId">(Required) Mqtt broker ID</param>
        public async Task<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse> UpdateTheSensorSettingsOfAnMQTTBroker(UpdateThePerPortVLANSettingsForASingleMXPortRequest request, string networkId, string mqttBrokerId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<IstTheSensorSettingsOfAllMQTTBrokersForThisNetworkResponse>($"networks/{networkId}/sensor/mqttBrokers/{mqttBrokerId}", request, headers);
        }
    
        /// <summary>
        /// Return an overview of currently alerting sensors by metric 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnAnOverviewOfCurrentlyAlertingSensorsByMetricResponse> ReturnAnOverviewOfCurrentlyAlertingSensorsByMetric(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnAnOverviewOfCurrentlyAlertingSensorsByMetricResponse>($"networks/{networkId}/sensor/alerts/current/overview/byMetric", headers);
        }
    
        /// <summary>
        /// Return an overview of alert occurrences over a timespan, by metric 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<NAnOverviewOfAlertOccurrencesOverATimespanByMetricResponse> NAnOverviewOfAlertOccurrencesOverATimespanByMetric(NAnOverviewOfAlertOccurrencesOverATimespanByMetricParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sensor/alerts/overview/byMetric", parametersDict);
            return await _httpClient.GetFromJsonAsync<NAnOverviewOfAlertOccurrencesOverATimespanByMetricResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return all reported readings from sensors in a given timespan, sorted by timestamp 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<AdingsFromSensorsInAGivenTimespanSortedByTimestampResponse> AdingsFromSensorsInAGivenTimespanSortedByTimestamp(AdingsFromSensorsInAGivenTimespanSortedByTimestampParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/sensor/readings/history", parametersDict);
            return await _httpClient.GetFromJsonAsync<AdingsFromSensorsInAGivenTimespanSortedByTimestampResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the latest available reading for each metric from each sensor, sorted by sensor serial 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<IngForEachMetricFromEachSensorSortedBySensorSerialResponse> IngForEachMetricFromEachSensorSortedBySensorSerial(IngForEachMetricFromEachSensorSortedBySensorSerialParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/sensor/readings/latest", parametersDict);
            return await _httpClient.GetFromJsonAsync<IngForEachMetricFromEachSensorSortedBySensorSerialResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the switch ports for a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListTheSwitchPortsForASwitchResponse> ListTheSwitchPortsForASwitch(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSwitchPortsForASwitchResponse>($"devices/{serial}/switch/ports", headers);
        }
    
        /// <summary>
        /// Return a switch port 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="portId">(Required) Port ID</param>
        public async Task<ListTheSwitchPortsForASwitchResponse> ReturnASwitchPort(string serial, string portId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSwitchPortsForASwitchResponse>($"devices/{serial}/switch/ports/{portId}", headers);
        }
    
        /// <summary>
        /// Update a switch port
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// name| string| The name of the switch port.
        /// tags| array| The list 
        /// of tags of the switch port.
        /// enabled| boolean| The status of the switch port.
        /// poeEnabled| boolean| 
        /// The PoE status of the switch port.
        /// type| string| The type of the switch port ('trunk' or 
        /// 'access').
        /// vlan| integer| The VLAN of the switch port. A null value will clear the value set for 
        /// trunk ports.
        /// voiceVlan| integer| The voice VLAN of the switch port. Only applicable to access 
        /// ports.
        /// allowedVlans| string| The VLANs allowed on the switch port. Only applicable to trunk 
        /// ports.
        /// isolationEnabled| boolean| The isolation status of the switch port.
        /// rstpEnabled| boolean| The 
        /// rapid spanning tree protocol status.
        /// stpGuard| string| The state of the STP guard ('disabled', 'root 
        /// guard', 'bpdu guard' or 'loop guard').
        /// linkNegotiation| string| The link speed for the switch 
        /// port.
        /// portScheduleId| string| The ID of the port schedule. A value of null will clear the port 
        /// schedule.
        /// udld| string| The action to take when Unidirectional Link is detected (Alert only, 
        /// Enforce). Default configuration is Alert only.
        /// accessPolicyType| string| The type of the access 
        /// policy of the switch port. Only applicable to access ports. Can be one of 'Open', 'Custom access 
        /// policy', 'MAC allow list' or 'Sticky MAC allow list'.
        /// accessPolicyNumber| integer| The number of a 
        /// custom access policy to configure on the switch port. Only applicable when 'accessPolicyType' is 
        /// 'Custom access policy'.
        /// macAllowList| array| Only devices with MAC addresses specified in this list 
        /// will have access to this port. Up to 20 MAC addresses can be defined. Only applicable when 
        /// 'accessPolicyType' is 'MAC allow list'.
        /// stickyMacAllowList| array| The initial list of MAC addresses 
        /// for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow 
        /// list'.
        /// stickyMacAllowListLimit| integer| The maximum number of MAC addresses for sticky MAC allow 
        /// list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
        /// stormControlEnabled| 
        /// boolean| The storm control status of the switch port.
        /// adaptivePolicyGroupId| string| The adaptive 
        /// policy group ID that will be used to tag traffic through this switch port. This ID must pre-exist 
        /// during the configuration, else needs to be created using adaptivePolicy/groups API. Cannot be 
        /// applied to a port on a switch bound to profile.
        /// peerSgtCapable| boolean| If true, Peer SGT is 
        /// enabled for traffic through this switch port. Applicable to trunk port only, not access port. Cannot 
        /// be applied to a port on a switch bound to profile.
        /// flexibleStackingEnabled| boolean| For supported 
        /// switches (e.g. MS420/MS425), whether or not the port has flexible stacking enabled.
        /// daiTrusted| 
        /// boolean| If true, ARP packets for this port will be considered trusted, and Dynamic ARP Inspection 
        /// will allow the traffic.
        /// profile| object| Profile attributes
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/ports/{portId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="portId">(Required) Port ID</param>
        public async Task<ListTheSwitchPortsForASwitchResponse> UpdateASwitchPort(UpdateASwitchPortRequest request, string serial, string portId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheSwitchPortsForASwitchResponse>($"devices/{serial}/switch/ports/{portId}", request, headers);
        }
    
        /// <summary>
        /// List layer 3 interfaces for a switch. Those for a stack may be found under switch stack routing. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListLayer3InterfacesForASwitchResponse> ListLayer3InterfacesForASwitch(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLayer3InterfacesForASwitchResponse>($"devices/{serial}/switch/routing/interfaces", headers);
        }
    
        /// <summary>
        /// Create a layer 3 interface for a switch
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| A friendly name or description for the interface or VLAN.
        /// subnet| string| The network that 
        /// this routed interface is on, in CIDR notation (ex. 10.1.1.0/24).
        /// interfaceIp| string| The IP address 
        /// this switch will use for layer 3 routing on this VLAN or subnet. This cannot be the same         as 
        /// the switch's management IP.
        /// multicastRouting| string| Enable multicast support if, multicast routing 
        /// between VLANs is required. Options are:         'disabled', 'enabled' or 'IGMP snooping querier'. 
        /// Default is 'disabled'.
        /// vlanId| integer| The VLAN this routed interface is on. VLAN must be between 1 
        /// and 4094.
        /// defaultGateway| string| The next hop for any traffic that isn't going to a directly 
        /// connected subnet or over a static route.         This IP address must exist in a subnet with a 
        /// routed interface. Required if this is the first IPv4 interface.
        /// ospfSettings| object| The OSPF 
        /// routing settings of the interface.
        /// ospfV3| object| The OSPFv3 routing settings of the 
        /// interface.
        /// ipv6| object| The IPv6 settings of the interface.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/interfaces` | create
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListLayer3InterfacesForASwitchResponse> CreateALayer3InterfaceForASwitch(CreateALayer3InterfaceForASwitchRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListLayer3InterfacesForASwitchResponse>($"devices/{serial}/switch/routing/interfaces", request, headers);
        }
    
        /// <summary>
        /// Return a layer 3 interface for a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="interfaceId">(Required) Interface ID</param>
        public async Task<ListLayer3InterfacesForASwitchResponse> ReturnALayer3InterfaceForASwitch(string serial, string interfaceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLayer3InterfacesForASwitchResponse>($"devices/{serial}/switch/routing/interfaces/{interfaceId}", headers);
        }
    
        /// <summary>
        /// Update a layer 3 interface for a switch
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| A friendly name or description for the interface or VLAN.
        /// subnet| string| The network that 
        /// this routed interface is on, in CIDR notation (ex. 10.1.1.0/24).
        /// interfaceIp| string| The IP address 
        /// this switch will use for layer 3 routing on this VLAN or subnet. This cannot be the same         as 
        /// the switch's management IP.
        /// multicastRouting| string| Enable multicast support if, multicast routing 
        /// between VLANs is required. Options are:         'disabled', 'enabled' or 'IGMP snooping querier'. 
        /// Default is 'disabled'.
        /// vlanId| integer| The VLAN this routed interface is on. VLAN must be between 1 
        /// and 4094.
        /// defaultGateway| string| The next hop for any traffic that isn't going to a directly 
        /// connected subnet or over a static route.         This IP address must exist in a subnet with a 
        /// routed interface. Required if this is the first IPv4 interface.
        /// ospfSettings| object| The OSPF 
        /// routing settings of the interface.
        /// ospfV3| object| The OSPFv3 routing settings of the 
        /// interface.
        /// ipv6| object| The IPv6 settings of the interface.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/interfaces/{interfaceId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="interfaceId">(Required) Interface ID</param>
        public async Task<ListLayer3InterfacesForASwitchResponse> UpdateALayer3InterfaceForASwitch(CreateALayer3InterfaceForASwitchRequest request, string serial, string interfaceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListLayer3InterfacesForASwitchResponse>($"devices/{serial}/switch/routing/interfaces/{interfaceId}", request, headers);
        }
    
        /// <summary>
        /// Delete a layer 3 interface from the switch
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/interfaces/{interfaceId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="interfaceId">(Required) Interface ID</param>
        public async Task<EmptyResponse> DeleteALayer3InterfaceFromTheSwitch(string serial, string interfaceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"devices/{serial}/switch/routing/interfaces/{interfaceId}", headers);
        }
    
        /// <summary>
        /// List layer 3 static routes for a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListLayer3StaticRoutesForASwitchResponse> ListLayer3StaticRoutesForASwitch(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLayer3StaticRoutesForASwitchResponse>($"devices/{serial}/switch/routing/staticRoutes", headers);
        }
    
        /// <summary>
        /// Create a layer 3 static route for a switch
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| Name or description for layer 3 static route
        /// subnet| string| The subnet which is routed via 
        /// this static route and should be specified in CIDR notation (ex. 1.2.3.0/24)
        /// nextHopIp| string| IP 
        /// address of the next hop device to which the device sends its traffic for the 
        /// subnet
        /// advertiseViaOspfEnabled| boolean| Option to advertise static route via 
        /// OSPF
        /// preferOverOspfRoutesEnabled| boolean| Option to prefer static route over OSPF routes
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/staticRoutes` | create
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListLayer3StaticRoutesForASwitchResponse> CreateALayer3StaticRouteForASwitch(CreateALayer3StaticRouteForASwitchRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListLayer3StaticRoutesForASwitchResponse>($"devices/{serial}/switch/routing/staticRoutes", request, headers);
        }
    
        /// <summary>
        /// Return a layer 3 static route for a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<ListLayer3StaticRoutesForASwitchResponse> ReturnALayer3StaticRouteForASwitch(string serial, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLayer3StaticRoutesForASwitchResponse>($"devices/{serial}/switch/routing/staticRoutes/{staticRouteId}", headers);
        }
    
        /// <summary>
        /// Update a layer 3 static route for a switch
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| Name or description for layer 3 static route
        /// subnet| string| The subnet which is routed via 
        /// this static route and should be specified in CIDR notation (ex. 1.2.3.0/24)
        /// nextHopIp| string| IP 
        /// address of the next hop device to which the device sends its traffic for the 
        /// subnet
        /// advertiseViaOspfEnabled| boolean| Option to advertise static route via 
        /// OSPF
        /// preferOverOspfRoutesEnabled| boolean| Option to prefer static route over OSPF routes
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<ListLayer3StaticRoutesForASwitchResponse> UpdateALayer3StaticRouteForASwitch(CreateALayer3StaticRouteForASwitchRequest request, string serial, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListLayer3StaticRoutesForASwitchResponse>($"devices/{serial}/switch/routing/staticRoutes/{staticRouteId}", request, headers);
        }
    
        /// <summary>
        /// Delete a layer 3 static route for a switch
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        /// <param name="staticRouteId">(Required) Static route ID</param>
        public async Task<EmptyResponse> DeleteALayer3StaticRouteForASwitch(string serial, string staticRouteId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"devices/{serial}/switch/routing/staticRoutes/{staticRouteId}", headers);
        }
    
        /// <summary>
        /// Return multicast settings for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnMulticastSettingsForANetworkResponse> ReturnMulticastSettingsForANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnMulticastSettingsForANetworkResponse>($"networks/{networkId}/switch/routing/multicast", headers);
        }
    
        /// <summary>
        /// Update multicast settings for a network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// defaultSettings| object| Default multicast setting for entire network. IGMP snooping and Flood 
        /// unknown multicast traffic settings are enabled by default.
        /// overrides| array| Array of paired 
        /// switches/stacks/profiles and corresponding multicast settings. An empty array will clear the 
        /// multicast settings.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/routing/multicast` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnMulticastSettingsForANetworkResponse> UpdateMulticastSettingsForANetwork(ReturnMulticastSettingsForANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnMulticastSettingsForANetworkResponse>($"networks/{networkId}/switch/routing/multicast", request, headers);
        }
    
        /// <summary>
        /// Return layer 3 OSPF routing configuration 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnLayer3OSPFRoutingConfigurationResponse> ReturnLayer3OSPFRoutingConfiguration(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnLayer3OSPFRoutingConfigurationResponse>($"networks/{networkId}/switch/routing/ospf", headers);
        }
    
        /// <summary>
        /// Update layer 3 OSPF routing configuration
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// enabled| boolean| Boolean value to enable or disable OSPF routing. OSPF routing is disabled by 
        /// default.
        /// helloTimerInSeconds| integer| Time interval in seconds at which hello packet will be sent 
        /// to OSPF neighbors to maintain connectivity. Value must be between 1 and 255. Default is 10 
        /// seconds.
        /// deadTimerInSeconds| integer| Time interval to determine when the peer will be declared 
        /// inactive/dead. Value must be between 1 and 65535
        /// areas| array| OSPF areas
        /// v3| object| OSPF v3 
        /// configuration
        /// md5AuthenticationEnabled| boolean| Boolean value to enable or disable MD5 
        /// authentication. MD5 authentication is disabled by default.
        /// md5AuthenticationKey| object| MD5 
        /// authentication credentials. This param is only relevant if md5AuthenticationEnabled is true
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/routing/ospf` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnLayer3OSPFRoutingConfigurationResponse> UpdateLayer3OSPFRoutingConfiguration(UpdateLayer3OSPFRoutingConfigurationRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnLayer3OSPFRoutingConfigurationResponse>($"networks/{networkId}/switch/routing/ospf", request, headers);
        }
    
        /// <summary>
        /// Return warm spare configuration for a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnMXWarmSpareSettingsResponse> ReturnWarmSpareConfigurationForASwitch(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnMXWarmSpareSettingsResponse>($"devices/{serial}/switch/warmSpare", headers);
        }
    
        /// <summary>
        /// Update warm spare configuration for a switch. The spare will use the same L3 configuration as the 
        /// primary. Note that this will irreversibly destroy any existing L3 configuration on the spare. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnMXWarmSpareSettingsResponse> UpdateWarmSpareConfigurationForASwitch(UpdateMXWarmSpareSettingsRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnMXWarmSpareSettingsResponse>($"devices/{serial}/switch/warmSpare", request, headers);
        }
    
        /// <summary>
        /// Return the access control lists for a MS network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> ReturnTheAccessControlListsForAMSNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/switch/accessControlLists", headers);
        }
    
        /// <summary>
        /// Update the access control lists for a MS network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// rules| 
        /// array| An ordered array of the access control list rules (not including the default rule). An empty 
        /// array will clear the rules.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheCellularFirewallRulesForAnMXNetworkResponse> UpdateTheAccessControlListsForAMSNetwork(ReturnTheCellularFirewallRulesForAnMXNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheCellularFirewallRulesForAnMXNetworkResponse>($"networks/{networkId}/switch/accessControlLists", request, headers);
        }
    
        /// <summary>
        /// List the access policies for a switch network. Only returns access policies with 'my RADIUS server' 
        /// as authentication method 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheAccessPoliciesForASwitchNetworkResponse> ListTheAccessPoliciesForASwitchNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheAccessPoliciesForASwitchNetworkResponse>($"networks/{networkId}/switch/accessPolicies", headers);
        }
    
        /// <summary>
        /// Create an access policy for a switch network. If you would like to enable Meraki Authentication, set 
        /// radiusServers to empty array. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheAccessPoliciesForASwitchNetworkResponse> CreateAnAccessPolicyForASwitchNetwork(CreateAnAccessPolicyForASwitchNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheAccessPoliciesForASwitchNetworkResponse>($"networks/{networkId}/switch/accessPolicies", request, headers);
        }
    
        /// <summary>
        /// Return a specific access policy for a switch network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="accessPolicyNumber">(Required) Access policy number</param>
        public async Task<ListTheAccessPoliciesForASwitchNetworkResponse> ReturnASpecificAccessPolicyForASwitchNetwork(string networkId, string accessPolicyNumber)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheAccessPoliciesForASwitchNetworkResponse>($"networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}", headers);
        }
    
        /// <summary>
        /// Update an access policy for a switch network. If you would like to enable Meraki Authentication, set 
        /// radiusServers to empty array. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="accessPolicyNumber">(Required) Access policy number</param>
        public async Task<ListTheAccessPoliciesForASwitchNetworkResponse> UpdateAnAccessPolicyForASwitchNetwork(CreateAnAccessPolicyForASwitchNetworkRequest request, string networkId, string accessPolicyNumber)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheAccessPoliciesForASwitchNetworkResponse>($"networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}", request, headers);
        }
    
        /// <summary>
        /// Delete an access policy for a switch network
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="accessPolicyNumber">(Required) Access policy number</param>
        public async Task<EmptyResponse> DeleteAnAccessPolicyForASwitchNetwork(string networkId, string accessPolicyNumber)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}", headers);
        }
    
        /// <summary>
        /// Return the switch alternate management interface for the network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<TheSwitchAlternateManagementInterfaceForTheNetworkResponse> TheSwitchAlternateManagementInterfaceForTheNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<TheSwitchAlternateManagementInterfaceForTheNetworkResponse>($"networks/{networkId}/switch/alternateManagementInterface", headers);
        }
    
        /// <summary>
        /// Update the switch alternate management interface for the network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// enabled| boolean| Boolean value to enable or disable AMI configuration. If enabled, VLAN and 
        /// protocols must be set
        /// vlanId| integer| Alternate management VLAN, must be between 1 and 
        /// 4094
        /// protocols| array| Can be one or more of the following values: 'radius', 'snmp' or 
        /// 'syslog'
        /// switches| array| Array of switch serial number and IP assignment. If parameter is present, 
        /// it cannot have empty body. Note: switches parameter is not applicable for template networks, in 
        /// other words, do not put 'switches' in the body when updating template networks. Also, an empty 
        /// 'switches' array will remove all previous assignments
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/alternateManagementInterface` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<TheSwitchAlternateManagementInterfaceForTheNetworkResponse> TheSwitchAlternateManagementInterfaceForTheNetwork2(TheSwitchAlternateManagementInterfaceForTheNetwork2Request request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<TheSwitchAlternateManagementInterfaceForTheNetworkResponse>($"networks/{networkId}/switch/alternateManagementInterface", request, headers);
        }
    
        /// <summary>
        /// Return the network's DHCPv4 servers seen within the selected timeframe (default 1 day) 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<V4ServersSeenWithinTheSelectedTimeframeDefault1DayResponse> V4ServersSeenWithinTheSelectedTimeframeDefault1Day(V4ServersSeenWithinTheSelectedTimeframeDefault1DayParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/switch/dhcp/v4/servers/seen", parametersDict);
            return await _httpClient.GetFromJsonAsync<V4ServersSeenWithinTheSelectedTimeframeDefault1DayResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the DHCP server settings. Blocked/allowed servers are only applied when default policy is 
        /// allow/block, respectively 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheDHCPServerSettingsResponse> ReturnTheDHCPServerSettings(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheDHCPServerSettingsResponse>($"networks/{networkId}/switch/dhcpServerPolicy", headers);
        }
    
        /// <summary>
        /// Update the DHCP server settings. Blocked/allowed servers are only applied when default policy is 
        /// allow/block, respectively 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheDHCPServerSettingsResponse> UpdateTheDHCPServerSettings(ReturnTheDHCPServerSettingsResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheDHCPServerSettingsResponse>($"networks/{networkId}/switch/dhcpServerPolicy", request, headers);
        }
    
        /// <summary>
        /// Return the DSCP to CoS mappings 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheDSCPToCoSMappingsResponse> ReturnTheDSCPToCoSMappings(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheDSCPToCoSMappingsResponse>($"networks/{networkId}/switch/dscpToCosMappings", headers);
        }
    
        /// <summary>
        /// Update the DSCP to CoS mappings
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// mappings| array| An array of DSCP to CoS 
        /// mappings. An empty array will reset the mappings to default.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/dscpToCosMappings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheDSCPToCoSMappingsResponse> UpdateTheDSCPToCoSMappings(ReturnTheDSCPToCoSMappingsResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheDSCPToCoSMappingsResponse>($"networks/{networkId}/switch/dscpToCosMappings", request, headers);
        }
    
        /// <summary>
        /// List link aggregation groups 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListLinkAggregationGroupsResponse> ListLinkAggregationGroups(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLinkAggregationGroupsResponse>($"networks/{networkId}/switch/linkAggregations", headers);
        }
    
        /// <summary>
        /// Create a link aggregation group
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// switchPorts| array| Array of switch or stack 
        /// ports for creating aggregation group. Minimum 2 and maximum 8 ports are 
        /// supported.
        /// switchProfilePorts| array| Array of switch profile ports for creating aggregation group. 
        /// Minimum 2 and maximum 8 ports are supported.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/linkAggregations` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListLinkAggregationGroupsResponse> CreateALinkAggregationGroup(CreateALinkAggregationGroupRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListLinkAggregationGroupsResponse>($"networks/{networkId}/switch/linkAggregations", request, headers);
        }
    
        /// <summary>
        /// Update a link aggregation group
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// switchPorts| array| Array of switch or stack 
        /// ports for updating aggregation group. Minimum 2 and maximum 8 ports are 
        /// supported.
        /// switchProfilePorts| array| Array of switch profile ports for updating aggregation group. 
        /// Minimum 2 and maximum 8 ports are supported.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/linkAggregations/{linkAggregationId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="linkAggregationId">(Required) Link aggregation ID</param>
        public async Task<ListLinkAggregationGroupsResponse> UpdateALinkAggregationGroup(CreateALinkAggregationGroupRequest request, string networkId, string linkAggregationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListLinkAggregationGroupsResponse>($"networks/{networkId}/switch/linkAggregations/{linkAggregationId}", request, headers);
        }
    
        /// <summary>
        /// Split a link aggregation group into separate ports
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/linkAggregations/{linkAggregationId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="linkAggregationId">(Required) Link aggregation ID</param>
        public async Task<EmptyResponse> SplitALinkAggregationGroupIntoSeparatePorts(string networkId, string linkAggregationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/switch/linkAggregations/{linkAggregationId}", headers);
        }
    
        /// <summary>
        /// Return the MTU configuration 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheMTUConfigurationResponse> ReturnTheMTUConfiguration(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheMTUConfigurationResponse>($"networks/{networkId}/switch/mtu", headers);
        }
    
        /// <summary>
        /// Update the MTU configuration
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// defaultMtuSize| integer| MTU size for the entire 
        /// network. Default value is 9578.
        /// overrides| array| Override MTU size for individual switches or 
        /// switch templates. An empty array will clear overrides.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/mtu` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheMTUConfigurationResponse> UpdateTheMTUConfiguration(UpdateTheMTUConfigurationRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheMTUConfigurationResponse>($"networks/{networkId}/switch/mtu", request, headers);
        }
    
        /// <summary>
        /// List switch port schedules 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListSwitchPortSchedulesResponse> ListSwitchPortSchedules(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListSwitchPortSchedulesResponse>($"networks/{networkId}/switch/portSchedules", headers);
        }
    
        /// <summary>
        /// Add a switch port schedule
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name for your port schedule. 
        /// Required
        /// portSchedule| object|     The schedule for switch port scheduling. Schedules are applied to 
        /// days of the week.
        ///     When it's empty, default schedule with all days of a week are configured.
        ///     
        /// Any unspecified day in the schedule is added as a default schedule configuration of the day.
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListSwitchPortSchedulesResponse> AddASwitchPortSchedule(ListSwitchPortSchedulesResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListSwitchPortSchedulesResponse>($"networks/{networkId}/switch/portSchedules", request, headers);
        }
    
        /// <summary>
        /// Delete a switch port schedule 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="portScheduleId">(Required) Port schedule ID</param>
        public async Task<EmptyResponse> DeleteASwitchPortSchedule(string networkId, string portScheduleId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/switch/portSchedules/{portScheduleId}", headers);
        }
    
        /// <summary>
        /// Update a switch port schedule
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name for your port 
        /// schedule.
        /// portSchedule| object|     The schedule for switch port scheduling. Schedules are applied 
        /// to days of the week.
        ///     When it's empty, default schedule with all days of a week are configured.
        ///   
        ///   Any unspecified day in the schedule is added as a default schedule configuration of the 
        /// day.
        /// 
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/portSchedules/{portScheduleId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="portScheduleId">(Required) Port schedule ID</param>
        public async Task<ListSwitchPortSchedulesResponse> UpdateASwitchPortSchedule(ListSwitchPortSchedulesResponse request, string networkId, string portScheduleId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListSwitchPortSchedulesResponse>($"networks/{networkId}/switch/portSchedules/{portScheduleId}", request, headers);
        }
    
        /// <summary>
        /// List quality of service rules 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListQualityOfServiceRulesResponse> ListQualityOfServiceRules(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListQualityOfServiceRulesResponse>($"networks/{networkId}/switch/qosRules", headers);
        }
    
        /// <summary>
        /// Add a quality of service rule
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// vlan| integer| The VLAN of the incoming packet. A 
        /// null value will match any VLAN.
        /// protocol| string| The protocol of the incoming packet. Can be one of 
        /// "ANY", "TCP" or "UDP". Default value is "ANY"
        /// srcPort| integer| The source port of the incoming 
        /// packet. Applicable only if protocol is TCP or UDP.
        /// srcPortRange| string| The source port range of 
        /// the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
        /// dstPort| 
        /// integer| The destination port of the incoming packet. Applicable only if protocol is TCP or 
        /// UDP.
        /// dstPortRange| string| The destination port range of the incoming packet. Applicable only if 
        /// protocol is set to TCP or UDP. Example: 70-80
        /// dscp| integer| DSCP tag. Set this to -1 to trust 
        /// incoming DSCP. Default value is 0
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/qosRules` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListQualityOfServiceRulesResponse> AddAQualityOfServiceRule(AddAQualityOfServiceRuleRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListQualityOfServiceRulesResponse>($"networks/{networkId}/switch/qosRules", request, headers);
        }
    
        /// <summary>
        /// Return a quality of service rule 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qosRuleId">(Required) Qos rule ID</param>
        public async Task<ListQualityOfServiceRulesResponse> ReturnAQualityOfServiceRule(string networkId, string qosRuleId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListQualityOfServiceRulesResponse>($"networks/{networkId}/switch/qosRules/{qosRuleId}", headers);
        }
    
        /// <summary>
        /// Delete a quality of service rule
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/qosRules/{qosRuleId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qosRuleId">(Required) Qos rule ID</param>
        public async Task<EmptyResponse> DeleteAQualityOfServiceRule(string networkId, string qosRuleId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/switch/qosRules/{qosRuleId}", headers);
        }
    
        /// <summary>
        /// Update a quality of service rule
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// vlan| integer| The VLAN of the incoming packet. A 
        /// null value will match any VLAN.
        /// protocol| string| The protocol of the incoming packet. Can be one of 
        /// "ANY", "TCP" or "UDP". Default value is "ANY".
        /// srcPort| integer| The source port of the incoming 
        /// packet. Applicable only if protocol is TCP or UDP.
        /// srcPortRange| string| The source port range of 
        /// the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
        /// dstPort| 
        /// integer| The destination port of the incoming packet. Applicable only if protocol is TCP or 
        /// UDP.
        /// dstPortRange| string| The destination port range of the incoming packet. Applicable only if 
        /// protocol is set to TCP or UDP. Example: 70-80
        /// dscp| integer| DSCP tag that should be assigned to 
        /// incoming packet. Set this to -1 to trust incoming DSCP. Default value is 0.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/qosRules/{qosRuleId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="qosRuleId">(Required) Qos rule ID</param>
        public async Task<ListQualityOfServiceRulesResponse> UpdateAQualityOfServiceRule(AddAQualityOfServiceRuleRequest request, string networkId, string qosRuleId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListQualityOfServiceRulesResponse>($"networks/{networkId}/switch/qosRules/{qosRuleId}", request, headers);
        }
    
        /// <summary>
        /// Returns the switch network settings 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsTheSwitchNetworkSettingsResponse> ReturnsTheSwitchNetworkSettings(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsTheSwitchNetworkSettingsResponse>($"networks/{networkId}/switch/settings", headers);
        }
    
        /// <summary>
        /// Update switch network settings
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// vlan| integer| Management VLAN
        /// useCombinedPower| 
        /// boolean| The use Combined Power as the default behavior of secondary power supplies on supported 
        /// devices.
        /// powerExceptions| array| Exceptions on a per switch basis to 
        /// "useCombinedPower"
        /// uplinkClientSampling| object| Uplink client sampling
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/settings` | settings/update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsTheSwitchNetworkSettingsResponse> UpdateSwitchNetworkSettings(UpdateSwitchNetworkSettingsRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsTheSwitchNetworkSettingsResponse>($"networks/{networkId}/switch/settings", request, headers);
        }
    
        /// <summary>
        /// List the switch stacks in a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheSwitchStacksInANetworkResponse> ListTheSwitchStacksInANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSwitchStacksInANetworkResponse>($"networks/{networkId}/switch/stacks", headers);
        }
    
        /// <summary>
        /// Create a stack
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// name| string| The name of the new stack
        /// serials| array| An array 
        /// of switch serials to be added into the new stack
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheSwitchStacksInANetworkResponse> CreateAStack(ListsAllSensorAlertProfilesForANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheSwitchStacksInANetworkResponse>($"networks/{networkId}/switch/stacks", request, headers);
        }
    
        /// <summary>
        /// Show a switch stack 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="switchStackId">(Required) Switch stack ID</param>
        public async Task<ListTheSwitchStacksInANetworkResponse> ShowASwitchStack(string networkId, string switchStackId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheSwitchStacksInANetworkResponse>($"networks/{networkId}/switch/stacks/{switchStackId}", headers);
        }
    
        /// <summary>
        /// Delete a stack 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="switchStackId">(Required) Switch stack ID</param>
        public async Task<EmptyResponse> DeleteAStack(string networkId, string switchStackId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/switch/stacks/{switchStackId}", headers);
        }
    
        /// <summary>
        /// Add a switch to a stack
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// serial| string| The serial of the switch to be 
        /// added
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="switchStackId">(Required) Switch stack ID</param>
        public async Task<ListTheSwitchStacksInANetworkResponse> AddASwitchToAStack(ListTheDevicesInAnOrganizationResponse request, string networkId, string switchStackId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheSwitchStacksInANetworkResponse>($"networks/{networkId}/switch/stacks/{switchStackId}/add", request, headers);
        }
    
        /// <summary>
        /// Remove a switch from a stack
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// serial| string| The serial of the switch to be 
        /// removed
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="switchStackId">(Required) Switch stack ID</param>
        public async Task<ListTheSwitchStacksInANetworkResponse> RemoveASwitchFromAStack(ListTheDevicesInAnOrganizationResponse request, string networkId, string switchStackId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheSwitchStacksInANetworkResponse>($"networks/{networkId}/switch/stacks/{switchStackId}/remove", request, headers);
        }
    
        /// <summary>
        /// Return the storm control configuration for a switch network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<EturnTheStormControlConfigurationForASwitchNetworkResponse> EturnTheStormControlConfigurationForASwitchNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<EturnTheStormControlConfigurationForASwitchNetworkResponse>($"networks/{networkId}/switch/stormControl", headers);
        }
    
        /// <summary>
        /// Update the storm control configuration for a switch network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// broadcastThreshold| integer| Percentage (1 to 99) of total available port bandwidth for broadcast 
        /// traffic type. Default value 100 percent rate is to clear the configuration.
        /// multicastThreshold| 
        /// integer| Percentage (1 to 99) of total available port bandwidth for multicast traffic type. Default 
        /// value 100 percent rate is to clear the configuration.
        /// unknownUnicastThreshold| integer| Percentage 
        /// (1 to 99) of total available port bandwidth for unknown unicast (dlf-destination lookup failure) 
        /// traffic type. Default value 100 percent rate is to clear the configuration.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/stormControl` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<EturnTheStormControlConfigurationForASwitchNetworkResponse> PdateTheStormControlConfigurationForASwitchNetwork(PdateTheStormControlConfigurationForASwitchNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<EturnTheStormControlConfigurationForASwitchNetworkResponse>($"networks/{networkId}/switch/stormControl", request, headers);
        }
    
        /// <summary>
        /// Returns STP settings 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsSTPSettingsResponse> ReturnsSTPSettings(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnsSTPSettingsResponse>($"networks/{networkId}/switch/stp", headers);
        }
    
        /// <summary>
        /// Updates STP settings
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// rstpEnabled| boolean| The spanning tree protocol status in 
        /// network
        /// stpBridgePriority| array| STP bridge priority for switches/stacks or switch templates. An 
        /// empty array will clear the STP bridge priority settings.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/switch/stp` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnsSTPSettingsResponse> UpdatesSTPSettings(UpdatesSTPSettingsRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnsSTPSettingsResponse>($"networks/{networkId}/switch/stp", request, headers);
        }
    
        /// <summary>
        /// List the switch templates for your switch template configuration 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        /// <param name="configTemplateId">(Required) Config template ID</param>
        public async Task<ESwitchTemplatesForYourSwitchTemplateConfigurationResponse> ESwitchTemplatesForYourSwitchTemplateConfiguration(string organizationId, string configTemplateId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ESwitchTemplatesForYourSwitchTemplateConfigurationResponse>($"organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles", headers);
        }
    
        /// <summary>
        /// Clone port-level and some switch-level configuration settings from a source switch to one or more 
        /// target switches. Cloned settings include: Aggregation Groups, Power Settings, Multicast Settings, 
        /// MTU Configuration, STP Bridge priority, Port Mirroring 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<SettingsFromASourceSwitchToOneOrMoreTargetSwitchesRequest> SettingsFromASourceSwitchToOneOrMoreTargetSwitches(SettingsFromASourceSwitchToOneOrMoreTargetSwitchesRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<SettingsFromASourceSwitchToOneOrMoreTargetSwitchesRequest>($"organizations/{organizationId}/switch/devices/clone", request, headers);
        }
    
        /// <summary>
        /// Cycle a set of switch ports
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// ports| array| List of switch ports
        /// 
        /// #### Supports 
        /// Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/switch/ports` | cycle
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<CycleASetOfSwitchPortsRequest> CycleASetOfSwitchPorts(CycleASetOfSwitchPortsRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<CycleASetOfSwitchPortsRequest>($"devices/{serial}/switch/ports/cycle", request, headers);
        }
    
        /// <summary>
        /// Return the status for all the ports of a switch 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheStatusForAllThePortsOfASwitchResponse> ReturnTheStatusForAllThePortsOfASwitch(ReturnTheStatusForAllThePortsOfASwitchParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/switch/ports/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnTheStatusForAllThePortsOfASwitchResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Update the bluetooth settings for a wireless device
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// uuid| 
        /// string| Desired UUID of the beacon. If the value is set to null it will reset to Dashboard's 
        /// automatically generated value.
        /// major| integer| Desired major value of the beacon. If the value is 
        /// set to null it will reset to Dashboard's automatically generated value.
        /// minor| integer| Desired 
        /// minor value of the beacon. If the value is set to null it will reset to Dashboard's automatically 
        /// generated value.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/wireless/bluetooth/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<UpdateTheBluetoothSettingsForAWirelessDeviceResponse> UpdateTheBluetoothSettingsForAWirelessDevice(UpdateTheBluetoothSettingsForAWirelessDeviceRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<UpdateTheBluetoothSettingsForAWirelessDeviceResponse>($"devices/{serial}/wireless/bluetooth/settings", request, headers);
        }
    
        /// <summary>
        /// Return the bluetooth settings for a wireless device 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<UpdateTheBluetoothSettingsForAWirelessDeviceResponse> ReturnTheBluetoothSettingsForAWirelessDevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<UpdateTheBluetoothSettingsForAWirelessDeviceResponse>($"devices/{serial}/wireless/bluetooth/settings", headers);
        }
    
        /// <summary>
        /// Return the Bluetooth settings for a network. Bluetooth settings must be enabled on the network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ErgyBLEBluetoothSettingsAMustBeEnabledOnTheNetworkResponse> ErgyBLEBluetoothSettingsAMustBeEnabledOnTheNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ErgyBLEBluetoothSettingsAMustBeEnabledOnTheNetworkResponse>($"networks/{networkId}/wireless/bluetooth/settings", headers);
        }
    
        /// <summary>
        /// Update the Bluetooth settings for a network. See the docs page for Bluetooth settings. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ErgyBLEBluetoothSettingsAMustBeEnabledOnTheNetworkResponse> UpdateTheBluetoothSettingsForANetwork(UpdateTheBluetoothSettingsForANetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ErgyBLEBluetoothSettingsAMustBeEnabledOnTheNetworkResponse>($"networks/{networkId}/wireless/bluetooth/settings", request, headers);
        }
    
        /// <summary>
        /// Return the radio settings of a device 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheRadioSettingsOfAnApplianceResponse> ReturnTheRadioSettingsOfADevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheRadioSettingsOfAnApplianceResponse>($"devices/{serial}/wireless/radio/settings", headers);
        }
    
        /// <summary>
        /// Update the radio settings of a device
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        /// 
        ///  :-------------: |:-------------: |:-------------: 
        /// rfProfileId| string| The ID of an RF profile to 
        /// assign to the device. If the value of this parameter is null, the appropriate basic RF profile 
        /// (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually 
        /// configured overrides on the device (channel width, channel, power).
        /// twoFourGhzSettings| object| 
        /// Manual radio settings for 2.4 GHz.
        /// fiveGhzSettings| object| Manual radio settings for 5 GHz.
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/devices/{serial}/wireless/radio/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheRadioSettingsOfAnApplianceResponse> UpdateTheRadioSettingsOfADevice(ReturnTheRadioSettingsOfAnApplianceResponse request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheRadioSettingsOfAnApplianceResponse>($"devices/{serial}/wireless/radio/settings", request, headers);
        }
    
        /// <summary>
        /// Return alternate management interface and devices with IP assigned 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<TernateManagementInterfaceAndDevicesWithIPAssignedResponse> TernateManagementInterfaceAndDevicesWithIPAssigned(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<TernateManagementInterfaceAndDevicesWithIPAssignedResponse>($"networks/{networkId}/wireless/alternateManagementInterface", headers);
        }
    
        /// <summary>
        /// Update alternate management interface and device static IP
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// enabled| boolean| Boolean value to enable or disable alternate management interface
        /// vlanId| 
        /// integer| Alternate management interface VLAN, must be between 1 and 4094
        /// protocols| array| Can be 
        /// one or more of the following values: 'radius', 'snmp', 'syslog' or 'ldap'
        /// accessPoints| array| Array 
        /// of access point serial number and IP assignment. Note: accessPoints IP assignment is not applicable 
        /// for template networks, in other words, do not put 'accessPoints' in the body when updating template 
        /// networks. Also, an empty 'accessPoints' array will remove all previous static IP assignments
        /// 
        /// #### 
        /// Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/alternateManagementInterface` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<TernateManagementInterfaceAndDevicesWithIPAssignedResponse> PdateAlternateManagementInterfaceAndDeviceStaticIP(PdateAlternateManagementInterfaceAndDeviceStaticIPRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<TernateManagementInterfaceAndDevicesWithIPAssignedResponse>($"networks/{networkId}/wireless/alternateManagementInterface", request, headers);
        }
    
        /// <summary>
        /// Return the billing settings of this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheBillingSettingsOfThisNetworkResponse> ReturnTheBillingSettingsOfThisNetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheBillingSettingsOfThisNetworkResponse>($"networks/{networkId}/wireless/billing", headers);
        }
    
        /// <summary>
        /// Update the billing settings
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// currency| string| The currency code of this node 
        /// group's billing plans
        /// plans| array| Array of billing plans in the node group. (Can configure a 
        /// maximum of 5)
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/billing` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheBillingSettingsOfThisNetworkResponse> UpdateTheBillingSettings(ReturnTheBillingSettingsOfThisNetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheBillingSettingsOfThisNetworkResponse>($"networks/{networkId}/wireless/billing", request, headers);
        }
    
        /// <summary>
        /// List RF profiles for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListRFProfilesForThisNetworkResponse> ListRFProfilesForThisNetwork(ListRFProfilesForThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/rfProfiles", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListRFProfilesForThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the wireless settings for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheWirelessSettingsForANetworkResponse> ReturnTheWirelessSettingsForANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheWirelessSettingsForANetworkResponse>($"networks/{networkId}/wireless/settings", headers);
        }
    
        /// <summary>
        /// Update the wireless settings for a network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// meshingEnabled| boolean| Toggle for enabling or disabling meshing in a network
        /// ipv6BridgeEnabled| 
        /// boolean| Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must 
        /// also be configured to use bridge mode)
        /// locationAnalyticsEnabled| boolean| Toggle for enabling or 
        /// disabling location analytics for your network
        /// upgradeStrategy| string| The upgrade strategy to apply 
        /// to the network. Must be one of 'minimizeUpgradeTime' or 'minimizeClientDowntime'. Requires firmware 
        /// version MR 26.8 or higher'
        /// ledLightsOn| boolean| Toggle for enabling or disabling LED lights on all 
        /// APs in the network (making them run dark)
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/settings` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheWirelessSettingsForANetworkResponse> UpdateTheWirelessSettingsForANetwork(UpdateTheWirelessSettingsForANetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnTheWirelessSettingsForANetworkResponse>($"networks/{networkId}/wireless/settings", request, headers);
        }
    
        /// <summary>
        /// List the MR SSIDs in a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheMRSSIDsInANetworkResponse> ListTheMRSSIDsInANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMRSSIDsInANetworkResponse>($"networks/{networkId}/wireless/ssids", headers);
        }
    
        /// <summary>
        /// Return a single MR SSID 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="number">(Required) Number</param>
        public async Task<ListTheMRSSIDsInANetworkResponse> ReturnASingleMRSSID(string networkId, string number)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMRSSIDsInANetworkResponse>($"networks/{networkId}/wireless/ssids/{number}", headers);
        }
    
        /// <summary>
        /// Update the attributes of an MR SSID
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of the SSID
        /// enabled| 
        /// boolean| Whether or not the SSID is enabled
        /// authMode| string| The association control method for the 
        /// SSID ('open', 'open-enhanced', 'psk', 'open-with-radius', 'open-with-nac', '8021x-meraki', 
        /// '8021x-nac', '8021x-radius', '8021x-google', '8021x-localradius', 'ipsk-with-radius', 
        /// 'ipsk-without-radius' or 'ipsk-with-nac')
        /// enterpriseAdminAccess| string| Whether or not an SSID is 
        /// accessible by 'enterprise' administrators ('access disabled' or 'access enabled')
        /// encryptionMode| 
        /// string| The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the 
        /// authMode is 'psk'
        /// psk| string| The passkey for the SSID. This param is only valid if the authMode is 
        /// 'psk'
        /// wpaEncryptionMode| string| The types of WPA encryption. ('WPA1 only', 'WPA1 and WPA2', 'WPA2 
        /// only', 'WPA3 Transition Mode', 'WPA3 only' or 'WPA3 192-bit Security')
        /// dot11w| object| The current 
        /// setting for Protected Management Frames (802.11w).
        /// dot11r| object| The current setting for 
        /// 802.11r
        /// splashPage| string| The type of splash page for the SSID ('None', 'Click-through splash 
        /// page', 'Billing', 'Password-protected with Meraki RADIUS', 'Password-protected with custom RADIUS', 
        /// 'Password-protected with Active Directory', 'Password-protected with LDAP', 'SMS authentication', 
        /// 'Systems Manager Sentry', 'Facebook Wi-Fi', 'Google OAuth', 'Sponsored guest', 'Cisco ISE' or 
        /// 'Google Apps domain'). This attribute is not supported for template 
        /// children.
        /// splashGuestSponsorDomains| array| Array of valid sponsor email domains for sponsored guest 
        /// splash type.
        /// oauth| object| The OAuth settings of this SSID. Only valid if splashPage is 'Google 
        /// OAuth'.
        /// localRadius| object| The current setting for Local Authentication, a built-in RADIUS server 
        /// on the access point. Only valid if authMode is '8021x-localradius'.
        /// ldap| object| The current 
        /// setting for LDAP. Only valid if splashPage is 'Password-protected with LDAP'.
        /// activeDirectory| 
        /// object| The current setting for Active Directory. Only valid if splashPage is 'Password-protected 
        /// with Active Directory'
        /// radiusServers| array| The RADIUS 802.1X servers to be used for 
        /// authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 
        /// 'ipsk-with-radius'
        /// radiusProxyEnabled| boolean| If true, Meraki devices will proxy RADIUS messages 
        /// through the Meraki cloud to the configured RADIUS auth and accounting servers.
        /// radiusTestingEnabled| 
        /// boolean| If true, Meraki devices will periodically send Access-Request messages to configured RADIUS 
        /// servers using identity 'meraki_8021x_test' to ensure that the RADIUS servers are 
        /// reachable.
        /// radiusCalledStationId| string| The template of the called station identifier to be used 
        /// for RADIUS (ex. $NODE_MAC$:$VAP_NUM$).
        /// radiusAuthenticationNasId| string| The template of the NAS 
        /// identifier to be used for RADIUS authentication (ex. $NODE_MAC$:$VAP_NUM$).
        /// radiusServerTimeout| 
        /// integer| The amount of time for which a RADIUS client waits for a reply from the RADIUS server (must 
        /// be between 1-10 seconds).
        /// radiusServerAttemptsLimit| integer| The maximum number of transmit 
        /// attempts after which a RADIUS server is failed over (must be between 1-5).
        /// radiusFallbackEnabled| 
        /// boolean| Whether or not higher priority RADIUS servers should be retried after 60 
        /// seconds.
        /// radiusCoaEnabled| boolean| If true, Meraki devices will act as a RADIUS Dynamic 
        /// Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent 
        /// by the RADIUS server.
        /// radiusFailoverPolicy| string| This policy determines how authentication 
        /// requests should be handled in the event that all of the configured RADIUS servers are unreachable 
        /// ('Deny access' or 'Allow access')
        /// radiusLoadBalancingPolicy| string| This policy determines which 
        /// RADIUS server will be contacted first in an authentication attempt and the ordering of any necessary 
        /// retry attempts ('Strict priority order' or 'Round robin')
        /// radiusAccountingEnabled| boolean| Whether 
        /// or not RADIUS accounting is enabled. This param is only valid if the authMode is 'open-with-radius', 
        /// '8021x-radius' or 'ipsk-with-radius'
        /// radiusAccountingServers| array| The RADIUS accounting 802.1X 
        /// servers to be used for authentication. This param is only valid if the authMode is 
        /// 'open-with-radius', '8021x-radius' or 'ipsk-with-radius' and radiusAccountingEnabled is 
        /// 'true'
        /// radiusAccountingInterimInterval| integer| The interval (in seconds) in which accounting 
        /// information is updated and sent to the RADIUS accounting server.
        /// radiusAttributeForGroupPolicies| 
        /// string| Specify the RADIUS attribute used to look up group policies ('Filter-Id', 'Reply-Message', 
        /// 'Airespace-ACL-Name' or 'Aruba-User-Role'). Access points must receive this attribute in the RADIUS 
        /// Access-Accept message
        /// ipAssignmentMode| string| The client IP assignment mode ('NAT mode', 'Bridge 
        /// mode', 'Layer 3 roaming', 'Ethernet over GRE', 'Layer 3 roaming with a concentrator' or 
        /// 'VPN')
        /// useVlanTagging| boolean| Whether or not traffic should be directed to use specific VLANs. 
        /// This param is only valid if the ipAssignmentMode is 'Bridge mode' or 'Layer 3 
        /// roaming'
        /// concentratorNetworkId| string| The concentrator to use when the ipAssignmentMode is 'Layer 
        /// 3 roaming with a concentrator' or 'VPN'.
        /// secondaryConcentratorNetworkId| string| The secondary 
        /// concentrator to use when the ipAssignmentMode is 'VPN'. If configured, the APs will switch to using 
        /// this concentrator if the primary concentrator is unreachable. This param is optional. ('disabled' 
        /// represents no secondary concentrator.)
        /// disassociateClientsOnVpnFailover| boolean| Disassociate 
        /// clients when 'VPN' concentrator failover occurs in order to trigger clients to re-associate and 
        /// generate new DHCP requests. This param is only valid if ipAssignmentMode is 'VPN'.
        /// vlanId| integer| 
        /// The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Layer 3 
        /// roaming with a concentrator' or 'VPN'
        /// defaultVlanId| integer| The default VLAN ID used for 'all 
        /// other APs'. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 
        /// roaming'
        /// apTagsAndVlanIds| array| The list of tags and VLAN IDs used for VLAN tagging. This param is 
        /// only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
        /// walledGardenEnabled| 
        /// boolean| Allow access to a configurable list of IP ranges, which users may access prior to 
        /// sign-on.
        /// walledGardenRanges| array| Specify your walled garden by entering an array of addresses, 
        /// ranges using CIDR notation, domain names, and domain wildcards (e.g. '192.168.1.1/24', 
        /// '192.168.37.10/32', 'www.yahoo.com', '*.google.com']). Meraki's splash page is automatically 
        /// included in your walled garden.
        /// gre| object| Ethernet over GRE settings
        /// radiusOverride| boolean| If 
        /// true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is 'NAT 
        /// mode'.
        /// radiusGuestVlanEnabled| boolean| Whether or not RADIUS Guest VLAN is enabled. This param is 
        /// only valid if the authMode is 'open-with-radius' and addressing mode is not set to 'isolated' or 
        /// 'nat' mode
        /// radiusGuestVlanId| integer| VLAN ID of the RADIUS Guest VLAN. This param is only valid if 
        /// the authMode is 'open-with-radius' and addressing mode is not set to 'isolated' or 'nat' 
        /// mode
        /// minBitrate| number| The minimum bitrate in Mbps of this SSID in the default indoor RF profile. 
        /// ('1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54')
        /// bandSelection| string| The 
        /// client-serving radio frequencies of this SSID in the default indoor RF profile. ('Dual band 
        /// operation', '5 GHz band only' or 'Dual band operation with Band 
        /// Steering')
        /// perClientBandwidthLimitUp| integer| The upload bandwidth limit in Kbps. (0 represents no 
        /// limit.)
        /// perClientBandwidthLimitDown| integer| The download bandwidth limit in Kbps. (0 represents no 
        /// limit.)
        /// perSsidBandwidthLimitUp| integer| The total upload bandwidth limit in Kbps. (0 represents no 
        /// limit.)
        /// perSsidBandwidthLimitDown| integer| The total download bandwidth limit in Kbps. (0 
        /// represents no limit.)
        /// lanIsolationEnabled| boolean| Boolean indicating whether Layer 2 LAN isolation 
        /// should be enabled or disabled. Only configurable when ipAssignmentMode is 'Bridge mode'.
        /// visible| 
        /// boolean| Boolean indicating whether APs should advertise or hide this SSID. APs will only broadcast 
        /// this SSID if set to true
        /// availableOnAllAps| boolean| Boolean indicating whether all APs should 
        /// broadcast the SSID or if it should be restricted to APs matching any availability tags. Can only be 
        /// false if the SSID has availability tags.
        /// availabilityTags| array| Accepts a list of tags for this 
        /// SSID. If availableOnAllAps is false, then the SSID will only be broadcast by APs with tags matching 
        /// any of the tags in this list.
        /// mandatoryDhcpEnabled| boolean| If true, Mandatory DHCP will enforce 
        /// that clients connecting to this SSID must use the IP address assigned by the DHCP server. Clients 
        /// who use a static IP address won't be able to associate.
        /// adultContentFilteringEnabled| boolean| 
        /// Boolean indicating whether or not adult content will be blocked
        /// dnsRewrite| object| DNS servers 
        /// rewrite settings
        /// speedBurst| object| The SpeedBurst setting for this SSID'
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/ssids/{number}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="number">(Required) Number</param>
        public async Task<ListTheMRSSIDsInANetworkResponse> UpdateTheAttributesOfAnMRSSID(UpdateTheAttributesOfAnMRSSIDRequest request, string networkId, string number)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheMRSSIDsInANetworkResponse>($"networks/{networkId}/wireless/ssids/{number}", request, headers);
        }
    
        /// <summary>
        /// Aggregated connectivity info for a given AP on this network 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<AggregatedConnectivityInfoForAGivenAPOnThisNetworkResponse> AggregatedConnectivityInfoForAGivenAPOnThisNetwork(AggregatedConnectivityInfoForAGivenAPOnThisNetworkParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/wireless/connectionStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AggregatedConnectivityInfoForAGivenAPOnThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated connectivity info for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ConnectionStats> AggregatedConnectivityInfoForThisNetwork(AggregatedConnectivityInfoForThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/connectionStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<ConnectionStats>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated latency info for a given AP on this network 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<AggregatedLatencyInfoForAGivenAPOnThisNetworkResponse> AggregatedLatencyInfoForAGivenAPOnThisNetwork(AggregatedLatencyInfoForAGivenAPOnThisNetworkParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/wireless/latencyStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AggregatedLatencyInfoForAGivenAPOnThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated latency info for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<LatencyStats> AggregatedLatencyInfoForThisNetwork(AggregatedLatencyInfoForThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/latencyStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<LatencyStats>(queryString, headers);
        }
    
        /// <summary>
        /// Return the SSID statuses of an access point 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnTheSSIDStatusesOfAnAccessPointResponse> ReturnTheSSIDStatusesOfAnAccessPoint(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheSSIDStatusesOfAnAccessPointResponse>($"devices/{serial}/wireless/status", headers);
        }
    
        /// <summary>
        /// List Air Marshal scan results from a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListAirMarshalScanResultsFromANetworkResponse> ListAirMarshalScanResultsFromANetwork(ListAirMarshalScanResultsFromANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/airMarshal", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListAirMarshalScanResultsFromANetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return AP channel utilization over time for a device or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<HannelUtilizationOverTimeForADeviceOrNetworkClientResponse> HannelUtilizationOverTimeForADeviceOrNetworkClient(HannelUtilizationOverTimeForADeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/channelUtilizationHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<HannelUtilizationOverTimeForADeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return wireless client counts over time for a network, device, or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<IentCountsOverTimeForANetworkDeviceOrNetworkClientResponse> IentCountsOverTimeForANetworkDeviceOrNetworkClient(IentCountsOverTimeForANetworkDeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clientCountHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<IentCountsOverTimeForANetworkDeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated connectivity info for this network, grouped by clients 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<AtedConnectivityInfoForThisNetworkGroupedByClientsResponse> AtedConnectivityInfoForThisNetworkGroupedByClients(AtedConnectivityInfoForThisNetworkGroupedByClientsParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/connectionStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AtedConnectivityInfoForThisNetworkGroupedByClientsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated connectivity info for a given client on this network. Clients are identified by their 
        /// MAC. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<AtedConnectivityInfoForThisNetworkGroupedByClientsResponse> EgatedConnectivityInfoForAGivenClientOnThisNetwork(EgatedConnectivityInfoForAGivenClientOnThisNetworkParameters queryParameters, string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/{clientId}/connectionStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AtedConnectivityInfoForThisNetworkGroupedByClientsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated latency info for this network, grouped by clients 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<GgregatedLatencyInfoForThisNetworkGroupedByClientsResponse> GgregatedLatencyInfoForThisNetworkGroupedByClients(GgregatedLatencyInfoForThisNetworkGroupedByClientsParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/latencyStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<GgregatedLatencyInfoForThisNetworkGroupedByClientsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated latency info for a given client on this network. Clients are identified by their MAC. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<GgregatedLatencyInfoForThisNetworkGroupedByClientsResponse> AggregatedLatencyInfoForAGivenClientOnThisNetwork(AggregatedLatencyInfoForAGivenClientOnThisNetworkParameters queryParameters, string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/{clientId}/latencyStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<GgregatedLatencyInfoForThisNetworkGroupedByClientsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the wireless connectivity events for a client within a network in the timespan. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<CtivityEventsForAClientWithinANetworkInTheTimespanResponse> CtivityEventsForAClientWithinANetworkInTheTimespan(CtivityEventsForAClientWithinANetworkInTheTimespanParameters queryParameters, string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/{clientId}/connectivityEvents", parametersDict);
            return await _httpClient.GetFromJsonAsync<CtivityEventsForAClientWithinANetworkInTheTimespanResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the latency history for a client. Clients can be identified by a client key or either the MAC 
        /// or IP depending on whether the network uses Track-by-IP. The latency data is from a sample of 2% of 
        /// packets and is grouped into 4 traffic categories: background, best effort, video, voice. Within 
        /// these categories the sampled packet counters are bucketed by latency in milliseconds. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<ReturnTheLatencyHistoryForAClientResponse> ReturnTheLatencyHistoryForAClient(ReturnTheLatencyHistoryForAClientParameters queryParameters, string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/clients/{clientId}/latencyHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnTheLatencyHistoryForAClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return PHY data rates over time for a network, device, or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<YDataRatesOverTimeForANetworkDeviceOrNetworkClientResponse> YDataRatesOverTimeForANetworkDeviceOrNetworkClient(YDataRatesOverTimeForANetworkDeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/dataRateHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<YDataRatesOverTimeForANetworkDeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated connectivity info for this network, grouped by node 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<AggregatedConnectivityInfoForAGivenAPOnThisNetworkResponse> RegatedConnectivityInfoForThisNetworkGroupedByNode(RegatedConnectivityInfoForThisNetworkGroupedByNodeParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/devices/connectionStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AggregatedConnectivityInfoForAGivenAPOnThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Aggregated latency info for this network, grouped by node 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<AggregatedLatencyInfoForAGivenAPOnThisNetworkResponse> AggregatedLatencyInfoForThisNetworkGroupedByNode(AggregatedLatencyInfoForThisNetworkGroupedByNodeParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/devices/latencyStats", parametersDict);
            return await _httpClient.GetFromJsonAsync<AggregatedLatencyInfoForAGivenAPOnThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get average channel utilization for all bands in a network, split by AP 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<GeChannelUtilizationForAllBandsInANetworkSplitByAPResponse> GeChannelUtilizationForAllBandsInANetworkSplitByAP(GeChannelUtilizationForAllBandsInANetworkSplitByAPParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/wireless/devices/channelUtilization/byDevice", parametersDict);
            return await _httpClient.GetFromJsonAsync<GeChannelUtilizationForAllBandsInANetworkSplitByAPResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get average channel utilization across all bands for all networks in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<GeChannelUtilizationForAllBandsInANetworkSplitByAPResponse> AtionAcrossAllBandsForAllNetworksInTheOrganization(AtionAcrossAllBandsForAllNetworksInTheOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/wireless/devices/channelUtilization/byNetwork", parametersDict);
            return await _httpClient.GetFromJsonAsync<GeChannelUtilizationForAllBandsInANetworkSplitByAPResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get a time-series of average channel utilization for all bands, segmented by device. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<RageChannelUtilizationForAllBandsSegmentedByDeviceResponse> RageChannelUtilizationForAllBandsSegmentedByDevice(RageChannelUtilizationForAllBandsSegmentedByDeviceParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/wireless/devices/channelUtilization/history/byDevice/byInterval", parametersDict);
            return await _httpClient.GetFromJsonAsync<RageChannelUtilizationForAllBandsSegmentedByDeviceResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get a time-series of average channel utilization for all bands 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<RageChannelUtilizationForAllBandsSegmentedByDeviceResponse> TATimeSeriesOfAverageChannelUtilizationForAllBands(TATimeSeriesOfAverageChannelUtilizationForAllBandsParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/wireless/devices/channelUtilization/history/byNetwork/byInterval", parametersDict);
            return await _httpClient.GetFromJsonAsync<RageChannelUtilizationForAllBandsSegmentedByDeviceResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Endpoint to see power status for wireless devices 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EndpointToSeePowerStatusForWirelessDevicesResponse> EndpointToSeePowerStatusForWirelessDevices(EndpointToSeePowerStatusForWirelessDevicesParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/wireless/devices/ethernet/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<EndpointToSeePowerStatusForWirelessDevicesResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List of all failed client connection events on this network in a given time range 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<IentConnectionEventsOnThisNetworkInAGivenTimeRangeResponse> IentConnectionEventsOnThisNetworkInAGivenTimeRange(IentConnectionEventsOnThisNetworkInAGivenTimeRangeParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/failedConnections", parametersDict);
            return await _httpClient.GetFromJsonAsync<IentConnectionEventsOnThisNetworkInAGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return average wireless latency over time for a network, device, or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<EssLatencyOverTimeForANetworkDeviceOrNetworkClientResponse> EssLatencyOverTimeForANetworkDeviceOrNetworkClient(EssLatencyOverTimeForANetworkDeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/latencyHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<EssLatencyOverTimeForANetworkDeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List wireless mesh statuses for repeaters 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListWirelessMeshStatusesForRepeatersResponse> ListWirelessMeshStatusesForRepeaters(ListWirelessMeshStatusesForRepeatersParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/meshStatuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListWirelessMeshStatusesForRepeatersResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return signal quality (SNR/RSSI) over time for a device or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<NalQualitySNRRSSIOverTimeForADeviceOrNetworkClientResponse> NalQualitySNRRSSIOverTimeForADeviceOrNetworkClient(NalQualitySNRRSSIOverTimeForADeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/signalQualityHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<NalQualitySNRRSSIOverTimeForADeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return AP usage over time for a device or network client 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnAPUsageOverTimeForADeviceOrNetworkClientResponse> ReturnAPUsageOverTimeForADeviceOrNetworkClient(ReturnAPUsageOverTimeForADeviceOrNetworkClientParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/wireless/usageHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnAPUsageOverTimeForADeviceOrNetworkClientResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Creates new RF profile for this network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique. This param is required on 
        /// creation.
        /// clientBalancingEnabled| boolean| Steers client to best available access point. Can be 
        /// either true or false. Defaults to true.
        /// minBitrateType| string| Minimum bitrate can be set to either 
        /// 'band' or 'ssid'. Defaults to band.
        /// bandSelectionType| string| Band selection can be set to either 
        /// 'ssid' or 'ap'. This param is required on creation.
        /// apBandSettings| object| Settings that will be 
        /// enabled if selectionType is set to 'ap'.
        /// twoFourGhzSettings| object| Settings related to 2.4Ghz 
        /// band
        /// fiveGhzSettings| object| Settings related to 5Ghz band
        /// sixGhzSettings| object| Settings related 
        /// to 6Ghz band. Only applicable to networks with 6Ghz capable APs
        /// transmission| object| Settings 
        /// related to radio transmission.
        /// perSsidSettings| object| Per-SSID radio settings by 
        /// number.
        /// flexRadios| object| Flex radio settings.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<Assigned> CreatesNewRFProfileForThisNetwork(Assigned request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<Assigned>($"networks/{networkId}/appliance/rfProfiles", request, headers);
        }
    
        /// <summary>
        /// Updates specified RF profile for this network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique.
        /// clientBalancingEnabled| boolean| Steers client 
        /// to best available access point. Can be either true or false.
        /// minBitrateType| string| Minimum bitrate 
        /// can be set to either 'band' or 'ssid'.
        /// bandSelectionType| string| Band selection can be set to 
        /// either 'ssid' or 'ap'.
        /// apBandSettings| object| Settings that will be enabled if selectionType is set 
        /// to 'ap'.
        /// twoFourGhzSettings| object| Settings related to 2.4Ghz band
        /// fiveGhzSettings| object| 
        /// Settings related to 5Ghz band
        /// sixGhzSettings| object| Settings related to 6Ghz band. Only applicable 
        /// to networks with 6Ghz capable APs
        /// transmission| object| Settings related to radio 
        /// transmission.
        /// perSsidSettings| object| Per-SSID radio settings by number.
        /// flexRadios| object| Flex 
        /// radio settings.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles/{rfProfileId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<Assigned> UpdatesSpecifiedRFProfileForThisNetwork(Assigned request, string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<Assigned>($"networks/{networkId}/appliance/rfProfiles/{rfProfileId}", request, headers);
        }
    
        /// <summary>
        /// Delete a RF Profile
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles/{rfProfileId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<EmptyResponse> DeleteARFProfile(string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/appliance/rfProfiles/{rfProfileId}", headers);
        }
    
        /// <summary>
        /// Return a RF profile 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<Assigned> ReturnARFProfile(string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<Assigned>($"networks/{networkId}/appliance/rfProfiles/{rfProfileId}", headers);
        }
    
        /// <summary>
        /// Creates new RF profile for this network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique. This param is required on 
        /// creation.
        /// clientBalancingEnabled| boolean| Steers client to best available access point. Can be 
        /// either true or false. Defaults to true.
        /// minBitrateType| string| Minimum bitrate can be set to either 
        /// 'band' or 'ssid'. Defaults to band.
        /// bandSelectionType| string| Band selection can be set to either 
        /// 'ssid' or 'ap'. This param is required on creation.
        /// apBandSettings| object| Settings that will be 
        /// enabled if selectionType is set to 'ap'.
        /// twoFourGhzSettings| object| Settings related to 2.4Ghz 
        /// band
        /// fiveGhzSettings| object| Settings related to 5Ghz band
        /// sixGhzSettings| object| Settings related 
        /// to 6Ghz band. Only applicable to networks with 6Ghz capable APs
        /// transmission| object| Settings 
        /// related to radio transmission.
        /// perSsidSettings| object| Per-SSID radio settings by 
        /// number.
        /// flexRadios| object| Flex radio settings.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles` | create
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListRFProfilesForThisNetworkResponse> CreatesNewRFProfileForThisNetwork2(CreatesNewRFProfileForThisNetwork2Request request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListRFProfilesForThisNetworkResponse>($"networks/{networkId}/wireless/rfProfiles", request, headers);
        }
    
        /// <summary>
        /// Updates specified RF profile for this network
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new profile. Must be unique.
        /// clientBalancingEnabled| boolean| Steers client 
        /// to best available access point. Can be either true or false.
        /// minBitrateType| string| Minimum bitrate 
        /// can be set to either 'band' or 'ssid'.
        /// bandSelectionType| string| Band selection can be set to 
        /// either 'ssid' or 'ap'.
        /// apBandSettings| object| Settings that will be enabled if selectionType is set 
        /// to 'ap'.
        /// twoFourGhzSettings| object| Settings related to 2.4Ghz band
        /// fiveGhzSettings| object| 
        /// Settings related to 5Ghz band
        /// sixGhzSettings| object| Settings related to 6Ghz band. Only applicable 
        /// to networks with 6Ghz capable APs
        /// transmission| object| Settings related to radio 
        /// transmission.
        /// perSsidSettings| object| Per-SSID radio settings by number.
        /// flexRadios| object| Flex 
        /// radio settings.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles/{rfProfileId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<ListRFProfilesForThisNetworkResponse> UpdatesSpecifiedRFProfileForThisNetwork2(CreatesNewRFProfileForThisNetwork2Request request, string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListRFProfilesForThisNetworkResponse>($"networks/{networkId}/wireless/rfProfiles/{rfProfileId}", request, headers);
        }
    
        /// <summary>
        /// Delete a RF Profile
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/wireless/rfProfiles/{rfProfileId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<EmptyResponse> DeleteARFProfile2(string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/wireless/rfProfiles/{rfProfileId}", headers);
        }
    
        /// <summary>
        /// Return a RF profile 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="rfProfileId">(Required) Rf profile ID</param>
        public async Task<ListRFProfilesForThisNetworkResponse> ReturnARFProfile2(string networkId, string rfProfileId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListRFProfilesForThisNetworkResponse>($"networks/{networkId}/wireless/rfProfiles/{rfProfileId}", headers);
        }
    
        /// <summary>
        /// Get application health by time 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="applicationId">(Required) Application ID</param>
        public async Task<GetApplicationHealthByTimeResponse> GetApplicationHealthByTime(GetApplicationHealthByTimeParameters queryParameters, string networkId, string applicationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/insight/applications/{applicationId}/healthByTime", parametersDict);
            return await _httpClient.GetFromJsonAsync<GetApplicationHealthByTimeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List all Insight tracked applications 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListAllInsightTrackedApplicationsResponse> ListAllInsightTrackedApplications(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListAllInsightTrackedApplicationsResponse>($"organizations/{organizationId}/insight/applications", headers);
        }
    
        /// <summary>
        /// List the monitored media servers for this organization. Only valid for organizations with Meraki 
        /// Insight. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheMonitoredMediaServersForThisOrganizationResponse> ListTheMonitoredMediaServersForThisOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMonitoredMediaServersForThisOrganizationResponse>($"organizations/{organizationId}/insight/monitoredMediaServers", headers);
        }
    
        /// <summary>
        /// Add a media server to be monitored for this organization. Only valid for organizations with Meraki 
        /// Insight. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheMonitoredMediaServersForThisOrganizationResponse> AddAMediaServerToBeMonitoredForThisOrganization(AddAMediaServerToBeMonitoredForThisOrganizationRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheMonitoredMediaServersForThisOrganizationResponse>($"organizations/{organizationId}/insight/monitoredMediaServers", request, headers);
        }
    
        /// <summary>
        /// Return a monitored media server for this organization. Only valid for organizations with Meraki 
        /// Insight. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        /// <param name="monitoredMediaServerId">(Required) Monitored media server ID</param>
        public async Task<ListTheMonitoredMediaServersForThisOrganizationResponse> ReturnAMonitoredMediaServerForThisOrganization(string organizationId, string monitoredMediaServerId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheMonitoredMediaServersForThisOrganizationResponse>($"organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}", headers);
        }
    
        /// <summary>
        /// Update a monitored media server for this organization. Only valid for organizations with Meraki 
        /// Insight. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        /// <param name="monitoredMediaServerId">(Required) Monitored media server ID</param>
        public async Task<ListTheMonitoredMediaServersForThisOrganizationResponse> UpdateAMonitoredMediaServerForThisOrganization(AddAMediaServerToBeMonitoredForThisOrganizationRequest request, string organizationId, string monitoredMediaServerId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheMonitoredMediaServersForThisOrganizationResponse>($"organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}", request, headers);
        }
    
        /// <summary>
        /// Delete a monitored media server from this organization. Only valid for organizations with Meraki 
        /// Insight. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        /// <param name="monitoredMediaServerId">(Required) Monitored media server ID</param>
        public async Task<EmptyResponse> DeleteAMonitoredMediaServerFromThisOrganization(string organizationId, string monitoredMediaServerId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}", headers);
        }
    
        /// <summary>
        /// Bypass activation lock attempt
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// ids| array| The ids of the devices to attempt 
        /// activation lock bypass.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<BypassActivationLockAttemptResponse> BypassActivationLockAttempt(BypassActivationLockAttemptRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<BypassActivationLockAttemptResponse>($"networks/{networkId}/sm/bypassActivationLockAttempts", request, headers);
        }
    
        /// <summary>
        /// Bypass activation lock attempt status 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="attemptId">(Required) Attempt ID</param>
        public async Task<BypassActivationLockAttemptResponse> BypassActivationLockAttemptStatus(string networkId, string attemptId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<BypassActivationLockAttemptResponse>($"networks/{networkId}/sm/bypassActivationLockAttempts/{attemptId}", headers);
        }
    
        /// <summary>
        /// List the devices enrolled in an SM network with various specified fields and filters 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<DInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse> DInAnSMNetworkWithVariousSpecifiedFieldsAndFilters(DInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/devices", parametersDict);
            return await _httpClient.GetFromJsonAsync<DInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Force check-in a set of devices
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// wifiMacs| array| The wifiMacs of the devices to 
        /// be checked-in.
        /// ids| array| The ids of the devices to be checked-in.
        /// serials| array| The serials of 
        /// the devices to be checked-in.
        /// scope| array| The scope (one of all, none, withAny, withAll, 
        /// withoutAny, or withoutAll) and a set of tags of the devices to be checked-in.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<BypassActivationLockAttemptRequest> ForceCheckInASetOfDevices(ForceCheckInASetOfDevicesRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<BypassActivationLockAttemptRequest>($"networks/{networkId}/sm/devices/checkin", request, headers);
        }
    
        /// <summary>
        /// Lock a set of devices
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// wifiMacs| array| The wifiMacs of the devices to 
        /// be locked.
        /// ids| array| The ids of the devices to be locked.
        /// serials| array| The serials of the 
        /// devices to be locked.
        /// scope| array| The scope (one of all, none, withAny, withAll, withoutAny, or 
        /// withoutAll) and a set of tags of the devices to be wiped.
        /// pin| integer| The pin number for locking 
        /// macOS devices (a six digit number). Required only for macOS devices.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<BypassActivationLockAttemptRequest> LockASetOfDevices(LockASetOfDevicesRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<BypassActivationLockAttemptRequest>($"networks/{networkId}/sm/devices/lock", request, headers);
        }
    
        /// <summary>
        /// Add, delete, or update the tags of a set of devices
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// wifiMacs| array| The wifiMacs of the devices to be modified.
        /// ids| array| The ids of the devices to 
        /// be modified.
        /// serials| array| The serials of the devices to be modified.
        /// scope| array| The scope (one 
        /// of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be 
        /// modified.
        /// tags| array| The tags to be added, deleted, or updated.
        /// updateAction| string| One of add, 
        /// delete, or update. Only devices that have been modified will be returned.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<DInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse> AddDeleteOrUpdateTheTagsOfASetOfDevices(AddDeleteOrUpdateTheTagsOfASetOfDevicesRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<DInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse>($"networks/{networkId}/sm/devices/modifyTags", request, headers);
        }
    
        /// <summary>
        /// Move a set of devices to a new network
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        /// 
        ///  :-------------: |:-------------: |:-------------: 
        /// wifiMacs| array| The wifiMacs of the devices to 
        /// be moved.
        /// ids| array| The ids of the devices to be moved.
        /// serials| array| The serials of the devices 
        /// to be moved.
        /// scope| array| The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) 
        /// and a set of tags of the devices to be moved.
        /// newNetwork| string| The new network to which the 
        /// devices will be moved.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<MoveASetOfDevicesToANewNetworkRequest> MoveASetOfDevicesToANewNetwork(MoveASetOfDevicesToANewNetworkRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<MoveASetOfDevicesToANewNetworkRequest>($"networks/{networkId}/sm/devices/move", request, headers);
        }
    
        /// <summary>
        /// Wipe a device
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// wifiMac| string| The wifiMac of the device to be wiped.
        /// id| 
        /// string| The id of the device to be wiped.
        /// serial| string| The serial of the device to be wiped.
        /// pin| 
        /// integer| The pin number (a six digit value) for wiping a macOS device. Required only for macOS 
        /// devices.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheOrganizationsResponse> WipeADevice(WipeADeviceRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheOrganizationsResponse>($"networks/{networkId}/sm/devices/wipe", request, headers);
        }
    
        /// <summary>
        /// Refresh the details of a device 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<EmptyResponse> RefreshTheDetailsOfADevice(string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<EmptyResponse>($"networks/{networkId}/sm/devices/{deviceId}/refreshDetails", headers);
        }
    
        /// <summary>
        /// Unenroll a device 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<NotifyThatCredentialHandoffToCameraHasCompletedResponse> UnenrollADevice(string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<NotifyThatCredentialHandoffToCameraHasCompletedResponse>($"networks/{networkId}/sm/devices/{deviceId}/unenroll", headers);
        }
    
        /// <summary>
        /// List all profiles in a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListAllProfilesInANetworkResponse> ListAllProfilesInANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListAllProfilesInANetworkResponse>($"networks/{networkId}/sm/profiles", headers);
        }
    
        /// <summary>
        /// List the target groups in this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheTargetGroupsInThisNetworkResponse> ListTheTargetGroupsInThisNetwork(ListTheTargetGroupsInThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/targetGroups", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheTargetGroupsInThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Add a target group
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// name| string| The name of this target group
        /// scope| string| The 
        /// scope and tag options of the target group. Comma separated values beginning with one of withAny, 
        /// withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheTargetGroupsInThisNetworkResponse> AddATargetGroup(ListAllProfilesInANetworkResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListTheTargetGroupsInThisNetworkResponse>($"networks/{networkId}/sm/targetGroups", request, headers);
        }
    
        /// <summary>
        /// Return a target group 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="targetGroupId">(Required) Target group ID</param>
        public async Task<ListTheTargetGroupsInThisNetworkResponse> ReturnATargetGroup(ReturnATargetGroupParameters queryParameters, string networkId, string targetGroupId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/targetGroups/{targetGroupId}", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheTargetGroupsInThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Update a target group
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of this target 
        /// group
        /// scope| string| The scope and tag options of the target group. Comma separated values beginning 
        /// with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none 
        /// if empty.
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="targetGroupId">(Required) Target group ID</param>
        public async Task<ListTheTargetGroupsInThisNetworkResponse> UpdateATargetGroup(ListAllProfilesInANetworkResponse request, string networkId, string targetGroupId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ListTheTargetGroupsInThisNetworkResponse>($"networks/{networkId}/sm/targetGroups/{targetGroupId}", request, headers);
        }
    
        /// <summary>
        /// Delete a target group from a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="targetGroupId">(Required) Target group ID</param>
        public async Task<EmptyResponse> DeleteATargetGroupFromANetwork(string networkId, string targetGroupId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/sm/targetGroups/{targetGroupId}", headers);
        }
    
        /// <summary>
        /// List Trusted Access Configs 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTrustedAccessConfigsResponse> ListTrustedAccessConfigs(ListTrustedAccessConfigsParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/trustedAccessConfigs", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTrustedAccessConfigsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List User Access Devices and its Trusted Access Connections 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<IstUserAccessDevicesAndItsTrustedAccessConnectionsResponse> IstUserAccessDevicesAndItsTrustedAccessConnections(IstUserAccessDevicesAndItsTrustedAccessConnectionsParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/userAccessDevices", parametersDict);
            return await _httpClient.GetFromJsonAsync<IstUserAccessDevicesAndItsTrustedAccessConnectionsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Delete a User Access Device
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}/sm/userAccessDevices/{userAccessDeviceId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="userAccessDeviceId">(Required) User access device ID</param>
        public async Task<EmptyResponse> DeleteAUserAccessDevice(string networkId, string userAccessDeviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}/sm/userAccessDevices/{userAccessDeviceId}", headers);
        }
    
        /// <summary>
        /// List the owners in an SM network with various specified fields and filters 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<SInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse> SInAnSMNetworkWithVariousSpecifiedFieldsAndFilters(SInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/users", parametersDict);
            return await _httpClient.GetFromJsonAsync<SInAnSMNetworkWithVariousSpecifiedFieldsAndFiltersResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get the organization's APNS certificate 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<GetTheOrganizationsAPNSCertificateResponse> GetTheOrganizationsAPNSCertificate(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<GetTheOrganizationsAPNSCertificateResponse>($"organizations/{organizationId}/sm/apnsCert", headers);
        }
    
        /// <summary>
        /// List the VPP accounts in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheVPPAccountsInTheOrganizationResponse> ListTheVPPAccountsInTheOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheVPPAccountsInTheOrganizationResponse>($"organizations/{organizationId}/sm/vppAccounts", headers);
        }
    
        /// <summary>
        /// Get a hash containing the unparsed token of the VPP account with the given ID 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        /// <param name="vppAccountId">(Required) Vpp account ID</param>
        public async Task<ListTheVPPAccountsInTheOrganizationResponse> IningTheUnparsedTokenOfTheVPPAccountWithTheGivenID(string organizationId, string vppAccountId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListTheVPPAccountsInTheOrganizationResponse>($"organizations/{organizationId}/sm/vppAccounts/{vppAccountId}", headers);
        }
    
        /// <summary>
        /// Return the client's daily cellular data usage history. Usage data is in kilobytes. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<ReturnTheClientsDailyCellularDataUsageHistoryResponse> ReturnTheClientsDailyCellularDataUsageHistory(string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheClientsDailyCellularDataUsageHistoryResponse>($"networks/{networkId}/sm/devices/{deviceId}/cellularUsageHistory", headers);
        }
    
        /// <summary>
        /// Returns historical connectivity data (whether a device is regularly checking in to Dashboard). 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<DataWhetherADeviceIsRegularlyCheckingInToDashboardResponse> DataWhetherADeviceIsRegularlyCheckingInToDashboard(DataWhetherADeviceIsRegularlyCheckingInToDashboardParameters queryParameters, string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/devices/{deviceId}/connectivity", parametersDict);
            return await _httpClient.GetFromJsonAsync<DataWhetherADeviceIsRegularlyCheckingInToDashboardResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return historical records of various Systems Manager network connection details for desktop devices. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<MsManagerNetworkConnectionDetailsForDesktopDevicesResponse> MsManagerNetworkConnectionDetailsForDesktopDevices(MsManagerNetworkConnectionDetailsForDesktopDevicesParameters queryParameters, string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/devices/{deviceId}/desktopLogs", parametersDict);
            return await _httpClient.GetFromJsonAsync<MsManagerNetworkConnectionDetailsForDesktopDevicesResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return historical records of commands sent to Systems Manager devices. Note that this will include 
        /// the name of the Dashboard user who initiated the command if it was generated by a Dashboard admin 
        /// rather than the automatic behavior of the system; you may wish to filter this out of any reports. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<OricalRecordsOfCommandsSentToSystemsManagerDevicesResponse> OricalRecordsOfCommandsSentToSystemsManagerDevices(OricalRecordsOfCommandsSentToSystemsManagerDevicesParameters queryParameters, string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/devices/{deviceId}/deviceCommandLogs", parametersDict);
            return await _httpClient.GetFromJsonAsync<OricalRecordsOfCommandsSentToSystemsManagerDevicesResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return historical records of various Systems Manager client metrics for desktop devices. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="deviceId">(Required) Device ID</param>
        public async Task<AriousSystemsManagerClientMetricsForDesktopDevicesResponse> AriousSystemsManagerClientMetricsForDesktopDevices(AriousSystemsManagerClientMetricsForDesktopDevicesParameters queryParameters, string networkId, string deviceId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/sm/devices/{deviceId}/performanceHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<AriousSystemsManagerClientMetricsForDesktopDevicesResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the licenses in a coterm organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheLicensesInACotermOrganizationResponse> ListTheLicensesInACotermOrganization(ListTheLicensesInACotermOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/licensing/coterm/licenses", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheLicensesInACotermOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Moves a license to a different organization (coterm only)
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// 
        /// destination| object| Destination data for the license move
        /// licenses| array| The list of licenses to 
        /// move
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<MovesALicenseToADifferentOrganizationCotermOnlyResponse> MovesALicenseToADifferentOrganizationCotermOnly(MovesALicenseToADifferentOrganizationCotermOnlyRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<MovesALicenseToADifferentOrganizationCotermOnlyResponse>($"organizations/{organizationId}/licensing/coterm/licenses/move", request, headers);
        }
    
        /// <summary>
        /// Return a single device 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnASingleDeviceResponse> ReturnASingleDevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnASingleDeviceResponse>($"devices/{serial}", headers);
        }
    
        /// <summary>
        /// Update the attributes of a device
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of a device
        /// tags| array| 
        /// The list of tags of a device
        /// lat| number| The latitude of a device
        /// lng| number| The longitude of a 
        /// device
        /// address| string| The address of a device
        /// notes| string| The notes for the device. String. 
        /// Limited to 255 characters.
        /// moveMapMarker| boolean| Whether or not to set the latitude and longitude 
        /// of a device based on the new address. Only applies when lat and lng are not 
        /// specified.
        /// switchProfileId| string| The ID of a switch template to bind to the device (for available 
        /// switch templates, see the 'Switch Templates' endpoint). Use null to unbind the switch device from 
        /// the current profile. For a device to be bindable to a switch template, it must (1) be a switch, and 
        /// (2) belong to a network that is bound to a configuration template.
        /// floorPlanId| string| The floor 
        /// plan to associate to this device. null disassociates the device from the floorplan.
        /// 
        /// #### Supports 
        /// Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: |:-------------:
        /// `/devices/{serial}` | 
        /// update
        /// 
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ReturnASingleDeviceResponse> UpdateTheAttributesOfADevice(UpdateTheAttributesOfADeviceRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnASingleDeviceResponse>($"devices/{serial}", request, headers);
        }
    
        /// <summary>
        /// Blink the LEDs on a device
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// duration| integer| The duration in seconds. Must 
        /// be between 5 and 120. Default is 20 seconds
        /// period| integer| The period in milliseconds. Must be 
        /// between 100 and 1000. Default is 160 milliseconds
        /// duty| integer| The duty cycle as the percent 
        /// active. Must be between 10 and 90. Default is 50.
        ///  
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<BlinkTheLEDsOnADeviceResponse> BlinkTheLEDsOnADevice(BlinkTheLEDsOnADeviceRequest request, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<BlinkTheLEDsOnADeviceResponse>($"devices/{serial}/blinkLeds", request, headers);
        }
    
        /// <summary>
        /// Reboot a device 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<NotifyThatCredentialHandoffToCameraHasCompletedResponse> RebootADevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<NotifyThatCredentialHandoffToCameraHasCompletedResponse>($"devices/{serial}/reboot", headers);
        }
    
        /// <summary>
        /// List the clients of a device, up to a maximum of a month ago. The usage of each client is returned 
        /// in kilobytes. If the device is a switch, the switchport is returned; otherwise the switchport field 
        /// is null. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListTheClientsOfADeviceUpToAMaximumOfAMonthAgoResponse> ListTheClientsOfADeviceUpToAMaximumOfAMonthAgo(ListTheClientsOfADeviceUpToAMaximumOfAMonthAgoParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/clients", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheClientsOfADeviceUpToAMaximumOfAMonthAgoResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List LLDP and CDP information for a device 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<ListLLDPAndCDPInformationForADeviceResponse> ListLLDPAndCDPInformationForADevice(string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ListLLDPAndCDPInformationForADeviceResponse>($"devices/{serial}/lldpCdp", headers);
        }
    
        /// <summary>
        /// Get the uplink loss percentage and latency in milliseconds, and goodput in kilobits per second for a 
        /// wired network device. 
        /// </summary>
        /// <param name="serial">(Required) Serial</param>
        public async Task<NdGoodputInKilobitsPerSecondForAWiredNetworkDeviceResponse> NdGoodputInKilobitsPerSecondForAWiredNetworkDevice(NdGoodputInKilobitsPerSecondForAWiredNetworkDeviceParameters queryParameters, string serial)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"devices/{serial}/lossAndLatencyHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<NdGoodputInKilobitsPerSecondForAWiredNetworkDeviceResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Bind a network to a template.
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// configTemplateId| string| The ID of the template 
        /// to which the network should be bound.
        /// autoBind| boolean| Optional boolean indicating whether the 
        /// network's switches should automatically bind to profiles of the same model. Defaults to false if 
        /// left unspecified. This option only affects switch networks and switch templates. Auto-bind is not 
        /// valid unless the switch template has at least one profile and has at most one profile per switch 
        /// model.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}` | bind
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<BindANetworkToATemplateResponse> BindANetworkToATemplate(BindANetworkToATemplateRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<BindANetworkToATemplateResponse>($"networks/{networkId}/bind", request, headers);
        }
    
        /// <summary>
        /// Delete a network
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}` | destroy
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<EmptyResponse> DeleteANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"networks/{networkId}", headers);
        }
    
        /// <summary>
        /// Return a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnANetworkResponse> ReturnANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnANetworkResponse>($"networks/{networkId}", headers);
        }
    
        /// <summary>
        /// Split a combined network into individual networks for each type of device 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<EdNetworkIntoIndividualNetworksForEachTypeOfDeviceResponse> EdNetworkIntoIndividualNetworksForEachTypeOfDevice(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostFromJsonAsync<EdNetworkIntoIndividualNetworksForEachTypeOfDeviceResponse>($"networks/{networkId}/split", headers);
        }
    
        /// <summary>
        /// Unbind a network from a template.
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// retainConfigs| boolean| Optional boolean to 
        /// retain all the current configs given by the template.
        /// 
        /// #### Supports Action 
        /// Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: |:-------------:
        /// `/networks/{networkId}` | 
        /// unbind
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnANetworkResponse> UnbindANetworkFromATemplate(UnbindANetworkFromATemplateRequest request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ReturnANetworkResponse>($"networks/{networkId}/unbind", request, headers);
        }
    
        /// <summary>
        /// Update a network
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: 
        /// |:-------------: |:-------------: 
        /// name| string| The name of the network
        /// timeZone| string| The 
        /// timezone of the network. For a list of allowed timezones, please see the 'TZ' column in the table in 
        /// this article.
        /// tags| array| A list of tags to be applied to the network
        /// enrollmentString| string| A 
        /// unique identifier which can be used for device enrollment or easy access through the Meraki SM 
        /// Registration page or the Self Service Portal. Please note that changing this field may cause 
        /// existing bookmarks to break.
        /// notes| string| Add any notes or additional information about this 
        /// network here.
        /// 
        /// #### Supports Action Batches
        /// 
        /// **Resource**|**Operation**
        /// :-------------: 
        /// |:-------------:
        /// `/networks/{networkId}` | update
        /// 
        ///  
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnANetworkResponse> UpdateANetwork(BindANetworkToATemplateResponse request, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<ReturnANetworkResponse>($"networks/{networkId}", request, headers);
        }
    
        /// <summary>
        /// Return the alert history for this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheAlertHistoryForThisNetworkResponse> ReturnTheAlertHistoryForThisNetwork(ReturnTheAlertHistoryForThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/alerts/history", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnTheAlertHistoryForThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the Bluetooth clients seen by APs in this network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheBluetoothClientsSeenByAPsInThisNetworkResponse> ListTheBluetoothClientsSeenByAPsInThisNetwork(ListTheBluetoothClientsSeenByAPsInThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/bluetoothClients", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheBluetoothClientsSeenByAPsInThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return a Bluetooth client. Bluetooth clients can be identified by their ID or their MAC. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="bluetoothClientId">(Required) Bluetooth client ID</param>
        public async Task<ListTheBluetoothClientsSeenByAPsInThisNetworkResponse> ReturnABluetoothClient(ReturnABluetoothClientParameters queryParameters, string networkId, string bluetoothClientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/bluetoothClients/{bluetoothClientId}", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheBluetoothClientsSeenByAPsInThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the clients that have used this network in the timespan 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheClientsThatHaveUsedThisNetworkInTheTimespanResponse> ListTheClientsThatHaveUsedThisNetworkInTheTimespan(ListTheClientsThatHaveUsedThisNetworkInTheTimespanParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/clients", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheClientsThatHaveUsedThisNetworkInTheTimespanResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the client associated with the given identifier. Clients can be identified by a client key or 
        /// either the MAC or IP depending on whether the network uses Track-by-IP. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        /// <param name="clientId">(Required) Client ID</param>
        public async Task<ReturnTheClientAssociatedWithTheGivenIdentifierResponse> ReturnTheClientAssociatedWithTheGivenIdentifier(string networkId, string clientId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnTheClientAssociatedWithTheGivenIdentifierResponse>($"networks/{networkId}/clients/{clientId}", headers);
        }
    
        /// <summary>
        /// List the events for the network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheEventsForTheNetworkResponse> ListTheEventsForTheNetwork(ListTheEventsForTheNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/events", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheEventsForTheNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Get the channel utilization over each radio for all APs in a network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ChannelUtilizationOverEachRadioForAllAPsInANetworkResponse> ChannelUtilizationOverEachRadioForAllAPsInANetwork(ChannelUtilizationOverEachRadioForAllAPsInANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/networkHealth/channelUtilization", parametersDict);
            return await _httpClient.GetFromJsonAsync<ChannelUtilizationOverEachRadioForAllAPsInANetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the splash login attempts for a network 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ListTheSplashLoginAttemptsForANetworkResponse> ListTheSplashLoginAttemptsForANetwork(ListTheSplashLoginAttemptsForANetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/splashLoginAttempts", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheSplashLoginAttemptsForANetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the LLDP and CDP information for all discovered devices and connections in a network. At least 
        /// one MX or MS device must be in the network in order to build the topology. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<IonForAllDiscoveredDevicesAndConnectionsInANetworkResponse> IonForAllDiscoveredDevicesAndConnectionsInANetwork(string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<IonForAllDiscoveredDevicesAndConnectionsInANetworkResponse>($"networks/{networkId}/topology/linkLayer", headers);
        }
    
        /// <summary>
        /// Return the traffic analysis data for this network. Traffic analysis with hostname visibility must be 
        /// enabled on the network. 
        /// </summary>
        /// <param name="networkId">(Required) Network ID</param>
        public async Task<ReturnTheTrafficAnalysisDataForThisNetworkResponse> ReturnTheTrafficAnalysisDataForThisNetwork(ReturnTheTrafficAnalysisDataForThisNetworkParameters queryParameters, string networkId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"networks/{networkId}/traffic", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnTheTrafficAnalysisDataForThisNetworkResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Claim a list of devices, licenses, and/or orders into an organization. When claiming by order, all 
        /// devices and licenses in the order will be claimed; licenses will be added to the organization and 
        /// devices will be placed in the organization's inventory. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListOfDevicesLicensesAndOrOrdersIntoAnOrganizationRequest> ListOfDevicesLicensesAndOrOrdersIntoAnOrganization(ListOfDevicesLicensesAndOrOrdersIntoAnOrganizationRequest request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<ListOfDevicesLicensesAndOrOrdersIntoAnOrganizationRequest>($"organizations/{organizationId}/claim", request, headers);
        }
    
        /// <summary>
        /// Create a new organization
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of the 
        /// organization
        /// management| object| Information about the organization's management system
        ///  
        /// </summary>
        public async Task<CreateANewOrganizationResponse> CreateANewOrganization(CreateANewOrganizationRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<CreateANewOrganizationResponse>($"organizations", request, headers);
        }
    
        /// <summary>
        /// Create a new organization by cloning the addressed organization
        ///  #### Body Parameters 
        /// 
        /// **Parameter**|**Type**|**Description** 
        ///  :-------------: |:-------------: |:-------------: 
        /// name| 
        /// string| The name of the new organization
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<CreateANewOrganizationResponse> EANewOrganizationByCloningTheAddressedOrganization(ListTheOrganizationsResponse request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PostJsonAsync<CreateANewOrganizationResponse>($"organizations/{organizationId}/clone", request, headers);
        }
    
        /// <summary>
        /// Delete an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EmptyResponse> DeleteAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.DeleteFromJsonAsync<EmptyResponse>($"organizations/{organizationId}", headers);
        }
    
        /// <summary>
        /// List the organizations that the user has privileges on 
        /// </summary>
        public async Task<CreateANewOrganizationResponse> ListTheOrganizationsThatTheUserHasPrivilegesOn()
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<CreateANewOrganizationResponse>($"organizations", headers);
        }
    
        /// <summary>
        /// Return an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<CreateANewOrganizationResponse> ReturnAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<CreateANewOrganizationResponse>($"organizations/{organizationId}", headers);
        }
    
        /// <summary>
        /// Update an organization
        ///  #### Body Parameters 
        /// **Parameter**|**Type**|**Description** 
        ///  
        /// :-------------: |:-------------: |:-------------: 
        /// name| string| The name of the 
        /// organization
        /// management| object| Information about the organization's management system
        /// api| object| 
        /// API-specific settings
        ///  
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<CreateANewOrganizationResponse> UpdateAnOrganization(CreateANewOrganizationResponse request, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.PutJsonAsync<CreateANewOrganizationResponse>($"organizations/{organizationId}", request, headers);
        }
    
        /// <summary>
        /// Returns adaptive policy aggregate statistics for an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<AdaptivePolicyAggregateStatisticsForAnOrganizationResponse> AdaptivePolicyAggregateStatisticsForAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<AdaptivePolicyAggregateStatisticsForAnOrganizationResponse>($"organizations/{organizationId}/adaptivePolicy/overview", headers);
        }
    
        /// <summary>
        /// List the API requests made by an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheAPIRequestsMadeByAnOrganizationResponse> ListTheAPIRequestsMadeByAnOrganization(ListTheAPIRequestsMadeByAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/apiRequests", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheAPIRequestsMadeByAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return data usage (in megabits per second) over time for all clients in the given organization 
        /// within a given time range. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ClientsInTheGivenOrganizationWithinAGivenTimeRangeResponse> ClientsInTheGivenOrganizationWithinAGivenTimeRange(ClientsInTheGivenOrganizationWithinAGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/clients/bandwidthUsageHistory", parametersDict);
            return await _httpClient.GetFromJsonAsync<ClientsInTheGivenOrganizationWithinAGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return summary information around client data usage (in mb) across the given organization. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<RoundClientDataUsageInMbAcrossTheGivenOrganizationResponse> RoundClientDataUsageInMbAcrossTheGivenOrganization(RoundClientDataUsageInMbAcrossTheGivenOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/clients/overview", parametersDict);
            return await _httpClient.GetFromJsonAsync<RoundClientDataUsageInMbAcrossTheGivenOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// View the Change Log for your organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ViewTheChangeLogForYourOrganizationResponse> ViewTheChangeLogForYourOrganization(ViewTheChangeLogForYourOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/configurationChanges", parametersDict);
            return await _httpClient.GetFromJsonAsync<ViewTheChangeLogForYourOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the availability information for devices in an organization. The data returned by this endpoint 
        /// is updated every 5 minutes. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EAvailabilityInformationForDevicesInAnOrganizationResponse> EAvailabilityInformationForDevicesInAnOrganization(EAvailabilityInformationForDevicesInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/availabilities", parametersDict);
            return await _httpClient.GetFromJsonAsync<EAvailabilityInformationForDevicesInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the power status information for devices in an organization. The data returned by this endpoint 
        /// is updated every 5 minutes. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<HePowerStatusInformationForDevicesInAnOrganizationResponse> HePowerStatusInformationForDevicesInAnOrganization(HePowerStatusInformationForDevicesInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/powerModules/statuses/byDevice", parametersDict);
            return await _httpClient.GetFromJsonAsync<HePowerStatusInformationForDevicesInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the provisioning statuses information for devices in an organization. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EAvailabilityInformationForDevicesInAnOrganizationResponse> OningStatusesInformationForDevicesInAnOrganization(OningStatusesInformationForDevicesInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/provisioning/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<EAvailabilityInformationForDevicesInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the status of every Meraki device in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ListTheStatusOfEveryMerakiDeviceInTheOrganizationResponse> ListTheStatusOfEveryMerakiDeviceInTheOrganization(ListTheStatusOfEveryMerakiDeviceInTheOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<ListTheStatusOfEveryMerakiDeviceInTheOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the current uplink addresses for devices in an organization. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<HeCurrentUplinkAddressesForDevicesInAnOrganizationResponse> HeCurrentUplinkAddressesForDevicesInAnOrganization(HeCurrentUplinkAddressesForDevicesInAnOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/uplinks/addresses/byDevice", parametersDict);
            return await _httpClient.GetFromJsonAsync<HeCurrentUplinkAddressesForDevicesInAnOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the uplink loss and latency for every MX in the organization from at latest 2 minutes ago 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ForEveryMXInTheOrganizationFromAtLatest2MinutesAgoResponse> ForEveryMXInTheOrganizationFromAtLatest2MinutesAgo(ForEveryMXInTheOrganizationFromAtLatest2MinutesAgoParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/devices/uplinksLossAndLatency", parametersDict);
            return await _httpClient.GetFromJsonAsync<ForEveryMXInTheOrganizationFromAtLatest2MinutesAgoResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return an overview of the license state for an organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnAnOverviewOfTheLicenseStateForAnOrganizationResponse> ReturnAnOverviewOfTheLicenseStateForAnOrganization(string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            return await _httpClient.GetFromJsonAsync<ReturnAnOverviewOfTheLicenseStateForAnOrganizationResponse>($"organizations/{organizationId}/licenses/overview", headers);
        }
    
        /// <summary>
        /// Return the OpenAPI Specification of the organization's API documentation in JSON 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<CificationOfTheOrganizationsAPIDocumentationInJSONResponse> CificationOfTheOrganizationsAPIDocumentationInJSON(CificationOfTheOrganizationsAPIDocumentationInJSONParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/openapiSpec", parametersDict);
            return await _httpClient.GetFromJsonAsync<CificationOfTheOrganizationsAPIDocumentationInJSONResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the top 10 appliances sorted by utilization over given time range. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<P10AppliancesSortedByUtilizationOverGivenTimeRangeResponse> P10AppliancesSortedByUtilizationOverGivenTimeRange(P10AppliancesSortedByUtilizationOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/appliances/byUtilization", parametersDict);
            return await _httpClient.GetFromJsonAsync<P10AppliancesSortedByUtilizationOverGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top 10 clients by data usage (in mb) over given time range. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<TionsTop10ClientsByDataUsageInMbOverGivenTimeRangeResponse> TionsTop10ClientsByDataUsageInMbOverGivenTimeRange(TionsTop10ClientsByDataUsageInMbOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/clients/byUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<TionsTop10ClientsByDataUsageInMbOverGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top clients by data usage (in mb) over given time range, grouped 
        /// by manufacturer. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<TaUsageInMbOverGivenTimeRangeGroupedByManufacturerResponse> TaUsageInMbOverGivenTimeRangeGroupedByManufacturer(TaUsageInMbOverGivenTimeRangeGroupedByManufacturerParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/clients/manufacturers/byUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<TaUsageInMbOverGivenTimeRangeGroupedByManufacturerResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top 10 devices sorted by data usage over given time range. Default 
        /// unit is megabytes. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<OnsTop10DevicesSortedByDataUsageOverGivenTimeRangeResponse> OnsTop10DevicesSortedByDataUsageOverGivenTimeRange(OnsTop10DevicesSortedByDataUsageOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/devices/byUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<OnsTop10DevicesSortedByDataUsageOverGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top 10 device models sorted by data usage over given time range. 
        /// Default unit is megabytes. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<P10DeviceModelsSortedByDataUsageOverGivenTimeRangeResponse> P10DeviceModelsSortedByDataUsageOverGivenTimeRange(P10DeviceModelsSortedByDataUsageOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/devices/models/byUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<P10DeviceModelsSortedByDataUsageOverGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top 10 ssids by data usage over given time range. Default unit is 
        /// megabytes. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<TaUsageInMbOverGivenTimeRangeGroupedByManufacturerResponse> GanizationsTop10SsidsByDataUsageOverGivenTimeRange(GanizationsTop10SsidsByDataUsageOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/ssids/byUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<TaUsageInMbOverGivenTimeRangeGroupedByManufacturerResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return metrics for organization's top 10 switches by energy usage over given time range. Default 
        /// unit is joules. 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<OnsTop10DevicesSortedByDataUsageOverGivenTimeRangeResponse> AtionsTop10SwitchesByEnergyUsageOverGivenTimeRange(AtionsTop10SwitchesByEnergyUsageOverGivenTimeRangeParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/summary/top/switches/byEnergyUsage", parametersDict);
            return await _httpClient.GetFromJsonAsync<OnsTop10DevicesSortedByDataUsageOverGivenTimeRangeResponse>(queryString, headers);
        }
    
        /// <summary>
        /// List the uplink status of every Meraki MX, MG and Z series devices in the organization 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse> FEveryMerakiMXMGAndZSeriesDevicesInTheOrganization(FEveryMerakiMXMGAndZSeriesDevicesInTheOrganizationParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/uplinks/statuses", parametersDict);
            return await _httpClient.GetFromJsonAsync<EveryMerakiMXAndZSeriesAppliancesInTheOrganizationResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return a list of alert types to be used with managing webhook alerts 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<AListOfAlertTypesToBeUsedWithManagingWebhookAlertsResponse> AListOfAlertTypesToBeUsedWithManagingWebhookAlerts(AListOfAlertTypesToBeUsedWithManagingWebhookAlertsParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/webhooks/alertTypes", parametersDict);
            return await _httpClient.GetFromJsonAsync<AListOfAlertTypesToBeUsedWithManagingWebhookAlertsResponse>(queryString, headers);
        }
    
        /// <summary>
        /// Return the log of webhook POSTs sent 
        /// </summary>
        /// <param name="organizationId">(Required) Organization ID</param>
        public async Task<ReturnTheLogOfWebhookPOSTsSentResponse> ReturnTheLogOfWebhookPOSTsSent(ReturnTheLogOfWebhookPOSTsSentParameters queryParameters, string organizationId)
        {
            var headers = new Dictionary<string, string>()
            {
                { $"Authorization", $"" }
            };
    
            var parametersDict = queryParameters.ToDictionary();
            var queryString = QueryHelpers.AddQueryString($"organizations/{organizationId}/webhooks/logs", parametersDict);
            return await _httpClient.GetFromJsonAsync<ReturnTheLogOfWebhookPOSTsSentResponse>(queryString, headers);
        }
    }
}