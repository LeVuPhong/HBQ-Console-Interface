using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace HBQ_Console_Interface
{
    public partial class Form1 : Form
    {
        FormConfig formConfig;
        FormHome formHome;
        FormConsole formConsole;
        UserSerial userSerial;

        FormProcess formProcess;
        ConnectTime connectTime = new ConnectTime();

        private MenuButtonIndex MenuButtonSelection;
        private DeviceConnectEnum deviceConnectStatus = DeviceConnectEnum.Diconnect;
        private int lostConnect = 0;
        private long lastConnect = 0;
        public Form1()
        {
            InitializeComponent();

            /*init serial*/
            userSerial = new UserSerial(btnConnectPort, cbxCOMPort.combobox, cbxBaudRate.combobox, cbxDataBits.combobox, cbxParity.combobox, cbxStopBits.combobox);
            userSerial.Terminal.LogTextBox = txtTerminal;
            userSerial.Console.LogTextBox = txtConsole;
            userSerial.OnChangeOpen += UserSerial_OnChangeOpen;
            userSerial.ProcessDeviceCommand += ProcessDeviceCommand;
            userSerial.setSignal(pannelTX, pannelRX);

            /*set form config*/
            formConfig = new FormConfig(userSerial);
            formConfig.TopLevel = false;
            splitContainer1.Panel1.Controls.Add(formConfig);
            formConfig.Dock = DockStyle.Fill;
            formConfig.Show();
            formConfig.Visible = false;

            /*set form Home*/
            formHome = new FormHome(userSerial);
            formHome.TopLevel = false;
            splitContainer1.Panel1.Controls.Add(formHome);
            formHome.Dock = DockStyle.Fill;
            formHome.Show();
            formHome.Visible = false;
            formHome.ButtonConnectClick += FormHome_ButtonConnectClick;
            formHome.ResetClick += FormHome_ResetClick;

            /*set form Console*/
            formConsole = new FormConsole(userSerial, connectTime);
            formConsole.TopLevel = false;
            splitContainer1.Panel1.Controls.Add(formConsole);
            formConsole.Dock = DockStyle.Fill;
            formConsole.Show();
            formConsole.Visible = false;

            panel7.SendToBack();

            
        }

        private void FormHome_ResetClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Want to reset device?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userSerial.sendWakeup();
                Thread.Sleep(50);
                userSerial.sendCommand((byte)FuntionCode.DeviceReset);
                DeviceConnectStatus = DeviceConnectEnum.Diconnect;

            }
        }

        private void FormHome_ButtonConnectClick(object sender, EventArgs e)
        {
            if(DeviceConnectStatus != DeviceConnectEnum.ConnectedNomal)
            {
                userSerial.sendWakeup();
                Thread.Sleep(50);
                if (userSerial.sendCommand((byte)FuntionCode.DeviceConnect, (UInt16)DeviceConnectParam.ConnectNomal) == false) return;
                DeviceConnectStatus = DeviceConnectEnum.RequestConnect;
                formProcess = new FormProcess("Connect to Device!", 40000);
                if(formProcess.ShowDialog() != DialogResult.OK)
                {
                    DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                }
            }
            else
            {
                if (userSerial.sendCommand((byte)FuntionCode.DeviceDisconnect) == false) return;
                DeviceConnectStatus = DeviceConnectEnum.Diconnect;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetMenuButton(MenuButtonIndex.Home);
            DeviceConnectStatus = DeviceConnectEnum.Diconnect;
        }

        private void UserSerial_OnChangeOpen(bool isOpen)
        {
            if(isOpen == false)
            {
                DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                MessageBox.Show(this, "Serial port is close!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetMenuButton(MenuButtonIndex.Home);
            }
        }

        /*
private void ProcessResponseData(CommandType command)
{
   if (command.Error == (byte)ErrorCode.CRC_Wrong)
   {
       userSerial.Console.WriteLine("Request failed: wrong CRC", LogTextColor.Error);
       return;
   }
   switch (command.Funtion & 0xF0)
   {
       case (byte)FuntionCode.DeviceFuntion:
           break;
       case (byte)FuntionCode.ConfigFuntion:
           ProcessConfigcommand(command);
           break;
       case (byte)FuntionCode.TestFuntion:
           break;
       case (byte)FuntionCode.GSMFuntion:
           ProcessGSMCommand(command);
           break;
       case (byte)FuntionCode.ServerFuntion:
           break;
       case (byte)FuntionCode.BatteryFuntion:
           break;
       default:
           break;

   }
}
*/
        private void ProcessDeviceCommand(CommandType command)
        {
            this.Invoke(new Action(() =>
            {
                switch (command.Funtion)
                {
                    case (byte)FuntionCode.DeviceConnect:
                        if (command.NumArgs == 0) break;

                        if (DeviceConnectStatus == DeviceConnectEnum.RequestConnect)
                        {
                            if (command.Args[0] == (UInt16)DeviceConnectParam.ConnectUnderReset)
                            {
                                DeviceConnectStatus = DeviceConnectEnum.ConnectedUnderReset;
                                formProcess.closeDiablog(true);
                            }
                            else if (command.Args[0] == (UInt16)DeviceConnectParam.ConnectNomal)
                            {
                                DeviceConnectStatus = DeviceConnectEnum.ConnectedNomal;
                                formProcess.closeDiablog(true);
                            }
                            //lastConnect = DateTime.Now.Ticks;
                            connectTime.Update();
                        }
                        else
                        {
                            //lastConnect = DateTime.Now.Ticks;
                            //Console.WriteLine(lastConnect);
                            connectTime.Update();
                        }
                        break;
                    case (byte)FuntionCode.DeviceDisconnect:
                        if(DeviceConnectStatus != DeviceConnectEnum.Diconnect)
                            DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                        MessageBox.Show(this, "Device Disconnected!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetMenuButton(MenuButtonIndex.Home);
                        break;
                    case (byte)FuntionCode.DeviceReset:

                        break;
                    default:
                        break;
                }
            }));
            
        }

        

        private void ProcessTestCommand(CommandType command)
        {
            switch(command.Funtion)
            {
                case (byte)FuntionCode.TestEnter:
                    break;
                case (byte)FuntionCode.TestGSM:
                    break;
                case (byte)FuntionCode.TestPowerSensor:
                    break;
                case (byte)FuntionCode.TestGPRS3G:
                    break;
                case (byte)FuntionCode.TestReadExternalFlash:
                    break;
                case (byte)FuntionCode.TestPerformance:
                    break;
                case (byte)FuntionCode.TestPulseIn:
                    break;
                case (byte)FuntionCode.TestSDCard:
                    break;
                case (byte)FuntionCode.TestSensorOut:
                    break;
                case (byte)FuntionCode.TestFlowSensor:
                    break;
                default:
                    break;
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {

            if (MenuButtonSelection != MenuButtonIndex.Home)
            {
                DialogResult dialogResult = new DialogResult();
                if (MenuButtonSelection == MenuButtonIndex.Console)
                    dialogResult = MessageBox.Show(this, "Do you want to exit test mode", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (MenuButtonSelection == MenuButtonIndex.Config)
                    dialogResult = MessageBox.Show(this, "Do you want to exit config mode", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    
                    DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                    MenuButtonSelection = MenuButtonIndex.Home;
                    SetMenuButton(MenuButtonSelection);
                    userSerial.sendCommand((byte)FuntionCode.DeviceDisconnect);
                }

            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if(DeviceConnectStatus != DeviceConnectEnum.ConnectedUnderReset)
            {
                if(MessageBox.Show(this, "Connect device to config\nDo you want to reset devive?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userSerial.sendWakeup();
                    Thread.Sleep(50);
                    if (userSerial.sendCommand((byte)FuntionCode.DeviceConnect, (byte)DeviceConnectParam.ConnectUnderReset) == false) return;
                    DeviceConnectStatus = DeviceConnectEnum.RequestConnect;
                    SetMenuButton(MenuButtonIndex.Config);
                    formProcess = new FormProcess("Connect device to config", 30000);
                    if(formProcess.ShowDialog() != DialogResult.OK)
                    {
                        DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                        SetMenuButton(MenuButtonIndex.Home);
                    }
                }
            }
            else
            {
                SetMenuButton(MenuButtonIndex.Config);
            }
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            FormPassword password = new FormPassword();
            if (password.ShowDialog() != DialogResult.OK) return;
            if (DeviceConnectStatus != DeviceConnectEnum.ConnectedUnderReset)
            {
                if (MessageBox.Show(this, "Connect device to Console\nDo you want to reset devive?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userSerial.sendWakeup();
                    Thread.Sleep(50);
                    if (userSerial.sendCommand((byte)FuntionCode.DeviceConnect, (byte)DeviceConnectParam.ConnectUnderReset) == false) return;
                    DeviceConnectStatus = DeviceConnectEnum.RequestConnect;
                    SetMenuButton(MenuButtonIndex.Console);
                    formProcess = new FormProcess("Connect device to Console", 30000);
                    if (formProcess.ShowDialog() != DialogResult.OK)
                    {
                        DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                        SetMenuButton(MenuButtonIndex.Home);
                    }
                }
            }
            else
            {
                SetMenuButton(MenuButtonIndex.Console);
            }
        }

        private void SetMenuButton(MenuButtonIndex index)
        {
            MenuButtonSelection = index;
            switch (index)
            {
                case MenuButtonIndex.Home:
                    MenuHomeShow(true);
                    MenuConfigShow(false);
                    MenuConsoleShow(false);
                    break;
                case MenuButtonIndex.Config:
                    MenuHomeShow(false);
                    MenuConfigShow(true);
                    MenuConsoleShow(false);
                    break;
                case MenuButtonIndex.Console:
                    MenuHomeShow(false);
                    MenuConfigShow(false);
                    MenuConsoleShow(true);
                    break;
            }

        }
        private void MenuConfigShow(bool show)
        {
            if (show)
            {
                btnConfig.BackColor = Color.White;
                btnConfig.Image = Properties.Resources.settings_cv;
                formConfig.Visible = true;
                lbMenuName.Text = "Configuration";
            }
            else
            {
                btnConfig.BackColor = Color.FromArgb(21, 129, 150);
                btnConfig.Image = Properties.Resources.settings;
                formConfig.Visible = false;
            }
        }

        private void MenuHomeShow(bool show)
        {
            if (show)
            {
                btnHome.BackColor = Color.White;
                btnHome.Image = Properties.Resources.home_cv;
                formHome.Visible = true;
                lbMenuName.Text = "Home";
            }
            else
            {
                btnHome.BackColor = Color.FromArgb(21, 129, 150);
                btnHome.Image = Properties.Resources.home;
                formHome.Visible = false;
            }

        }
        private void MenuConsoleShow(bool show)
        {
            if (show)
            {
                btnConsole.BackColor = Color.White;
                btnConsole.Image = Properties.Resources.test_cv;
                formConsole.Visible = true;
                lbMenuName.Text = "Console";
            }
            else
            {
                btnConsole.BackColor = Color.FromArgb(21, 129, 150);
                btnConsole.Image = Properties.Resources.test;
                formConsole.Visible = false;
            }

        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void btnClearTerminal_Click(object sender, EventArgs e)
        {
            txtTerminal.Clear();
        }

        private void setDeviceConnectsatus()
        {
            this.Invoke(new Action(() =>
            {
                if (deviceConnectStatus == DeviceConnectEnum.ConnectedUnderReset)
                {
                    formConfig.setEnable(true);
                    formConsole.Enabled = true;
                    formHome.FuntionEnable = false;
                    timer1.Start();
                    //lostConnect = 0;
                }
                else if (deviceConnectStatus == DeviceConnectEnum.ConnectedNomal)
                {
                    formConfig.setEnable(false);
                    formConsole.Enabled = false;
                    formHome.FuntionEnable = true;
                    timer1.Start();
                    //lostConnect = 0;
                    formHome.setButtonConnectStatus(ButtonConnect.Disconnect);
                }
                else if (deviceConnectStatus == DeviceConnectEnum.Diconnect)
                {
                    formConfig.setEnable(false);
                    formConsole.Enabled = false;
                    formHome.FuntionEnable = false;
                    timer1.Stop();
                    //lostConnect = 0;
                    formHome.setButtonConnectStatus(ButtonConnect.Connect);
                }
            }));
        }

        private DeviceConnectEnum DeviceConnectStatus
        {
            get => deviceConnectStatus;
            set
            {
                deviceConnectStatus = value;
                setDeviceConnectsatus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //long subTick = DateTime.Now.Ticks - lastConnect;
            //if (subTick > TimeSpan.FromSeconds(10).Ticks)
            if(connectTime.DifferenceTick(20))
            {
                DeviceConnectStatus = DeviceConnectEnum.Diconnect;
                MessageBox.Show(this, "Lost Connect To Device!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetMenuButton(MenuButtonIndex.Home);
            }
            else if(connectTime.DifferenceTick(4))
            {
                //lostConnect++;
                userSerial.sendCommand((byte)FuntionCode.DeviceConnect, (UInt16)DeviceConnectParam.RequestConnect);
            }
            
            //userSerial.sendCommand((byte)FuntionCode.DeviceConnect, (UInt16)DeviceConnectParam.RequestConnect);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.InitialDirectory = @"C:/";
                //saveFileDialog1.FileName = labelScript.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.OpenFile());
                    streamWriter.WriteLine(txtConsole.Text);
                    streamWriter.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
