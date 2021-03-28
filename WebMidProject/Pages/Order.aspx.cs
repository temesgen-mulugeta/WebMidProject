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
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Cookie.isUserLoggedIn(Request))
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (orderTypeList.Items.Count == 1)
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

        protected void orderDimensionsList_TextChanged(object sender, EventArgs e)
        {
            
        


        }

        protected void OrderB_Click(object sender, EventArgs e)
        {
            availableDimensions = new Orders().GetAvailableDimensions(orderTypeList.SelectedValue);

            int index = (from item in availableDimensions[0]
                         where item.IndexOf(orderDimensionsList.Text) >= 0
                         select item.IndexOf(orderDimensionsList.Text)).SingleOrDefault();

            if (OrderB.Text == "Calculate Price")
            {
                OrderB.Text = "Confirm Order";
                TotalAmountLabel.Text = availableDimensions[index][1];
            }
        }
    }
}

     
    
