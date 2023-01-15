using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.BLL;
using GestaoSEGSAL.DTO;

namespace GestaoSEGSAL.View
{
    public partial class frm_listInvoice : Form
    {
        InvoiceDTO iDto = new InvoiceDTO();
        InvoiceBLL iBll = new InvoiceBLL();

        public frm_listInvoice()
        {
            InitializeComponent();
        }

        public void ToCreateNewInvoice()
        {
            //iBll.ToCreateNewInvoice(iDto);

            //Int32 id = iDto.Id + 1;
            //String numero = "NF-" + id.ToString("0000#");

            //frm_addInvoice inv = new frm_addInvoice(id, numero);
            //inv.Show();

            //this.Close();
        }



        private void btn_novo_Click(object sender, EventArgs e)
        {
            //ToCreateNewInvoice();            
        }

        private void frm_listInvoice_Load(object sender, EventArgs e)
        {
            //Define Estrutura das colunas
            lvw_listaNotaFiscal.Columns.Add("Id", 0, HorizontalAlignment.Center);
            lvw_listaNotaFiscal.Columns.Add("Número", 100, HorizontalAlignment.Center);
            lvw_listaNotaFiscal.Columns.Add("Data Emissão", 100, HorizontalAlignment.Center);
            lvw_listaNotaFiscal.Columns.Add("Título", 700, HorizontalAlignment.Left);
            lvw_listaNotaFiscal.Columns.Add("Cliente-Base", 200, HorizontalAlignment.Left);
            lvw_listaNotaFiscal.Columns.Add("Valor (R$)", 90, HorizontalAlignment.Right);
            lvw_listaNotaFiscal.Columns.Add("Nota Fiscal", 86, HorizontalAlignment.Left);
        }
    }
}
