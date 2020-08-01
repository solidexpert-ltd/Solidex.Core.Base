using System;

namespace Solidex.Core.Base.Infrastructure.Querying
{
    public class IdsSearchRequest
    {
        public FieldRequest<Guid> Ids { get; set; }
    }
}