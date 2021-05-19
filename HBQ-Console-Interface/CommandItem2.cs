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
    public partial class CommandItem2 : UserControl
    {
        private ConfigItem2AutoSize itemAutoSize = ConfigItem2AutoSize.Both;
        private ConfigItem2Show itemShow = ConfigItem2Show.Both;
        private ConfigItem2LabelShow labelShow = ConfigItem2LabelShow.Both;
        private ConfigMessageIconEnum messageIcon = ConfigMessageIconEnum.Ok;
        private bool messageVisible;
        public CommandItem2()
        {
            InitializeComponent();
            btnWrite.Enabled = false;
        }
        #region public funtion
        public void setMessage(string message, ConfigMessageIconEnum icon)
        {
            setMessageIcon(icon);
            txtMessage.Invoke(new Action(() =>
            {
                txtMessage.Text = message;
            }));
        }
        public void setText1(string value)
        {
            textBox1.Invoke(new Action(() =>
            {
                textBox1.Text = value;
            }));
        }
        public void setText2(string value)
        {
            textBox2.Invoke(new Action(() =>
            {
                textBox2.Text = value;
            }));
        }
        public void setButtonWriteEnable(bool value)
        {
            btnWrite.Invoke(new Action(() =>
            {
                ButtonWriteEnable = value;
            }));
        }

        public void setButtonWriteVisible(bool value)
        {
            btnWrite.Invoke(new Action(() =>
            {
                ButtonWriteVisible = value;
            }));
        }

        public void setButtonReadVisible(bool value)
        {
            btnRead.Invoke(new Action(() =>
            {
                ButtonReadVisible = value;
            }));
        }
        public void setMessageVisible(bool value)
        {
            txtMessage.Invoke(new Action(() =>
            {
                MessageVisible = value;
            }));
        }
        #endregion

        #region private funtion

        private void ConfigItem2_SizeChanged(object sender, EventArgs e)
        {
            if (itemAutoSize == ConfigItem2AutoSize.Both)
            {
                int sz = (this.Width - 550) / 2;
                panel1.Width = sz;
                panel2.Width = sz;
            }

        }
        
        private void btnRead_Click(object sender, EventArgs e)
        {
            if(ButtonReadClick != null)
            {
                ButtonReadClick?.Invoke(sender, e);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (ButtonWriteClick != null)
            {
                ButtonWriteClick?.Invoke(sender, e);
            }
        }
        private void setMessageIcon(ConfigMessageIconEnum icon)
        {
            switch (icon)
            {
                case ConfigMessageIconEnum.Ok:
                    iconMessage.BackgroundImage = Properties.Resources.ok;
                    break;
                case ConfigMessageIconEnum.Error:
                    iconMessage.BackgroundImage = Properties.Resources.error;
                    break;
                case ConfigMessageIconEnum.Information:
                    iconMessage.BackgroundImage = Properties.Resources.info;
                    break;
                case ConfigMessageIconEnum.Warning:
                    iconMessage.BackgroundImage = Properties.Resources.warning;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(btnWrite.Enabled == false)
            {
                btnWrite.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (btnWrite.Enabled == false)
            {
                btnWrite.Enabled = true;
            }
        }
        #endregion

        #region public poroperties
        public string ItemText
        {
            get => labelText.Text;
            set => labelText.Text = value;
        }


        public string LabelText1
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public string LabelText2
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public int LabelSize1
        {
            get => label1.Width;
            set => label1.Width = value;
        }

        public int LabelSize2
        {
            get => label2.Width;
            set => label2.Width = value;
        }

        public ConfigItem2Show ItemShow
        {
            get => itemShow;
            set
            {
                itemShow = value;
                if(itemShow == ConfigItem2Show.TextBox1)
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                }
                else if (itemShow == ConfigItem2Show.TextBox2)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                else
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                }
            }
        }
        public ConfigItem2LabelShow LabelShow
        {
            get => labelShow;
            set
            {
                labelShow = value;
                if(labelShow == ConfigItem2LabelShow.OnlyLabel1)
                {
                    label1.Visible = true;
                    label2.Visible = false;
                }
                else if (labelShow == ConfigItem2LabelShow.OnlyLabel2)
                {
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (labelShow == ConfigItem2LabelShow.Both)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    label2.Visible = false;
                }
            }
        }

        public ConfigItem2AutoSize ItemAutoSize
        {
            get => itemAutoSize;
            set
            {
                itemAutoSize = value;
                if(itemAutoSize == ConfigItem2AutoSize.TextBox1)
                {
                    panel1.Dock = DockStyle.Fill;
                    panel2.Dock = DockStyle.Right;
                }
                else if(itemAutoSize == ConfigItem2AutoSize.TextBox2)
                {
                    panel1.Dock = DockStyle.Left;
                    panel2.Dock = DockStyle.Fill;
                }
                else
                {
                    panel1.Dock = DockStyle.Left;
                    panel2.Dock = DockStyle.Right;
                }
            }
        }

        public int TextBox1Size
        {
            get => panel1.Width;
            set
            {
                panel1.Width = value;
            }
        }
        public int TextBox2Size
        {
            get => panel2.Width;
            set
            {
                panel2.Width = value;
            }
        }

        public ConfigMessageIconEnum MessageIcon
        {
            get => messageIcon;
            set
            {
                messageIcon = value;
                setMessageIcon(MessageIcon);
            }
        }

        public string MessageText
        {
            get => txtMessage.Text;
            set => txtMessage.Text = value;
        }
        public bool ButtonWriteEnable
        {
            get => btnWrite.Enabled;
            set => btnWrite.Enabled = value;
        }

        public string Text1
        {
            get => textBox1.textbox.Text;
            set
            {
                textBox1.textbox.Text = value;
            }
        }
        public string Text2
        {
            get => textBox2.textbox.Text;
            set
            {
                textBox2.textbox.Text = value;
            }
        }
        public TextBoxValueType TextBox1ValueType
        {
            get => textBox1.ValueType;
            set => textBox1.ValueType = value;
        }
        public TextBoxValueType TextBox2ValueType
        {
            get => textBox2.ValueType;
            set => textBox2.ValueType = value;
        }
        public bool ButtonWriteVisible
        {
            get => btnWrite.Visible;
            set => btnWrite.Visible = value;
        }
        public bool ButtonReadVisible
        {
            get => btnRead.Visible;
            set => btnRead.Visible = value;
        }
        public bool MessageVisible
        {
            get => messageVisible;
            set
            {
                messageVisible = value;
                if (messageVisible)
                {
                    txtMessage.Visible = true;
                    iconMessage.Visible = true;
                }
                else
                {
                    txtMessage.Visible = false;
                    iconMessage.Visible = false;
                }
            }
        }
        public int PanelMessageSize
        {
            get => circlePannel2.Width;
            set => circlePannel2.Width = value;
        }
        public event EventHandler ButtonReadClick;
        public event EventHandler ButtonWriteClick;

        #endregion

        
    }
    
}
