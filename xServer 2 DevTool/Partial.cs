using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xRouteWSService
{
    public partial class Segment
    {
        [XmlIgnore]
        public int MyProperty { get; private set; }
    }
}
