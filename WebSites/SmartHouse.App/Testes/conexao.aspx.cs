using System;
using System.Collections.Generic;
public partial class conexao : System.Web.UI.Page
{
    protected List<Teste.TesteVO> lista;
    protected Teste.TesteBLL ctxConexao;
    protected void Page_Load(object sender, EventArgs e)
    {
        ctxConexao = new Teste.TesteBLL();

        if (Request["gravar"] == "S")
        {
            ctxConexao.Inserir(Request["f_nome"]);
            Response.Redirect("conexao.aspx");
        }
    }
}