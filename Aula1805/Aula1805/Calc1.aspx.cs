using System;

namespace Aula1805
{
    public partial class Calc1 : System.Web.UI.Page
    {
        public string NomeUsuario
        {
            get
            {
                return ViewState["NomeUsuario"].ToString();
            }

            set
            {
                ViewState["NomeUsuario"] = value;
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                NomeUsuario = "Godofredo";
            }

        }

        protected void btnMais_Click(object sender, EventArgs e)
        {

            //Pegando os valores diretamente
            //double res = 
            //    Convert.ToDouble(txtValor1.Text) + 
            //    Convert.ToDouble(txtValor2.Text);

            //txtResultado.Text = res.ToString();



            // Armazenando informacao na ViewState
            ViewState["valor1"] = txtValor1.Text;
            ViewState["valor2"] = txtValor2.Text;
            

            // Recuperando informacao da ViewState
            double res =
                Convert.ToDouble(ViewState["valor1"]) +
                Convert.ToDouble(ViewState["valor2"]);

            lblNome.Text = NomeUsuario + " o resultado é ";

            txtResultado.Text = res.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            // armazenando os valores na session
            Session["valor1"] = txtValor1.Text;
            Session["valor2"] = txtValor2.Text;

            // Redirecionando o usuario
            Response.Redirect("~/Calc2.aspx");
        }
    }
}