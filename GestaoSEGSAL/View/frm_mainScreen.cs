using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.View;

namespace GestaoSEGSAL.View
{
    public partial class frm_mainScreen : Form
    {
        public frm_mainScreen()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Deseja realmente sair deste formulário?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }                       
        }

        private void propostasComerciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listBussinesProposal lbp = new frm_listBussinesProposal();
            lbp.Visible = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addInvoice inv = new frm_addInvoice();
            inv.Visible = true;
        }

        private void chamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addInvoice inv = new frm_addInvoice();
            inv.Visible = true;
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listBillsToPay pag = new frm_listBillsToPay();
            pag.Visible = true;
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listBillsToReceive rec = new frm_listBillsToReceive();
            rec.Visible = true;
        }
    }
}
