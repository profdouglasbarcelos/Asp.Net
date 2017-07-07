using RelatoriosMVC.Models;
using RelatoriosMVC.Relatorios.DataSets;
using System;
using System.Data;
using System.Linq;

namespace RelatoriosMVC.Relatorios
{
    public partial class wfRelatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            rvVisualizador.ProcessingMode =
                Microsoft.Reporting.WebForms.ProcessingMode.Local;

            // limpando datasources (fontes de dados)
            rvVisualizador.LocalReport.DataSources.Clear();

            // escolhendo qual relatorio
            rvVisualizador.LocalReport.ReportPath =
                Request.MapPath(
                    Request.ApplicationPath + @"Relatorios\Reports\rptProdutosAnalitico.rdlc");

            // consultando os dados

            Contexto db = new Contexto();

            var resultadoConsulta = db.Produtos.ToList();


            // Preenchendo o dataSet
            dsRelatorioProdutosAnalitico dataSet = new dsRelatorioProdutosAnalitico();

            foreach (Produto p in resultadoConsulta)
            {
                dataSet.dtProdutosAnalitico.AdddtProdutosAnaliticoRow(
                    p.Nome,
                    p.Descricao,
                    p.Preco,
                    p._Categoria.Nome
                    );
            }

            // informando dataSet para o relatorio
            rvVisualizador.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WebForms.ReportDataSource(
                    "dsProdutos",
                    (DataTable)dataSet.dtProdutosAnalitico
                )
            );

            // carregando o relatorio
            rvVisualizador.LocalReport.Refresh();
        }
    }
}