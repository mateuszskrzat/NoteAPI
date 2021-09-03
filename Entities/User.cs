using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : AuditableEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
