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
    public partial class FormHome : Form
    {
        private bool _funtionEnable;
        private UserSerial userSerial;
        private FormProcess formProcess = new FormProcess();
        public FormHome(UserSerial serial)
        {
            InitializeComponent();

            this.userSerial = serial;
            this.userSerial.ProcessReadParamCommand += UserSerial_ProcessReadParamCommand;
            
            itemSensorAppValue.ShowItem = false;
            itemSensorAppStatus.ShowItem = false;
            itemSensorBuffer.ShowItem = false;
            itemFlowMeterSensor0.ShowItem = false;
            itemFlowMeterSensor1.ShowItem = false;
            itemBatteryLowThreshold.ShowItem = false;
            itemFWRev.ShowItem = false;
            itemGPRSStatus.ShowItem = false;
            itemSystemCode.ShowItem = false;
            itemModbusStatus.ShowItem = false;
            itemModbus.ShowItem = false;
            itemDeviceStatus.ShowItem = false;
            itemDeviceStatusValue.ShowItem = false;
            
        }

        private void UserSerial_ProcessReadParamCommand(CommandType command)
        {
            if(command.Error != 0)
            {
                return;
            }
            switch(command.Funtion)
            {
                case (byte)FuntionCode.ReadSensorAppValue:
                    itemSensorAppValue.Items[0].setText(UserApp.ConvertU32ToString(command.Args[0], command.Args[1]));
                    itemSensorAppValue.Items[1].setText(UserApp.ConvertU32ToString(command.Args[2], command.Args[3]));
                    itemSensorAppValue.Items[2].setText(UserApp.ConvertU32ToString(command.Args[4], command.Args[5]));
                    itemSensorAppValue.Items[3].setText(UserApp.ConvertU32ToString(command.Args[6], command.Args[7]));
                    itemSensorAppValue.Items[4].setText(UserApp.ConvertU32ToString(command.Args[8], command.Args[9]));
                    itemSensorAppValue.Items[5].setText(UserApp.ConvertU32ToString(command.Args[10], command.Args[11]));
                    itemSensorAppValue.Items[6].setText(UserApp.ConvertU32ToString(command.Args[12], command.Args[13]));
                    itemSensorAppValue.Items[7].setText(UserApp.ConvertU32ToString(command.Args[14], command.Args[15]));
                    formProcess.closeDiablog(true);
                    itemSensorAppValue.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadSensorAppStatus:
                    itemSensorAppStatus.Items[0].setText(command.Args[0].ToString());
                    itemSensorAppStatus.Items[1].setText(ParameterString.SensorType(command.Args[1]));
                    itemSensorAppStatus.Items[2].setText(ParameterString.SensorStatus(command.Args[2]));
                    itemSensorAppStatus.Items[3].setText(ParameterString.PowerControl(command.Args[3]));
                    formProcess.closeDiablog(true);
                    itemSensorAppStatus.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);

                    break;
                case (byte)FuntionCode.ReadFlowMeter0:
                    itemFlowMeterSensor0.Items[0].setText(UserApp.ConvertU32ToString(command.Args[0], command.Args[1]));
                    itemFlowMeterSensor0.Items[1].setText(UserApp.ConvertU32ToString(command.Args[2], command.Args[3]));
                    itemFlowMeterSensor0.Items[2].setText(UserApp.ConvertU32ToString(command.Args[4], command.Args[5]));
                    itemFlowMeterSensor0.Items[3].setText(UserApp.ConvertU32ToString(command.Args[6], command.Args[7]));
                    itemFlowMeterSensor0.Items[4].setText(UserApp.ConvertU32ToString(command.Args[8], command.Args[9]));
                    itemFlowMeterSensor0.Items[5].setText(UserApp.ConvertU32ToString(command.Args[10], command.Args[11]));
                    itemFlowMeterSensor0.Items[6].setText(UserApp.ConvertU32ToString(command.Args[12], command.Args[13]));
                    formProcess.closeDiablog(true);
                    itemFlowMeterSensor0.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadFlowMeter1:
                    itemFlowMeterSensor1.Items[0].setText(UserApp.ConvertU32ToString(command.Args[0], command.Args[1]));
                    itemFlowMeterSensor1.Items[1].setText(UserApp.ConvertU32ToString(command.Args[2], command.Args[3]));
                    itemFlowMeterSensor1.Items[2].setText(UserApp.ConvertU32ToString(command.Args[4], command.Args[5]));
                    itemFlowMeterSensor1.Items[3].setText(UserApp.ConvertU32ToString(command.Args[6], command.Args[7]));
                    itemFlowMeterSensor1.Items[4].setText(UserApp.ConvertU32ToString(command.Args[8], command.Args[9]));
                    itemFlowMeterSensor1.Items[5].setText(UserApp.ConvertU32ToString(command.Args[10], command.Args[11]));
                    itemFlowMeterSensor1.Items[6].setText(UserApp.ConvertU32ToString(command.Args[12], command.Args[13]));
                    formProcess.closeDiablog(true);
                    itemFlowMeterSensor1.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadDeviceStatus:
                    itemDeviceStatus.Items[0].setText(ParameterString.DevicePowerMode(command.Args[0]));
                    itemDeviceStatus.Items[1].setText(ParameterString.SDCardStatuts(command.Args[1]));
                    itemDeviceStatus.Items[2].setText(ParameterString.BoxStatus(command.Args[2]));
                    itemDeviceStatus.Items[3].setText(ParameterString.DataLoggingEnable(command.Args[3]));
                    itemDeviceStatus.Items[4].setText(UserApp.ConvertU32ToString(command.Args[4], command.Args[5]));
                    itemDeviceStatus.Items[5].setText(UserApp.ConvertU32ToString(command.Args[6], command.Args[7]));
                    formProcess.closeDiablog(true);
                    itemDeviceStatus.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadDeviceStatusValue:
                    itemDeviceStatusValue.Items[0].setText(((float)command.Args[0] / 100).ToString("0.00 V"));
                    itemDeviceStatusValue.Items[1].setText(((float)command.Args[1] / 100).ToString("0.00 V"));
                    itemDeviceStatusValue.Items[2].setText(UserApp.ConvertU32ToString(command.Args[2], command.Args[3]));
                    itemDeviceStatusValue.Items[3].setText(UserApp.ConvertU32ToString(command.Args[4], command.Args[5]));
                    itemDeviceStatusValue.Items[4].setText(ParameterString.GSMService(command.Args[6]));
                    itemDeviceStatusValue.Items[5].setText(command.Args[7].ToString());
                    itemDeviceStatusValue.Items[6].setText(((float)command.Args[6] / 100).ToString("0.00 C"));
                    itemDeviceStatusValue.Items[7].setText(command.Args[7].ToString());
                    formProcess.closeDiablog(true);
                    itemDeviceStatusValue.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadFirmware:
                    itemFWRev.Items[0].setText(command.Args[0].ToString());//Update FW
                    itemFWRev.Items[1].setText(UserApp.ConvertByte2String(command.Args, 1, command.NumArgs - 1));//FW Revision
                    formProcess.closeDiablog(true);
                    itemFWRev.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadSensorBuffer:
                    itemSensorBuffer.Items[0].setText(command.Args[0].ToString());// buffer count
                    itemSensorBuffer.Items[1].setText(command.Args[1].ToString());// buffer in
                    itemSensorBuffer.Items[2].setText(command.Args[2].ToString());// buffer out
                    itemSensorBuffer.Items[3].setText(UserApp.ConvertU32ToString(command.Args[3], command.Args[4]));// Send failed
                    itemSensorBuffer.Items[4].setText(UserApp.ConvertU32ToString(command.Args[5], command.Args[6]));// GSM reset
                    itemSensorBuffer.Items[5].setText(UserApp.ConvertU32ToString(command.Args[7], command.Args[8]));// total
                    formProcess.closeDiablog(true);
                    itemSensorBuffer.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadGPRSStatus:
                    itemGPRSStatus.Items[0].setText(ParameterString.GPRSStatus(command.Args[0]));//GPRS status
                    itemGPRSStatus.Items[1].setText(ParameterString.GSMStatus(command.Args[1]));//GSM status
                    formProcess.closeDiablog(true);
                    itemGPRSStatus.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadBatteryLowThreshold:
                    itemBatteryLowThreshold.Items[0].setText(((float)command.Args[0] / 100).ToString("0.00"));//battry low threshold
                    formProcess.closeDiablog(true);
                    itemBatteryLowThreshold.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadSystemCode:
                    itemSystemCode.Items[0].setText($"0x{(command.Args[0] & 0xFF):X2}");//System Init State
                    itemSystemCode.Items[1].setText($"0x{(command.Args[1] & 0xFF):X2}");//System code
                    itemSystemCode.Items[2].setText($"0x{(command.Args[2] & 0xFF):X2}");//System falie code
                    formProcess.closeDiablog(true);
                    itemSystemCode.setMessage("LAST UPDATE " + DateTime.Now.ToString("HH:mm:ss"), ConfigMessageIconEnum.Ok);
                    break;
                case (byte)FuntionCode.ReadModbusStatus:

                    break;
                case (byte)FuntionCode.ReadModbusValue:

                    break;
                default:
                    break;
            }
        }

        public bool FuntionEnable
        {
            get => _funtionEnable;
            set
            {
                _funtionEnable = value;

                panel2.Enabled = value;
            }
        }

        #region private event click
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(ButtonConnectClick != null)
            {
                ButtonConnectClick?.Invoke(sender, e);
            }

        }
        public void setButtonConnectStatus(ButtonConnect button)
        {
            this.Invoke(new Action(() =>
            {
                if (button == ButtonConnect.Connect)
                {
                    btnConnect.Text = "Connect";
                    btnConnect.Image = Properties.Resources.connection;
                }
                else
                {
                    btnConnect.Text = "Disconnect";
                    btnConnect.Image = Properties.Resources.disconnection;
                }
            }));
            
        }
        public event EventHandler ButtonConnectClick;

        private void itemSensorAppValue_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadSensorAppValue);
            formProcess = new FormProcess("Read Sensor App Value!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemSensorAppValue.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemSensorAppStatus_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadSensorAppStatus);
            formProcess = new FormProcess("Read Sensor App Status!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemSensorAppStatus.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemFlowMeterSensor0_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadFlowMeter0);
            formProcess = new FormProcess("Read Flow Meter 0!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemFlowMeterSensor0.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemFlowMeterSensor1_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadFlowMeter1);
            formProcess = new FormProcess("Read Flow Meter 1!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemFlowMeterSensor1.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemDeviceStatus_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadDeviceStatus);
            formProcess = new FormProcess("Read Device Status!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemDeviceStatus.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemDeviceStatusValue_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadDeviceStatusValue);
            formProcess = new FormProcess("Read Device Status Value!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemDeviceStatusValue.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemSensorBuffer_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadSensorBuffer);
            formProcess = new FormProcess("Read Sensor Buffer!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemSensorBuffer.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemFWRev_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadFirmware);
            formProcess = new FormProcess("Read Firmware Rev!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemFWRev.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemGPRSStatus_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadGPRSStatus);
            formProcess = new FormProcess("Read GPRS / GSM Status!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemGPRSStatus.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemBatteryLowThreshold_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadBatteryLowThreshold);
            formProcess = new FormProcess("Read Battery Low Threshold!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemBatteryLowThreshold.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemSystemCode_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadSystemCode);
            formProcess = new FormProcess("Read System Code!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemSystemCode.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemModbusStatus_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadModbusStatus);
            formProcess = new FormProcess("Read Modbus Status!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemModbusStatus.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }

        private void itemModbus_ButtonReadClick(object sender, EventArgs e)
        {
            userSerial.sendCommand((byte)FuntionCode.ReadModbusValue);
            formProcess = new FormProcess("Read Modbus Value!");
            DialogResult res = formProcess.ShowDialog();
            if (res == DialogResult.No)
            {
                itemModbus.setMessage("Read Timeout!", ConfigMessageIconEnum.Error);
            }
        }
        public event EventHandler ResetClick;
        private void btnReset_Click(object sender, EventArgs e)
        {
            if(ResetClick != null)
            {
                ResetClick?.Invoke(sender, e);
            }
            /*
            if(MessageBox.Show(this, "Want to reset device?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                userSerial.sendCommand((byte)FuntionCode.ReadModbusStatus);
            }
            */
        }
        #endregion


    }
}
