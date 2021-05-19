using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBQ_Console_Interface
{
    class ParameterString
    {
        public static string SensorMode(int mode)
        {
            switch (mode)
            {
                case 0:
                    return "Initializing";
                case 1:
                    return "Idle";
                case 2:
                    return "Sampling";
                case 3:
                    return "Error";
                default:
                    return "Invalid Value";
            }
        }
        public static string SensorType(int type)
        {
            switch (type)
            {
                case 0:
                    return "2 Analog";
                case 1:
                    return "4 Analog";
                case 2:
                    return "All Analog";
                case 3:
                    return "ModBus";
                case 4:
                    return "ModBus Mix";
                default:
                    return "Invalid Value";
            }
        }
        public static string SensorStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return "Initializing";
                case 1:
                    return "Idle";
                case 2:
                    return "Sampling";
                case 3:
                    return "Error";
                default:
                    return "Invalid Value";
            }
        }
        public static string PowerControl(int control)
        {
            switch (control)
            {
                case 'F':
                    return "Power Off";
                case 'N':
                    return "Power On";
                default:
                    return "Invalid Value";
            }
        }
        public static string DevicePowerMode(int mode)
        {
            switch (mode)
            {
                case 'O':
                    return "Nomal";
                case 'W':
                    return "Low Battery";
                case 'L':
                    return "Lost Battery";
                default:
                    return "Invalid Value";
            }
        }
        public static string SDCardStatuts(int status)
        {
            switch (status)
            {
                case 'G':
                    return "SD Card Good";
                case 'F':
                    return "SD Card Full";
                case 'X':
                    return "Not Available";
                case 'E':
                    return "SD Card Error";
                default:
                    return "Invalid Value";
            }
        }
        public static string BoxStatus(int status)
        {
            switch (status)
            {
                case 'O':
                    return "Box Open";
                case 'C':
                    return "Box closed";
                default:
                    return "Invalid Value";
            }
        }
        public static string GSMService(int service)
        {
            switch (service)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "VinaPhone";
                case 2:
                    return "Viettel";
                case 3:
                    return "MobiPhone";
                case 4:
                    return "Vietnam Mobile";
                case 5:
                    return "BeeLine";
                case 6:
                    return "Auto Detect";
                default:
                    return "Invalid Value";
            }
        }
        public static string DataLoggingEnable(int enable)
        {
            switch (enable)
            {
                case 'E':
                    return "Enable";
                case 'D':
                    return "Disable";
                default:
                    return "Invalid Value";
            }
        }
        public static string GPRSStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return "Initializing";
                case 1:
                    return "Idle";
                case 2:
                    return "Connected";
                case 3:
                    return "Connecting";
                case 4:
                    return "Closed";
                case 5:
                    return "Disconnected";
                default:
                    return "Invalid Value";
            }
        }
        public static string GSMStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return "Initializing";
                case 1:
                    return "Idle";
                case 2:
                    return "OK";
                case 3:
                    return "Unservice";
                case 4:
                    return "Unknown Error";
                case 5:
                    return "Sleep";
                case 6:
                    return "Off";
                default:
                    return "Invalid Value";
            }
        }
    }
}
