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
using GestaoSEGSAL.Report;
using Microsoft.Reporting.WinForms;

namespace GestaoSEGSAL.View
{
    public partial class frm_listBussinesProposal : Form
    {
        BussinessProposalDTO bpDto = new BussinessProposalDTO();
        BussinessProposalBLL bpBll = new BussinessProposalBLL();

        CompanyDTO comDto = new CompanyDTO();
        CompanyBLL comBll = new CompanyBLL();

        ClientDTO cliDto = new ClientDTO();
        ClientBLL cliBll = new ClientBLL();

        BussinessProposalServiceDTO bpsDto = new BussinessProposalServiceDTO();
        BussinessProposalServiceBLL bpsBll = new BussinessProposalServiceBLL();

        double qtdPropostas;

        public frm_listBussinesProposal()
        {
            InitializeComponent();
        }

        public void InitialStateBussinessProposal()
        {
            //Buttons
            this.btn_novo.Visible = true;
            this.btn_sair.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_excluir.Visible = false;
            this.btn_servico.Visible = false;
            this.btn_imprimir.Visible = false;

            this.btn_sair.Location = new Point(1261, 4);
            this.btn_novo.Location = new Point(1191, 4);
        }

        DataTable dt = new DataTable();
        Int32 id = 1;

        public void ToPrintBussinessProposal()
        {
            //Selecionar dados do cliente
            string cliente = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[4].Text;

            string[] split = cliente.Split('-');

            string nomeCliente = split[0];
            string nomeBaseCliente = split[1];

            //Selecionar dados da proposta
            var numeroProposta = lvw_listaPropostaComercial.SelectedItems[0].SubItems[1].Text;

            
            //Selecionar dados do serviço da proposta


            //Enviar para impressão            
            frm_bussinessProposalReportViewer prop = new frm_bussinessProposalReportViewer(nomeCliente, nomeBaseCliente, numeroProposta);
            prop.Show();

            
        }

        public void ToCreateNewBussinessProposal()
        {
            bpBll.ToCreateNewBussinessProposal(bpDto);

            Int32 id = bpDto.Id;
            Int32 prox = id + 1;
            DateTime dataProposta = DateTime.Now;
            DateTime ano = DateTime.Now;

            string codigo = prox.ToString("0000#") + "-" + ano.Year;

            frm_addBussinessProposal prop = new frm_addBussinessProposal(prox, codigo, dataProposta);
            prop.Visible = true;

            this.Close();
        }

        public void ToUpdateBussinessProposal()
        {
            var numero = lvw_listaPropostaComercial.SelectedItems[0].SubItems[1].Text;
            //var dataP = lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            bpDto.NumberProposal = numero.ToString();

            List<BussinessProposalDTO> proposta = bpBll.ToSelectBussinessProposal(bpDto);

            Int32 id = proposta[0].Id;
            String codigo = proposta[0].NumberProposal;
            DateTime dataProposta = proposta[0].DateProposal;
            //String dataPropostaRecebida = proposta[0].DateProposal.ToString("dd/MM/yyyy");
            //DateTime dataProposta = DateTime.Parse(dataP);
            String cliente = proposta[0].Client;
            String baseCliente = proposta[0].BaseClient;
            String titulo = proposta[0].Title;
            String descricao = proposta[0].Description;
            String observacao = proposta[0].Observation;
            String condPgto = proposta[0].PaymentTerms;
            String formaPgto = proposta[0].PaymentForm;
            Int32 valor = proposta[0].Amount;

            frm_addBussinessProposal prop = new frm_addBussinessProposal(id, codigo, dataProposta, cliente, baseCliente, titulo, descricao, observacao, condPgto, formaPgto, valor);
            prop.Visible = true;

            this.Close();
        }

        public void ToAddServiceBussinessProposal()
        {
            var numero = lvw_listaPropostaComercial.SelectedItems[0].SubItems[1].Text;

            bpDto.NumberProposal = numero.ToString();

            List<BussinessProposalDTO> proposta = bpBll.ToSelectBussinessProposal(bpDto);

            String codigo = proposta[0].NumberProposal;
            String titulo = proposta[0].Title;
            Int32 valor = proposta[0].Amount;

            frm_addServiceBussinessProposal serv = new frm_addServiceBussinessProposal(codigo, titulo, valor);
            serv.Show();

            this.Close();
        }

        public void ToCancelRegister()
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Deseja realmente cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.InitialStateBussinessProposal();
            }
        }

        public void LoadBussinessProposal()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposal();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais";
        }

        public void LoadBussinessProposalCreate()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalCreate();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Criadas";
        }

        public void LoadBussinessProposalSend()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalSend();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Enviadas";
        }

        public void LoadBussinessProposalCanceled()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalCanceled();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Canceladas";
        }

        public void LoadBussinessProposalApproved()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalApproved();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Aprovadas";
        }

        public void LoadBussinessProposalCompleted()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalCompleted();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Finalizadas";
        }

        public void LoadBussinessProposalToReceive()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalToReceive();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais a Faturar";
        }

        public void LoadBussinessProposalReceived()
        {
            lvw_listaPropostaComercial.Items.Clear();

            string[] item = new string[8];

            var listProposal = bpBll.ToListBussinessProposalReceived();

            foreach (BussinessProposalDTO bp in listProposal)
            {
                item[0] = bp.Id.ToString();
                item[1] = bp.NumberProposal;
                item[2] = bp.DateProposal.ToString("dd/MM/yyyy");
                item[3] = bp.Title;
                item[4] = bp.Client + "-" + bp.BaseClient;
                item[5] = bp.Amount.ToString("R$ #,##0.00");
                item[6] = bp.Invoice;
                item[7] = bp.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
            }
            this.lbl_tituloListView.Text = "Propostas Comerciais Faturadas";
        }

        private static double Porcentagem(double valor, double total)
        {
            return (100 / total) * valor;
        }

        public void ToCountBussinessProposal()
        {
            qtdPropostas = bpBll.ToCountBussinessProposal();            
        }

        public void ToCountBussinessProposalCreate()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasCriadas = bpBll.ToCountBussinessProposalCreate();

            this.lbl_qtdCriadas.Text = "Total: " + qtdPropostasCriadas.ToString();
            this.lbl_criadasPorCento.Text = Porcentagem(qtdPropostasCriadas, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalSend()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasEnviadas = bpBll.ToCountBussinessProposalSend();
            
            this.lbl_qtdEnviadas.Text = "Total: " + qtdPropostasEnviadas.ToString();
            this.lbl_enviadasPorCento.Text = Porcentagem(qtdPropostasEnviadas, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalCanceled()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasCanceladas = bpBll.ToCountBussinessProposalCanceled();

            this.lbl_qtdCanceladas.Text = "Total: " + qtdPropostasCanceladas.ToString();
            this.lbl_canceladasPorCento.Text = Porcentagem(qtdPropostasCanceladas, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalApproved()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasAprovadas = bpBll.ToCountBussinessProposalApproved();

            this.lbl_qtdAprovadas.Text = "Total: " + qtdPropostasAprovadas.ToString();
            this.lbl_aprovadasPorCento.Text = Porcentagem(qtdPropostasAprovadas, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalCompleted()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasCompletadas = bpBll.ToCountBussinessProposalApproved();

            this.lbl_qtdFinalizadas.Text = "Total: " + qtdPropostasCompletadas.ToString();
            this.lbl_finalizadasPorCento.Text = Porcentagem(qtdPropostasCompletadas, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalToReceive()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasAReceber = bpBll.ToCountBussinessProposalToReceive();

            this.lbl_qtdAFaturar.Text = "Total: " + qtdPropostasAReceber.ToString();
            this.lbl_aSerFaturadasPorCento.Text = Porcentagem(qtdPropostasAReceber, qtdPropostas).ToString("#.##") + " %";
        }

        public void ToCountBussinessProposalReceived()
        {
            this.ToCountBussinessProposal();

            double qtdPropostasRecebidas = bpBll.ToCountBussinessProposalReceived();

            this.lbl_qtdFaturadas.Text = "Total: " + qtdPropostasRecebidas.ToString();
            this.lbl_faturadasPorCento.Text = Porcentagem(qtdPropostasRecebidas, qtdPropostas).ToString("#.##") + " %";
        }

              
        private void frm_listBussinesProposal_Load(object sender, EventArgs e)
        {
            //Define Estrutura das colunas
            lvw_listaPropostaComercial.Columns.Add("Id", 0, HorizontalAlignment.Center);
            lvw_listaPropostaComercial.Columns.Add("Número", 100, HorizontalAlignment.Center);
            lvw_listaPropostaComercial.Columns.Add("Data Proposta", 100, HorizontalAlignment.Center);
            lvw_listaPropostaComercial.Columns.Add("Título", 700, HorizontalAlignment.Left);
            lvw_listaPropostaComercial.Columns.Add("Cliente-Base", 200, HorizontalAlignment.Left);
            lvw_listaPropostaComercial.Columns.Add("Valor (R$)", 90, HorizontalAlignment.Right);
            lvw_listaPropostaComercial.Columns.Add("Nota Fiscal", 86, HorizontalAlignment.Left);

            this.LoadBussinessProposal();
            //this.ToCountBussinessProposalCreate();
            //this.ToCountBussinessProposalSend();
            //this.ToCountBussinessProposalCanceled();
            //this.ToCountBussinessProposalApproved();
            //this.ToCountBussinessProposalCompleted();
            //this.ToCountBussinessProposalToReceive();
            //this.ToCountBussinessProposalReceived();

            this.InitialStateBussinessProposal();
        }

        private void gbx_criadas_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalCreate();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalSend();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalCanceled();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalApproved();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalCompleted();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalToReceive();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            this.LoadBussinessProposalReceived();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
                
            resposta = MessageBox.Show("Deseja realmente sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lvw_listaPropostaComercial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.btn_novo.Visible = false;
            this.btn_sair.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_excluir.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_servico.Visible = true;

            this.btn_cancelar.Location = new Point(981, 4);
            this.btn_editar.Location = new Point(1051, 4);
            this.btn_excluir.Location = new Point(1121, 4);            
            this.btn_servico.Location = new Point(1191, 4);
            this.btn_imprimir.Location = new Point(1261, 4);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.ToCancelRegister();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.ToCreateNewBussinessProposal();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.ToUpdateBussinessProposal();
        }

        private void lvw_listaPropostaComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_servico_Click(object sender, EventArgs e)
        {
            this.ToAddServiceBussinessProposal();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            this.ToPrintBussinessProposal();
            
        }
    }
}
