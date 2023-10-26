namespace ScanNetHub
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLastEntranceTitle = new System.Windows.Forms.Label();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.rtbEntranceHistory = new System.Windows.Forms.RichTextBox();
            this.lblLastEntrance = new System.Windows.Forms.Label();
            this.PanelTCP = new System.Windows.Forms.Panel();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSerial = new System.Windows.Forms.Panel();
            this.lblSerialStatus = new System.Windows.Forms.Label();
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PanelTCP.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastEntranceTitle
            // 
            this.lblLastEntranceTitle.AutoSize = true;
            this.lblLastEntranceTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEntranceTitle.Location = new System.Drawing.Point(12, 9);
            this.lblLastEntranceTitle.Name = "lblLastEntranceTitle";
            this.lblLastEntranceTitle.Size = new System.Drawing.Size(220, 46);
            this.lblLastEntranceTitle.TabIndex = 0;
            this.lblLastEntranceTitle.Text = "Last Entrace";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "TCP/IP",
            "Serial",
            "Bluetooth"});
            this.cmbConnectionType.Location = new System.Drawing.Point(304, 146);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(234, 21);
            this.cmbConnectionType.TabIndex = 1;
            // 
            // rtbEntranceHistory
            // 
            this.rtbEntranceHistory.Location = new System.Drawing.Point(12, 104);
            this.rtbEntranceHistory.Name = "rtbEntranceHistory";
            this.rtbEntranceHistory.ReadOnly = true;
            this.rtbEntranceHistory.Size = new System.Drawing.Size(270, 283);
            this.rtbEntranceHistory.TabIndex = 2;
            this.rtbEntranceHistory.Text = "";
            // 
            // lblLastEntrance
            // 
            this.lblLastEntrance.AutoSize = true;
            this.lblLastEntrance.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEntrance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLastEntrance.Location = new System.Drawing.Point(12, 55);
            this.lblLastEntrance.Name = "lblLastEntrance";
            this.lblLastEntrance.Size = new System.Drawing.Size(92, 46);
            this.lblLastEntrance.TabIndex = 3;
            this.lblLastEntrance.Text = "xxxx";
            // 
            // PanelTCP
            // 
            this.PanelTCP.Controls.Add(this.lblConnectionStatus);
            this.PanelTCP.Controls.Add(this.btnConnect);
            this.PanelTCP.Controls.Add(this.txtPort);
            this.PanelTCP.Controls.Add(this.lblPort);
            this.PanelTCP.Controls.Add(this.txtIpAddress);
            this.PanelTCP.Controls.Add(this.lblIpAddress);
            this.PanelTCP.Location = new System.Drawing.Point(304, 173);
            this.PanelTCP.Name = "PanelTCP";
            this.PanelTCP.Size = new System.Drawing.Size(234, 195);
            this.PanelTCP.TabIndex = 4;
            this.PanelTCP.Visible = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(16, 115);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(195, 40);
            this.lblConnectionStatus.TabIndex = 6;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(128, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "12345";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(128, 2);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(3, 19);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIpAddress.TabIndex = 1;
            this.txtIpAddress.Text = "127.0.0.1";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(3, 3);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblIpAddress.TabIndex = 0;
            this.lblIpAddress.Text = "Ip Address";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(265, 104);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 283);
            this.vScrollBar1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ScanNetHub";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PanelSerial
            // 
            this.PanelSerial.Controls.Add(this.cmbBaudRate);
            this.PanelSerial.Controls.Add(this.cmbSerialPort);
            this.PanelSerial.Controls.Add(this.btnConnectSerial);
            this.PanelSerial.Controls.Add(this.lblBaudRate);
            this.PanelSerial.Controls.Add(this.lblSerialPort);
            this.PanelSerial.Controls.Add(this.lblSerialStatus);
            this.PanelSerial.Location = new System.Drawing.Point(307, 173);
            this.PanelSerial.Name = "PanelSerial";
            this.PanelSerial.Size = new System.Drawing.Size(234, 195);
            this.PanelSerial.TabIndex = 7;
            this.PanelSerial.Visible = false;
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSerialStatus.Location = new System.Drawing.Point(13, 116);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(195, 40);
            this.lblSerialStatus.TabIndex = 6;
            this.lblSerialStatus.Text = "Disconnected";
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Location = new System.Drawing.Point(6, 90);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(75, 23);
            this.btnConnectSerial.TabIndex = 4;
            this.btnConnectSerial.Text = "Connect";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(3, 45);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(61, 13);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate ";
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(3, 3);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(55, 13);
            this.lblSerialPort.TabIndex = 0;
            this.lblSerialPort.Text = "Serial Port";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(6, 17);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPort.TabIndex = 7;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(6, 61);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(550, 452);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lblLastEntrance);
            this.Controls.Add(this.rtbEntranceHistory);
            this.Controls.Add(this.cmbConnectionType);
            this.Controls.Add(this.lblLastEntranceTitle);
            this.Controls.Add(this.PanelSerial);
            this.Controls.Add(this.PanelTCP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ScanNetHub";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.PanelTCP.ResumeLayout(false);
            this.PanelTCP.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelSerial.ResumeLayout(false);
            this.PanelSerial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastEntranceTitle;
        private System.Windows.Forms.ComboBox cmbConnectionType;
        private System.Windows.Forms.RichTextBox rtbEntranceHistory;
        private System.Windows.Forms.Label lblLastEntrance;
        private System.Windows.Forms.Panel PanelTCP;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanelSerial;
        private System.Windows.Forms.Label lblSerialStatus;
        private System.Windows.Forms.Button btnConnectSerial;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

