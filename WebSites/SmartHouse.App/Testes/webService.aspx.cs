using System;
using System.Collections.Generic;
public partial class webService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request["gravar"] == "S")
        {
            new SmartHouse.ConexaoBLL().Inserir(Request["f_nome"]);
        }
    }
}