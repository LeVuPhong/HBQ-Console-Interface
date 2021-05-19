using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HBQ_Console_Interface
{
    public class CommandItem4 : Control
    {
        public CommandItem4()
        {
            InitializeComponent();
        }

        #region private funtion
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
            if (value)
            {
                btnShowItem.BackgroundImage = Properties.Resources.minus;
                panelSubItem.Visible = true;
                this.Height = lastHieght;
                ButtonWriteEnable = true;
                ButtonReadEnable = true;
            }
            else
            {
                btnShowItem.BackgroundImage = Properties.Resources.add;
                panelSubItem.Visible = false;
                this.Height = 50;
                ButtonWriteEnable = false;
                ButtonReadEnable = false;
            }
        }
        private void btnShowItem_Click(object sender, EventArgs e)
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
        private void AddItem()
        {
            int x = 0, y = 0, numrow = 0, totalSpan = 0, subRow = 0;
            this.tableLayout.RowStyles.Clear();
            //if (items == null) return;
            numrow = items.Length / 4;
            if (items.Length % 4 != 0) numrow++;
            for (int i = 0; i < numrow; i++)
            {
                this.tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }
            foreach (ParameterItem item in this.items)
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
            if (totalSpan % 4 > 0)
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

            this.tableLayout.Height = (30 * numrow) + (30 * subRow);
            //panelSubItem.Height = tableLayout.Height + 10;
            this.Height = this.tableLayout.Height + 70;
            this.lastHieght = this.Height;
            this.panel2.SendToBack();
        }
        private void OnchangeSpanColum(Control control, int span)
        {
            int totalSpan = 0, subRow = 0;
            this.tableLayout.SetColumnSpan(control, span);
            foreach (ParameterItem item in items)
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
            this.Height = this.tableLayout.Height + 70;
            this.lastHieght = this.Height;
        }

        #endregion

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
        public Font TitleFont
        {
            get => labelTitle.Font;
            set => labelTitle.Font = value;
        }
        public Color TitleForeColor
        {
            get => labelTitle.ForeColor;
            set => labelTitle.ForeColor = value;
        }
        public Color TitleBackColor
        {
            get => panelTitle.Backround;
            set
            {
                panelTitle.Backround = value;
                panel1.BackColor = value;
            }
        }
        public string MessageText
        {
            get => txtMessage.Text;
            set => txtMessage.Text = value;
        }
        public Font MessageFont
        {
            get => txtMessage.Font;
            set => txtMessage.Font = value;
        }
        public Color MessageForeColor
        {
            get => txtMessage.ForeColor;
            set => txtMessage.ForeColor = value;
        }
        public Color MessageBackColor
        {
            get => panelMessage.Backround;
            set => panelMessage.Backround = value;
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
            get => panelMessage.Width;
            set => panelMessage.Width = value;
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
        public bool ButtonReadEnable
        {
            get => btnRead.Enabled;
            set => btnRead.Enabled = value;
        }
        public bool ButtonReadVisible
        {
            get => btnRead.Visible;
            set => btnRead.Visible = value;
        }

        public event EventHandler ButtonReadClick;
        public event EventHandler ButtonWriteClick;

        public ParameterItem[] Items
        {
            get => items;
            set
            {
                items = value;
                AddItem();
            }
        }

        #endregion

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSubItem = new HBQ_Console_Interface.CirclePannel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.circlePannel4 = new HBQ_Console_Interface.CirclePannel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new HBQ_Console_Interface.CirclePannel();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMessage = new HBQ_Console_Interface.CirclePannel();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.iconMessage = new System.Windows.Forms.Panel();
            this.btnRead = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubItem.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubItem
            // 
            this.panelSubItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubItem.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(221)))));
            this.panelSubItem.BorderColor = System.Drawing.Color.Gray;
            this.panelSubItem.BorderSize = 0;
            this.panelSubItem.Controls.Add(this.tableLayout);
            this.panelSubItem.Controls.Add(this.circlePannel4);
            this.panelSubItem.Controls.Add(this.panel2);
            this.panelSubItem.Location = new System.Drawing.Point(25, 45);
            this.panelSubItem.Name = "panelSubItem";
            this.panelSubItem.PannelRadius = 10;
            this.panelSubItem.Size = new System.Drawing.Size(950, 50);
            this.panelSubItem.TabIndex = 1;
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayout.Location = new System.Drawing.Point(0, 10);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.Size = new System.Drawing.Size(950, 30);
            this.tableLayout.TabIndex = 2;
            // 
            // circlePannel4
            // 
            this.circlePannel4.BackColor = System.Drawing.Color.Transparent;
            this.circlePannel4.Backround = System.Drawing.Color.Transparent;
            this.circlePannel4.BorderColor = System.Drawing.Color.Gray;
            this.circlePannel4.BorderSize = 0;
            this.circlePannel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.circlePannel4.Location = new System.Drawing.Point(0, 40);
            this.circlePannel4.Name = "circlePannel4";
            this.circlePannel4.PannelRadius = 10;
            this.circlePannel4.Size = new System.Drawing.Size(950, 10);
            this.circlePannel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(221)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 10);
            this.panel2.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.panelTitle.BorderColor = System.Drawing.Color.Gray;
            this.panelTitle.BorderSize = 0;
            this.panelTitle.Controls.Add(this.btnShowItem);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.panelMessage);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.PannelRadius = 10;
            this.panelTitle.Size = new System.Drawing.Size(1000, 45);
            this.panelTitle.TabIndex = 0;
            // 
            // btnShowItem
            // 
            this.btnShowItem.BackColor = System.Drawing.Color.Transparent;
            this.btnShowItem.BackgroundImage = global::HBQ_Console_Interface.Properties.Resources.minus;
            this.btnShowItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowItem.FlatAppearance.BorderSize = 0;
            this.btnShowItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItem.Location = new System.Drawing.Point(13, 10);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(25, 25);
            this.btnShowItem.TabIndex = 12;
            this.btnShowItem.UseVisualStyleBackColor = false;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(54, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(646, 44);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Command Item";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelMessage.Backround = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.panelMessage.BorderColor = System.Drawing.Color.Gray;
            this.panelMessage.BorderSize = 0;
            this.panelMessage.Controls.Add(this.btnWrite);
            this.panelMessage.Controls.Add(this.txtMessage);
            this.panelMessage.Controls.Add(this.iconMessage);
            this.panelMessage.Controls.Add(this.btnRead);
            this.panelMessage.Controls.Add(this.panel1);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMessage.Location = new System.Drawing.Point(700, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.PannelRadius = 10;
            this.panelMessage.Size = new System.Drawing.Size(300, 45);
            this.panelMessage.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.BackgroundImage = global::HBQ_Console_Interface.Properties.Resources.pencil;
            this.btnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Location = new System.Drawing.Point(50, 10);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(25, 25);
            this.btnWrite.TabIndex = 14;
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(135, 14);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(68, 17);
            this.txtMessage.TabIndex = 13;
            this.txtMessage.Text = "Write OK!";
            // 
            // iconMessage
            // 
            this.iconMessage.BackgroundImage = global::HBQ_Console_Interface.Properties.Resources.check_mark;
            this.iconMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMessage.Location = new System.Drawing.Point(105, 10);
            this.iconMessage.Name = "iconMessage";
            this.iconMessage.Size = new System.Drawing.Size(25, 25);
            this.iconMessage.TabIndex = 12;
            // 
            // btnRead
            // 
            this.btnRead.BackgroundImage = global::HBQ_Console_Interface.Properties.Resources.refresh;
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Location = new System.Drawing.Point(19, 10);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(25, 25);
            this.btnRead.TabIndex = 11;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(152)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 43);
            this.panel1.TabIndex = 0;
            // 
            // CommandItem4
            // 
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Controls.Add(this.panelSubItem);
            this.Controls.Add(this.panelTitle);
            this.Size = new System.Drawing.Size(1000, 100);
            this.panelSubItem.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CirclePannel panelTitle;
        private CirclePannel panelMessage;
        private System.Windows.Forms.Panel panel1;
        private CirclePannel panelSubItem;
        private System.Windows.Forms.Panel panel2;
        private CirclePannel circlePannel4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Panel iconMessage;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.TableLayoutPanel tableLayout;

        #region private variable
        private ConfigMessageIconEnum messageIcon = ConfigMessageIconEnum.Ok;
        private bool messageVisible = true;
        private bool showItem = true;
        private int lastHieght;
        private ParameterItem[] items;
        #endregion
    }
}
