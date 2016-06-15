using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookNook_Fianl
{
    public partial class Products : System.Web.UI.Page
    {
        protected static ArrayList partNumber = new ArrayList();
        protected static ArrayList numInCart = new ArrayList();
        protected static int itemsInCart = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            lblNumInCart.Text = itemsInCart.ToString();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            GridViewRow row = GridView1.SelectedRow;
            String selectedPartNum = row.Cells[0].Text;
            if (!partNumber.Contains(selectedPartNum))
            {
                partNumber.Add(row.Cells[0].Text);
                numInCart.Add(1);
                itemsInCart += 1;

            }
            else {
                int partIndex = partNumber.IndexOf(selectedPartNum);
                int num = (int)numInCart[partIndex];
                numInCart[partIndex] = num + 1;
                itemsInCart += 1;
            }

            lblNumInCart.Text = itemsInCart.ToString();


        }

        protected void btnDisplayCart_Click(object sender, EventArgs e)
        {
            Session["partNumber"] = partNumber;
            Session["numInCart"] = numInCart;
            Response.Redirect("DisplayCart.aspx");
        }
    }
}