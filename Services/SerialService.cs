using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanNetHub.Services
{
    public class SerialService
    {
        private SerialPort serialPort;

        public SerialService()
        {
            serialPort = new SerialPort();
        }

        public bool IsOpen()
        {
            return serialPort.IsOpen;
        }

        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public void SetPort(string portName, int baudRate)
        {
            serialPort.PortName = portName;
            serialPort.BaudRate = baudRate;
        }

        public void OpenConnection()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
            }
            catch (System.IO.IOException ex)
            {
                // Aquí puedes registrar el error o mostrar un mensaje al usuario.
                MessageBox.Show("Error al abrir el puerto serie: " + ex.Message);
            }
        }


        public void CloseConnection()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }

}
