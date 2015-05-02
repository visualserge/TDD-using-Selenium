using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMain;
using WebMain.Core;

namespace WebMain
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();

            Result result = obj.LogIn(txtUserName.Text, txtPassword.Text);

            if (result.issuccess)
            {
                lblMessage.Text = obj.ShowMessage(result);
            }
            else
            {
                lblMessage.Text = obj.ShowMessage(result);
            }
        }
    }
}