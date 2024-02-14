using Newtonsoft.Json;

namespace Cosmos.Models;

public class Frog
{
    [JsonProperty("id")]
    public Guid Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
}