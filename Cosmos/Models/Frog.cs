using Newtonsoft.Json;

namespace Cosmos.Models;

public class Frog(Guid id, string name, string? description)
{
    [JsonProperty("id")]
    public Guid Id { get; set; } = id;

    [JsonProperty("name")]
    public string Name { get; set; } = name;
    
    [JsonProperty("description")]
    public string? Description { get; set; } = description;
}