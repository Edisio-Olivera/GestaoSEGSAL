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
    public partial class frm_addServiceBussinessProposal : Form
    {
        BussinessProposalServiceDTO bpsDto = new BussinessProposalServiceDTO();
        BussinessProposalServiceBLL bpsBll = new BussinessProposalServiceBLL();

        BussinessProposalDTO bpDto = new BussinessProposalDTO();
        BussinessProposalBLL bpBll = new BussinessProposalBLL();

        ServiceTypeDTO serDto = new ServiceTypeDTO();
        ServiceTypeBLL serBll = new ServiceTypeBLL();

        Int32 valorUnitarioErrado = 0;        
        Int32 valorUnitarioCerto = 0;
        Int32 valorTotalErrado = 0;
        Int32 valorTotalCerto = 0;

        public void ToSelectAmountBussinessProposal()
        {
            bpDto.NumberProposal = this.txt_codigo.Text;
                        
            List<BussinessProposalDTO> proposta = bpBll.ToSelectBussinessProposal(bpDto);
                        
            Int32 valor = proposta[0].Amount;

            this.txt_valor.Text = valor.ToString("#,##0.00");
        }

        public void LoadServiceBussinessProposal()
        {
            bpsDto.NumberProposal = this.txt_codigo.Text;

            this.lvw_listaServicoPropostaComercial.Items.Clear();

            string[] item = new string[7];

            var listProposal = bpsBll.ToListBussinessProposalService(bpsDto);

            foreach (BussinessProposalServiceDTO bps in listProposal)
            {
                item[0] = bps.Id.ToString();
                item[1] = bps.NumberProposal;
                item[2] = bps.Quantity.ToString();
                item[3] = bps.ServiceType;
                item[4] = bps.Service;
                item[5] = bps.UnitityValue.ToString("#,##0.00");
                item[6] = bps.Amount.ToString("#,##0.00");

                lvw_listaServicoPropostaComercial.Items.Add(new ListViewItem(item));
            }
            //this.lbl_tituloListView.Text = "Propostas Comerciais";
        }

        public void ToCreateNewServiceBussinessProposal()
        {
            bpsBll.ToCreateNewBussinesProposalService(bpsDto);

            Int32 prox = bpsDto.Id + 1;
            this.txt_id.Text = prox.ToString();

            this.cmb_tipoServico.Enabled = true;
            this.txt_qtd.Enabled = true;
            this.txt_servico.Enabled = true;
            this.txt_valorUnitario.Enabled = true;
            this.lvw_listaServicoPropostaComercial.Enabled = false;

            this.txt_id.BackColor = Color.FromArgb(192,255, 255);
            this.cmb_tipoServico.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_qtd.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_servico.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_valorUnitario.BackColor = Color.FromArgb(255, 255, 192);
            this.lvw_listaServicoPropostaComercial.BackColor = Color.FromArgb(255, 255, 192);

            this.btn_novo.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_excluir.Visible = false;

            this.btn_cancelar.Location = new Point(1261, 4);
            this.btn_salvar.Location = new Point(1191, 4);

            this.ToPopulaComboboxServiceType();

            this.cmb_tipoServico.Text = "";
        }

        public void ToSaveNewServiceBussinessProposal()
        {
            bpsDto.Id = Int32.Parse(this.txt_id.Text);
            bpsDto.NumberProposal = this.txt_codigo.Text;
            if(this.txt_qtd.Text == "")
            {
                MessageBox.Show("Por favor, digite um valor para a quantidade!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_qtd.Focus();
                return;
            }
            else
            {
                bpsDto.Quantity = Int32.Parse(this.txt_qtd.Text);
            }
            if(this.cmb_tipoServico.Text == "")
            {
                MessageBox.Show("Por favor, digite selecione um tipo de serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoServico.Focus();
                return;
            }
            else
            {
                bpsDto.ServiceType = this.cmb_tipoServico.Text;
            }
            if(this.txt_servico.Text == "")
            {
                MessageBox.Show("Por favor, digite a descrição do serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_servico.Focus();
                return;
            }
            else
            {
                bpsDto.Service = this.txt_servico.Text;
            }
            if(this.txt_valorUnitario.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor unitário do serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valorUnitario.Focus();
                return;
            }
            else
            {
                bpsDto.UnitityValue = Int32.Parse(this.txt_valorUnitario.Text) * 100;
            }
            
            bpsDto.Amount = bpsDto.Quantity * bpsDto.UnitityValue;

            //Salva o serviço
            bpsBll.ToSaveNewBussinessProposalService(bpsDto);

            bpDto.Amount = bpsDto.Amount;
            bpDto.NumberProposal = bpsDto.NumberProposal;

            //Atualiza o valor da proposta
            bpBll.ToUpdateAmountBussinessProposal(bpDto);

            MessageBox.Show("Serviço cadastrado com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Carrega o valor atualizado da proposta
            this.ToSelectAmountBussinessProposal();

            //Carrega a lista de serviços atualizada
            this.LoadServiceBussinessProposal();

            //Volta ao estado inicial
            this.InitialStateBussinessProposalService();
        }

        public void ToUpdateServiceBussinessProposal()
        {
            valorUnitarioErrado = Int32.Parse(this.txt_valorUnitarioErrado.Text);
            valorTotalErrado = Int32.Parse(this.txt_valorTotalErrado.Text);
            
            bpsDto.Id = Int32.Parse(this.txt_id.Text);
            bpsDto.NumberProposal = this.txt_codigo.Text;
            if (this.txt_qtd.Text == "")
            {
                MessageBox.Show("Por favor, digite um valor para a quantidade!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_qtd.Focus();
                return;
            }
            else
            {
                bpsDto.Quantity = Int32.Parse(this.txt_qtd.Text);
            }
            if (this.cmb_tipoServico.Text == "")
            {
                MessageBox.Show("Por favor, digite selecione um tipo de serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoServico.Focus();
                return;
            }
            else
            {
                bpsDto.ServiceType = this.cmb_tipoServico.Text;
            }
            if (this.txt_servico.Text == "")
            {
                MessageBox.Show("Por favor, digite a descrição do serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_servico.Focus();
                return;
            }
            else
            {
                bpsDto.Service = this.txt_servico.Text;
            }
            if (this.txt_valorUnitario.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor unitário do serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valorUnitario.Focus();
                return;
            }
            else
            {
                valorUnitarioCerto = Int32.Parse(this.txt_valorUnitario.Text);                
            }
            valorTotalErrado = Int32.Parse(this.txt_valorTotal.Text);
            //diferença = valor_certo - valor_errado
            bpsDto.UnitityValue = (valorUnitarioCerto - valorUnitarioErrado) * 100;

            bpsDto.Amount = bpsDto.Quantity * bpsDto.UnitityValue;

             

            


            //Atualiza o serviço
            bpsBll.ToUpdateBussinessProposalService(bpsDto);

            bpDto.Amount = bpsDto.Amount;
            bpDto.NumberProposal = bpsDto.NumberProposal;

            //Atualiza o valor da proposta
            bpBll.ToUpdateAmountBussinessProposal(bpDto);

            MessageBox.Show("Serviço atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Carrega o valor atualizado da proposta
            this.ToSelectAmountBussinessProposal();

            //Carrega a lista de serviços atualizada
            this.LoadServiceBussinessProposal();

            //Volta ao estado inicial
            this.InitialStateBussinessProposalService();
        }

        public void ToPopulaComboboxServiceType()
        {
            List<ServiceTypeDTO> serv = serBll.ToPopulaComboboxServiceType();

            this.cmb_tipoServico.DataSource = serv;
            this.cmb_tipoServico.DisplayMember = "description";
            this.cmb_tipoServico.ValueMember = "id";
        }

        public void InitialStateBussinessProposalService()
        {
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_titulo.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_valor.BackColor = Color.FromArgb(192, 255, 255);

            this.txt_id.Enabled = false;
            this.cmb_tipoServico.Enabled = false;
            this.txt_qtd.Enabled = false;
            this.txt_servico.Enabled = false;
            this.txt_valorUnitario.Enabled = false;
            this.txt_valorTotal.Enabled = false;
            this.lvw_listaServicoPropostaComercial.Enabled = true;

            this.txt_id.Text = "";
            this.cmb_tipoServico.Text = "";
            this.txt_qtd.Text = "";
            this.txt_servico.Text = "";
            this.txt_valorUnitario.Text = "";
            this.txt_valorTotal.Text = "";

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_tipoServico.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_qtd.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_servico.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_valorUnitario.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_valorTotal.BackColor = Color.FromArgb(192, 255, 255);

            this.btn_novo.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_excluir.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(1261, 4);
            this.btn_novo.Location = new Point(1191, 4);
        }

        public frm_addServiceBussinessProposal()
        {
            InitializeComponent();
        }

        public frm_addServiceBussinessProposal(String codigo, String titulo, Int32 valor)
        {
            InitializeComponent();

            this.txt_codigo.Text = codigo;
            this.txt_titulo.Text = titulo;
            this.txt_valor.Text = valor.ToString();

            this.InitialStateBussinessProposalService();
        }

        private void frm_addServiceBussinessProposal_Load(object sender, EventArgs e)
        {
            //Define Estrutura das colunas
            lvw_listaServicoPropostaComercial.Columns.Add("Id", 0, HorizontalAlignment.Center);
            lvw_listaServicoPropostaComercial.Columns.Add("Número Proposta", 0, HorizontalAlignment.Center);
            lvw_listaServicoPropostaComercial.Columns.Add("Quantidade", 80, HorizontalAlignment.Center);
            lvw_listaServicoPropostaComercial.Columns.Add("Tipo de Serviço", 200, HorizontalAlignment.Left);
            lvw_listaServicoPropostaComercial.Columns.Add("Descrição do Serviço", 750, HorizontalAlignment.Left);
            lvw_listaServicoPropostaComercial.Columns.Add("Valor Unitário (R$)", 120, HorizontalAlignment.Right);
            lvw_listaServicoPropostaComercial.Columns.Add("Valor Total (R$)", 120, HorizontalAlignment.Right);            
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            this.LoadServiceBussinessProposal();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.ToCreateNewServiceBussinessProposal();
        }

        private void txt_valorUnitario_TextChanged(object sender, EventArgs e)
        {
            //Int32 qtd = Int32.Parse(this.txt_qtd.Text);
            //Int32 valorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            //Int32 total = qtd * valorUnitario;

            //this.txt_valorTotal.Text = total.ToString();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.ToSaveNewServiceBussinessProposal();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.ToUpdateServiceBussinessProposal();
        }

        private void lvw_listaServicoPropostaComercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvw_listaServicoPropostaComercial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bpsDto.Id = Int32.Parse(this.lvw_listaServicoPropostaComercial.SelectedItems[0].Text);

            bpsBll.ToSelectBussinessProposalService(bpsDto);

            List<BussinessProposalServiceDTO> serv = bpsBll.ToSelectBussinessProposalService(bpsDto);

            Int32 id = serv[0].Id;
            String tipo = serv[0].ServiceType;
            Int32 qtd = serv[0].Quantity;
            String servico = serv[0].Service;
            Int32 vUnitario = serv[0].UnitityValue;
            Int32 valor = serv[0].Amount;

            this.ToPopulaComboboxServiceType();

            this.txt_id.Text = id.ToString();
            this.cmb_tipoServico.Text = tipo;
            this.txt_qtd.Text = qtd.ToString();
            this.txt_servico.Text = servico;
            this.txt_valorUnitario.Text = vUnitario.ToString();
            this.txt_valorTotal.Text = valor.ToString();
            this.txt_valorUnitarioErrado.Text = vUnitario.ToString();
            this.txt_valorTotalErrado.Text = valor.ToString();

            this.txt_id.Enabled = false;
            this.cmb_tipoServico.Enabled = true;
            this.txt_qtd.Enabled = true;
            this.txt_servico.Enabled = true;
            this.txt_valorUnitario.Enabled = true;
            this.txt_valorTotal.Enabled = false;

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_tipoServico.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_qtd.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_servico.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_valorUnitario.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_valorTotal.BackColor = Color.FromArgb(192, 255, 255);

            this.btn_novo.Visible = false;
            this.btn_editar.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_excluir.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(1261, 4);
            this.btn_excluir.Location = new Point(1191, 4);
            this.btn_editar.Location = new Point(1121, 4);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //Deletar o serviço
            bpsDto.Id = Int32.Parse(this.txt_id.Text);

            bpsBll.ToDeleteBussinessProposalService(bpsDto);

            //Atualizar o valor da proposta
            bpDto.NumberProposal = this.txt_codigo.Text;            

            //Int32 total = Int32.Parse(this.txt_valor.Text) * 100;
            Int32 valorDeletado = Int32.Parse(txt_valorTotal.Text) * 100;

            bpDto.Amount = (valorDeletado * -1);

            bpBll.ToUpdateAmountBussinessProposal(bpDto);

            MessageBox.Show("Serviço excluído com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Carrega o valor atualizado da proposta
            this.ToSelectAmountBussinessProposal();

            //Carrega a lista de serviços atualizada
            this.LoadServiceBussinessProposal();

            //Volta ao estado inicial
            this.InitialStateBussinessProposalService();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Deseja realmente sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                frm_listBussinesProposal bp = new frm_listBussinesProposal();
                bp.Show();

                this.Close();
            }
        }
    }
}
