using Newtonsoft.Json;

namespace Cosmos.Models;

public class Frog(Guid id, string name)
{
    [JsonProperty("id")]
    public Guid Id { get; set; } = id;

    [JsonProperty("name")]
    public string Name { get; set; } = name;
}