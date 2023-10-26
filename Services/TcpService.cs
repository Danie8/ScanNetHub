using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ScanNetHub.Services
{
    internal class TcpService
    {
        private TcpListener _listener;
        private bool _isListening = false;

        public event Action<string> MessageReceived;
        public event Action ClientConnected;

        public bool IsListening
        {
            get { return _isListening; }
        }

        // Este método inicia el TcpListener para comenzar a escuchar conexiones entrantes
        public void StartListening(string ipAddress, int port)
        {
            _listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            _listener.Start();
            _isListening = true;

            Task.Run(() => AcceptLoop());
        }

        // Este método detiene el TcpListener
        public void StopListening()
        {
            _isListening = false;
            _listener?.Stop();
        }

        // Un bucle que constantemente acepta conexiones entrantes
        private async Task AcceptLoop()
        {
            while (_isListening)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    ClientConnected?.Invoke();
                    HandleClient(client);
                }
                catch (Exception ex)
                {

                }
            }
        }

        // Método para manejar cada conexión entrante
        private async Task HandleClient(TcpClient client)
        {
            using (var stream = client.GetStream())
            using (var reader = new StreamReader(stream))
            {
                while (_isListening && client.Connected)
                {
                    var message = await reader.ReadLineAsync();
                    if (!string.IsNullOrEmpty(message))
                    {
                        // Dispara un evento cuando se recibe un mensaje
                        MessageReceived?.Invoke(message);
                    }
                }
            }
        }
    }
}
