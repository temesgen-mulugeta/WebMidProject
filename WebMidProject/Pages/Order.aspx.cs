using System;
using System.Linq;
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
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
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

        protected void orderDimensionsList_TextChanged(object sender, EventArgs e) { }

        protected void OrderB_Click(object sender, EventArgs e)
        {
            if (orderTypeList.SelectedValue != String.Empty
                    && orderDimensionsList.SelectedValue != String.Empty)
            {
                availableDimensions = new Orders().GetAvailableDimensions(orderTypeList.SelectedValue);

                var index = (from item in availableDimensions[0]
                             where item.IndexOf(orderDimensionsList.Text) >= 0
                             select item.IndexOf(orderDimensionsList.Text)).SingleOrDefault();

                if (OrderB.Text == "Calculate Price")
                {
                    OrderB.Text = "Confirm Order";
                    TotalAmountLabel.Text = $"Total amount is: {Double.Parse(QuantityTB.Text) * Double.Parse(availableDimensions[index][1])}";
                    UploadPanel.EnableViewState = true;
                }
                else if (FileUpload.HasFile)
                {
                    var response = new Orders().PlaceOrder(email: Cookie.GetCookieData(request: Request), serviceType: orderTypeList.Text, dimensions: orderDimensionsList.Text, quantity: double.Parse(QuantityTB.Text), FileUpload.FileBytes);
                }
            }
        }
    }
}

     
    
