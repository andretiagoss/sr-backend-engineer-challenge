using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Taller.Application.Interfaces;

namespace Taller.Infrastructure.Security;

public class SecretProvider : ISecretProvider
{
    private readonly SecretClient _client;

    public SecretProvider(string keyVaultUrl)
    {
        _client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
    }
    public Task<string> GetSecretAsync(string secretName)
    {
        //var secret = await _client.GetSecretAsync(secretName);
        //return secret.Value.Value;

        //For this challenge, implement a mock version that returns a hardcoded connection string
        var mockValue = "Server=.,1433;Database=taller-db-dev;User Id=sa;Password=Strong(!)Password;TrustServerCertificate=true;Encrypt=true";
        return Task.FromResult(mockValue);
    }
}
