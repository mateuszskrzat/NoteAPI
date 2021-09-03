using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AuditableEntity : Entity, IAudit
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
