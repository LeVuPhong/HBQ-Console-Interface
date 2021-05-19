using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBQ_Console_Interface
{
    public enum DeviceConnectState
    {
        Disconnect = 0,
        Connected = 1,
        Conneting = 2,
    }

    public enum DeviceConnectParam
    {
        RequestConnect = 0,
        ConnectNomal = 1,
        ConnectUnderReset = 2,
    }

    public enum ErrorCode
    {
        No_Error = 0x00,
        TimeOut = 0x01,
        CRC_Wrong = 0x02,
        Param_Wrong = 0x03,
        ID_CMD_Wrong = 0x04,
        Set_Value_Error = 0x05,
        Res_Error = 0xFF,
    }
    public enum CMDIndex
    {
        Type = 0,
        Funtion = 1,
        Lenght = 2,
        LenghtRes = 3,
        Error = 2,
        ResData = 4,
        NotifData = 4,
        ReqCKA = 3,
        ReqCKB = 4,
        ResCKA = 4,
        ResCKB = 5,
        NotifiCKA = 3,
        NotifiCKB = 4,
    };
    public enum FuntionCode
    {
        DeviceFuntion = 0x10,
        DeviceReset = 0x11,
        DeviceConnect = 0x12,
        DeviceDisconnect = 0x13,

        ConfigFuntion = 0x30,
        ConfigEnter = 0x31,
        ConfigExit = 0x32,
        ConfigSetSamplingSendingRate = 0x33,
        ConfigGetSamplingSendingRate = 0x34,
        ConfigSetSerialID = 0x35,
        ConfigGetSerialID = 0x36,
        ConfigSetDeviceID = 0x37,
        ConfigGetDeviceID = 0x38,
        ConfigSetLoggingMode = 0x39,
        ConfigGetLoggingMode = 0x3A,
        ConfigGetAllSetting = 0x3F,

        ServerFuntion = 0x40,
        ServerSetDAQ = 0x41,
        ServerSetPort = 0x42,
        ServerGetDAQ = 0x43,

        FlashFuntion = 0x20,
        FlashSetDefault = 0x21,
        FlashSaved = 0x22,

        GSMFuntion = 0x50,
        GSMConfigSevicer = 0x51,
        GSMGetSevicer = 0x52,

        BatteryFuntion = 0x60,
        BatteryConfigCoff = 0x61,
        BatteryGetCoff = 0x62,

        TestFuntion = 0xA0,
        TestEnter = 0xA1,
        TestResStatus = 0xA2,
        TestGSM = 0xA3,
        TestPowerSensor = 0xA4,
        TestGPRS3G = 0xA5,
        TestSDCard = 0xA6,
        TestPulseIn = 0xA7,
        TestSensorOut = 0xA8,
        TestFlowSensor = 0xA9,
        TestPerformance = 0xAA,
        TestEraseExternalFlash = 0xAB,
        TestReadExternalFlash = 0xAC,
        TestEndTesting = 0xAF,

        ReadParamFuntion = 0xC0,
        ReadSensorAppValue = 0xC1,
        ReadSensorAppStatus = 0xC2,
        ReadFlowMeter0 = 0xC3,
        ReadFlowMeter1 = 0xC4,
        ReadDeviceStatusValue = 0xC5,
        ReadDeviceStatus = 0xC6,
        ReadFirmware = 0xC7,
        ReadSensorBuffer = 0xC8,
        ReadGPRSStatus = 0xC9,
        ReadBatteryLowThreshold = 0xCA,
        ReadSystemCode = 0xCB,
        ReadModbusValue = 0xCC,
        ReadModbusStatus = 0xCD,

    }
}
