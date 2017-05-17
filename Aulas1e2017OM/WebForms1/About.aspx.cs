using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            link1.Text = "Home Page";
            //calDataInicio.SelectedDate = new DateTime(2017, 03, 08);
            calDataInicio.VisibleDate = new DateTime(2017, 05, 08);
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            link1.Text = txtNome.Text;
        }
    }
}