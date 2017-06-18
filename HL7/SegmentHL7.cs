using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7
{
    class SegmentHL7
    {
        public string[] campos;
        public List<Boolean> opcionalidade = new List<Boolean>();

        public SegmentHL7(string segmento, char separadorCampos)
        {
            campos = segmento.Split(separadorCampos);
        }

        public int TotalCampos()
        {
            return campos.Count();
        }

        public string PrimeiroCampoSegmento()
        {
            return campos[0];
        }

        public void verificarOpcionalidade()
        {
            int i = 0;
            foreach (Boolean op in opcionalidade)
            {
                if (op == true && campos[i] == "")
                    throw new MSHException(2);
                i++;
            }
        }
    }
}
