using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTELCO.Domain
{
    public class Key
    {
        public Key()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
