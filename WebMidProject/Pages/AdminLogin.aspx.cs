using System;
using WebMidProject.BusinessLayer;


namespace WebMidProject.Pages
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        Auth auth;
        Cookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new Auth();
        }
        protected void Admin_Login_Click(object sender, EventArgs e)
        {

            var response = auth.Login(
               role: "admin",
               email: LoginEmailTB.Text,
               password: LoginPasswordTB.Text
               );
            System.Diagnostics.Debug.WriteLine(response);
            if (response)
            {
                cookie = new Cookie(LoginEmailTB.Text, "admin", Response);
                cookie.AddCookie();
                Response.Redirect("AdminHome.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }






        }
    }
}