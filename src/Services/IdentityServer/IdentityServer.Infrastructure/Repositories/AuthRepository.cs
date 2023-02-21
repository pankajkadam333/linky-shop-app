using IdentityServer.Domain.Entities;
using IdentityServer.Infrastructure.DataContext;

namespace IdentityServer.Infrastructure.Repositories.Interfaces;

public class AuthRepository : BaseRepository<User, ApplicationDbContext>, IAuthRepository
{
    public AuthRepository(ApplicationDbContext context) : base(context) { }
}
