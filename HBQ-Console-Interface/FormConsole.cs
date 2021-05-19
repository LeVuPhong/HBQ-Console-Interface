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

namespace HBQ_Console_Interface
{
    public partial class FormConsole : Form
    {
        private UserSerial userSerial;
        private FormProcess formProcess = new FormProcess();
        private byte cycleFuntion;
        private Timer timerCycle = new Timer();
        private bool sendCycle = false;
        private ConnectTime connectTime;
        private TestMode testMode = TestMode.None;
        private bool testTimeOut = false;
        private int lostTest = 0;
        private int statusTimeoutDefault = 3000;
        public FormConsole(UserSerial serial, ConnectTime time)
        {
            InitializeComponent();

            this.userSerial = serial;
            userSerial.ProcessTestCommand += UserSerial_ProcessTestCommand;
            //userSerial.ProcessDeviceCommand += UserSerial_ProcessDeviceCommand;
            timerCycle.Tick += TimerCycle_Tick;

            this.connectTime = time;

            testVSensor.comboBox.Items.AddRange(new object[]
            {
                "Turn On",
                "Turn Off",
            });
            testVSensor.comboBox.SelectedIndex = 0;

            testPerformance.comboBox.Items.AddRange(new object[]
            {
                "Stop Mode",
                "Standby Mode",
                "Turn On GSM",
                "Turn Off GSM",
                "Reset GSM",
                "Sleep GSM",
            });
            testVSensor.comboBox.SelectedIndex = 0;
        }

        private void UserSerial_ProcessDeviceCommand(CommandType command)
        {
            if (this.Enabled == false) return;
            this.Invoke(new Action(() =>
            {
                if(TestingMode != TestMode.None && testTimeOut)
                {
                    if(command.Funtion == (byte)FuntionCode.DeviceConnect)
                    {
                        TestingMode = TestMode.None;
                        //testTimeOut = false;
                        //timer1.Stop();
                        setTimerStatus(false, 0);
                    }
                }
            }));
        }
        private void TimerCycle_Tick(object sender, EventArgs e)
        {
            if(userSerial.IsOpen && this.Enabled)
            {
                if(userSerial.sendCommand(cycleFuntion))
                {
                    setTestConloseText(cycleFuntion, TestStatus.Start);
                }
            }
            else
            {
                timerCycle.Stop();
            }
        }

        private void UserSerial_ProcessTestCommand(CommandType command)
        {
            if (this.Enabled == false) return;
            //this.Invoke(new ProcessDataEventHandler(ProcessTestCommand));
            this.Invoke(new Action(() =>
            {
                if (command.NumArgs < 1) return; //khung loi - in thieu arg
                connectTime.Update();
                lostTest = 0;
                if (command.Funtion == (byte)FuntionCode.TestResStatus)
                {
                    setTestConloseText((byte)command.Args[0], TestStatus.Testting);
                    connectTime.Lock = true;
                    testTimeOut = false;
                    return;
                }
                if (command.Args[0] == 1)//wait status
                {
                    setTestConloseText(command.Funtion, TestStatus.Start);
                    setTestingMode(command.Funtion);
                    //connectTime.Lock = true;
                    testTimeOut = false;
                    //timer1.Start();
                    setTimerStatus(true, statusTimeoutDefault);
                }
                else if(command.Args[0] == 0xFF)//ens test
                {
                    
                    if(command.Funtion == (byte)FuntionCode.TestPulseIn || command.Funtion == (byte)FuntionCode.TestPowerSensor)
                    {
                        setTestConloseText(command.Funtion, TestStatus.End, command.Args, 1, command.NumArgs - 1);
                        //connectTime.Lock = true;
                        testTimeOut = false;
                    }
                    else
                    {
                        setTestConloseText(command.Funtion, TestStatus.End, command.Args, 1, command.NumArgs - 1);
                        setTestingMode((byte)0);
                        setTimerStatus(false, 0);
                    }
                    /*
                    setTestConloseText(command.Funtion, TestStatus.End, command.Args, 1, command.NumArgs - 1);
                    setTestingMode((byte)0);
                    setTimerStatus(false, 0);
                    */
                    //if(command.NumArgs >= 2)
                }
                /*
                switch (command.Funtion)
                {
                    case (byte)FuntionCode.TestResStatus:
                        if (command.NumArgs < 1) break;//loi khung
                        lostTest = 0;
                        if (command.Args[1] == 1)
                        {
                            setTestConloseText((byte)command.Args[0], TestStatus.Start);
                            //TestConsoleWrite("UI: > Start test GSM\n");
                            setTestingMode((byte)command.Args[0]);
                            connectTime.Lock = true;
                            testTimeOut = false;
                            timer1.Start();
                        }
                        else if (command.Args[1] == 2)
                        {
                            //TestConsoleWrite("UI: > GSM testing\n");
                            setTestConloseText((byte)command.Args[0], TestStatus.Testting);
                            connectTime.Lock = true;
                            testTimeOut = false;
                        }
                        if (command.Args[1] == 3)//end
                        {
                            //TestConsoleWrite("UI: > End test GSM\n");
                            setTestConloseText((byte)command.Args[0], TestStatus.End);
                            setTestingMode((byte)0);
                            connectTime.Lock = false;
                            timer1.Stop();
                        }
                        break;
                    case (byte)FuntionCode.TestGSM:
                        //TestConsoleWrite("UI: > API test GSM", LogTextColor.Information);
                        //if(command)
                        break;
                    case (byte)FuntionCode.TestPowerSensor:

                        break;
                    case (byte)FuntionCode.TestGPRS3G:
                        TestConsoleWrite("UI: > API test GPRS / 3G", LogTextColor.Information);
                        break;
                    case (byte)FuntionCode.TestSDCard:
                        break;
                    case (byte)FuntionCode.TestPulseIn:
                        break;
                    case (byte)FuntionCode.TestSensorOut:
                        break;
                    case (byte)FuntionCode.TestFlowSensor:
                        break;
                    case (byte)FuntionCode.TestPerformance:
                        break;
                    case (byte)FuntionCode.TestEraseExternalFlash:
                        break;
                    case (byte)FuntionCode.TestReadExternalFlash:
                        break;
                    default:
                        break;
                }
                connectTime.Update();
                */
            }));
        }
        private void setTestConloseText(TestMode mode, TestStatus status)
        {
            string msg = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss") +" UI: > ";
            //LogTextColor textcolor;
            switch(mode)
            {
                case TestMode.GSM:
                    msg += "GSM ";
                    break;
                case TestMode.PowerSensor:
                    msg += "Power Sensor ";
                    break;
                case TestMode.GPRS:
                    msg += "GPRS / 3G ";
                    break;
                case TestMode.SDCard:
                    msg += "SD Card ";
                    break;
                case TestMode.PulseIn:
                    msg += "Pulse In ";
                    break;
                case TestMode.SensorOut:
                    msg += "Sensor Out ";
                    break;
                case TestMode.FlowSensor:
                    msg += "Flow Sensor ";
                    break;
                case TestMode.Performance:
                    msg += "Performance ";
                    break;
                case TestMode.EraseFlash:
                    msg += "Erase Flash ";
                    break;
                case TestMode.ReadFlash:
                    msg += "Read Flash ";
                    break;
            }

            switch(status)
            {
                case TestStatus.Start:
                    msg += "Start Test";
                    TestConsoleWrite(msg, LogTextColor.Recieves);
                    break;
                case TestStatus.Testting:
                    msg += "Testting";
                    TestConsoleWrite(msg, LogTextColor.Information);
                    break;
                case TestStatus.End:
                    msg += "End Test";
                    TestConsoleWrite(msg, LogTextColor.Warning);
                    break;
                case TestStatus.TimeOut:
                    msg += "Timeout";
                    TestConsoleWrite(msg, LogTextColor.Error);
                    return;
            }

            
        }
        private void setTestConloseText(byte mode, TestStatus status)
        {
            string msg = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss") + " UI: > ";

            switch (mode)
            {
                case (byte)TestMode.GSM:
                    msg += "GSM ";
                    break;
                case (byte)TestMode.PowerSensor:
                    msg += "Power Sensor ";
                    break;
                case (byte)TestMode.GPRS:
                    msg += "GPRS / 3G ";
                    break;
                case (byte)TestMode.SDCard:
                    msg += "SD Card ";
                    break;
                case (byte)TestMode.PulseIn:
                    msg += "Pulse In ";
                    break;
                case (byte)TestMode.SensorOut:
                    msg += "Sensor Out ";
                    break;
                case (byte)TestMode.FlowSensor:
                    msg += "Flow Sensor ";
                    break;
                case (byte)TestMode.Performance:
                    msg += "Performance ";
                    break;
                case (byte)TestMode.EraseFlash:
                    msg += "Erase Flash ";
                    break;
                case (byte)TestMode.ReadFlash:
                    msg += "Read Flash ";
                    break;
            }

            switch (status)
            {
                case TestStatus.Start:
                    msg += "Start Test";
                    TestConsoleWrite(msg, LogTextColor.Recieves);
                    break;
                case TestStatus.Testting:
                    msg += "Testting";
                    TestConsoleWrite(msg, LogTextColor.Information);
                    break;
                case TestStatus.End:
                    msg += "End Test";
                    TestConsoleWrite(msg, LogTextColor.Warning);
                    break;
                case TestStatus.TimeOut:
                    msg += "Timeout";
                    TestConsoleWrite(msg, LogTextColor.Error);
                    return;
            }

            //TestConsoleWrite(msg, LogTextColor.Information);
        }
        private void setTestConloseText(byte mode, TestStatus status, UInt16[] result, int startIndex, int count)
        {
            string msg = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss") + " UI: > ";

            switch (mode)
            {
                case (byte)TestMode.GSM:
                    msg += "GSM ";
                    break;
                case (byte)TestMode.PowerSensor:
                    msg += "Power Sensor ";
                    break;
                case (byte)TestMode.GPRS:
                    msg += "GPRS / 3G ";
                    break;
                case (byte)TestMode.SDCard:
                    msg += "SD Card ";
                    break;
                case (byte)TestMode.PulseIn:
                    msg += "Pulse In ";
                    break;
                case (byte)TestMode.SensorOut:
                    msg += "Sensor Out ";
                    break;
                case (byte)TestMode.FlowSensor:
                    msg += "Flow Sensor ";
                    break;
                case (byte)TestMode.Performance:
                    msg += "Performance ";
                    break;
                case (byte)TestMode.EraseFlash:
                    msg += "Erase Flash ";
                    break;
                case (byte)TestMode.ReadFlash:
                    msg += "Read Flash ";
                    break;
            }

            switch (status)
            {
                case TestStatus.Start:
                    msg += "Start Test - Status ";
                    //TestConsoleWrite(msg, LogTextColor.Recieves);
                    break;
                case TestStatus.Testting:
                    msg += "Testting - Status ";
                    //TestConsoleWrite(msg, LogTextColor.Recieves);
                    break;
                case TestStatus.End:
                    msg += "End Test - Result ";
                    //TestConsoleWrite(msg, LogTextColor.Recieves);
                    break;
            }
            if(count >= 1)
            {
                msg += "[";
                for (int i = startIndex; i < (startIndex + count); i++)
                {
                    msg += result[i].ToString();
                }
                msg += ", ]";
            }
            
            TestConsoleWrite(msg, LogTextColor.Information);
        }
        private void EnableSendCycle(TestItem testItem,byte funtion)
        {
            if(sendCycle == false)
            {
                userSerial.sendCommand(funtion);
                cycleFuntion = funtion;
                timerCycle.Interval = testItem.Cycle * 1000;
                timerCycle.Start();
                sendCycle = true;
                testItem.ButtonFlag = ButtonStatus.Stop;
            }
            else
            {
                MessageBox.Show(this, "You are in another test mode!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                testItem.ButtonFlag = ButtonStatus.Start;
            }
        }
        private void DisableSendCycle(TestItem testItem)
        {
            timerCycle.Stop();
            sendCycle = false;
            testItem.ButtonFlag = ButtonStatus.Start;
        }
        private void ProcessTestCommand(CommandType command)
        {
            testGSM.Title = "ProcessTestCommand";
        }

        private void testGSM_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestGSM);
            }
        }

        private void testPower_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None || TestingMode == TestMode.PowerSensor)
            {
                if (testPower.ButtonFlag == ButtonStatus.Start)
                {
                    //userSerial.sendCommand((byte)FuntionCode.TestPowerSensor);
                    //testPower.ButtonFlag = ButtonStatus.Stop;
                    EnableSendCycle(testPower, (byte)FuntionCode.TestPowerSensor);
                    setTestConloseText((byte)FuntionCode.TestPowerSensor, TestStatus.Start);
                    setTestingMode((byte)FuntionCode.TestPowerSensor);
                    testTimeOut = false;
                    setTimerStatus(true, testPower.Cycle * 2000);
                }
                else
                {
                    DisableSendCycle(testPower);
                    setTestConloseText((byte)FuntionCode.TestPowerSensor, TestStatus.End);
                    setTestingMode(0);
                    setTimerStatus(false, 0);
                }
            }
        }

        private void testGPRS_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestGPRS3G);
            }
        }

        private void testSDCard_ButtonClick(object sender, EventArgs e)
        {
            if(TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestSDCard);
            }
        }

        private void testPulse_ButtonClick(object sender, EventArgs e)
        {
            if(TestingMode == TestMode.None || TestingMode == TestMode.PulseIn)
            {
                if (testPulse.ButtonFlag == ButtonStatus.Start)
                {
                    //userSerial.sendCommand((byte)FuntionCode.TestPulseIn);
                    //testPulse.ButtonFlag = ButtonStatus.Stop;
                    EnableSendCycle(testPulse, (byte)FuntionCode.TestPulseIn);
                    setTestConloseText((byte)FuntionCode.TestPulseIn, TestStatus.Start);
                    setTestingMode((byte)FuntionCode.TestPulseIn);
                    testTimeOut = false;
                    setTimerStatus(true, testPulse.Cycle * 2000);
                }
                else
                {
                    DisableSendCycle(testPulse);
                    setTestConloseText((byte)FuntionCode.TestPulseIn, TestStatus.End);
                    setTestingMode(0);
                    setTimerStatus(false, 0);
                }
            }
            
        }

        private void testFlowSensor_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestFlowSensor);
            }
        }

        private void testPerformance_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestPerformance);
            }
        }

        private void testEraseFlash_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestEraseExternalFlash);
            }
        }

        private void testReadFlash_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                userSerial.sendCommand((byte)FuntionCode.TestReadExternalFlash);
            }
        }

        private void testVSensor_ButtonClick(object sender, EventArgs e)
        {
            if (TestingMode == TestMode.None)
            {
                if(userSerial.sendCommand((byte)FuntionCode.TestSensorOut, (UInt16)(testVSensor.comboBox.SelectedIndex + 1)))
                {
                    setTestConloseText((byte)FuntionCode.TestSensorOut, TestStatus.Start);
                }
            }
        }
        private void TestConsoleWrite(string value)
        {
            txtTestConsole.AppendText(value);
            txtTestConsole.ScrollToCaret();
        }
        private void TestConsoleWrite(string value, LogTextColor color)
        {
            txtTestConsole.SelectionColor = getTextColor(color);
            txtTestConsole.AppendText(value + "\n");
            txtTestConsole.ScrollToCaret();
        }
        private TestMode TestingMode
        {
            get => testMode;
            set
            {
                testMode = value;
                TestingModeChange(value);
            }
        }
        private void TestingModeChange(TestMode mode)
        {
            if(mode == TestMode.None)
            {
                testMode = TestMode.None;
                testGSM.Enabled = true;
                testGPRS.Enabled = true;
                testFlowSensor.Enabled = true;
                testPerformance.Enabled = true;
                testPower.Enabled = true;
                testPulse.Enabled = true;
                testSDCard.Enabled = true;
                testVSensor.Enabled = true;
                testReadFlash.Enabled = true;
                testEraseFlash.Enabled = true;
                return;
            }
            testGSM.Enabled = false;
            testGPRS.Enabled = false;
            testFlowSensor.Enabled = false;
            testPerformance.Enabled = false;
            testPower.Enabled = false;
            testPulse.Enabled = false;
            testSDCard.Enabled = false;
            testVSensor.Enabled = false;
            testReadFlash.Enabled = false;
            testEraseFlash.Enabled = false;
            
            switch(mode)
            {
                case TestMode.GSM:
                    testGSM.Enabled = true;
                    break;
                case TestMode.GPRS:
                    testGPRS.Enabled = true;
                    break;
                case TestMode.PowerSensor:
                    testPower.Enabled = true;
                    break;
                case TestMode.PulseIn:
                    testPulse.Enabled = true;
                    break;
                case TestMode.SDCard:
                    testSDCard.Enabled = true;
                    break;
                case TestMode.SensorOut:
                    testVSensor.Enabled = true;
                    break;
                case TestMode.FlowSensor:
                    testFlowSensor.Enabled = true;
                    break;
                case TestMode.Performance:
                    testPerformance.Enabled = true;
                    break;
                case TestMode.EraseFlash:
                    testEraseFlash.Enabled = true;
                    break;
                case TestMode.ReadFlash:
                    testReadFlash.Enabled = true;
                    break;
                default:
                    testMode = TestMode.None;
                    break;
            }
        }
        private void setTestingMode(byte mode)
        {
            if (mode == (byte)TestMode.None)
            {
                testMode = TestMode.None;
                testGSM.Enabled = true;
                testGPRS.Enabled = true;
                testFlowSensor.Enabled = true;
                testPerformance.Enabled = true;
                testPower.Enabled = true;
                testPulse.Enabled = true;
                testSDCard.Enabled = true;
                testVSensor.Enabled = true;
                testReadFlash.Enabled = true;
                testEraseFlash.Enabled = true;
                return;
            }
            testGSM.Enabled = false;
            testGPRS.Enabled = false;
            testFlowSensor.Enabled = false;
            testPerformance.Enabled = false;
            testPower.Enabled = false;
            testPulse.Enabled = false;
            testSDCard.Enabled = false;
            testVSensor.Enabled = false;
            testReadFlash.Enabled = false;
            testEraseFlash.Enabled = false;

            switch (mode)
            {
                case (byte)TestMode.GSM:
                    testGSM.Enabled = true;
                    testMode = TestMode.GSM;
                    break;
                case (byte)TestMode.GPRS:
                    testGPRS.Enabled = true;
                    testMode = TestMode.GPRS;
                    break;
                case (byte)TestMode.PowerSensor:
                    testPower.Enabled = true;
                    testMode = TestMode.PowerSensor;
                    break;
                case (byte)TestMode.PulseIn:
                    testPulse.Enabled = true;
                    testMode = TestMode.PulseIn;
                    break;
                case (byte)TestMode.SDCard:
                    testSDCard.Enabled = true;
                    testMode = TestMode.SDCard;
                    break;
                case (byte)TestMode.SensorOut:
                    testVSensor.Enabled = true;
                    testMode = TestMode.SensorOut;
                    break;
                case (byte)TestMode.FlowSensor:
                    testFlowSensor.Enabled = true;
                    testMode = TestMode.FlowSensor;
                    break;
                case (byte)TestMode.Performance:
                    testPerformance.Enabled = true;
                    testMode = TestMode.Performance;
                    break;
                case (byte)TestMode.EraseFlash:
                    testEraseFlash.Enabled = true;
                    testMode = TestMode.EraseFlash;
                    break;
                case (byte)TestMode.ReadFlash:
                    testReadFlash.Enabled = true;
                    testMode = TestMode.ReadFlash;
                    break;
                default:
                    testMode = TestMode.None;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lostTest > 1)
            {
                testTimeOut = true;
                //timer1.Stop();
                //TestingMode = TestMode.None;
                //connectTime.Lock = false;
                connectTime.Update();
                //MessageBox.Show(this, "Test Timeout!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //TestConsoleWrite("Time Out!\n");
                setTestConloseText(TestingMode, TestStatus.TimeOut);
                if(lostTest > 6)
                {
                    if(TestingMode == TestMode.PulseIn)
                    {
                        DisableSendCycle(testPulse);
                    }
                    else if(TestingMode == TestMode.PowerSensor)
                    {
                        DisableSendCycle(testPower);
                    }
                    setTestingMode(0);
                    //connectTime.Lock = false;
                    //timer1.Stop();
                    setTimerStatus(false, 0);
                }
            }
            lostTest++;
        }
        private Color getTextColor(LogTextColor color)
        {
            switch (color)
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

        private void FormConsole_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled == false)
            {
                if (TestingMode == TestMode.PulseIn)
                {
                    DisableSendCycle(testPulse);
                }
                else if (TestingMode == TestMode.PowerSensor)
                {
                    DisableSendCycle(testPower);
                }
                setTestingMode(0);
                //connectTime.Lock = false;
                //timer1.Stop();
                setTimerStatus(false, 0);
            }
        }
        private void setTimerStatus(bool run, int timeout)
        {
            if(run == true)
            {
                timer1.Interval = timeout;
                timer1.Start();
                if(timeout > 4000)
                {
                    connectTime.Lock = false;
                }
                else
                {
                    connectTime.Lock = true;
                }
                
            }
            else
            {
                timer1.Stop();
                connectTime.Lock = false;
            }
        }

        private void btnExportTestConsole_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.InitialDirectory = @"C:/";
                //saveFileDialog1.FileName = labelScript.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.OpenFile());
                    streamWriter.WriteLine(txtTestConsole.Text);
                    streamWriter.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearTestConsole_Click(object sender, EventArgs e)
        {
            txtTestConsole.Clear();
        }
    }
}
