using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xS2Development.xRouteWSService
{
    public partial class Segment
    {
        [XmlIgnore]
        public string Country { get { return (this.attributes == null || this.attributes.descriptors == null) ? null : this.attributes.descriptors.country; } private set { } }
    }
}
