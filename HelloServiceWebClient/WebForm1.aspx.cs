using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloServiceWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyService.HelloServiceClient client = new MyService.
                                         HelloServiceClient
                                         ("BasicHttpBinding_IHelloService");
            client.DoWork();
            Response.Write(client.Message("Calling WCF service from web client"));
        }
    }
}