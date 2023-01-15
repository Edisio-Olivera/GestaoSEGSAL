using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoSEGSAL.View
{
    public partial class frm_listBillsToReceive : Form
    {
        public frm_listBillsToReceive()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            frm_addBillsToReceive btr = new frm_addBillsToReceive();
            btr.Visible = true;
        }
    }
}
