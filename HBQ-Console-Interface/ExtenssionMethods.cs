using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HBQ_Console_Interface
{
    internal static class ExtenssionMethods
    {
        public static Color FromHex(this string hex) =>
            ColorTranslator.FromHtml(hex);
    }
}
