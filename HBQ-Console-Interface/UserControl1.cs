using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBQ_Console_Interface
{
    public partial class UserControl1 : UserControl
    {
        private ParameterItemType itemType = ParameterItemType.TextBox;
        public UserControl1()
        {
            InitializeComponent();
        }
        public ParameterItemType ItemType
        {
            get => itemType;
            set
            {
                itemType = value;
                if(itemType == ParameterItemType.TextBox)
                {
                    textBox1.Visible = true;
                    comboBox1.Visible = false;
                }
                else
                {
                    textBox1.Visible = false;
                    comboBox1.Visible = true;
                }
            }
        }
    }
}
