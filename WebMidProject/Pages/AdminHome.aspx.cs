using System;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected OrderModel[] allOrders = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (allOrders == null)
            {
                allOrders = new Orders().GetAllOrders();
            }



        }

        protected void Download_Click(object sender, EventArgs e)
        {

        }
        protected void Logout_Click(object sender, EventArgs e)
        {

        }
    }

}