using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBQ_Console_Interface
{
    public partial class FormProcess : Form
    {
        //private int time
        public FormProcess()
        {
            InitializeComponent();
        }
        public FormProcess(string message)
        {
            InitializeComponent();
            lbMessage.Text = message;
            timer1.Enabled = true;
        }
        public FormProcess(string message, int timeout)
        {
            InitializeComponent();
            lbMessage.Text = message;
            timer1.Interval = timeout;
            timer1.Enabled = true;
        }
        public void setMessage(string message)
        {
            timer1.Stop();
            lbMessage.Text = message;
            btnOK.Visible = true;
            btnStop.Visible = false;
            progressBar1.Style = ProgressBarStyle.Blocks;

        }

        public void closeDiablog(bool result)
        {
            if(result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            btnOK.Visible = true;
            btnStop.Visible = false;
            progressBar1.Style = ProgressBarStyle.Blocks;
            lbError.Text = "Timeout!";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
