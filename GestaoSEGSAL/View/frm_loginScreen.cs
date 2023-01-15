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
    public partial class frm_loginScreen : Form
    {
        public frm_loginScreen()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            frm_mainScreen main = new frm_mainScreen();
            main.Show();
            this.Hide();
        }
    }
}
