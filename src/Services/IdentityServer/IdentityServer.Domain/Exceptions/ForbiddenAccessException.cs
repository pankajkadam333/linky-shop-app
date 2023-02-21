using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IdentityServer.Domain.Exceptions;
[Serializable]
// Important: This attribute is NOT inherited from Exception, and MUST be specified 
// otherwise serialization will fail with a SerializationException stating that
// "Type X in Assembly Y is not marked as serializable."
public class ForbiddenAccessException : Exception
{
    public ForbiddenAccessException() : base() { }
    public ForbiddenAccessException(string message) : base(message) { }
    public ForbiddenAccessException(string message, Exception innerException) : base(message, innerException) { }
    protected ForbiddenAccessException(SerializationInfo info, StreamingContext context)
    : base(info, context) { }
}
