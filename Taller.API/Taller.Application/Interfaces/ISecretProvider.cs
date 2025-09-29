namespace Taller.Application.Interfaces;

public interface ISecretProvider
{
    Task<string> GetSecretAsync(string secretName);
}
