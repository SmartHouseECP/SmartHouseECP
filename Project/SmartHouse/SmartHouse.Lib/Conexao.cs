using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Transactions;

namespace SmartHouse
{
    public class ConexaoVO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
    public class ConexaoBLL : SmartHouseBLL
    {
        public List<ConexaoVO> Conectar()
        {
            string strSQL = "SELECT * FROM Teste ";

            // Perform data access using the context 
            return context.Database.SqlQuery<ConexaoVO>(strSQL).ToList();
        }
        public void Inserir( string nome)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                string strSQL = "INSERT INTO Teste (Nome) VALUES (@p0) ";

                // Perform data access using the context 
                context.Database.ExecuteSqlCommand(strSQL, nome);
                
                ts.Complete();
            }

        }
    }
}
