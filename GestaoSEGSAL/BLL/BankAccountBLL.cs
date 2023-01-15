using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.DAO;
using System.Data.OleDb;

namespace GestaoSEGSAL.BLL
{
    class BankAccountBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        BankAccountTypeDTO batDto = new BankAccountTypeDTO();
        BankAccountTypeBLL batBll = new BankAccountTypeBLL();

        Int32 resultCountCodeBankAccount;



        //Criar nova conta bancária
        public void ToCreateNewClient(BankAccountDTO ba)
        {
            ToCountCodeBankAccount();

            if (resultCountCodeBankAccount == 0)
            {
                ba.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_client";

                try
                {
                    cmd.Connection = connection.ToConnect();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    dr.Read();
                    ba.Id = dr.GetInt32(0);

                    connection.ToDisconnect();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Contar registros conta bancária
        public Int32 ToCountCodeBankAccount()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_bankAccount";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                resultCountCodeBankAccount = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultCountCodeBankAccount;
        }        

        //Salvar conta bancária
        public void ToSaveBankAccount(BankAccountDTO ba)
        {
            //Selecionar codigo do tipo de conta
            batDto.BankAccountType = ba.BankAccountType;
            //Selecionar codigo do banco

            cmd.CommandText = "INSERT INTO (" +
                "id, " +
                "registerDate, " +
                "surname, " +
                "idBank, " +
                "idBankAccountType, " +
                "agencyNumber, " +
                "accountNumber, " +
                "balance) " +
                "VALUES (" +
                ba.Id + ", '" +
                ba.RegisterDate + "', '" +
                ba.BankAccountName + "', " +
                //banDto.Id + ", " +
                batDto.Id + ", '" +
                ba.AgencyNumber + "', '" +
                ba.AccountNumber + "', " +
                ba.Balance + ")";

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

        //Editar conta bancária
        public void ToUpdateBankAccount(BankAccountDTO ba)
        {
            //Selecionar codigo do tipo de conta
            batDto.BankAccountType = ba.BankAccountType;
            //Selecionar codigo do banco


            cmd.CommandText = "UPDATE tb_bankAccount SET " +
                "surname = '" + ba.BankAccountName + "', " +
                //"idBank = " + ban.Id + ", " +
                "idBankAccountType = " + batDto.Id + ", " +
                "agencyNumber = '" + ba.AgencyNumber + "', " +
                "accountNumber = '" + ba.AccountNumber + "', " +
                "balance = " + ba.Balance + " " +
                "WHERE id = " + ba.Id;

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
        //Deletar conta bancária
        public void ToDeleteBankAccount(BankAccountDTO ba)
        {
            cmd.CommandText = "DELETE FROM tb_bankAccount WHERE id = " + ba.Id;

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

        //Listar conta bancária

        //Selecionar conta bancária

        //Selecionar codigo conta bancária
        public Int32 ToSelectCodeBankAccount(BankAccountDTO ba)
        {
            cmd.CommandText = "SELECT id FROM tb_bankAccount " +
                "WHERE accountNumber = '" + ba.AccountNumber + "' " +
                "AND agencyNumber = '" + ba.AgencyNumber + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                ba.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ba.Id;
        }

        //Popular combobox conta bancária
        public List<BankAccountDTO> ToPopulaComboboxBankAccount()
        {
            cmd.CommandText = "SELECT surname FROM tb_bankAccount " +
                "ORDER BY surname ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BankAccountDTO> account = new List<BankAccountDTO>();

            while (dr.Read())
            {
                BankAccountDTO acc = new BankAccountDTO();
                acc.BankAccountName = dr.GetString(0);
                account.Add(acc);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return account;
        }



    }
}
