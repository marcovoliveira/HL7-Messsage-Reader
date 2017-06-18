using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7
{
    class EVN :SegmentHL7
    {
        String eventTypeCode;
        String recordedDateTime;
        String dateTimePlannedEvent;
        String eventReasonCode;
        String operatorID;
        String eventOcurred;
        String eventFacility;

        public EVN(String segmento, char separadorCampos) : base(segmento, separadorCampos)
        {
            eventTypeCode = campos[1];
            recordedDateTime = campos[2];
            if (campos.Length == 4)
                dateTimePlannedEvent = campos[3];
            if (campos.Length == 5)
            {
                dateTimePlannedEvent = campos[3];
                eventReasonCode = campos[4];
            }
            if (campos.Length == 6)
            {
                dateTimePlannedEvent = campos[3];
                eventReasonCode = campos[4];
                operatorID = campos[5];
            }
            if (campos.Length == 7)
            {
                dateTimePlannedEvent = campos[3];
                eventReasonCode = campos[4];
                operatorID = campos[5];
                eventOcurred = campos[6];
            }
            if (campos.Length == 8)
            {
                dateTimePlannedEvent = campos[3];
                eventReasonCode = campos[4];
                operatorID = campos[5];
                eventOcurred = campos[6];
                eventFacility = campos[7];
            }
        }
    }
}
