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
    public partial class CommandItem1 : UserControl
    {
        private ConfigItem1AutoSize itemAutoSize = ConfigItem1AutoSize.Both;
        private ConfigItem1Show itemShow = ConfigItem1Show.Both;
        private ConfigItem1LabelShow labelShow = ConfigItem1LabelShow.Both;
        private ConfigMessageIconEnum messageIcon = ConfigMessageIconEnum.Ok;
        private bool messageVisible;
        public CommandItem1()
        {
            InitializeComponent();
            ComboBox1.combobox.SelectedIndexChanged += ComboBox1_SelectIndexChanged;
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
        public void setText(string value)
        {
            TextBox1.Invoke(new Action(() =>
            {
                TextBox1.Text = value;
            }));
        }
        public void setSelectedIndex(int index)
        {
            ComboBox1.combobox.Invoke(new Action(() =>
            {
                ComboBox1.combobox.SelectedIndex = index;
            }));
        }
        public void setButtonWriteEnable(bool value)
        {
            btnWrite.Invoke(new Action(() =>
            {
                btnWrite.Enabled = value;
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
        private void setMessageIcon(ConfigMessageIconEnum icon)
        {
            switch(icon)
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
        private void ConfigItem1_SizeChanged(object sender, EventArgs e)
        {
            if (itemAutoSize == ConfigItem1AutoSize.Both)
            {
                int sz = (this.Width - 550) / 2;
                panel1.Width = sz;
                panel2.Width = sz;
            }

        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (ButtonReadClick != null)
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
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(btnWrite.Enabled == false)
            {
                btnWrite.Enabled = true;
            }
        }
        private void ComboBox1_SelectIndexChanged(object sender, EventArgs e)
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
        public ConfigItem1AutoSize ItemAutoSize
        {
            get => itemAutoSize;
            set
            {
                itemAutoSize = value;
                if (itemAutoSize == ConfigItem1AutoSize.TextBox1)
                {
                    panel1.Dock = DockStyle.Fill;
                    panel2.Dock = DockStyle.Right;
                }
                else if (itemAutoSize == ConfigItem1AutoSize.ComboBox1)
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
        public ConfigItem1Show ItemShow
        {
            get => itemShow;
            set
            {
                itemShow = value;
                if (itemShow == ConfigItem1Show.TextBox1)
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                }
                else if (itemShow == ConfigItem1Show.ComboBox1)
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
        public ConfigItem1LabelShow LabelShow
        {
            get => labelShow;
            set
            {
                labelShow = value;
                if (labelShow == ConfigItem1LabelShow.OnlyLabel1)
                {
                    label1.Visible = true;
                    label2.Visible = false;
                }
                else if (labelShow == ConfigItem1LabelShow.OnlyLabel2)
                {
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else if (labelShow == ConfigItem1LabelShow.Both)
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

        public int TextBoxSize
        {
            get => panel1.Width;
            set
            {
                panel1.Width = value;
            }
        }
        public int ComboBoxSize
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
            get => TextBox1.textbox.Text;
            set
            {
                TextBox1.textbox.Text = value;
            }
        }
        public int SelectedIndex
        {
            get => ComboBox1.combobox.SelectedIndex;
            set
            {
                ComboBox1.combobox.SelectedIndex = value;
            }
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
