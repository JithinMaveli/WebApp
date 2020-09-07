using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SecurityProtocolType s = ServicePointManager.SecurityProtocol;

            Label1.Text = "ServicePointManager.SecurityProtocol: " + ServicePointManager.SecurityProtocol.ToString();
        }
    }
}