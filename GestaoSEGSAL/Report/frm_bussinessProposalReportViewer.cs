using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.BLL;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.Report;
using Microsoft.Reporting.WinForms;

namespace GestaoSEGSAL.Report
{
    public partial class frm_bussinessProposalReportViewer : Form
    {
        DataTable dt = new DataTable();

        CompanyDTO comDto = new CompanyDTO();
        CompanyBLL comBll = new CompanyBLL();

        ClientDTO cliDto = new ClientDTO();
        ClientBLL cliBll = new ClientBLL();

        BaseClientDTO bcDto = new BaseClientDTO();
        BaseClientBLL bcBll = new BaseClientBLL();

        BussinessProposalDTO bpDto = new BussinessProposalDTO();
        BussinessProposalBLL bpBll = new BussinessProposalBLL();

        BussinessProposalServiceDTO bpsDto = new BussinessProposalServiceDTO();
        BussinessProposalServiceBLL bpsBll = new BussinessProposalServiceBLL();

        String cabecLinha1;
        String cabecLinha2;
        String cabecLinha3;
        String cabecLinha4;
        String logomarca;
        String nomeCliente;
        String codigoCliente;
        String cliLinha1;
        String cliLinha2;
        String cliLinha3;
        String nomeBaseCliente;
        String cnpjBaseCliente;
        String enderecoBaseCliente;
        String complementoBaseCliente;
        String bairroBaseCliente;
        String cidadeBaseCliente;
        String estadoBaseCliente;
        String cepBaseCliente;
        String telefoneBaseCliente;
        String emailBaseCliente;
        String numeroProposta;
        String dataProposta;
        String dataPropostaExtenso;
        String titulo;
        String descricao;
        String observacao;
        String condicaoPgto;
        String formaPgto;
        String valorTotal;

        public frm_bussinessProposalReportViewer()
        {
            InitializeComponent();
        }

        public frm_bussinessProposalReportViewer(String fantasyName, String nameBase, String numberProposal)
        {
            InitializeComponent();

            //Selecionar os dados da empresa
            List<CompanyDTO> company = comBll.ToSelectCompany();

            //Cabeçalho - Linha 01 (Nome Fantasia)
            cabecLinha1 = company[0].FantasyName;

            //Cabeçalho - Linha 02 (CNPJ)
            cabecLinha2 = company[0].Cnpj;

            //Cabeçalho - Linha 03 (Endereço)
            cabecLinha3 = company[0].Address + ", " + company[0].Complement + ", " + company[0].District + " - " + company[0].City + "/" + company[0].FederationState + " - CEP.: " + company[0].PostalCode;

            //Cabeçalho - Linha 04 (Contato)
            cabecLinha4 = "Fone: " + company[0].Telephone + " - E-mail: " + company[0].Email;

            //Logomarca
            logomarca = Application.StartupPath + company[0].LogoPrint;

            //Selecionar dados do cliente
            cliDto.FantasyName = fantasyName;            

            List<ClientDTO> client = cliBll.ToSelectClient(cliDto);

            nomeCliente = client[0].FantasyName;
            codigoCliente = client[0].Code;

            //Cliente - Linha 01 (Cliente)
            cliLinha1 = nomeCliente + " - " + nomeBaseCliente + "/" + estadoBaseCliente + " - CNPJ: " + cnpjBaseCliente;

            //Cliente - Linha 02 (CNPJ)
            cliLinha2 = enderecoBaseCliente + ", " + complementoBaseCliente + ", " + bairroBaseCliente + ", " + cidadeBaseCliente + "/" + estadoBaseCliente + " - CEP.: " + cepBaseCliente;

            //Cliente - Linha 03 (Endereço)
            cliLinha3 = "Fone: " + telefoneBaseCliente + " - E-mail: " + emailBaseCliente;

            //Selecionar dados da base do cliente
            bcDto.Client = codigoCliente;
            bcDto.NameBase = nameBase;            

            List<BaseClientDTO> baseClient = bcBll.ToSelectBaseClient(bcDto);

            nomeBaseCliente = baseClient[0].NameBase;
            cnpjBaseCliente = baseClient[0].Cnpj;
            enderecoBaseCliente = baseClient[0].Address;
            complementoBaseCliente = baseClient[0].Complement;
            bairroBaseCliente = baseClient[0].District;
            cidadeBaseCliente = baseClient[0].City;
            estadoBaseCliente = baseClient[0].FaderationState;
            cepBaseCliente = baseClient[0].PostalCode;
            telefoneBaseCliente = baseClient[0].Telephone;
            emailBaseCliente = baseClient[0].Email;

            //Selecionar dados da proposta
            bpDto.NumberProposal = numberProposal;
            numeroProposta = numberProposal;

            List<BussinessProposalDTO> proposal = bpBll.ToSelectBussinessProposal(bpDto);

            dataProposta = proposal[0].DateProposal.ToString("dd/MM/yyyy");
            dataPropostaExtenso = "Fortaleza/CE " + proposal[0].DateProposal.ToString("dd") + " de " + proposal[0].DateProposal.ToString("MMMM") + " de " + proposal[0].DateProposal.ToString("yyyy");
            titulo = proposal[0].Title;
            descricao = proposal[0].Description;
            observacao = proposal[0].Observation;
            condicaoPgto = proposal[0].PaymentTerms;
            formaPgto = proposal[0].PaymentForm;
            valorTotal = proposal[0].Amount.ToString("R$ #,##0.00");

            //Selecionar dodos dos serviços da proposta
            bpsDto.NumberProposal = numeroProposta;
            
            //string[] item = new string[5];

            ////dt.Columns.Add("Qtd");
            ////dt.Columns.Add("Tipo");
            ////dt.Columns.Add("Descrição");
            ////dt.Columns.Add("Valor Unit.");
            ////dt.Columns.Add("Valor Total");

            //var services = bpsBll.ToSelectBussinessProposalService(bpsDto);

            //foreach (BussinessProposalServiceDTO bps in services)
            //{
            //    item[0] = bps.Quantity.ToString();
            //    item[1] = bps.ServiceType;
            //    item[2] = bps.Service;
            //    item[3] = bps.UnitityValue.ToString("R$ #,##0.00");
            //    item[4] = bps.Amount.ToString("R$ #,##0.00");                
            //}
            
            //this.dt.Rows.Add(services);
        }

        private void frm_bussinessProposalReportViewer_Load(object sender, EventArgs e)
        {            
            //======================================================================================================================
            ReportParameterCollection parametersCompany = new ReportParameterCollection();

            //Cabeçalho do Relatório
            parametersCompany.Add(new ReportParameter("cabecalhoLinha1", cabecLinha1));
            parametersCompany.Add(new ReportParameter("cabecalhoLinha2", cabecLinha2));
            parametersCompany.Add(new ReportParameter("cabecalhoLinha3", cabecLinha3));
            parametersCompany.Add(new ReportParameter("cabecalhoLinha4", cabecLinha4));
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            //this.reportViewer1.LocalReport.LoadReportDefinition();
            parametersCompany.Add(new ReportParameter("logomarca", logomarca));

            //Dados do Cliente
            parametersCompany.Add(new ReportParameter("clienteLinha1", cliLinha1));
            parametersCompany.Add(new ReportParameter("clienteLinha2", cliLinha2));
            parametersCompany.Add(new ReportParameter("clienteLinha3", cliLinha3));

            //Dados da Proposta
            parametersCompany.Add(new ReportParameter("numeroProposta", numeroProposta));
            parametersCompany.Add(new ReportParameter("dataProposta", dataProposta));
            parametersCompany.Add(new ReportParameter("valorProposta", valorTotal));
            parametersCompany.Add(new ReportParameter("tituloProposta", titulo));
            parametersCompany.Add(new ReportParameter("descricaoProposta", descricao));
            parametersCompany.Add(new ReportParameter("observacaoProposta", observacao));
            parametersCompany.Add(new ReportParameter("condicaoPgto", condicaoPgto));
            parametersCompany.Add(new ReportParameter("formaPgto", formaPgto));
            parametersCompany.Add(new ReportParameter("dataPropostaExtenso", dataPropostaExtenso));

            //Dados dos Serviços
            this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            
            this.reportViewer1.LocalReport.SetParameters(parametersCompany);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }   

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
