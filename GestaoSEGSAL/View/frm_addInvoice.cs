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
    public partial class frm_addInvoice : Form
    {
        InvoiceDTO iDto = new InvoiceDTO();
        InvoiceBLL iBll = new InvoiceBLL();

        public frm_addInvoice()
        {
            InitializeComponent();
        }

        public frm_addInvoice(Int32 id, String numero)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_numero.Text = numero;
            this.dtp_dataEmissao.Value = DateTime.Now;


        }


        public void ToSaveInvoice()
        {
            iDto.Id = Int32.Parse(this.txt_id.Text);
            iDto.NumberInvoice = this.txt_numero.Text;
            DateTime dataEmissao = this.dtp_dataEmissao.Value;
            iDto.IssuanceDate = dataEmissao;
            DateTime dataPrevisao = this.dtp_dataPrevisao.Value;
            iDto.ForecastDate = dataPrevisao;
            iDto.InvoiceType = this.cmb_tipoNotaFiscal.Text;
            iDto.Competence = this.txt_competencia.Text + "/" + this.dtp_dataEmissao.Value.ToString("yyyy");
            iDto.VerificationCode = this.txt_codigoVerificacao.Text;
            iDto.Client = this.cmb_cliente.Text;
            iDto.BaseClient = this.cmb_base.Text;
            iDto.Service = this.txt_servico.Text;
            iDto.RequestNumber = this.txt_numeroPedido.Text;
            iDto.Amount = Int32.Parse(this.txt_valor.Text) * 100;
            iDto.File = "/documentos/nota fiscal/" + iDto.NumberInvoice + ".pdf";
            iDto.Status = "A Receber";

            iBll.ToSaveNewInvoice(iDto);

            MessageBox.Show("Nota Fiscal Nº " + iDto.NumberInvoice + " cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listInvoice inv = new frm_listInvoice();
            inv.Show();

            this.Close();
        }

        public void ToUpdateInvoice()
        {
            iDto.NumberInvoice = this.txt_numero.Text;
            DateTime dataEmissao = this.dtp_dataEmissao.Value;
            iDto.IssuanceDate = dataEmissao;
            DateTime dataPrevisao = this.dtp_dataPrevisao.Value;
            iDto.ForecastDate = dataPrevisao;
            iDto.InvoiceType = this.cmb_tipoNotaFiscal.Text;
            iDto.Competence = this.txt_competencia.Text + "/" + this.dtp_dataEmissao.Value.ToString("yyyy");
            iDto.VerificationCode = this.txt_codigoVerificacao.Text;
            iDto.Client = this.cmb_cliente.Text;
            iDto.BaseClient = this.cmb_base.Text;
            iDto.Service = this.txt_servico.Text;
            iDto.RequestNumber = this.txt_numeroPedido.Text;
            iDto.Amount = Int32.Parse(this.txt_valor.Text) * 100;

            iBll.ToUpdateInvoice(iDto);

            MessageBox.Show("Nota Fiscal Nº " + iDto.NumberInvoice + " editada com sucesso!", "Editar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listInvoice inv = new frm_listInvoice();
            inv.Show();

            this.Close();
        }








        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
