namespace IdentityServer.Domain.Common;
#nullable enable
public abstract class AuditableEntityBase<Tid> : EntityBase<Tid>
{
    public DateTime Created { get; private set; }

    public string? CreatedBy { get; private set; }

    public DateTime LastModified { get; private set; }

    public string? LastModifiedBy { get; private set; }

}
