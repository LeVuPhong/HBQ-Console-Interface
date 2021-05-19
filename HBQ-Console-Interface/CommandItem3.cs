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
    public partial class CommandItem3 : UserControl
    {

        private ConfigMessageIconEnum messageIcon = ConfigMessageIconEnum.Ok;
        private bool messageVisible = true;
        private bool showItem = true;
        private int lastHieght;
        private ParameterItem1[] items;
        //private TableLayoutPanel tableLayout = new TableLayoutPanel();
        public CommandItem3()
        {
            InitializeComponent();

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
        

        private void changeItemShow(bool value)
        {
            if(value)
            {
                btnShowItem.BackgroundImage = Properties.Resources.minus;
                panelSubItem.Visible = true;
                this.Height = lastHieght;
            }
            else
            {
                btnShowItem.BackgroundImage = Properties.Resources.add;
                panelSubItem.Visible = false;
                this.Height = 50;
            }
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

        #region public properties
        public string Title
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }
        public string MessageText
        {
            get => txtMessage.Text;
            set => txtMessage.Text = value;
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
        public ConfigMessageIconEnum MessageIcon
        {
            get => messageIcon;
            set
            {
                messageIcon = value;
                setMessageIcon(MessageIcon);
            }
        }
        public int MessageSize
        {
            get => circlePannel2.Width;
            set => circlePannel2.Width = value;
        }

        public bool ShowItem
        {
            get => showItem;
            set
            {
                showItem = value;
                changeItemShow(showItem);
            }
        }

        public bool ButtonWriteEnable
        {
            get => btnWrite.Enabled;
            set => btnWrite.Enabled = value;
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
        
        public event EventHandler ButtonReadClick;
        public event EventHandler ButtonWriteClick;
        #endregion

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            
            if(ShowItem == true)
            {
                ShowItem = false;
            }
            else
            {
                ShowItem = true;
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

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
            if (ShowItem == true)
            {
                ShowItem = false;
            }
            else
            {
                ShowItem = true;
            }
            
        }
        public ParameterItem1[] Items
        {
            get => items;
            set
            {
                items = value;
                AddItem();
            }
        }
        private void AddItem( )
        {
            int x = 0, y = 0, numrow = 0, totalSpan = 0, subRow = 0;
            this.tableLayout.RowStyles.Clear();
            //if (items == null) return;
            numrow = items.Length / 4;
            if (items.Length % 4 != 0) numrow++;
            for(int i = 0; i < numrow; i++)
            {
                this.tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            }
            foreach (ParameterItem1 item in this.items)
            {
                
                item.Dock = DockStyle.Fill;
                item.RemoveSpanEvent();
                item.SpanColumChange += OnchangeSpanColum;
                this.tableLayout.Controls.Add(item, x, y);
                this.tableLayout.SetColumnSpan(item, item.Span);

                totalSpan += item.Span;
                x++;
                if (x > 3)
                {
                    x = 0;
                    y++;
                }
            }
            if(totalSpan % 4 > 0)
            {
                totalSpan = (totalSpan / 4) + 1;
            }
            else
            {
                totalSpan = (totalSpan / 4);
            }
            subRow = totalSpan - numrow;
            for (int i = 0; i < subRow; i++)
            {
                this.tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }
            this.tableLayout.RowCount = numrow + subRow;

            this.tableLayout.Height = (30 * numrow)  + (30 * subRow);
            //panelSubItem.Height = tableLayout.Height + 10;
            this.Height = this.tableLayout.Height + 60;
            this.lastHieght = this.Height;
            this.panel2.SendToBack();
        }
        private void OnchangeSpanColum(Control control, int span)
        {
            int totalSpan = 0, subRow = 0;
            this.tableLayout.SetColumnSpan(control, span);
            foreach (ParameterItem1 item in items)
            {
                totalSpan += item.Span;
            }
            if (totalSpan % 4 > 0)
            {
                totalSpan = (totalSpan / 4) + 1;
            }
            else
            {
                totalSpan = (totalSpan / 4);
            }
            subRow = totalSpan - this.tableLayout.RowCount;
            for (int i = 0; i < subRow; i++)
            {
                this.tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }
            this.tableLayout.RowCount += subRow;
            this.tableLayout.Height = this.tableLayout.RowCount * 30;
            this.Height = this.tableLayout.Height + 60;
            this.lastHieght = this.Height;
        }
    }
}
