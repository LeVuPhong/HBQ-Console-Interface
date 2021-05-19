using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBQ_Console_Interface
{
    public class CommandType
    {
        public byte Funtion;
        public byte Type;
        public byte NumArgs;
        public UInt16[] Args = new UInt16[64];
        public byte Error;
        public byte CKA;
        public byte CKB;
    }
}
