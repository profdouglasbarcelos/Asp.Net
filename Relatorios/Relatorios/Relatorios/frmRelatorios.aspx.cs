using Relatorios.Models;
using Relatorios.Relatorios.DataSets;
using System;
using System.Data;
using System.Linq;

namespace Relatorios.Relatorios
{
    public partial class frmRelatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarRelatorio();

        }

        private void CarregarRelatorio()
        {
            rvRelatorios.ProcessingMode =
                            Microsoft.Reporting.WebForms.ProcessingMode.Local;

            rvRelatorios.LocalReport.ReportPath = 
                Request.MapPath(Request.ApplicationPath + @"Relatorios\Reports\rptProdutosAnalitico.rdlc");

            // Criando instancia do dataset para preencher
            dsRelatorioProdutos ds = new dsRelatorioProdutos();

            // fazendo consulta e preenchendo a dataTable
            Contexto ctx = new Contexto();

            var listaProdutos = ctx.Produtos.ToList();

            foreach (Produto p in listaProdutos)
            {
                // adicionando as linhas na dataTable dtProdutos
                ds.dtProdutos.AdddtProdutosRow(
                    p.Nome,
                    p.Descricao,
                    p.Preco,
                    p._Categoria.Nome
                    );
            }

            rvRelatorios.LocalReport.DataSources.Clear();

            rvRelatorios.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WebForms.ReportDataSource(
                    "dsProdutos", (DataTable)ds.dtProdutos
                    )
                );

            rvRelatorios.LocalReport.Refresh();
        }
    }
}