using System;
using System.Drawing;
using System.Windows.Forms;
using ScanNetHub.Services;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ScanNetHub
{
    public partial class MainForm : Form
    {
        private TcpService _tcpService = new TcpService();
        private SerialService _serialService = new SerialService();
        private string _currentFilePath;

        public MainForm()
        {
            InitializeComponent();

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; // Icono de información.
            notifyIcon1.BalloonTipTitle = "ScanNetHub"; // Título por defecto.

            // Lista para almacenar los tipos de conexión
            List<string> connectionTypes = new List<string>
            {
                "Select the type of connection"
            };
            connectionTypes.AddRange(new string[] { "TCP", "Serial", "Bluetooth", "Weird" });
            cmbConnectionType.DataSource = connectionTypes;

            _tcpService.MessageReceived += UpdateUIWithMessage;
            _tcpService.ClientConnected += CreateNewLogFile;

            // Evento para cuando cambie la selección del combo box
            cmbConnectionType.SelectedIndexChanged += CmbConnectionType_SelectedIndexChanged;

            // Inicializa los puertos seriales y velocidades en el combo box
            string[] ports = _serialService.GetAvailablePorts();
            cmbSerialPort.Items.AddRange(ports);

            int[] baudRates = { 9600, 115200, 2000000 };
            // Formatea los números con separadores de miles antes de añadirlos al ComboBox
            string[] formattedBaudRates = baudRates.Select(br => string.Format("{0:N0}", br)).ToArray();
            cmbBaudRate.Items.AddRange(formattedBaudRates);

        }

        // Evento que se ejecuta cuando cambia el valor seleccionado del combo box
        private void CmbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbConnectionType.SelectedItem.ToString();

            switch (selectedType)
            {
                case "TCP":
                    PanelSerial.Visible = false;
                    PanelTCP.Visible = true;

                    if (_tcpService.IsListening)
                    {
                        StopTcpConnection();
                    }
                    break;

                case "Serial":
                    PanelTCP.Visible = false;
                    PanelSerial.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void StopTcpConnection()
        {
            _tcpService.StopListening();
            txtIpAddress.Enabled = true;
            txtPort.Enabled = true;
            btnConnect.Text = "Connect";
            lblConnectionStatus.Text = "DISCONNECTED";
            lblConnectionStatus.ForeColor = Color.FromArgb(255, 0, 0); // Rojo
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            if (cmbSerialPort.SelectedItem != null && cmbBaudRate.SelectedItem != null)
            {
                string selectedPort = cmbSerialPort.SelectedItem.ToString();

                // Elimina cualquier separador de miles antes de intentar la conversión
                string selectedBaudRateString = cmbBaudRate.SelectedItem.ToString().Replace(",", "");

                if (int.TryParse(selectedBaudRateString, out int selectedBaudRate))
                {
                    if (!_serialService.IsOpen())
                    {
                        _serialService.SetPort(selectedPort, selectedBaudRate);
                        _serialService.OpenConnection();
                        if (_serialService.IsOpen())
                        {
                            lblSerialStatus.Text = "CONNECTED";
                            lblSerialStatus.ForeColor = Color.Green;
                        }                           
                            
                    }
                    else
                    {
                        _serialService.CloseConnection();
                        lblSerialStatus.Text = "DISCONNECTED";
                        lblSerialStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    // Maneja el error de conversión aquí, si es necesario
                    MessageBox.Show("Tasa de baudios no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateUIWithMessage(string message)
        {
            var timestamp = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            string finalMessage = $"{timestamp}: {message}";

            if (lblLastEntrance.InvokeRequired)
            {
                lblLastEntrance.Invoke(new Action(() => {
                    lblLastEntrance.Text = message;  // Mostrar el mensaje sin marca de tiempo
                    rtbEntranceHistory.AppendText(finalMessage + Environment.NewLine);
                    File.AppendAllText(_currentFilePath, finalMessage + Environment.NewLine);
                }));
            }
            else
            {
                lblLastEntrance.Text = message;  // Mostrar el mensaje sin marca de tiempo
                rtbEntranceHistory.AppendText(finalMessage + Environment.NewLine);
                File.AppendAllText(_currentFilePath, finalMessage + Environment.NewLine);
            }
        }

        private void CreateNewLogFile()
        {
            var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            _currentFilePath = $@"C:\Space\ScanNetHub\Logs\log_{timestamp}.txt";
            if (!File.Exists(_currentFilePath))
            {
                File.Create(_currentFilePath).Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Conectar
            if (!_tcpService.IsListening)
            {
                // Comienza la escucha en la Ip y Puertos especificados
                _tcpService.StartListening(txtIpAddress.Text.ToString(), Convert.ToInt32(txtPort.Text));

                // Lógica de la vista
                txtIpAddress.Enabled = false;
                txtPort.Enabled = false;
                btnConnect.Text = "Disconnect";
                lblConnectionStatus.Text = "CONNECTED";
                lblConnectionStatus.ForeColor = Color.FromArgb(35, 173, 36); // Verde
            }

            // Desconectar
            else
            {
                // Detiene la escucha
                StopTcpConnection();
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tcpService?.StopListening(); 
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000, "ScanNetHub", "La aplicación está corriendo en segundo plano.", ToolTipIcon.Info);
            }
        }        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;  // Cancela el evento de cierre
                this.Hide();  // Oculta el formulario
                notifyIcon1.Visible = true;  // Muestra el ícono en la bandeja del sistema
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

    }
}
