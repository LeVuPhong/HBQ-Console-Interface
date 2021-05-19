using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Diagnostics;

namespace HBQ_Console_Interface
{
    public delegate void ProcessDataEventHandler(CommandType command);
    public class UserSerial
    {
        private SerialPort _serialPort;
        private ComboBox _cbComPort;
        private ComboBox _cbBaudRate;
        private ComboBox _cbDataBits;
        private ComboBox _cbParity;
        private ComboBox _cbStopBits;
        private Button _btnConnectPort;
        private Timer timerUpdate;
        private Timer timerCycle;
        private Timer timerTX;
        private Timer timerRX;
        private CirclePannel TXSignal;
        private CirclePannel RXSignal;

        private string PortIsConnect = "";
        private int RX_Count = 0;
        private int RX_Lenght = 0;
        private byte[] RecieveBuff = new byte[127];
        private byte[] cycleCommand = new byte[127];
        private int cycleLenght = 0;


        private CommandType commandType = new CommandType();


        public LogWindown Terminal = new LogWindown();
        public LogWindown Console = new LogWindown();

        
        public delegate void SeriaOpenOnChangeHandler(bool isOpen);
        //public event ProcessDataEventHandler ProcessResponseData;
        //public event ProcessDataEventHandler ProcessNotifycationData;
        public event ProcessDataEventHandler ProcessDeviceCommand;
        public event ProcessDataEventHandler ProcessConfigCommand;
        public event ProcessDataEventHandler ProcessTestCommand;
        public event ProcessDataEventHandler ProcessGSMCommand;
        public event ProcessDataEventHandler ProcessBatteryCommand;
        public event ProcessDataEventHandler ProcessServerCommand;
        public event ProcessDataEventHandler ProcessReadParamCommand;
        public event ProcessDataEventHandler ProcessFlashCommand;

        public event SeriaOpenOnChangeHandler OnChangeOpen;

        public UserSerial(Button btnConnectPort, ComboBox cbComPort, ComboBox cbBaudRate, ComboBox cbDataBits, ComboBox cbParity, ComboBox cbStopBits)
        {
            this._serialPort = new SerialPort();
            //this._serialPort = serialPort;
            this._btnConnectPort = btnConnectPort;
            this._cbComPort = cbComPort;
            this._cbBaudRate = cbBaudRate;
            this._cbDataBits = cbDataBits;
            this._cbParity = cbParity;
            this._cbStopBits = cbStopBits;

            _serialPort.DataReceived += serialPort_DataReceived;

            setUartItem();

            UpdatePort();

            timerUpdate = new Timer();
            timerUpdate.Interval = 500;
            timerUpdate.Tick += TimerUpdate_Tick;
            timerUpdate.Enabled = true;

            _btnConnectPort.Click += btnConnectPort_Click;

            //timerCycle = new Timer();

            timerTX = new Timer();
            timerTX.Interval = 50;
            timerTX.Tick += TimerTX_Tick;

            timerRX = new Timer();
            timerRX.Interval = 50;
            timerRX.Tick += TimerRX_Tick;

        }
        public void setSignal(CirclePannel tx, CirclePannel rx)
        {
            this.TXSignal = tx;
            this.RXSignal = rx;
        }
        private void setTXSignal()
        {
            if(TXSignal != null)
            {
                TXSignal.Invoke(new Action(() =>
                {
                    TXSignal.Backround = Color.Red;
                    timerTX.Start();
                }));
            }
        }
        private void setRXSignal()
        {
            if (RXSignal != null)
            {
                RXSignal.Invoke(new Action(() =>
                {
                    RXSignal.Backround = Color.Red;
                    timerRX.Start();
                }));
                
            }
        }
        private void TimerRX_Tick(object sender, EventArgs e)
        {
            RXSignal.Invoke(new Action(() =>
            {
                RXSignal.Backround = Color.Lime;
                timerRX.Stop();
            }));
        }

        private void TimerTX_Tick(object sender, EventArgs e)
        {
            TXSignal.Invoke(new Action(() =>
            {
                TXSignal.Backround = Color.Blue;
                timerTX.Stop();
            }));
        }
        #region private funtion
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdatePort();
        }

        private void setUartItem()
        {
            _cbBaudRate.Items.AddRange(new object[]
            {
                "2400",
                "4800",
                "9600",
                "38400",
                "57600",
                "115200",
                "230400",
                "460800",
            });
            _cbBaudRate.SelectedIndex = 5;

            _cbDataBits.Items.AddRange(new object[]
            {
                "6",
                "7",
                "8"
            });
            _cbDataBits.SelectedIndex = 2;

            _cbParity.Items.AddRange(new object[]
            {
                "Even",
                "None",
                "Old"
            });
            _cbParity.SelectedIndex = 1;

            _cbStopBits.Items.AddRange(new object[]
            {
                "None",
                "One",
                "Tow",
                "OnePointFive"
            });
            _cbStopBits.SelectedIndex = 1;
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdatePort();
        }
        private void btnConnectPort_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                CloseSerialPorts();
            }
            else
            {
                OpenSerialPorts();
            }
        }
        private void OpenSerialPorts()
        {
            try
            {
                _serialPort.PortName = _cbComPort.Text;
                _serialPort.BaudRate = Convert.ToInt32(_cbBaudRate.Text);
                _serialPort.DataBits = Convert.ToInt32(_cbDataBits.Text);
                _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _cbStopBits.Text);
                _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), _cbParity.Text);

                _serialPort.Open();
                PortIsConnect = _cbComPort.Text;
                //progressBar1.Value = 100;
                _cbComPort.Enabled = false;
                _cbBaudRate.Enabled = false;
                _cbDataBits.Enabled = false;
                _cbParity.Enabled = false;
                _cbStopBits.Enabled = false;
                _btnConnectPort.Text = "Disconnect";
                onchangeOpen_callback();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CloseSerialPorts()
        {
            _serialPort.Close();
            _cbComPort.Enabled = true;
            _cbBaudRate.Enabled = true;
            _cbDataBits.Enabled = true;
            _cbParity.Enabled = true;
            _cbStopBits.Enabled = true;
            _btnConnectPort.Text = "Connect";
            onchangeOpen_callback();
        }
        private void UpdatePort()
        {
            int ssPort = 0;
            //cBoxCOMPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (_cbComPort.Items.Count != ports.Length)
            {
                _cbComPort.Items.Clear();
                foreach (string pname in ports)
                {
                    _cbComPort.Items.Add(pname);
                    if (PortIsConnect == pname) ssPort++;
                }
                //cBoxCOMPort.Items.AddRange(ports);
                if (ssPort > 0)
                {
                    _cbComPort.SelectedIndex = _cbComPort.FindStringExact(PortIsConnect);
                    //OpenSerialPorts();
                }
                else
                {
                    if (_cbComPort.Items.Count > 0) _cbComPort.SelectedIndex = _cbComPort.SelectionStart;
                    CloseSerialPorts();
                }

            }

        }
        private void onchangeOpen_callback()
        {
            if(OnChangeOpen != null)
            {
                OnChangeOpen?.Invoke(_serialPort.IsOpen);
            }
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //ShowData();
            try
            {
                string stringRX = string.Empty;
                int dataLength = _serialPort.BytesToRead;
                byte[] dataRecevied = new byte[dataLength];
                int nbytes = _serialPort.Read(dataRecevied, 0, dataLength);
                bool recieve_string = false;
                for (int i = 0; i < dataLength; i++)
                {
                    switch (RX_Count)
                    {
                        case 0:
                            if (dataRecevied[i] == 0x03 || dataRecevied[i] == 0x04)
                            {
                                RecieveBuff[RX_Count] = dataRecevied[i];
                                RX_Count++;
                            }
                            else
                            {
                                stringRX += (char)dataRecevied[i];
                                recieve_string = true;
                            }
                            break;
                        case 1:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        case 2:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        case 3:
                            RX_Lenght = dataRecevied[i] * 2 + 5;
                            if (RX_Lenght > 64)
                            {
                                RX_Count = 0; //wrong format
                                break;
                            }
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        default:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            if (RX_Count > RX_Lenght)
                            {
                                RX_Count = 0;

                                Terminal.WriteLine(RecieveBuff, 0, RX_Lenght + 1, "--> ", LogTextColor.Recieves, LogDateTime.ShortTime);
                                /*call process data event*/
                                callProcessData(RecieveBuff);
                            }
                            break;
                    }
                }
                if (recieve_string)
                {
                    Console.write(stringRX, LogTextColor.Recieves);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Recieve Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Debug.WriteLine(err.Message);
            }
        }

        private void ShowData()
        {
            try
            {
                string stringRX = string.Empty;
                int dataLength = _serialPort.BytesToRead;
                byte[] dataRecevied = new byte[dataLength];
                int nbytes = _serialPort.Read(dataRecevied, 0, dataLength);
                bool recieve_string = false;
                for (int i = 0; i < dataLength; i++)
                {
                    switch (RX_Count)
                    {
                        case 0:
                            if (dataRecevied[i] == 0x03 || dataRecevied[i] == 0x04)
                            {
                                RecieveBuff[RX_Count] = dataRecevied[i];
                                RX_Count++;
                            }
                            else
                            {
                                stringRX += (char)dataRecevied[i];
                                recieve_string = true;
                            }
                            break;
                        case 1:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        case 2:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        case 3:
                            RX_Lenght = dataRecevied[i] * 2 + 5;
                            if (RX_Lenght > 64)
                            {
                                RX_Count = 0; //wrong format
                                break;
                            }
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            break;
                        default:
                            RecieveBuff[RX_Count] = dataRecevied[i];
                            RX_Count++;
                            if (RX_Count > RX_Lenght)
                            {
                                RX_Count = 0;

                                Terminal.WriteLine(RecieveBuff, 0, RX_Lenght + 1, "--> ",LogTextColor.Recieves, LogDateTime.ShortTime);
                                /*call process data event*/
                                callProcessData(RecieveBuff);
                            }
                            break;
                    }
                }
                if (recieve_string)
                {
                    Console.WriteLine(stringRX, LogTextColor.Recieves);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Recieve Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Debug.WriteLine(err.Message);
            }
        }
        private void callProcessData(byte[] data)
        {
            setRXSignal();
            int len = data[(int)CMDIndex.LenghtRes] * 2 + 4;
            if (IsChecksum(data, 0, len, data[len], data[len + 1]) == false)
            {
                Console.WriteLine("Response Error Checksum!", LogTextColor.Error);
                return;
            }

            UserApp.parseArgCommand(data, commandType);

            if(commandType.Type == 0x03)
            {
                switch (commandType.Funtion & 0xF0)
                {
                    case (byte)FuntionCode.DeviceFuntion:
                        if (ProcessDeviceCommand != null)
                            ProcessDeviceCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.ConfigFuntion:
                        if (ProcessConfigCommand != null)
                            ProcessConfigCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.TestFuntion:
                        if (ProcessTestCommand != null)
                            ProcessTestCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.GSMFuntion:
                        if (ProcessGSMCommand != null)
                            ProcessGSMCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.ServerFuntion:
                        if (ProcessServerCommand != null)
                            ProcessServerCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.BatteryFuntion:
                        if (ProcessBatteryCommand != null)
                            ProcessBatteryCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.ReadParamFuntion:
                        if (ProcessReadParamCommand != null)
                            ProcessReadParamCommand?.Invoke(commandType);
                        break;
                    case (byte)FuntionCode.FlashFuntion:
                        if (ProcessFlashCommand != null)
                            ProcessFlashCommand?.Invoke(commandType);
                        break;
                    default:
                        break;

                }
            }
            else if (commandType.Type == 0x04)
            {

            }
        }
        #endregion

        #region public funtion
        public void CalculateChecksum(byte[] buffer, int startIndex, int lenght)
        {
            int CK_A = 0xFF, CK_B = 0xFF;
            for (int i = startIndex; i < lenght; i++)
            {
                CK_A = CK_A ^ buffer[i];
                CK_B = CK_B ^ CK_A;
            }
            buffer[startIndex + lenght] = (byte)CK_A;
            buffer[startIndex + lenght + 1] = (byte)CK_B;
        }

        public bool IsChecksum(byte[] buffer, int startIndex, int lenght, byte ckA, byte ckB)
        {
            int CK_A = 0xFF, CK_B = 0xFF;
            for (int i = startIndex; i < lenght; i++)
            {
                CK_A = CK_A ^ buffer[i];
                CK_B = CK_B ^ CK_A;
            }
            if (CK_A != ckA || CK_B != ckB)
            {
                return false;
            }
            return true;
        }
        public bool sendWakeup()
        {
            try
            {
                byte[] pdata = { 0xFF, 0xFF };
                _serialPort.Write(pdata, 0, 2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            setTXSignal();
            return true;
        }
        public bool sendCommand(byte funtion)
        {
            try
            {
                //int CK_A = 0xFF, CK_B = 0xFF;
                byte[] pData = new byte[16];
                int len = 3;
                pData[0] = 0x02;
                pData[1] = funtion;
                pData[2] = 0;
                CalculateChecksum(pData, 0, len);

                _serialPort.Write(pData, 0, len + 2);

                Terminal.WriteLine(pData, 0, len + 2, "<-- ", LogTextColor.Transmits, LogDateTime.ShortTime);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Debug.WriteLine(err.Message);
                return false;
            }
            setTXSignal();
            return true;
        }
        public bool sendCommand(byte funtion, UInt16 data)
        {
            try
            {
                //int CK_A = 0xFF, CK_B = 0xFF;
                byte[] pData = new byte[16];
                int len = 5;
                pData[0] = 0x02;
                pData[1] = funtion;
                pData[2] = 1;
                pData[3] = (byte)(data & 0xFF);
                pData[4] = (byte)(data >> 8);
                CalculateChecksum(pData, 0, len);

                _serialPort.Write(pData, 0, len + 2);

                Terminal.WriteLine(pData, 0, len + 2, "<-- ", LogTextColor.Transmits, LogDateTime.ShortTime);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Debug.WriteLine(err.Message);
                return false;
            }
            setTXSignal();
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="funtion"></param>
        /// <param name="data"></param>
        /// <param name="lenght"></param>
        public bool sendCommand(byte funtion, UInt16[] data, byte lenght)
        {
            try
            {
                //int CK_A = 0xFF, CK_B = 0xFF;
                byte[] pData = new byte[16];
                int len = 0;
                pData[0] = 0x02;
                pData[1] = funtion;
                pData[2] = lenght;
                for (int i = 0; i < lenght; i++)
                {
                    pData[i * 2 + 3] = (byte)(data[i]);
                    pData[i * 2 + 4] = (byte)(data[i] >> 8);
                }
                len = pData[2] * 2 + 3;
                CalculateChecksum(pData, 0, len);

                _serialPort.Write(pData, 0, len + 2);

                Terminal.WriteLine(pData, 0, len + 2, "<-- ", LogTextColor.Transmits, LogDateTime.ShortTime);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Debug.WriteLine(err.Message);
                return false;
            }
            setTXSignal();
            return true;
        }
        #endregion

        #region public properties
        public bool IsOpen
        {
            get
            {
                return _serialPort.IsOpen;
            }
        }

        #endregion
    }
    public class LogWindown
    {
        private RichTextBox _logTextBox;
        public LogWindown()
        {

        }

        public LogWindown(RichTextBox logTextBox)
        {
            this._logTextBox = logTextBox;
        }
        #region public funtion
        public void write(string text)
        {
            if (_logTextBox != null)
            {
                _logTextBox.AppendText(text);
                _logTextBox.ScrollToCaret();
            }
        }
        public void write(string text, LogTextColor color)
        {
            if (_logTextBox != null)
            {
                _logTextBox.Invoke(new Action(() =>
                {
                    _logTextBox.SelectionColor = getLogTextColor(color);
                    _logTextBox.AppendText(text);
                    _logTextBox.ScrollToCaret();
                }));

            }
        }
        public void WriteLine(string text)
        {
            if (_logTextBox != null)
            {
                _logTextBox.AppendText(text + "\n");
                _logTextBox.ScrollToCaret();
            }
        }

        public void WriteLine(string text, LogTextColor color)
        {
            if(_logTextBox != null)
            {
                _logTextBox.Invoke(new Action(() =>
                {
                    _logTextBox.SelectionColor = getLogTextColor(color);
                    _logTextBox.AppendText(text + "\n");
                    _logTextBox.ScrollToCaret();
                }));
                
            }
        }

        public void WriteLine(string text, LogTextColor color, LogDateTime logDateTime)
        {
            if (_logTextBox == null) return;

            _logTextBox.Invoke(new Action(() =>
            {
                /*set text color*/
                _logTextBox.SelectionColor = getLogTextColor(color);

                /*add data time*/
                switch(logDateTime)
                {
                    case LogDateTime.LongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss.fff "));
                        break;
                    case LogDateTime.ShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss "));
                        break;
                    case LogDateTime.DateLongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss.fff "));
                        break;
                    case LogDateTime.DateShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss "));
                        break;
                    default:
                        break;
                }
            
                /*write text*/
                _logTextBox.AppendText(text + "\n");
                _logTextBox.ScrollToCaret();
            }));
        }
        public void WriteLine(byte[] byteArray, int startIndex, int lenght, LogTextColor color, LogDateTime logDateTime)
        {
            if (_logTextBox == null) return;
            _logTextBox.Invoke(new Action(() =>
            {
                string text = BitConverter.ToString(byteArray, startIndex, lenght).Replace("-", " ");
                /*set text color*/
                _logTextBox.SelectionColor = getLogTextColor(color);

                /*add data time*/
                switch (logDateTime)
                {
                    case LogDateTime.LongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss.fff "));
                        break;
                    case LogDateTime.ShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss "));
                        break;
                    case LogDateTime.DateLongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss.fff "));
                        break;
                    case LogDateTime.DateShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss "));
                        break;
                    default:
                        break;
                }

                /*write text*/
                _logTextBox.AppendText(text + "\n");
                _logTextBox.ScrollToCaret();    
            }));
        }

        public void WriteLine(byte[] byteArray, int startIndex, int lenght,string header, LogTextColor color, LogDateTime logDateTime)
        {
            if (_logTextBox == null) return;
            _logTextBox.Invoke(new Action(() =>
            {
                string text = BitConverter.ToString(byteArray, startIndex, lenght).Replace("-", " ");
                /*set text color*/
                _logTextBox.SelectionColor = getLogTextColor(color);

                /*add data time*/
                switch (logDateTime)
                {
                    case LogDateTime.LongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss.fff "));
                        break;
                    case LogDateTime.ShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss "));
                        break;
                    case LogDateTime.DateLongTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss.fff "));
                        break;
                    case LogDateTime.DateShortTime:
                        _logTextBox.AppendText(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss "));
                        break;
                    default:
                        break;
                }

                /*write text*/
                _logTextBox.AppendText(header + text + "\n");
                _logTextBox.ScrollToCaret();
            }));
        }
        #endregion

        #region private funtion

        private Color getLogTextColor(LogTextColor color)
        {
            switch(color)
            {
                case LogTextColor.Default:
                    return Color.Black;
                case LogTextColor.Transmits:
                    return Color.DodgerBlue;
                case LogTextColor.Recieves:
                    return Color.Green;
                case LogTextColor.Information:
                    return Color.Blue;
                case LogTextColor.Warning:
                    return Color.Orange;
                case LogTextColor.Error:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }
        #endregion

        #region public variable

        public RichTextBox LogTextBox
        {
            set
            {
                _logTextBox = value;
            }
        }


        #endregion

    }
    
}
