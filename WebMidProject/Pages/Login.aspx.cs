using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        DataAccess dataAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            var response = dataAccess.Login(
               email: LoginEmailTB.Text,
               password: LoginPasswordTB.Text
               );
            System.Diagnostics.Debug.WriteLine(response);
            if (response)
            {
                Session["email"] = LoginEmailTB.Text;
            }
                


        }

    }
}