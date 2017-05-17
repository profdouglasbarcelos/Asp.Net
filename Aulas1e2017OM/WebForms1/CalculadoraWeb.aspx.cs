using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms1
{
    public partial class CalculadoraWeb : System.Web.UI.Page
    {
        public int Valor1
        {
            get
            {
                return (int)ViewState["v1"];
            }

            set
            {
                ViewState.Add("v1", value);
            }
        }
        public int Valor2 { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        protected void btnMais_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = string.Empty;
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}