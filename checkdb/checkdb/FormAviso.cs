using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkdb
{
    public partial class FormAviso : Form
    {
        public DialogResult Result;

        public FormAviso()
        {
            InitializeComponent();
        }

        private void buttonAceitaTermos_Click(object sender, EventArgs e)
        {   
            if (checkBoxTermos.Checked)
                Result = DialogResult.OK;
            else
                Result = DialogResult.No;

            this.Close();
        }

        private void checkBoxTermos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTermos.Checked)
                this.buttonAceitaTermos.Enabled = true;
            else
                this.buttonAceitaTermos.Enabled = false;
        }      

    }
}
