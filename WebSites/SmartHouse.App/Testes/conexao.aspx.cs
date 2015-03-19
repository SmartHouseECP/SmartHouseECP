using System;
using System.Collections.Generic;
public partial class conexao : System.Web.UI.Page
{
    protected List<SmartHouse.ConexaoVO> lista;
    protected SmartHouse.ConexaoBLL ctxConexao;
    protected void Page_Load(object sender, EventArgs e)
    {
        ctxConexao = new SmartHouse.ConexaoBLL();

        if (Request["gravar"] == "S")
        {
            ctxConexao.Inserir(Request["f_nome"]);
            Response.Redirect("conexao.aspx");
        }
    }
}