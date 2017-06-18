using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7
{
    class PID :SegmentHL7 
    {
        String patientID;
        String patientName;
        char sex;
        String patientAddress;
        DateTime dataBirth;

        public PID(String segmento, char separadorCampos, char separadorComponentes) : base(segmento, separadorCampos)
        {
            patientID = campos[3];
            patientName = campos[5];
            dataBirth = DateTime.ParseExact(campos[7], "yyyyMMdd", null);
            sex = Convert.ToChar(campos[8]);

            String[] nome = patientName.Split(separadorComponentes);
            String nomeCompleto = nome[1] + " " + nome[2] + " " + nome[0];
        }

    }
}
