using System;

namespace Entities
{
    public interface IAudit
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}