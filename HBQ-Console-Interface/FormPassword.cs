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
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();

        }
        private void FormPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Select();
            this.ActiveControl = txtPassword;
            txtPassword.Focus();
            
        }
        private void CheckPassword()
        {
            if (txtPassword.Text == "1234")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (MessageBox.Show(this, "Password Not Correct! Try Again??", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckPassword();
            }
        }

       
    }
}
