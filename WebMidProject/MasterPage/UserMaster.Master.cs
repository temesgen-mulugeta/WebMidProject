using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMidProject.BusinessLayer;

namespace WebMidProject.MasterPage
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cookie.isUserLoggedIn(Request)) { 

                authButtonLabel.Text = "Logout";
                authLink.NavigateUrl = "UserHome.aspx";
                //new Cookie(response: Response).RemoveCookie();

            }     
            else 
            {
                authButtonLabel.Text = "Login";
                authLink.NavigateUrl = "Login.aspx";
            }


        }
        protected void LoginB_Click(object sender, EventArgs e)
        {
        }
    }
}