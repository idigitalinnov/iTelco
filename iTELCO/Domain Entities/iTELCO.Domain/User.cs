using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTELCO.Common.Enums;

namespace iTELCO.Domain
{
    public class User : Key
    {
        public string FirstName { get; set; }
        public string ConnectionType { get; set; }

        public string Protocol { get; set; }
        public string LastName { get; set; }
    }
}
