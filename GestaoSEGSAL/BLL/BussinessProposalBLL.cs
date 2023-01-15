using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.DAO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GestaoSEGSAL.BLL
{
    class BussinessProposalBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        BaseClientDTO bcDto = new BaseClientDTO();
        BaseClientBLL bcBll = new BaseClientBLL();

        PaymentFormDTO pfDto = new PaymentFormDTO();
        PaymentFormBLL pfBll = new PaymentFormBLL();

        BussinessProposalStatusDTO bpsDto = new BussinessProposalStatusDTO();
        BussinessProposalStatusBLL bpsBll = new BussinessProposalStatusBLL();

        Int32 toResultCountProposal;
        Int32 toResultCountProposalCreate;
        Int32 toResultCountProposalSend;
        Int32 toResultCountProposalCanceled;
        Int32 toResultCountProposalApproved;
        Int32 toResultCountProposalCompleted;
        Int32 toResultCountProposalToReceive;
        Int32 toResultCountProposalReceived;

        public void ToCreateNewBussinessProposal(BussinessProposalDTO bp)
        {
            this.ToCountBussinessProposal();

            if(toResultCountProposal == 0)
            {
                bp.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_bussinessProposal";
                
                try
                {
                    cmd.Connection = connection.ToConnect();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    bp.Id = leitor.GetInt32(0);

                    connection.ToDisconnect();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ToSaveNewBussinessProposal(BussinessProposalDTO bp)
        {
            bcDto.NameBase = bp.BaseClient;
            bcBll.ToSelectCodeBaseClient(bcDto);

            pfDto.PaymentForm = bp.PaymentForm;
            pfBll.ToSelectCodePaymentForm(pfDto);

            bpsDto.Status = bp.Status;
            bpsBll.ToSelectCodeBussinessProposalStatus(bpsDto);

            cmd.CommandText = "INSERT INTO tb_bussinessProposal (" +
                "id, " +
                "numberProposal, " +
                "dateProposal, " +
                "title, " +
                "description, " +
                "observation, " +
                "codeBaseClient, " +
                "amount, " +
                "codePaymentForm, " +
                "codeInvoice, " +
                "codeStatus) " +
                "VALUES (" +
                bp.Id + ", '" +
                bp.NumberProposal + "', '" +
                bp.DateProposal + "', '" +
                bp.Title + "', '" +
                bp.Description + "', '" +
                bp.Observation + "', '" +
                bcDto.Code + "', " +
                bp.Amount + ", " +
                pfDto.Id + ", '" +
                bp.Invoice + "', " +
                bpsDto.Id + ")";
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ToUpdateBussinessProposal(BussinessProposalDTO bp)
        {
            bcDto.NameBase = bp.BaseClient;
            bcBll.ToSelectCodeBaseClient(bcDto);

            pfDto.PaymentForm = bp.PaymentForm;
            pfBll.ToSelectCodePaymentForm(pfDto);

            cmd.CommandText = "UPDATE tb_bussinesSProposal SET " +
                "dateProposal = '" + bp.DateProposal + "', " +
                "title = '" + bp.Title + "', " +
                "description = '" + bp.Description + "', " +
                "observation = '" + bp.Observation + "', " +
                "codeBaseClient = '" + bcDto.Code + "', " +
                "codePaymentForm = " + pfDto.Id + " " +
                "WHERE numberProposal = '" + bp.NumberProposal + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ToDeleteBussinessProposal(BussinessProposalDTO bp)
        {
            cmd.CommandText = "UPDATE tb_bussinessProposal " +
                "SET codeStatus = 3 " +
                "WHERE numberProposal = '" + bp.NumberProposal + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<BussinessProposalDTO> ToListBussinessProposal()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;            
        }

        public List<BussinessProposalDTO> ToListBussinessProposalCreate()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 1 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalSend()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 2 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalCanceled()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 3 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalApproved()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 4 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalCompleted()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 5 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalToReceive()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 6 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalDTO> ToListBussinessProposalReceived()
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.codeStatus = 7 " +
               "ORDER BY tb_bussinessProposal.numberProposal DESC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(12);

            while (dr.Read())
            {
                BussinessProposalDTO bp = new BussinessProposalDTO();

                bp.Id = dr.GetInt32(0); //id
                bp.NumberProposal = dr.GetString(1); //number proposal
                bp.DateProposal = dr.GetDateTime(2); //date proposal
                bp.Title = dr.GetString(3); //title
                bp.Description = dr.GetString(4); //description
                bp.Client = dr.GetString(5); //client
                bp.BaseClient = dr.GetString(6); //base client
                bp.Amount = dr.GetInt32(7) / 100; //amount
                bp.PaymentTerms = dr.GetString(8); //payment terms
                bp.PaymentForm = dr.GetString(9); //payment form
                bp.Invoice = dr.GetString(10); //invoice
                bp.Status = dr.GetString(11); //status proposal

                proposal.Add(bp);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public Int32 ToCountBussinessProposal()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposal = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposal;            
        }

        public Int32 ToCountBussinessProposalCreate()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_bussinessProposal WHERE codeStatus = 1";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalCreate = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalCreate;
        }

        public Int32 ToCountBussinessProposalSend()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 2";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalSend = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalSend;
        }

        public Int32 ToCountBussinessProposalCanceled()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 3";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalCanceled = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalCanceled;
        }

        public Int32 ToCountBussinessProposalApproved()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 4";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalApproved = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalApproved;
        }

        public Int32 ToCountBussinessProposalCompleted()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 5";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalCompleted = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalCompleted;
        }

        public Int32 ToCountBussinessProposalToReceive()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 6";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalToReceive = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalToReceive;
        }

        public Int32 ToCountBussinessProposalReceived()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_bussinessProposal WHERE codeStatus = 7";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                toResultCountProposalReceived = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountProposalReceived;
        }

        public List<BussinessProposalDTO> ToSelectBussinessProposal(BussinessProposalDTO bp)
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposal.id, " +
               "tb_bussinessProposal.numberProposal, " +
               "tb_bussinessProposal.dateProposal, " +
               "tb_bussinessProposal.title, " +
               "tb_bussinessProposal.description, " +
               "tb_bussinessProposal.observation, " +
               "tb_client.fantasyName, " +
               "tb_baseClient.nameBase," +
               "tb_bussinessProposal.amount, " +
               "tb_paymentTerms.paymentTerms, " +
               "tb_paymentForm.paymentForm, " +
               "tb_bussinessProposal.codeInvoice, " +
               "tb_bussinessProposalStatus.status " +
               "FROM (((((tb_bussinessProposal " +
               "INNER JOIN tb_baseClient ON tb_bussinessProposal.codeBaseClient = tb_baseClient.code) " +
               "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
               "INNER JOIN tb_paymentForm ON tb_bussinessProposal.codePaymentForm = tb_paymentForm.id) " +
               "INNER JOIN tb_paymentTerms ON tb_paymentForm.codePaymentTerms = tb_paymentTerms.id) " +
               "INNER JOIN tb_bussinessProposalStatus ON tb_bussinessProposal.codeStatus = tb_bussinessProposalStatus.id) " +
               "WHERE tb_bussinessProposal.numberProposal = '" + bp.NumberProposal + "'";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalDTO> proposal = new List<BussinessProposalDTO>(13);

            while (dr.Read())
            {
                proposal.Add(new BussinessProposalDTO());

                proposal[0].Id = dr.GetInt32(0); //id
                proposal[0].NumberProposal = dr.GetString(1); //number proposal
                proposal[0].DateProposal = dr.GetDateTime(2); //data proposal
                proposal[0].Title = dr.GetString(3); //title
                proposal[0].Description = dr.GetString(4); //description
                proposal[0].Observation = dr.GetString(5); //observation
                proposal[0].Client = dr.GetString(6); //client
                proposal[0].BaseClient = dr.GetString(7); //base client
                proposal[0].Amount = dr.GetInt32(8) / 100; //amount
                proposal[0].PaymentTerms = dr.GetString(9); //payment terms
                proposal[0].PaymentForm = dr.GetString(10); //payment form
                proposal[0].Invoice = dr.GetString(11); //invoice
                proposal[0].Status = dr.GetString(12); //status
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public void ToUpdateAmountBussinessProposal(BussinessProposalDTO bp)
        {
            cmd.CommandText = "UPDATE tb_bussinessProposal SET " +
                "amount = amount + (" + bp.Amount + ") " +
                "WHERE numberProposal = '" + bp.NumberProposal + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            


















        





    }
}
