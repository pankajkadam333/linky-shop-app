using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using IdentityServer.Domain.Dtos;
using IdentityServer.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace IdentityServer.Infrastructure.JwtConfiguration;

public class JwtWebTokenConfiguration
{
    private IConfiguration _configuration { get; }
    public JwtWebTokenConfiguration(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string CreateToken(UserDto user)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.Name, user.Username)
        };

        string ExpiryTimeToken = _configuration.GetSection("JwtSettings:ExpiryInMinutes").Value;
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JwtSettings:Key").Value));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            _configuration.GetSection("JwtSettings:Issuer").Value,
            _configuration.GetSection("JwtSettings:Audience").Value,
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(ExpiryTimeToken)),
            signingCredentials: creds
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
