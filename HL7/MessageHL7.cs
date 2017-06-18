using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HL7
{
    class MessageHL7
    {
        String mensagem;
        String[] segmentos;
        String[] campos;
        char separadorCampos;
        char separadorComponentes;
        char separadorSubComponentes;
        String tipoMensagem;
        String versao;
        List<SegmentHL7> listaSegmentos = new List<SegmentHL7>();

        public MessageHL7(String mensagem)
        {
            //Verifica se a mensagem começa com MSH
            if (!mensagem.StartsWith("MSH"))
                throw new MSHException(0);

            //Obtem segmentos
            segmentos = mensagem.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //Obtem separadores 
            separadorCampos = segmentos[0][3];
            separadorComponentes = segmentos[0][4];
            separadorSubComponentes = segmentos[0][7];

            //Obtem campos do segmento 1(MSH)
            campos = segmentos[0].Split(separadorCampos);

            //Verifica se a versão é 2.3
            if (campos[11] != "2.3")
                throw new MSHException(1);

            //Cria segmentos
            foreach (String s in segmentos)
            {
                if (s.StartsWith("MSH"))
                {
                    MSH msh = new MSH(s, separadorCampos);
                    msh.verificarOpcionalidade();
                    listaSegmentos.Add(msh);
                }
                else if (s.StartsWith("EVN"))
                {
                    EVN evn = new EVN(s, separadorCampos);
                    listaSegmentos.Add(evn);
                }
                else if (s.StartsWith("PID"))
                {
                    PID pid = new PID(s, separadorCampos, separadorComponentes);
                    listaSegmentos.Add(pid);
                }
                else
                {
                    SegmentHL7 segmento = new SegmentHL7(s, separadorCampos);
                    listaSegmentos.Add(segmento);
                }
            }


            //Testar se está a criar os tipos de segmentos certos
            foreach (SegmentHL7 s in listaSegmentos)
            {
                System.Windows.Forms.MessageBox.Show(s.GetType() + "");
            }

        }

        public char SeparadorCampos
        {
            get { return separadorCampos; }
            set { separadorCampos = value; }
        }

        public char SeparadorComponentes
        {
            get { return separadorComponentes; }
            set { separadorComponentes = value; }
        }

        public char SeparadorSubComponentes
        {
            get { return separadorComponentes; }
            set { separadorComponentes = value; }
        }

        public List<SegmentHL7> ListaSegmentos
        {
            get { return listaSegmentos; }
        }

        public int TotalSegmentos()
        {
            return segmentos.Count();
        }

        public String[] DevolverSegmentos()
        {
            return segmentos;
        }

        public String TipoMensagem()
        {
            return campos[8];
        }

        public String Versao()
        {
            return campos[11];
        }

        public PID getPID()
        {
            foreach (SegmentHL7 s in listaSegmentos)
                if (s is PID)
                    return (s as PID);
            return null;
        }

    }
}