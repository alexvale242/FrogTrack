namespace Cosmos;

public class CosmosDbOptions
{
    public Uri ServiceEndpoint { get; set; } = default!;
    public string AuthKey { get; set; } = default!;
    public string DatabaseId { get; set; } = default!;
    public bool DisableCertificateValidation { get; set; }
}
