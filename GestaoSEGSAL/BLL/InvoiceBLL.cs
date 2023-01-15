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
    class InvoiceBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        InvoiceStatusDTO isDto = new InvoiceStatusDTO();
        InvoiceStatusBLL isBLL = new InvoiceStatusBLL();

        ClientDTO cliDto = new ClientDTO();
        ClientBLL cliBll = new ClientBLL();

        BaseClientDTO bcDto = new BaseClientDTO();
        BaseClientBLL bcBll = new BaseClientBLL();

        InvoiceTypeDTO itDto = new InvoiceTypeDTO();
        InvoiceTypeBLL itBll = new InvoiceTypeBLL();

        Int32 toResultCountInvoice;

        public void ToCreateNewInvoice(InvoiceDTO i)
        {
            this.ToCountInvoice();

            if (toResultCountInvoice == 0)
            {
                i.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_invoice";

                try
                {
                    cmd.Connection = connection.ToConnect();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    i.Id = leitor.GetInt32(0);

                    connection.ToDisconnect();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Int32 ToCountInvoice()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_invoice";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();
                toResultCountInvoice = reader.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return toResultCountInvoice;
        }

        public void ToSaveNewInvoice(InvoiceDTO i)
        {
            itDto.InvoiceType = i.InvoiceType;
            itBll.ToSelectCodeInvoiceType(itDto);

            bcDto.Client = i.Client;
            bcDto.NameBase = i.BaseClient;
            bcBll.ToSelectCodeBaseClient(bcDto);

            isDto.Status = i.Status;
            isBLL.ToSelectCodeInvoiceStatus(isDto);

            cmd.CommandText = "INSERT INTO tb_invoice (" +
                "id, " +
                "numberInvoice, " +
                "issuanceDate, " +
                "forecastDate, " +
                "codeInvoiceType, " +
                "competence, " +
                "verificationCode, " +
                "codeBaseClient, " +
                "service, " +
                "requestNumber, " +
                "amount, " +
                "file, " +
                "codeStatus) " +
                "VALUES (" +
                i.Id + ", '" +
                i.NumberInvoice + "', '" +
                i.IssuanceDate + "', '" +
                i.ForecastDate + "', " +
                itDto.Id + ", '" +
                i.Competence + "', '" +
                i.VerificationCode + "', '" +
                bcDto.Code + ", '" +
                i.Service + "', '" +
                i.RequestNumber + "', " +
                i.Amount + ", '" +
                i.File + "', " +
                isDto.Id + ")";

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

        public void ToUpdateInvoice(InvoiceDTO i)
        {
            itDto.InvoiceType = i.InvoiceType;
            itBll.ToSelectCodeInvoiceType(itDto);

            bcDto.Client = i.Client;
            bcDto.NameBase = i.BaseClient;
            bcBll.ToSelectCodeBaseClient(bcDto);

            isDto.Status = i.Status;
            isBLL.ToSelectCodeInvoiceStatus(isDto);

            cmd.CommandText = "UPDATE tb_invoice SET " +
                "issuanceDate = '" + i.IssuanceDate + "', " +
                "forecastDate = '" + i.ForecastDate + "', " +
                "codeInvoiceType = " + itDto.Id + ", " +
                "competence = '" + i.Competence + "', " +
                "verificationCode = '" + i.VerificationCode + "', " +
                "codeBaseClient = '" + bcDto.Code + ", " +
                "service = '" + i.Service + "', " +
                "requestNumber = '" + i.RequestNumber + "', " +
                "amount = " + i.Amount + ", " +
                "WHERE numberInvoice = '" + i.NumberInvoice + "'";

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

        public void ToDeleteInvoice(InvoiceDTO i)
        {
            cmd.CommandText = "DELETE FROM tb_invoice WHERE numberInvoice = '" + i.NumberInvoice + "'";

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

        public void ToCancelInvoice(InvoiceDTO i)
        {
            isDto.Status = i.Status;
            isBLL.ToSelectCodeInvoiceStatus(isDto);

            cmd.CommandText = "UPDATE tb_invoice SET codeStatus = " + isDto.Id + 
                "WHERE numberInvoice = '" + i.NumberInvoice + "'";

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

        public List<InvoiceDTO> ToListInvoice()
        {
            cmd.CommandText = "SELECT " +
                "tb_invoice.id, " +
                "tb_invoice.numberInvoice, " +
                "tb_invoice.issuanceDate," +
                "tb_invoice.forecastDate, " +
                "tb_invoiceType.type, " +
                "tb_invoice.competence, " +
                "tb_invoice.verificationCode, " +
                "tb_client.fantasyName, " +
                "tb_baseClient.namebase, " +
                "tb_invoice.service, " +
                "tb_invoice.requestNumber, " +
                "tb_invoice.amount, " +
                "tb_invoiceStatus.status " +
                "FROM ((((tb_invoice " +
                "INNER JOIN tb_invoiceType ON tb_invoice.codeInvoiceType = tb_invoiceType.id) " +
                "INNER JOIN tb_baseClient ON tb_invoice.codeBaseClient = tb_baseClient.code) " +
                "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
                "INNER JOIN tb_invoiceStatus ON tb_invoice.codeStatus = tb_invoiceStatus.id) " +
                "WHERE tb_invoice.codeStatus <> 3 " +
                "ORDER BY tb_invoice.numberInvoice ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<InvoiceDTO> invoice = new List<InvoiceDTO>(13);

            while (dr.Read())
            {
                invoice.Add(new InvoiceDTO());

                invoice[0].Id = dr.GetInt32(0); //id
                invoice[0].NumberInvoice = dr.GetString(1); //number invoice
                invoice[0].IssuanceDate = dr.GetDateTime(2); //issuance date
                invoice[0].ForecastDate = dr.GetDateTime(3); //forecast date
                invoice[0].InvoiceType = dr.GetString(4); //type
                invoice[0].Competence = dr.GetString(5); //competence
                invoice[0].VerificationCode = dr.GetString(6); //verification code
                invoice[0].Client = dr.GetString(7); //client
                invoice[0].BaseClient = dr.GetString(8); //base client
                invoice[0].Service = dr.GetString(9); //service
                invoice[0].RequestNumber = dr.GetString(10); //request number
                invoice[0].Amount = dr.GetInt32(11) / 100; //amount
                invoice[0].Status = dr.GetString(12); //status
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return invoice;
        }

        public List<InvoiceDTO> ToListInvoiceStatus(InvoiceDTO i)
        {
            isBLL.ToSelectCodeInvoiceStatus(isDto);

            cmd.CommandText = "SELECT " +
                "tb_invoice.id, " +
                "tb_invoice.numberInvoice, " +
                "tb_invoice.issuanceDate," +
                "tb_invoice.forecastDate, " +
                "tb_invoiceType.type, " +
                "tb_invoice.competence, " +
                "tb_invoice.verificationCode, " +
                "tb_client.fantasyName, " +
                "tb_baseClient.namebase, " +
                "tb_invoice.service, " +
                "tb_invoice.requestNumber, " +
                "tb_invoice.amount, " +
                "tb_invoiceStatus.status " +
                "FROM ((((tb_invoice " +
                "INNER JOIN tb_invoiceType ON tb_invoice.codeInvoiceType = tb_invoiceType.id) " +
                "INNER JOIN tb_baseClient ON tb_invoice.codeBaseClient = tb_baseClient.code) " +
                "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
                "INNER JOIN tb_invoiceStatus ON tb_invoice.codeStatus = tb_invoiceStatus.id) " +
                "WHERE tb_invoice.codeStatus = " + isDto.Id + " " +
                "ORDER BY tb_invoice.numberInvoice ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<InvoiceDTO> invoice = new List<InvoiceDTO>(13);

            while (dr.Read())
            {
                invoice.Add(new InvoiceDTO());

                invoice[0].Id = dr.GetInt32(0); //id
                invoice[0].NumberInvoice = dr.GetString(1); //number invoice
                invoice[0].IssuanceDate = dr.GetDateTime(2); //issuance date
                invoice[0].ForecastDate = dr.GetDateTime(3); //forecast date
                invoice[0].InvoiceType = dr.GetString(4); //type
                invoice[0].Competence = dr.GetString(5); //competence
                invoice[0].VerificationCode = dr.GetString(6); //verification code
                invoice[0].Client = dr.GetString(7); //client
                invoice[0].BaseClient = dr.GetString(8); //base client
                invoice[0].Service = dr.GetString(9); //service
                invoice[0].RequestNumber = dr.GetString(10); //request number
                invoice[0].Amount = dr.GetInt32(11) / 100; //amount
                invoice[0].Status = dr.GetString(12); //status
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return invoice;
        }

        public List<InvoiceDTO> ToListInvoiceYeah(InvoiceDTO i)
        {
            cmd.CommandText = "SELECT " +
                "tb_invoice.id, " +
                "tb_invoice.numberInvoice, " +
                "tb_invoice.issuanceDate," +
                "tb_invoice.forecastDate, " +
                "tb_invoiceType.type, " +
                "tb_invoice.competence, " +
                "tb_invoice.verificationCode, " +
                "tb_client.fantasyName, " +
                "tb_baseClient.namebase, " +
                "tb_invoice.service, " +
                "tb_invoice.requestNumber, " +
                "tb_invoice.amount, " +
                "tb_invoiceStatus.status " +
                "FROM ((((tb_invoice " +
                "INNER JOIN tb_invoiceType ON tb_invoice.codeInvoiceType = tb_invoiceType.id) " +
                "INNER JOIN tb_baseClient ON tb_invoice.codeBaseClient = tb_baseClient.code) " +
                "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
                "INNER JOIN tb_invoiceStatus ON tb_invoice.codeStatus = tb_invoiceStatus.id) " +
                "WHERE YEAR(tb_invoice.issuanceDate) = '" + i.YearIssuanceDate + "' " +
                "AND tb_invoice.codeStatus <> 3 " +
                "ORDER BY tb_invoice.numberInvoice ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<InvoiceDTO> invoice = new List<InvoiceDTO>(13);

            while (dr.Read())
            {
                invoice.Add(new InvoiceDTO());

                invoice[0].Id = dr.GetInt32(0); //id
                invoice[0].NumberInvoice = dr.GetString(1); //number invoice
                invoice[0].IssuanceDate = dr.GetDateTime(2); //issuance date
                invoice[0].ForecastDate = dr.GetDateTime(3); //forecast date
                invoice[0].InvoiceType = dr.GetString(4); //type
                invoice[0].Competence = dr.GetString(5); //competence
                invoice[0].VerificationCode = dr.GetString(6); //verification code
                invoice[0].Client = dr.GetString(7); //client
                invoice[0].BaseClient = dr.GetString(8); //base client
                invoice[0].Service = dr.GetString(9); //service
                invoice[0].RequestNumber = dr.GetString(10); //request number
                invoice[0].Amount = dr.GetInt32(11) / 100; //amount
                invoice[0].Status = dr.GetString(12); //status
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return invoice;
        }

        public List<InvoiceDTO> ToListInvoiceMonthYear(InvoiceDTO i)
        {
            cmd.CommandText = "SELECT " +
                "tb_invoice.id, " +
                "tb_invoice.numberInvoice, " +
                "tb_invoice.issuanceDate," +
                "tb_invoice.forecastDate, " +
                "tb_invoiceType.type, " +
                "tb_invoice.competence, " +
                "tb_invoice.verificationCode, " +
                "tb_client.fantasyName, " +
                "tb_baseClient.namebase, " +
                "tb_invoice.service, " +
                "tb_invoice.requestNumber, " +
                "tb_invoice.amount, " +
                "tb_invoiceStatus.status " +
                "FROM ((((tb_invoice " +
                "INNER JOIN tb_invoiceType ON tb_invoice.codeInvoiceType = tb_invoiceType.id) " +
                "INNER JOIN tb_baseClient ON tb_invoice.codeBaseClient = tb_baseClient.code) " +
                "INNER JOIN tb_client ON tb_baseClient.codeClient = tb_client.code) " +
                "INNER JOIN tb_invoiceStatus ON tb_invoice.codeStatus = tb_invoiceStatus.id) " +
                "WHERE MONTH(tb_invoice.issuanceDate) = '" + i.MonthIssuanceDate + "' " +
                "AND YEAR(tb_invoice.issuanceDate) = '" + i.YearIssuanceDate + "' " +
                "AND tb_invoice.codeStatus <> 3 " +
                "ORDER BY tb_invoice.numberInvoice ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<InvoiceDTO> invoice = new List<InvoiceDTO>(13);

            while (dr.Read())
            {
                invoice.Add(new InvoiceDTO());

                invoice[0].Id = dr.GetInt32(0); //id
                invoice[0].NumberInvoice = dr.GetString(1); //number invoice
                invoice[0].IssuanceDate = dr.GetDateTime(2); //issuance date
                invoice[0].ForecastDate = dr.GetDateTime(3); //forecast date
                invoice[0].InvoiceType = dr.GetString(4); //type
                invoice[0].Competence = dr.GetString(5); //competence
                invoice[0].VerificationCode = dr.GetString(6); //verification code
                invoice[0].Client = dr.GetString(7); //client
                invoice[0].BaseClient = dr.GetString(8); //base client
                invoice[0].Service = dr.GetString(9); //service
                invoice[0].RequestNumber = dr.GetString(10); //request number
                invoice[0].Amount = dr.GetInt32(11) / 100; //amount
                invoice[0].Status = dr.GetString(12); //status
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return invoice;
        }

        public Int32 ToSelectSumAmountInvoice(InvoiceDTO i)
        {
            cmd.CommandText = "SELECT SUM(amount) FROM tb_invoice";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                i.Amount = dr.GetInt32(0) / 100;

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i.Amount;
        }

        public Int32 ToSelectSumAmountInvoiceStatus(InvoiceDTO i)
        {
            isBLL.ToSelectCodeInvoiceStatus(isDto);

            cmd.CommandText = "SELECT SUM(amount) FROM tb_invoice " +
                "WHERE codeStatus = " + isDto.Id;

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                i.Amount = dr.GetInt32(0) / 100;

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i.Amount;
        }

        public Int32 ToSelectSumAmountInvoiceYear(InvoiceDTO i)
        {
            cmd.CommandText = "SELECT SUM(amount) FROM tb_invoice " +
                "WHERE YEAR(issuanceDate) = '" + i.YearIssuanceDate + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                i.Amount = dr.GetInt32(0) / 100;

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i.Amount;
        }

        public Int32 ToSelectSumAmountInvoiceMonthYear(InvoiceDTO i)
        {
            cmd.CommandText = "SELECT SUM(amount) FROM tb_invoice " +
                "WHERE YEAR(issuanceDate) = '" + i.YearIssuanceDate + "' " +
                "AND MONTH(issuanceDate) = '" + i.MonthIssuanceDate + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                i.Amount = dr.GetInt32(0) / 100;

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i.Amount;
        }
    }
}
