using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookNook_Fianl
{
    public partial class Contact : Page
    {
        Boolean isSent;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

        }

        protected void btnSemd_Click(object sender, EventArgs e)
        {
            String recipient = txtFrom.Text;
            String subject = txtSubject.Text;
            String message = txtBody.Text;

            SendMail newMessage = new SendMail();
            isSent = newMessage.sendMail(recipient, subject, message, null);

            if (isSent)
            {
                lblSendStatus.Text = "Success!";

            }
            else {
                lblSendStatus.Text = "Email Failed";

            }
        }
    }
}