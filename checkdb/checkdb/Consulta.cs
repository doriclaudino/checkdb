using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkdb
{
    class Consulta
    {
        public String apelido;
        public String campo;
        public String query;
        public int retorno;

        public Consulta(String apelido, String campo, int retorno)
        {
            this.apelido = apelido;
            this.campo = campo;
            this.retorno = retorno;
        }

        public Consulta(String apelido, String campo, String query)
        {
            this.apelido = apelido;
            this.campo = campo;
            this.query = query;
        }
    }
}
