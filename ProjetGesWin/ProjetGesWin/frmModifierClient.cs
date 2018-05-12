using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetGesWin
{
    public partial class frmModifierClient : ProjetGesWin.frmClientParent
    {
        public frmModifierClient()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmModifierClient_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmModifierClient frmModifier = new frmModifierClient();
            this.Close();
        }
    }
}
