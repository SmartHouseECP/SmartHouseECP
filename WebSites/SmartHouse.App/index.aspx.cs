using System;

public partial class index : System.Web.UI.Page
{
    protected SmartHouse.SmartHouse coisa;
    protected void Page_Load(object sender, EventArgs e)
    {
        coisa = new SmartHouse.SmartHouse();
        coisa.nome = "Nome";
        coisa.DataInclusao = DateTime.Now;
        
    }
}