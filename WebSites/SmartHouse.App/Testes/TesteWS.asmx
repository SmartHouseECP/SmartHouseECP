<%@ WebService Language="C#" Class="TesteWS" %>

using System;
using System.Collections.Generic;
using SmartHouse;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[System.Web.Script.Services.ScriptService]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class TesteWS  : System.Web.Services.WebService {
    [WebMethod]
    public List<ConexaoVO> Selecionar() {
        return new ConexaoBLL().Conectar();
    }
    
}