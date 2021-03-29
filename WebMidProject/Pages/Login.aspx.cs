using System;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        Auth auth;
        Cookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new Auth();
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            var response = auth.Login(
               role: "user",
               email: LoginEmailTB.Text,
               password: LoginPasswordTB.Text
               );
            System.Diagnostics.Debug.WriteLine(response);
            if (response)
            {
                cookie = new Cookie(LoginEmailTB.Text, "user", Response);
                cookie.AddCookie();
                Response.Redirect("UserHome.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }



        }

    }
}