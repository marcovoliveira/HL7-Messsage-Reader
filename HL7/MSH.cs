using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7
{
    class MSH : SegmentHL7
    {
        String tipoMensagem;
        String aplicacaoEmissora;
        String aplicacaoReceptora;
        String versao;

        public MSH(String segmento, char separadorCampos) : base(segmento, separadorCampos)
        {
            tipoMensagem = campos[8];
            aplicacaoEmissora = campos[2];
            aplicacaoReceptora = campos[4];
            versao = campos[11];
            opcionalidade.Add(true);
            opcionalidade.Add(true);
            opcionalidade.Add(false);
            opcionalidade.Add(false);
            opcionalidade.Add(false);
            opcionalidade.Add(false);
            opcionalidade.Add(false);
            opcionalidade.Add(false);
            opcionalidade.Add(true);
            opcionalidade.Add(true);
            opcionalidade.Add(true);
            opcionalidade.Add(true);
        }
    }
}
