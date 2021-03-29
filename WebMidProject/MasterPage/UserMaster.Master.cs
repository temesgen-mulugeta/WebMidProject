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
                authButtonLabel.Text = Cookie.isUserLoggedIn(Request) ? "Logout" : "Login";
        }
        protected void LoginB_Click(object sender, EventArgs e)
        {
        }
    }
}