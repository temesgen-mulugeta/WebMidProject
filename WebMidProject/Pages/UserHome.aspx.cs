using System;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class UserHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Cookie.isUserLoggedIn(Request))
            {
               // Response.Redirect("Login.aspx");
                return;
            }

        }
    }
}