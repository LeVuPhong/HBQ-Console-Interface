using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBQ_Console_Interface
{
    public enum TestMode
    {
        None = 0,
        GSM = 0xA3,
        PowerSensor = 0xA4,
        GPRS = 0xA5,
        SDCard = 0xA6,
        PulseIn = 0xA7,
        SensorOut = 0xA8,
        FlowSensor = 0xA9,
        Performance = 0xAA,
        EraseFlash = 0xAB,
        ReadFlash = 0xAC,
    }
    public enum ParameterItemType
    {
        TextBox = 0,
        ComboBox = 1
    }
    public enum TextBoxValueType
    {
        String = 0,
        Number = 1,
    }
    public enum ConfigMessageIconEnum
    {
        Ok = 0,
        Error = 1,
        Information = 2,
        Warning = 3,
    }
    public enum ConfigItem2AutoSize
    {
        Both = 0,
        TextBox1 = 1,
        TextBox2 = 2,
    }

    public enum ConfigItem2Show
    {
        Both = 0,
        TextBox1 = 1,
        TextBox2 = 2,
    }
    public enum ConfigItem2LabelShow
    {
        HideAll = 0,
        Both = 1,
        OnlyLabel1 = 2,
        OnlyLabel2 = 3,
    }

    public enum ConfigItem1AutoSize
    {
        Both = 0,
        TextBox1 = 1,
        ComboBox1 = 2,
    }

    public enum ConfigItem1Show
    {
        Both = 0,
        TextBox1 = 1,
        ComboBox1 = 2,
    }
    public enum ConfigItem1LabelShow
    {
        HideAll = 0,
        Both = 1,
        OnlyLabel1 = 2,
        OnlyLabel2 = 3,
    }
    public enum TestItemShow
    {
        HideAll = 0,
        Numberic = 1,
        ComboBox = 2,

    }

    public enum MenuButtonIndex
    {
        Home = 0,
        Config = 1,
        Console = 2,
    }

    public enum DeviceConnectEnum
    {
        RequestConnect = 0,
        Diconnect = 1,
        ConnectedUnderReset = 2,
        ConnectedNomal = 3,
    }
    public enum ButtonConnect
    {
        Disconnect = 0,
        Connect = 1,
    }
    public enum LogTextColor
    {
        Default = 0,
        Transmits = 1,
        Recieves = 2,
        Information = 3,
        Warning = 4,
        Error = 5
    }

    public enum LogDateTime
    {
        None = 0,
        LongTime = 1,
        ShortTime = 2,
        DateLongTime = 3,
        DateShortTime = 4
    }
    public enum TestStatus
    {
        Start = 0,
        Testting = 1,
        End = 2,
        TimeOut = 3,
    }
}
