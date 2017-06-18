using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7
{
    class MSHException :Exception
    {
        String _texto;

        public MSHException(int valor)
        {
            switch (valor)
            {
                case 0:
                    _texto = "Erro geral na mensagem";
                    break;
                case 1:
                    _texto = "Erro na versão";
                    break;
                case 2:
                    _texto = "Os campos obrigatórios têm de ser preenchidos.";
                    break;
            }
        }

        public override String ToString()
        {
            return _texto;
        }
    }
}
