using IdentityServer.Domain.Common;

namespace IdentityServer.Domain.Entities;

public class User : EntityBase<long>
{
    public string Username { get; private set; } = string.Empty;
    public byte[] PasswordHash { get; private set; }
    public byte[] PasswordSalt { get; private set; }
    public long RoleId { get; set; }
    public Role Role { get; private set; }

    public void CreatePasswordHash(string password)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512();
        PasswordSalt = hmac.Key;
        PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    }

    public bool VerifyPasswordHash(string password)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512(PasswordSalt);
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(PasswordHash);
    }
}
