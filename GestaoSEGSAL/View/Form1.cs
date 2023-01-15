using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.View;

namespace GestaoSEGSAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.lbl_status.Text = "Carregando o Sistema...";
            this.lbl_contagem.Text = "0%";
            this.Refresh();

            for(int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                string cont = i.ToString();
                this.lbl_contagem.Text = "%";
                this.lbl_contagem.Location = new Point(i * 5, 30);
                Thread.Sleep(40);
            }
            progressBar1.Value = 100;
            Thread.Sleep(2000);            
            frm_loginScreen l = new frm_loginScreen();
            l.Show();
            this.Hide();
        }
    }
}
