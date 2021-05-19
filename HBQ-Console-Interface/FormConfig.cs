using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBQ_Console_Interface
{
    public partial class FormConfig : Form
    {
        private UserSerial userSerial;
        private FormProcess formProcess = new FormProcess();
        private bool saveFlash = true;
        public FormConfig(UserSerial serial)
        {
            InitializeComponent();
            this.userSerial = serial;

            InitConfigItem();
        }

        #region private funtion
        private void InitConfigItem()
        {
            userSerial.ProcessConfigCommand += ProcessConfigcommand;
            userSerial.ProcessServerCommand += ProcessServerCommand;
            userSerial.ProcessGSMCommand += ProcessGSMCommand;
            userSerial.ProcessBatteryCommand += ProcessBatteryCommand;
            userSerial.ProcessFlashCommand += UserSerial_ProcessFlashCommand;

            configItemLogging.ComboBox1.AddRangeItem(new object[]
            {
                "Clear All Data and Restart Logging Enable",
                "Disable Logging Keep Old data",
                "Enable Logging Keep Old data",
            });

            configItemGSM.ComboBox1.AddRangeItem(new object[]
            {
                "VinaPhone",
                "Viettel",
                "MobiPhone",
                "AutoDetect",
            });

            configItemSerialID.textBox1.textbox.MaxLength = 4;
            configItemSerialID.textBox1.textbox.CharacterCasing = CharacterCasing.Upper;

            configItemDeviceID.textBox1.textbox.MaxLength = 6;
            configItemDeviceID.textBox1.textbox.CharacterCasing = CharacterCasing.Upper;


        }

        private void UserSerial_ProcessFlashCommand(CommandType command)
        {
            if (command.Error != 0)
            {
                switch (command.Funtion)
                {
                    case (byte)FuntionCode.FlashSaved:
                        formProcess.setMessage("Save setting fail!");
                        break;
                    case (byte)FuntionCode.FlashSetDefault:
                        formProcess.setMessage("Set default fail!");
                        break;
                    default:
                        break;
                }
            }
            switch (command.Funtion)
            {
                case (byte)FuntionCode.FlashSaved:
                    formProcess.closeDiablog(false);
                    break;
                case (byte)FuntionCode.FlashSetDefault:
                    formProcess.closeDiablog(false);
                    break;
                default:
                    break;
            }

        }

        private void pn26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProcessConfigcommand(CommandType command)
        {
            if (command.Error != 0)
            {
                switch (command.Funtion)
                {
                    case (byte)FuntionCode.ConfigEnter:
                        break;
                    case (byte)FuntionCode.ConfigExit:
                        break;
                    case (byte)FuntionCode.ConfigSetSamplingSendingRate:
                        //configItemSamplingSendding.MessageText = 
                        formProcess.closeDiablog(false);
                        configItemSamplingSendding.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigGetSamplingSendingRate:
                        formProcess.closeDiablog(false);
                        configItemSamplingSendding.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigSetSerialID:
                        formProcess.closeDiablog(false);
                        configItemSerialID.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigGetSerialID:
                        formProcess.closeDiablog(false);
                        configItemSerialID.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigSetDeviceID:
                        formProcess.closeDiablog(false);
                        configItemDeviceID.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigGetDeviceID:
                        formProcess.closeDiablog(false);
                        configItemDeviceID.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigSetLoggingMode:
                        formProcess.closeDiablog(false);
                        configItemLogging.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigGetLoggingMode:
                        formProcess.closeDiablog(false);
                        configItemLogging.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    case (byte)FuntionCode.ConfigGetAllSetting:
                        break;

                    default:
                        break;
                }
                return;
            }
            switch (command.Funtion)
            {
                case (byte)FuntionCode.ConfigEnter:
                    formProcess.closeDiablog(true);
                    break;
                case (byte)FuntionCode.ConfigExit:
                    formProcess.closeDiablog(true);
                    break;
                case (byte)FuntionCode.ConfigSetSamplingSendingRate:
                    configItemSamplingSendding.setText1(command.Args[0].ToString());
                    configItemSamplingSendding.setText2(command.Args[1].ToString());
                    formProcess.closeDiablog(true);
                    configItemSamplingSendding.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemSamplingSendding.setButtonWriteEnable(false);
                    saveFlash = false;
                    break;
                case (byte)FuntionCode.ConfigGetSamplingSendingRate:
                    configItemSamplingSendding.setText1(command.Args[0].ToString());
                    configItemSamplingSendding.setText2(command.Args[1].ToString());
                    //configItemSamplingSendding.Text1 = command.Args[0].ToString();
                    //configItemSamplingSendding.Text2 = command.Args[2].ToString();
                    formProcess.closeDiablog(true);
                    configItemSamplingSendding.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemSamplingSendding.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.ConfigSetSerialID:
                    configItemSerialID.setText1(UserApp.ConvertByte2String(command.Args, 0, 2));
                    formProcess.closeDiablog(true);
                    configItemSerialID.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemSerialID.setButtonWriteEnable(false);
                    saveFlash = false;
                    break;
                case (byte)FuntionCode.ConfigGetSerialID:
                    configItemSerialID.setText1(UserApp.ConvertByte2String(command.Args, 0, 2));
                    formProcess.closeDiablog(true);
                    configItemSerialID.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemSerialID.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.ConfigSetDeviceID:
                    formProcess.closeDiablog(true);
                    configItemDeviceID.setText1(UserApp.ConvertByte2String(command.Args, 0, 3));
                    configItemDeviceID.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemDeviceID.setButtonWriteEnable(false);
                    saveFlash = false;
                    break;
                case (byte)FuntionCode.ConfigGetDeviceID:
                    formProcess.closeDiablog(true);
                    configItemDeviceID.setText1(UserApp.ConvertByte2String(command.Args, 0, 3));
                    configItemDeviceID.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemDeviceID.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.ConfigSetLoggingMode:
                    formProcess.closeDiablog(true);
                    if (command.Args[0] == 'E')
                    {
                        configItemLogging.setText("Enable");
                    }
                    else if (command.Args[0] == 'D')
                    {
                        configItemLogging.setText("Disable");
                    }
                    configItemLogging.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemLogging.setButtonWriteEnable(false);
                    saveFlash = false;
                    break;
                case (byte)FuntionCode.ConfigGetLoggingMode:
                    formProcess.closeDiablog(true);
                    if (command.Args[0] == 'E')
                    {
                        configItemLogging.setText("Enable");
                    }
                    else if (command.Args[0] == 'D')
                    {
                        configItemLogging.setText("Disable");
                    }
                    configItemLogging.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemLogging.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.ConfigGetAllSetting:
                    formProcess.closeDiablog(true);
                    break;
                default:
                    break;
            }
        }
        private void ProcessServerCommand(CommandType command)
        {
            switch (command.Funtion)
            {
                case (byte)FuntionCode.ServerSetDAQ:
                    if (command.NumArgs < 2)
                    {
                        formProcess.closeDiablog(false);
                        configItemServer.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemServer.setText1(command.Args[0].ToString());
                    configItemServer.setText2(UserApp.ConvertByte2String(command.Args, 1, command.NumArgs - 1));
                    formProcess.closeDiablog(true);
                    configItemServer.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemServer.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.ServerGetDAQ:
                    if (command.NumArgs < 2)
                    {
                        formProcess.closeDiablog(false);
                        configItemServer.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemServer.setText1(command.Args[0].ToString());
                    configItemServer.setText2(UserApp.ConvertByte2String(command.Args, 1, command.NumArgs - 1));
                    formProcess.closeDiablog(true);
                    configItemServer.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemServer.setButtonWriteEnable(false);
                    break;
                default:
                    break;
            }
        }

        private void ProcessGSMCommand(CommandType command)
        {
            switch (command.Funtion)
            {
                case (byte)FuntionCode.GSMConfigSevicer:
                    if (command.NumArgs < 1)
                    {
                        formProcess.closeDiablog(false);
                        configItemGSM.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemGSM.setSelectedIndex((int)command.Args[0] - 1);
                    configItemGSM.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemGSM.setButtonWriteEnable(false);
                    formProcess.closeDiablog(true);
                    break;
                case (byte)FuntionCode.GSMGetSevicer:
                    if (command.NumArgs < 1)
                    {
                        formProcess.closeDiablog(false);
                        configItemGSM.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemGSM.setSelectedIndex((int)command.Args[0] - 1);
                    configItemGSM.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemGSM.setButtonWriteEnable(false);
                    formProcess.closeDiablog(true);
                    break;
                default:
                    break;
            }
        }

        private void ProcessBatteryCommand(CommandType command)
        {
            switch (command.Funtion)
            {
                case (byte)FuntionCode.BatteryConfigCoff:
                    if (command.NumArgs < 2)
                    {
                        formProcess.closeDiablog(false);
                        configItemBattery.setMessage("Write Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemBattery.setText1(command.Args[0].ToString());
                    configItemBattery.setText2(command.Args[1].ToString());
                    formProcess.closeDiablog(true);
                    configItemBattery.setMessage("Write OK!", ConfigMessageIconEnum.Ok);
                    configItemBattery.setButtonWriteEnable(false);
                    break;
                case (byte)FuntionCode.BatteryGetCoff:
                    if (command.NumArgs < 2)
                    {
                        formProcess.closeDiablog(false);
                        configItemBattery.setMessage("Read Error!", ConfigMessageIconEnum.Error);
                        break;
                    }
                    configItemBattery.setText1(command.Args[0].ToString());
                    configItemBattery.setText2(command.Args[1].ToString());
                    formProcess.closeDiablog(true);
                    configItemBattery.setMessage("Read OK!", ConfigMessageIconEnum.Ok);
                    configItemBattery.setButtonWriteEnable(false);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region public funtion

        #endregion

        #region private event
        private void btnsaveFlash_Click(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.FlashSaved);
            formProcess = new FormProcess("Save setting to flash!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemSerialID.setMessage("Save setting Timeout!", ConfigMessageIconEnum.Error);
            }
        }
        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.FlashSetDefault);
        }
        private void configItemSerialID_ButtonWriteClick(object sender, EventArgs e)
        {
            UInt16[] dat = UserApp.ConvertStrinbg2U16(configItemSerialID.Text1);
            userSerial.sendCommand((byte)FuntionCode.ConfigSetSerialID, dat, 2);
            formProcess = new FormProcess("Write Serial ID!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemSerialID.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }
        private void configItemSerialID_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ConfigGetSerialID);
            formProcess = new FormProcess("Read Serial ID!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemSerialID.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemDeviceID_ButtonWriteClick(object sender, EventArgs e)
        {
            UInt16[] dat = UserApp.ConvertStrinbg2U16(configItemDeviceID.Text1);
            userSerial.sendCommand((byte)FuntionCode.ConfigSetDeviceID, dat ,3);
            formProcess = new FormProcess("Write Device ID!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemDeviceID.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemDeviceID_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ConfigGetDeviceID);
            formProcess = new FormProcess("Read Device ID!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemDeviceID.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemSamplingSendding_ButtonWriteClick(object sender, EventArgs e)
        {
            UInt16[] data = new UInt16[2];
            data[0] = Convert.ToUInt16(configItemSamplingSendding.Text1);
            data[1] = Convert.ToUInt16(configItemSamplingSendding.Text2);
            userSerial.sendCommand((byte)FuntionCode.ConfigSetSamplingSendingRate, data, 2);
            formProcess = new FormProcess("Read Sampling rate / Sending Rate");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemSamplingSendding.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemSamplingSendding_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ConfigGetSamplingSendingRate);
            formProcess = new FormProcess("Read Sampling rate / Sending Rate");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemSamplingSendding.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemLogging_ButtonWriteClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ConfigSetLoggingMode, (UInt16)(configItemLogging.SelectedIndex + 1));
            formProcess = new FormProcess("Write Logging Mode");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemLogging.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemLogging_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ConfigGetLoggingMode);
            formProcess = new FormProcess("Read Logging Mode");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemLogging.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemServer_ButtonWriteClick(object sender, EventArgs e)
        {
            UInt16[] data = UserApp.ConvertServer2U16(configItemServer.Text1, configItemServer.Text2);
            userSerial.sendCommand((byte)FuntionCode.ServerSetDAQ, data, (byte)data.Length);
            formProcess = new FormProcess("Write Server DAQ");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemServer.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemServer_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ServerGetDAQ);
            formProcess = new FormProcess("Read Server DAQ");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemServer.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemGSM_ButtonWriteClick(object sender, EventArgs e)
        {

            userSerial.sendCommand((byte)FuntionCode.GSMConfigSevicer, (UInt16)(configItemGSM.SelectedIndex+1));
            formProcess = new FormProcess("Write GSM Service");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemGSM.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemGSM_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.GSMGetSevicer);
            formProcess = new FormProcess("Read GSM Service");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemGSM.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemBattery_ButtonWriteClick(object sender, EventArgs e)
        {
            UInt16[] data = new UInt16[2];
            data[0] = Convert.ToUInt16(configItemBattery.Text1);
            data[1] = Convert.ToUInt16(configItemBattery.Text2);
            userSerial.sendCommand((byte)FuntionCode.BatteryConfigCoff, data, 2);
            formProcess = new FormProcess("write Battery Coff");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemBattery.setMessage("Write Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void configItemBattery_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.BatteryGetCoff);
            formProcess = new FormProcess("Read Battery Coff");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                configItemBattery.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }
        #endregion

        public void setEnable(bool enable)
        {
            if(enable == true)
            {
                this.Enabled = true;
                saveFlash = true;
            }
            else
            {
                if(saveFlash == false && this.Enabled == true)
                {
                    DialogResult result =  MessageBox.Show(this, "Want to save your setting?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    saveFlash = true;
                    if (result == DialogResult.Yes)
                    {
                        userSerial.sendCommand((byte)FuntionCode.FlashSaved);
                    }
                    else
                    {
                        saveFlash = false;
                    }
                    this.Enabled = false;
                }
            }
        }
    }

}
