using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace cookNook_Fianl
{
    public partial class DisplayCart : System.Web.UI.Page
    {
        ArrayList partNumber;
        ArrayList numInCart;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Request.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            if (Session["partNumber"] == null || Session["numInCart"] == null)
            {
                Response.Redirect("Products.aspx");
            }
            else
            {

                partNumber = (ArrayList)Session["partNumber"];
                numInCart = (ArrayList)Session["numInCart"];

                Double totalCost = 0.0;
                foreach (string part in partNumber) {

                    //Gets product data----------------------------
                    string constring = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    SqlConnection inventoryConnect = new SqlConnection(constring);
                    SqlCommand getProductInfo = new SqlCommand("select PartNumberPK, Description, QtyOnHand, Price from tblInventory where PartNumberPK='"  + part + "'", inventoryConnect);


                    inventoryConnect.Open();
                    SqlDataReader productInfo = getProductInfo.ExecuteReader();


                    productInfo.Read();
                    String partNumberPK = productInfo["PartNumberPK"].ToString().Trim();
                    String description = productInfo["Description"].ToString().Trim();
                    String qtyOnHand = productInfo["QtyOnHand"].ToString().Trim();
                    String price = productInfo["Price"].ToString().Trim();

                    inventoryConnect.Close();

                    //Sets product data on the screen-------------------------------------------
                    String numCart = numInCart[partNumber.IndexOf(part)].ToString();

                    HtmlGenericControl dt = new HtmlGenericControl("dt");
                    dt.InnerText = "Part Number: " + partNumberPK;
                    HtmlGenericControl ddOne = new HtmlGenericControl("dd");
                    HtmlGenericControl ddTwo = new HtmlGenericControl("dd");
                    HtmlGenericControl ddThree = new HtmlGenericControl("dd");
                    HtmlGenericControl ddFour = new HtmlGenericControl("dd");
                    HtmlGenericControl ddSpace = new HtmlGenericControl("dd");
                    ddOne.InnerText = "Description: " + description;
                    ddTwo.InnerText = "Quantity on hand: " + qtyOnHand;
                    ddThree.InnerText = "Price: $" + price;
                    ddFour.InnerText = "Number in cart: " + numCart;
                    ddSpace.InnerHtml = "<br>";

                    productsList.Controls.Add(dt);
                    productsList.Controls.Add(ddOne);
                    productsList.Controls.Add(ddTwo);
                    productsList.Controls.Add(ddThree);
                    productsList.Controls.Add(ddFour);
                    productsList.Controls.Add(ddSpace);

                    totalCost += (Double.Parse(price) * Double.Parse(numCart));

                }

                HtmlGenericControl dtTotalCost = new HtmlGenericControl("dt");
                dtTotalCost.InnerText = "Total Cost for all items: $" + totalCost.ToString();
                productsList.Controls.Add(dtTotalCost);

            }
        }
    }
}