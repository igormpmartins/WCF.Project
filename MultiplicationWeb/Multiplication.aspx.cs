using MultiplicationWeb.ServiceReference;
using System;

namespace MultiplicationWeb
{
    public partial class Multiplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new NewMultiplicationServiceClient("BasicHttpBinding_NewMultiplicationService");
            Response.Write(client.MultiplyDouble(5.3, 5.3));
        }
    }
}