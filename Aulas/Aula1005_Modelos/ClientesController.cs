using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_Modelos
{
    class ClientesController
    {
        private MeuBancoDados contexto = new MeuBancoDados();

        public void SalvarCliente(Clientes cli)
        {
            contexto.Clientes.Add(cli);
            contexto.SaveChanges();
        }
    }
}
