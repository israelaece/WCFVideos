using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFVideos.WebUI
{
    public partial class Proposta : System.Web.UI.Page
    {
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Analisar_Click(object sender, EventArgs e)
        {

        }
    }
}