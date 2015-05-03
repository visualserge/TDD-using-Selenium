using System;
using System.Web.UI;
using WebMain.Core;

namespace WebMain
{
    public partial class LogIn : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            var obj = new UserLogin();

            var result = obj.LogIn(txtUserName.Text, txtPassword.Text);

            lblMessage.Text = obj.ShowMessage(result.Code);
        }
    }
}