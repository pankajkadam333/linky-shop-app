namespace IdentityServer.Domain.Common;

public class EntityBase<Tid>
{
    protected EntityBase() { }
    protected EntityBase(Tid id)
    {
        Id = id;
    }

    public Tid Id { get; private set; }
}
