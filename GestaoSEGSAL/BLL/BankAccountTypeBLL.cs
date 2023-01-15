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
    class BankAccountTypeBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();


        public List<BankAccountTypeDTO> ToPopulaComboboxBankAccountType()
        {
            cmd.CommandText = "SELECT bankAccountType FROM tb_bankAccountType " +
                "ORDER BY bankAccountType ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BankAccountTypeDTO> accountType = new List<BankAccountTypeDTO>();

            while (dr.Read())
            {
                BankAccountTypeDTO bat = new BankAccountTypeDTO();
                bat.BankAccountType = dr.GetString(0);
                accountType.Add(bat);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return accountType;
        }

        public Int32 ToSelectCodeBankAccountType(BankAccountTypeDTO bat)
        {
            cmd.CommandText = "SELECT id FROM tb_bankAccountType " +
                "WHERE bankAccountType = '" + bat.BankAccountType + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                bat.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bat.Id;
        }






    }
}
