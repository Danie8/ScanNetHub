using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ScanNetHub.Utils.Constants;

namespace ScanNetHub.Models
{
    public class ClientInfo
    {
        public string IPAddress { get; set; }
        public ConnectionType Type { get; set; }  // Enum para definir tipo de conexión: TCP/IP, Serial, Bluetooth o el otro raro

        // Otros campos pertinentes
    }

}
