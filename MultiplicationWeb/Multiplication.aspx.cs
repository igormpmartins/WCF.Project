using MultiplicationWeb.ServiceReference;
using System;
using System.ServiceModel;

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
            //Response.Write(client.MultiplyDouble(5.3, 5.3));
            try
            {
                Response.Write(client.DivInt(5, 0));
            }
            catch (FaultException<DivFault> ex)
            {
                Response.Write($"{ex.Detail.Message}<br/>");
                Response.Write($"{ex.Detail.OperationMessage}<br/>");
            }

            client.Save(new Student { Id = 123, Name = "That Guy" });
        }
    }
}