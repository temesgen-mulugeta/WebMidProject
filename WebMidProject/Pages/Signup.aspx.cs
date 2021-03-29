using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        Auth auth;
        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new Auth();
        }

        protected void SignupB_Click(object sender, EventArgs e)
        {
            var response = auth.SignUp(
                name: NameTB.Text, 
                phoneNumber: PhoneTB.Text, 
                email: EmailTB.Text, 
                password: PasswordTB.Text
                );
            if (response)
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }

        }
    }
}