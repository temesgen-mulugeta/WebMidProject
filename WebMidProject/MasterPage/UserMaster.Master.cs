using System;
using WebMidProject.BusinessLayer;

namespace WebMidProject.MasterPage
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e) =>
            LoginB.Text = Cookie.isUserLoggedIn(Request) ? "Logout" : "Login";
        
        protected void LoginB_Click(object sender, EventArgs e)
        {
            if (Cookie.isUserLoggedIn(Request))
            {
                new Cookie(response: Response).RemoveCookie();
                Response.Redirect("UserHome.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }

        }
    }
}