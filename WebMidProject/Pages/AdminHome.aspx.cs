using System;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected OrderModel[] allOrders = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Cookie.isUserLoggedIn(Request) || !(Cookie.GetCookieData(Request).role == "admin"))
            {
                Response.Redirect("AdminLogin.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }
            else if (allOrders == null)
            {
                allOrders = new Orders().GetAllOrders();
            }



        }

        protected void Download_Click(object sender, EventArgs e)
        {

        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            new Cookie(response: Response).RemoveCookie();
            Response.Redirect("AdminLogin.aspx", false);
            Context.ApplicationInstance.CompleteRequest();

        }
    }

}