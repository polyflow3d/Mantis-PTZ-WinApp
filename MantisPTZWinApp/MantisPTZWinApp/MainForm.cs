using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using MantisPTZWinApp;
using System.Diagnostics;


public partial class MainForm : Form
{

    public enum ConnectionMode
    {
        UDP,
        UART
    }


    public ConnectionMode connectionMode = ConnectionMode.UDP;
    udpConnectionManager udpManager;
    uint recievedPackedIdx = 0;
    List<InputPacket> inputPacketsHistory;
    int maxLogLines = 10;
    List<string> logLines = new List<string>(10);


    #region Constant
    private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
    #endregion

    private SerialPort Serial = new SerialPort();

    #region Local Helpers
    private void UpdateCOMPortList()
    {
        // Get all existing Com Port names
        string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
        comport_cbox.Items.Clear();
        //cboxBaudrate.Items.Clear();

        // Append existing COM to the cboxComport list
        foreach (var item in Ports)
        {
            comport_cbox.Items.Add(item);
        }

        // Append possible Baudrate to the cboxBaudrate list
        // foreach (var baud in baudrate) {
        //    cboxBaudrate.Items.Add(baud.ToString());
        // }
    }
    #endregion

    #region Delegates
    public delegate void UPDATE_OUTPUT_TEXT(String Str);
    public void UpdateOutputText(String Str)
    {
        // tboxReceive.Text = Str;
        //  tboxReceive.ScrollToCaret();
    }


    public delegate void UPDATE_PACKETS_LISTVIEW();

    public void UpdatePacketsListView()
    {
        //listView_packets.Items.Clear();
        //for (int i = 0; i < inputPacketsHistory.Count; i++)
        //{
        //    listView_packets.Items.Add(inputPacketsHistory[i].lvi);
        //}
    }
    #endregion


    #region Handlers
    void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
    {
        int bytesToRead = Serial.BytesToRead;
        byte[] _bytes = new byte[bytesToRead];
        Serial.Read(_bytes, 0, Serial.BytesToRead);

        /*
        String str = "bytes to read length" + Serial.BytesToRead.ToString();

        int payloadLen = 2 + 1 + 4 + 1;
        byte[] payload = new byte[payloadLen];
        int startByteIdx = 0;
        int packetIdIdx = 1;
        int cobsIdx = 2;
        int payloadLengthIdx = 3;
        int crcIdx = 4 + payloadLen;

        Serial.Read(bytes, 0, Serial.BytesToRead);
        byte[] oneByte = new byte[1];

        /*
        if (bytesToRead >= 13) {
            System.Array.Copy(bytes, 4, payload, 0, payloadLen);
            //System.Array.Copy(bytes, 4, payload2, 0, 7 );
            oneByte[0] = bytes[6];
            str += string.Format("Paload Length in {0} calculated {1} ", bytes[payloadLengthIdx], payloadLen);
            str += string.Format(" int {0} {1} = {2} | ", ToHex(payload[0]), ToHex(payload[1]), BitConverter.ToInt16(bytes, 4));
            str += string.Format(" char {0} = {1} | ", ToHex(payload[2]), System.Text.Encoding.ASCII.GetString(oneByte));
            str += string.Format(" float {0} {1} {2} {3} = {4} | ", ToHex(payload[3]), ToHex(payload[4]), ToHex(payload[5]), ToHex(payload[6]), BitConverter.ToSingle(payload, 3).ToString("F5"));
            str += string.Format(" byte = {0}", ToHex(payload[7]));
            str += string.Format(" CRC in {0}", ToHex(bytes[crcIdx]));
            str += string.Format(" CRC calc {0}", ToHex(Crc8.calculate(payload)));
            str += Environment.NewLine;
        }
        */

        if (inputPacketsHistory == null)
        {
            inputPacketsHistory = new List<InputPacket>();
        }
        InputPacket ip = new InputPacket(recievedPackedIdx, DateTime.Now, _bytes);
        recievedPackedIdx++;
        inputPacketsHistory.Add(ip);

        while (inputPacketsHistory.Count > 4)
        {
            inputPacketsHistory.RemoveAt(0);
        }

        Invoke(new UPDATE_PACKETS_LISTVIEW(UpdatePacketsListView));
    }
    #endregion

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (connectionMode == ConnectionMode.UDP)
        {
            if (udpManager == null)
            {
                udpManager = new udpConnectionManager( port_maskedTextBox.Text , "192.168.88.254");
                Log(udpManager.connectionSummary);
 
            }
            else
            {
                udpManager.Dispose();
                udpManager = null;
            }
        }



        //// If user click disconnect
        //if ("Disconnect" == btnConnect.Text.ToString())
        //{
        //    if (true == Serial.IsOpen)
        //    {
        //        Serial.Close();

        //    }
        //    Serial.DataReceived -= new SerialDataReceivedEventHandler(SerialOnReceivedHandler);
        //    btnConnect.Text = "Connect";
        //    comport_cbox.Enabled = true;
        //    //cboxBaudrate.Enabled = true;
        //    //btnRefresh.Enabled = true;

        //    return;
        //}

        //// else we gonna open the desired COM port
        //// Get user comport from cbox
        //try
        //{
        //    Serial.PortName = comport_cbox.Text;
        //}
        //catch
        //{
        //    MessageBox.Show("Error! No COM Port selected");
        //    return;
        //}

        //// Get user baudrate from cbox
        //try
        //{
        //    Serial.BaudRate = 9600;
        //    //int.Parse(cboxBaudrate.Text.ToString());
        //}
        //catch
        //{
        //    MessageBox.Show("Error! No Baudrate selected");
        //    return;
        //}

        //// Serial Port Configuration
        //Serial.Parity = Parity.None;
        //Serial.DataBits = 8;
        //Serial.ReceivedBytesThreshold = 1;
        //Serial.StopBits = StopBits.One;
        //Serial.Handshake = Handshake.None;
        //Serial.WriteTimeout = 3000;

        //// Check if com port is opened by other application
        //if (false == Serial.IsOpen)
        //{
        //    try
        //    {
        //        // Com port available
        //        Serial.Open();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("The COM port is not accessible", "Error");
        //        return;
        //    }
        //    ;


        //    // double comform it is opened
        //    if (true == Serial.IsOpen)
        //    {
        //        btnConnect.Text = "Disconnect";
        //        comport_cbox.Enabled = false;
        //        //cboxBaudrate.Enabled = false;
        //        //btnRefresh.Enabled = false;

        //        // Add callback handler for receiving
        //        Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);


        //    }

        //}
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // We need to populate the lists during mainform is loading
        UpdateCOMPortList();
        ArrangeLayout();
        fill_listView_packets_collums();
    }

    void AddCollumnToListView(ListView lv, string text, int width)
    {
        ColumnHeader ch = new ColumnHeader();
        ch.Text = text;
        ch.Width = width;
        lv.Columns.Add(ch);
    }

    private void fill_listView_packets_collums()
    {
        //listView_packets.Columns.Clear();
        //listView_packets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        //AddCollumnToListView(listView_packets, "#", 80);
        //AddCollumnToListView(listView_packets, "Time", 80);
        //AddCollumnToListView(listView_packets, "Start Byte", 80);
        //AddCollumnToListView(listView_packets, "Packet ID", 80);
        //AddCollumnToListView(listView_packets, "COBS", 70);
        //AddCollumnToListView(listView_packets, "Payload Length", 90);
        //AddCollumnToListView(listView_packets, "P0", 50);
        //AddCollumnToListView(listView_packets, "P1", 50);
        //AddCollumnToListView(listView_packets, "P2", 50);
        //AddCollumnToListView(listView_packets, "P3", 50);
        //AddCollumnToListView(listView_packets, "P4", 50);
        //AddCollumnToListView(listView_packets, "P5", 50);
        //AddCollumnToListView(listView_packets, "P6", 50);
        //AddCollumnToListView(listView_packets, "P7", 50);
        //AddCollumnToListView(listView_packets, "CRC", 50);
        //AddCollumnToListView(listView_packets, "Stop Byte", 50);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {

        UpdateCOMPortList();
    }



    private void tboxReceive_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void mainPanel_Resize(object sender, EventArgs e)
    {
        ArrangeLayout();
    }

    void ArrangeLayout()
    {
        Size s = mainPanel.ClientSize;
        laptop_icon.Location = new Point(8, 8);
        remoteControllerIcon.Location = new Point(s.Width / 2 - 64, 8);
        ptzIcon.Location = new Point(s.Width - 128, 8);
    }

    private void cboxComport_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void udp_toolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (connectionMode == ConnectionMode.UART)
        {
            connectionMode = ConnectionMode.UDP;
            udp_toolStripMenuItem.Checked = true;
            uart_toolStripMenuItem.Checked = false;
            OnChangeConnectionMode();
        }
    }

    private void uart_toolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (connectionMode == ConnectionMode.UDP)
        {
            connectionMode = ConnectionMode.UART;
            udp_toolStripMenuItem.Checked = false;
            uart_toolStripMenuItem.Checked = true;
            OnChangeConnectionMode();
        }
    }

    long logCounter;

    void Log(string text)
    {
        string logNumberStr = string.Format("#{0}       ", logCounter).Remove(6);
        logLines.Add(string.Format("{0} {1}", logNumberStr, text));
        logCounter++;
        int diff = logLines.Count - 10;
        while (logLines.Count > 10)
        {
            logLines.RemoveAt(0);
        }
        log_textBox.Clear();
        foreach (string s in logLines)
        {
            Debug.Print(s);
            log_textBox.Text += s;
            log_textBox.Text += System.Environment.NewLine;
        }
    }

    void OnChangeConnectionMode()
    {
        Log(string.Format(string.Format("connection type changed to {0}", connectionMode.ToString())));
        if (connectionMode == ConnectionMode.UDP)
        {
            IP_groupbox.Visible = true;
            comPort_groupBox.Visible = false;
            btnConnect.Enabled = true;
        }
        else
        {
            IP_groupbox.Visible = false;
            comPort_groupBox.Visible = true;
            btnConnect.Enabled = false;
        }
    }

    private void timer_100ms_Tick(object sender, EventArgs e)
    {
        if (udpManager != null)
        {
            Byte[] data = udpManager.Update();
            if (data != null)
            {
                Log(Encoding.ASCII.GetString(data));
            }
        }

    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if(udpManager != null){ 
            udpManager.Dispose();
        }
    }
}
