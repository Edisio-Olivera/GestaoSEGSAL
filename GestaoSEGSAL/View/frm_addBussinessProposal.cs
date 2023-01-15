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
    public partial class frm_addBussinessProposal : Form
    {
        BussinessProposalDTO bpDto = new BussinessProposalDTO();
        BussinessProposalBLL bpBll = new BussinessProposalBLL();

        ClientDTO cliDto = new ClientDTO();
        ClientBLL cliBll = new ClientBLL();

        BaseClientDTO bcDto = new BaseClientDTO();
        BaseClientBLL bcBll = new BaseClientBLL();        

        PaymentTermsDTO ptDto = new PaymentTermsDTO();
        PaymentTermsBLL ptBll = new PaymentTermsBLL();

        PaymentFormDTO pfDto = new PaymentFormDTO();
        PaymentFormBLL pfBll = new PaymentFormBLL();

        public void ToSaveBussinesProposal()
        {
            bpDto.Id = Int32.Parse(this.txt_id.Text);
            bpDto.NumberProposal = this.txt_codigo.Text;
            DateTime dataProposal = this.dtp_dataProposta.Value;
            bpDto.DateProposal = dataProposal;
            if(this.txt_titulo.Text == "")
            {
                MessageBox.Show("Por favor, digite um título para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_titulo.Focus();
                return;
            }
            else
            {
                bpDto.Title = this.txt_titulo.Text;
            }     
            if(this.txt_descricao.Text == "")
            {
                bpDto.Description = "-";
            }
            else
            {
                bpDto.Description = this.txt_descricao.Text;
            }
            if (this.txt_observacao.Text == "")
            {
                bpDto.Observation = "-";
            }
            else
            {
                bpDto.Observation = this.txt_observacao.Text;
            }
            if (this.cmb_cliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um cliente para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cliente.Focus();
                return;
            }
            else
            {
                bpDto.Client = this.cmb_cliente.Text;
            }
            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma base do cliente para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                bpDto.BaseClient = this.cmb_base.Text;
            }
            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                bpDto.PaymentTerms = this.cmb_condPgto.Text;
            }
            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                bpDto.PaymentForm = this.cmb_formaPgto.Text;
            }            
            bpDto.Amount = 0;
            bpDto.Invoice = "-";
            bpDto.Status = "Criada";

            bpBll.ToSaveNewBussinessProposal(bpDto);

            MessageBox.Show("Proposta Comercial Nº " + bpDto.NumberProposal + " cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            frm_listBussinesProposal lbp = new frm_listBussinesProposal();
            lbp.Visible = true;
        }

        public void ToUpdateBussinessProposal()
        {
            bpDto.NumberProposal = this.txt_codigo.Text;
            DateTime dataProposal = this.dtp_dataProposta.Value;
            bpDto.DateProposal = dataProposal;
            if (this.txt_titulo.Text == "")
            {
                MessageBox.Show("Por favor, digite um título para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_titulo.Focus();
                return;
            }
            else
            {
                bpDto.Title = this.txt_titulo.Text;
            }
            if (this.txt_descricao.Text == "")
            {
                bpDto.Description = "-";
            }
            else
            {
                bpDto.Description = this.txt_descricao.Text;
            }
            if (this.txt_observacao.Text == "")
            {
                bpDto.Observation = "-";
            }
            else
            {
                bpDto.Observation = this.txt_observacao.Text;
            }
            if (this.cmb_cliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um cliente para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cliente.Focus();
                return;
            }
            else
            {
                bpDto.Client = this.cmb_cliente.Text;
            }
            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma base do cliente para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                bpDto.BaseClient = this.cmb_base.Text;
            }
            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                bpDto.PaymentTerms = this.cmb_condPgto.Text;
            }
            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                bpDto.PaymentForm = this.cmb_formaPgto.Text;
            }

            bpBll.ToUpdateBussinessProposal(bpDto);

            MessageBox.Show("Proposta Comercial Nº " + bpDto.NumberProposal + " atualizada com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            frm_listBussinesProposal lbp = new frm_listBussinesProposal();
            lbp.Visible = true;
        }

        public void ToCancelRegister()
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Deseja realmente cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
                frm_listBussinesProposal lbp = new frm_listBussinesProposal();
                lbp.Visible = true;
            }
        }

        public void ToPopularComboboxClient()
        {
            List<ClientDTO> cliente = cliBll.ToPopulaComboboxClient();

            this.cmb_cliente.DataSource = cliente;
            this.cmb_cliente.DisplayMember = "fantasyName";
            this.cmb_cliente.ValueMember = "id";

            //this.cmb_cliente.Text = "";
        }

        public void ToPopularComboboxBaseClient()
        {
            String cliente = this.cmb_cliente.Text;
            bcDto.Client = cliente;

            this.cmb_base.Enabled = true;
            this.cmb_base.Items.Clear();            

            List<BaseClientDTO> baseCliente = bcBll.ToPopulaComboxBaseClient(bcDto);

            this.cmb_base.DataSource = baseCliente;
            this.cmb_base.DisplayMember = "namebase";
            this.cmb_base.ValueMember = "id";                        
        }

        public void ToPopularComboboxPaymentTerms()
        {
            List<PaymentTermsDTO> terms = ptBll.ToPopulaComboxPaymentTerms();

            this.cmb_condPgto.DataSource = terms;
            this.cmb_condPgto.DisplayMember = "paymentTerms";
            this.cmb_condPgto.ValueMember = "id";            
        }

        public frm_addBussinessProposal()
        {
            InitializeComponent();
        }

        public frm_addBussinessProposal(Int32 proxId, string codigo, DateTime dataProposta)
        {
            InitializeComponent();

            this.txt_id.Text = proxId.ToString();
            this.txt_codigo.Text = codigo;
            this.dtp_dataProposta.Text = dataProposta.ToString("dd/MM/yyyy");
          
            this.ToPopularComboboxClient();
            this.ToPopularComboboxPaymentTerms();

            this.cmb_cliente.Text = "";
            this.cmb_condPgto.Text = "";
            
            this.cmb_base.Enabled = false;
            this.cmb_formaPgto.Enabled = false;

            this.txt_id.BackColor = Color.FromArgb(192,255,255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_cliente.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_titulo.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_descricao.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_observacao.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_condPgto.BackColor = Color.FromArgb(255, 255, 192);

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_valor.Enabled = false;

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;

            this.btn_cancelar.Location = new Point(1261, 4);
            this.btn_salvar.Location = new Point(1191, 4);            
        }

        public frm_addBussinessProposal(Int32 id, string codigo, DateTime dataProposta, string cliente, string baseCliente, string titulo, string descricao, string observacao, string condPgto, string formaPgto, Int32 valor)
        {
            InitializeComponent();

            this.ToPopularComboboxClient();
            this.ToPopularComboboxPaymentTerms();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.dtp_dataProposta.Text = dataProposta.ToString();
            this.cmb_cliente.Text = cliente;
            this.cmb_base.Text = baseCliente;
            this.txt_titulo.Text = titulo;
            this.txt_descricao.Text = descricao;
            this.txt_observacao.Text = observacao;
            this.cmb_condPgto.Text = condPgto;
            this.cmb_formaPgto.Text = formaPgto;
            this.txt_valor.Text = valor.ToString("#,##0.00");            

            //this.cmb_base.Enabled = false;
            //this.cmb_formaPgto.Enabled = false;

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_cliente.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_base.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_titulo.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_descricao.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_observacao.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_condPgto.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_formaPgto.BackColor = Color.FromArgb(255, 255, 192);

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_valor.Enabled = false;

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = true;

            this.btn_cancelar.Location = new Point(1261, 4);
            this.btn_atualizar.Location = new Point(1191, 4);
        }

        private void frm_addBussinessProposal_Load(object sender, EventArgs e)
        {
            
        }

        private void dtp_dataProposta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.ToCancelRegister();
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            string cliente = this.cmb_cliente.Text;

            if (cliente == "GestaoSEGSAL.DTO.ClientDTO")
            {
                return;
            }
            else
            {
                bcDto.Client = cliente;

                this.cmb_base.Enabled = true;
                this.cmb_base.BackColor = Color.FromArgb(255, 255, 192);

                List<BaseClientDTO> baseCliente = bcBll.ToPopulaComboxBaseClient(bcDto);

                this.cmb_base.DataSource = baseCliente;
                this.cmb_base.DisplayMember = "namebase";
                this.cmb_base.ValueMember = "id";

                this.cmb_base.Text = "";
            }
        }

        private void cmb_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmb_cliente_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.ToUpdateBussinessProposal();
            
        }

        private void cmb_cliente_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_addBussinessProposal_Shown(object sender, EventArgs e)
        {
            
        }

        private void cmb_condPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            string condicao = this.cmb_condPgto.Text;

            if (condicao == "GestaoSEGSAL.DTO.PaymentTermsDTO")
            {
                return;
            }
            else
            {
                pfDto.PaymentTerms = condicao;

                this.cmb_formaPgto.Enabled = true;
                this.cmb_formaPgto.BackColor = Color.FromArgb(255, 255, 192);

                List<PaymentFormDTO> forma = pfBll.ToPopulaComboboxPaymentForm(pfDto);

                this.cmb_formaPgto.DataSource = forma;
                this.cmb_formaPgto.DisplayMember = "paymentForm";
                this.cmb_formaPgto.ValueMember = "id";

                this.cmb_formaPgto.Text = "";
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.ToSaveBussinesProposal();
        }
    }
}
