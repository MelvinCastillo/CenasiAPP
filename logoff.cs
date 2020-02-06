using CenasiAPP.clases;
using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace CenasiAPP
{
  public class logoff : Page
  {
    protected HtmlForm form1;

    protected void Page_Load(object sender, EventArgs e)
    {
      CURRENTUSR.Reset();
      FormsAuthentication.SignOut();
      this.Response.Redirect("login.aspx");
    }
  }
}
