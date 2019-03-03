// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CapturedHashCredential
    {
        /// <summary>
        /// Initializes a new instance of the CapturedHashCredential class.
        /// </summary>
        public CapturedHashCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapturedHashCredential class.
        /// </summary>
        /// <param name="hashCredentialType">Possible values include: 'NTLM',
        /// 'LM', 'SHA1'</param>
        /// <param name="type">Possible values include: 'Password', 'Hash',
        /// 'Ticket'</param>
        public CapturedHashCredential(string hash = default(string), HashType? hashCredentialType = default(HashType?), int? id = default(int?), string domain = default(string), string username = default(string), string serviceName = default(string), CredentialType? type = default(CredentialType?))
        {
            Hash = hash;
            HashCredentialType = hashCredentialType;
            Id = id;
            Domain = domain;
            Username = username;
            ServiceName = serviceName;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NTLM', 'LM', 'SHA1'
        /// </summary>
        [JsonProperty(PropertyName = "hashCredentialType")]
        public HashType? HashCredentialType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Password', 'Hash', 'Ticket'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public CredentialType? Type { get; set; }

    }
}