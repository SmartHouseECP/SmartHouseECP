using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Teste
{
    public class TesteBLL : SmartHouse.SmartHouseBLL
    {
        public List<TesteVO> Selecionar()
        {
            return context.Database.SqlQuery<TesteVO>(
                @"SELECT 
                    Codigo,
                    Nome
                FROM 
                    Teste "
                ).ToList();
        }

        public void Inserir(string nome)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                context.Database.ExecuteSqlCommand(
                  @"INSERT INTO Teste (
                        Nome
                    ) VALUES (
                        @p0
                    ) ",
                    nome
                );

                ts.Complete();
            }

        }
    }
}
