using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMidProject.BusinessLayer;

namespace WebMidProject.Pages
{
    public partial class Order : System.Web.UI.Page
    {
        String[][] availableDimensions = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Cookie.isUserLoggedIn(Request))
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (orderTypeList.Items.Count == 0)
            {
                var orderTypes = new Orders().GetAvailableOrdersTypes();
                if (orderTypes != null && orderTypes.Length > 0)
                {
                    foreach (var orderType in orderTypes)
                    {
                        orderTypeList.Items.Add(orderType);
                    }


                }

            }
        }

        protected void orderTypeList_TextChanged(object sender, EventArgs e)
        {
            orderDimensionsList.Items.Clear();
            availableDimensions = new Orders().GetAvailableDimensions(orderTypeList.SelectedValue);
            foreach (var dimension in availableDimensions)
            {
                orderDimensionsList.Items.Add(dimension[0]);
            }
        }
    }
}

     
    
