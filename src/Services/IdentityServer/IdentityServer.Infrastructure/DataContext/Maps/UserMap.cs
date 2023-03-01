using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityServer.Infrastructure.DataContext.Maps;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.PasswordHash).IsRequired();
        builder.Property(p => p.PasswordSalt).IsRequired();
        builder.Property(p => p.RoleId).IsRequired();
        builder.HasOne(p => p.Role).WithMany(p => p.Users).HasForeignKey(p => p.RoleId);
    }
}