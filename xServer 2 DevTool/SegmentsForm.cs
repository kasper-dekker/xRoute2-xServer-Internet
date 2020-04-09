using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xS2Development
{
    public partial class SegmentsForm : Form
    {
        public SegmentsForm(xRouteWSService.RouteResponse routeResp)
        {
            InitializeComponent();
            foreach (var item in routeResp.segments)
            {
                
                segmentBindingSource.Add(item);
            }
        }


    }
}
