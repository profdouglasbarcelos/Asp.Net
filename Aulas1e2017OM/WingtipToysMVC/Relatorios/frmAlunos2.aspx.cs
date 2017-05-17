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
    public partial class frmAlunos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            // criar contexto
            using (WingtipToysMVCContext ctx = new WingtipToysMVCContext())
            {
                // Pesquisar os dados
                var listaProdutos = ctx.Produtoes.ToList();


                // https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
                // LINQ
                var query = from p in ctx.Produtoes
                            join c in ctx.Categorias
                            on p.CategoriaID equals c.CategoriaID
                            select new
                            {
                                p.ProdutoID,
                                p.Nome,
                                p.Descricao,
                                p.CategoriaID,
                                NomeCategoria = c.Nome
                            };


                // Preencher dataSet
                dsAlunos2 dataSet = new dsAlunos2();

                //foreach (Produto p in listaProdutos)
                foreach (var produto in query)
                {
                    dataSet.dtProdutos2.AdddtProdutos2Row(
                        produto.ProdutoID,
                        produto.Nome,
                        produto.Descricao,
                        produto.CategoriaID,

                        // p._Categoria.Nome // lazyload

                        produto.NomeCategoria // query linq
                    );
                }

                // modo processamento
                ReportViewer1.ProcessingMode =
                    Microsoft.Reporting.WebForms.ProcessingMode.Local;

                // caminho do arquivo do relatorio (layout)
                ReportViewer1.LocalReport.ReportPath =
                    @"Relatorios\rptAlunos2.rdlc";

                // limpando fontes de dados
                ReportViewer1.LocalReport.DataSources.Clear();

                // definir novas fontes de dados
                ReportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WebForms.ReportDataSource(
                        "dsAlunos2",
                        (DataTable)dataSet.dtProdutos2
                        )
                    );

                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}