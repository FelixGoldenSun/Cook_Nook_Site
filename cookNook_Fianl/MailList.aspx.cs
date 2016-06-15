using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookNook_Fianl
{
    public partial class MailList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection insertConnect = new SqlConnection(constring);
            SqlCommand insertMailInfo = new SqlCommand("INSERT INTO tblEmail (email, first_name, last_name) VALUES(@email, @first_name, @last_name)", insertConnect);
            insertMailInfo.Parameters.AddWithValue("@email", txtEmail.Text);
            insertMailInfo.Parameters.AddWithValue("@first_name", txtFirstName.Text);
            insertMailInfo.Parameters.AddWithValue("@last_name", txtLastName.Text);
            insertConnect.Open();

            try
            {
                insertMailInfo.ExecuteNonQuery();
                lblSuccess.Text = "Entry Added!";
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }

            insertConnect.Close();

        }

        protected void valValidEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //Gets email data----------------------------
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection emailConnect = new SqlConnection(constring);
            SqlCommand getEmail = new SqlCommand("select email from tblEmail where email='" + txtEmail.Text + "'", emailConnect);


            emailConnect.Open();
            SqlDataReader email = getEmail.ExecuteReader();

            if (email.HasRows)
            {
                args.IsValid = false;
                valValidEmail.Text = "Duplicate email address";
            }
            else {
                args.IsValid = true;
            }
      

            emailConnect.Close();
        }
    }
}