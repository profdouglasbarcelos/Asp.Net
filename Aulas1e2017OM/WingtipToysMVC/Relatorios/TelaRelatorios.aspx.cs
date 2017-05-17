using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToysMVC.Models;

namespace WingtipToysMVC.Relatorios
{
    public partial class TelaRelatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dsRelatorio1 ds = new dsRelatorio1();

                using (WingtipToysMVCContext banco = new WingtipToysMVCContext())
                {
                    foreach (Produto p in banco.Produtoes)
                    {
                        ds.dtProdutos.AdddtProdutosRow(p.Nome, p.Descricao, p._Categoria.Nome);
                    }

                    rvRelatorios.ProcessingMode = 
                        Microsoft.Reporting.WebForms.ProcessingMode.Local;

                    rvRelatorios.LocalReport.ReportPath = 
                        Request.MapPath(Request.ApplicationPath + @"Relatorios\Relatorio1.rdlc");

                    rvRelatorios.LocalReport.DataSources.Clear();

                    rvRelatorios.LocalReport.DataSources.Add(
                        new Microsoft.Reporting.WebForms.ReportDataSource(
                            "dsRelatorio1", (DataTable)ds.dtProdutos
                            )
                            );

                    rvRelatorios.LocalReport.Refresh();
                }
            }
        }
    }
}