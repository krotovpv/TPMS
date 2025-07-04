using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS_WF
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
                tcpClient.Connect("127.0.0.1", 23);
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
            //MessageBox.Show(Encoding.UTF8.GetString(bytes, 0, bytes.Length));
            if (bytes.Length == 18 &&
                bytes[0] == 0x5A &&
                bytes[1] == 0xAA &&
                bytes[2] == 0x02 &&
                bytes[3] == 0x04)
            {
                string tirePressure = "---";
                string tireTemperature = "--";
                ETypeTire typeTire = (ETypeTire)Convert.ToUInt16(bytes[4]);
                if (bytes[13] != 0xFF)
                    tirePressure = Math.Round((Convert.ToUInt16(bytes[13]) * 5.48 - 100), 0).ToString();
                if (bytes[14] != 0xFF)
                    tireTemperature = (Convert.ToUInt16(bytes[14]) - 50).ToString();

                new HistoryData(tirePressure, tireTemperature, typeTire);
                if (typeTire == ETypeTire.FrontLeft)
                {
                    this.ExInvoke(() =>
                    {
                        lblFrontLeftPressure.Text = tirePressure + " кПа";
                        lblFrontLeftTemperature.Text = tireTemperature + " °С";
                    });
                }
                else if (typeTire == ETypeTire.FrontRight)
                {
                    this.ExInvoke(() =>
                    {
                        lblFrontRightPressure.Text = tirePressure + " кПа";
                        lblFrontRightTemperature.Text = tireTemperature + " °С";
                    });
                }
                else if (typeTire == ETypeTire.BackLeft)
                {
                    this.ExInvoke(() =>
                    {
                        lblBackLeftPressure.Text = tirePressure + " кПа";
                        lblBackLeftTemperature.Text = tireTemperature + " °С";
                    });
                }
                else if (typeTire == ETypeTire.BackRight)
                {
                    this.ExInvoke(() =>
                    {
                        lblBackRightPressure.Text = tirePressure + " кПа";
                        lblBackRightTemperature.Text = tireTemperature + " °С";
                    });
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
                Thread.Sleep(100);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient?.Connected == true)
                tcpClient.Close();
        }
    }
}
