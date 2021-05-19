using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBQ_Console_Interface
{
    public class UserApp
    {
        public static string ConvertByte2String(UInt16[] data, int startIndex, int lenght)
        {
            string retString = string.Empty;

            for (int i = startIndex; i < startIndex + lenght; i++)
            {
                retString += Convert.ToChar(data[i] & 0xFF);
                retString += Convert.ToChar(data[i] >> 8);
            }

            return retString;
        }
        public static string ConvertByte2String(UInt16[] data, int len)
        {
            string retString = string.Empty;

            for (int i = 0; i < len; i++)
            {
                retString += Convert.ToChar(data[i] & 0xFF);
                retString += Convert.ToChar(data[i] >> 8);
            }

            return retString;
        }
        public static byte[] ConvertString2Byte(string str)
        {
            byte[] bt = new byte[str.Length];

            bt = Convert.FromBase64String(str);

            return bt;
        }
        public static UInt16[] ConvertStrinbg2U16(string dat)
        {
            int ulen;
            if (dat.Length % 2 == 0)
            {
                ulen = dat.Length / 2;
            }
            else
            {
                ulen = (dat.Length / 2) + 1;
            }
            UInt16[] u16 = new UInt16[ulen];
            byte[] bt = new byte[dat.Length + 1];
            for (int i = 0; i < dat.Length; i++)
            {
                bt[i] = (byte)dat[i];
            }
            bt[bt.Length - 1] = 0;
            for (int i = 0; i < ulen; i++)
            {
                u16[i] = bt[i * 2];
                u16[i] |= (UInt16)(bt[(i * 2) + 1] << 8);
            }
            return u16;
        }
        public static UInt16[] ConvertServer2U16(string port, string domain)
        {
            int ulen;
            if (domain.Length % 2 == 0)
            {
                ulen = domain.Length / 2 + 1;
            }
            else
            {
                ulen = (domain.Length / 2) + 2;
            }
            UInt16[] u16 = new UInt16[ulen];
            u16[0] = Convert.ToUInt16(port);
            byte[] bt = new byte[domain.Length + 1];
            for (int i = 1; i <= domain.Length; i++)
            {
                bt[i] = (byte)domain[i];
            }
            bt[bt.Length - 1] = 0;
            for (int i = 0; i < ulen; i++)
            {
                u16[i] = bt[i * 2];
                u16[i] |= (UInt16)(bt[(i * 2) + 1] << 8);
            }
            return u16;
        }
        public static string ConvertU32ToString(UInt16 lsb, UInt16 msb)
        {
            UInt32 value = (UInt32)(msb << 16 | lsb);
            return value.ToString();
        }
        public static void parseArgCommand(byte[] data, CommandType command)
        {
            command.Type = data[(int)CMDIndex.Type];
            command.Funtion = data[(int)CMDIndex.Funtion];
            command.Error = data[(int)CMDIndex.Error];
            command.NumArgs = data[(int)CMDIndex.LenghtRes];
            for (int i = 0; i < command.NumArgs; i++)
            {
                command.Args[i] = (UInt16)(data[(int)CMDIndex.ResData + i * 2] | data[(int)CMDIndex.ResData + i * 2 + 1] << 8);
            }
        }
    }

    public class ConnectTime
    {
        private long lastConnect;
        private bool lockConnect = false;
        public ConnectTime()
        {

        }

        public void Update()
        {
            lastConnect = DateTime.Now.Ticks;
        }

        public bool DifferenceTick(int second)
        {
            if ((lockConnect == false) && (DateTime.Now.Ticks - lastConnect > TimeSpan.FromSeconds(second).Ticks))
                return true;
            return false;
        }
        public bool Lock
        {
            get => lockConnect;
            set => lockConnect = value;
        }

    }
}
