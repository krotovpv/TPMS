using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS_WF2
{
    public partial class MainForm : Form
    {
        TcpClient tcpClient;
        NetworkStream stream;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(Connect);
        }

        private void Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                //tcpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                tcpClient.Connect("192.168.0.7", 23);
                stream = tcpClient.GetStream();
                ReadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ParseData(byte[] bytes)
        {
            if (bytes.Length == 18 &&
                bytes[0] == 0x5A &&
                bytes[1] == 0xAA)
            {
                string tirePressure = "---";
                string tireTemperature = "--";

                string tireNumber = Convert.ToInt16(bytes[9]).ToString() + " " + Convert.ToInt16(bytes[10]).ToString() + " " + Convert.ToInt16(bytes[11]).ToString() + " " + Convert.ToInt16(bytes[12]).ToString();
                if (bytes[13] != 0xFF)
                    tirePressure = Math.Round((Convert.ToUInt16(bytes[13]) * 5.48 - 100), 0).ToString();
                if (bytes[14] != 0xFF)
                    tireTemperature = (Convert.ToUInt16(bytes[14]) - 50).ToString();
                short tireCode = Convert.ToInt16(bytes[15]);
               
                new HistoryData(tirePressure, tireTemperature, tireNumber, tireCode);

                int rowIndex = -1;
                foreach (DataGridViewRow item in dgvMain.Rows)
                {
                    if (item.Cells["ColumnNumber"].Value.ToString() == tireNumber)
                        rowIndex = item.Index;
                }
                if (rowIndex != -1)
                {
                    dgvMain.Rows[rowIndex].Cells["ColumnNumber"].Value = tireNumber;
                    dgvMain.Rows[rowIndex].Cells["ColumnDate"].Value = DateTime.Now;
                    dgvMain.Rows[rowIndex].Cells["ColumnCode"].Value = tireCode;
                    dgvMain.Rows[rowIndex].Cells["ColumnPressure"].Value = tirePressure;
                    dgvMain.Rows[rowIndex].Cells["ColumnTemperature"].Value = tireTemperature;
                }
                else
                {
                    dgvMain.Rows.Add(tireNumber, DateTime.Now, tireCode, tirePressure, tireTemperature);
                }
            }
        }

        private void ReadData()
        {
            while (tcpClient.Connected)
            {
                if (stream.DataAvailable)
                {
                    byte[] responseDataBuffer = new byte[128];
                    List<byte> responseData = new List<byte>();
                    int messageLength = stream.ReadAsync(responseDataBuffer, 0, 128).Result;
                    for (int i = 0; i < messageLength; i++)
                    {
                        responseData.Add(responseDataBuffer[i]);
                    }
                    ParseData(responseData.ToArray());
                }
                Task.Delay(100);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient?.Connected == true)
                tcpClient.Close();
        }
    }
}
